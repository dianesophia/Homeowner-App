using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class ReactionController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReactionController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // POST: Reaction/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int postId, string type)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Check if user already reacted
            var existingReaction = await _context.Reactions
                .Where(r => r.PostId == postId && r.UserId == userId)
                .FirstOrDefaultAsync();

            if (existingReaction != null)
            {
                existingReaction.Type = type;
            }
            else
            {
                var reaction = new ReactionModel
                {
                    PostId = postId,
                    UserId = userId,
                    Type = type
                };
                _context.Reactions.Add(reaction);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Post", new { id = postId });
        }
    }
}
