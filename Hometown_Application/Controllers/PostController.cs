using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;
using Hometown_Application.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace Hometown_Application.Controllers
{
    [Authorize] // Require authentication to access posts
    public class PostController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHubContext<NotificationHub> _hubContext;

        public PostController(ApplicationDBContext context, UserManager<ApplicationUser> userManager, IHubContext<NotificationHub> hubContext)
        {
            _context = context;
            _userManager = userManager;
            _hubContext = hubContext;
        }

        // GET: Posts
        public async Task<IActionResult> Index()
        {
            var posts = await _context.Posts.Include(p => p.ApplicationUser)
                                            .Include(p => p.Comments)
                                            .Include(p => p.Reactions)
                                            .ToListAsync();
            return View(posts);
        }

        // GET: Post/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var post = await _context.Posts.Include(p => p.ApplicationUser)
                                           .Include(p => p.Comments)
                                           .ThenInclude(c => c.ApplicationUser)
                                           .Include(p => p.Reactions)
                                           .FirstOrDefaultAsync(p => p.PostId == id);

            if (post == null)
                return NotFound();

            return View(post);
        }

        // GET: Post/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PostModel model, IFormFile imageFile)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Index");

            if (imageFile != null && imageFile.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await imageFile.CopyToAsync(memoryStream);
                    model.Image = memoryStream.ToArray(); // Convert file to byte array
                }
            }
            model.UserId = user.Id;
            model.AddedOn = DateTime.UtcNow;
            model.AddedBy = user.Id;
            _context.Posts.Add(model);
            await _context.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", "A new post has been added!");
            return RedirectToAction("Index", "Dashboard");
        }


        // GET: Post/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
                return NotFound();

            return View(post);
        }

        // POST: Post/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PostModel post)
        {
            if (id != post.PostId)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        // POST: Post/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var post = await _context.Posts.Include(p => p.Comments)
                                           .Include(p => p.Reactions)
                                           .FirstOrDefaultAsync(p => p.PostId == id);

            if (post == null)
                return NotFound();

            // Manually delete related comments & reactions
            _context.Comments.RemoveRange(post.Comments);
            _context.Reactions.RemoveRange(post.Reactions);
            _context.Posts.Remove(post);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
