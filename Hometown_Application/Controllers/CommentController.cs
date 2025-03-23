using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        private readonly ApplicationDBContext _context;

        public CommentController(ApplicationDBContext context)
        {
            _context = context;
        }

        // POST: Comment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int postId, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return RedirectToAction("Details", "Post", new { id = postId });

            var comment = new CommentModel
            {
                PostId = postId,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                Content = content,
                AddedOn = DateTime.Now,
                AddedBy = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Post", new { id = postId });
        }
    }
}
