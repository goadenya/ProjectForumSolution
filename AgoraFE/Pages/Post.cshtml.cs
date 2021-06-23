using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgoraFE.Areas.Identity.Data;
using AgoraFE.Models;
using AgoraFE.Services;
using AgoraFE.Services.Tools;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgoraFE.Pages
{
    public class PostModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int PostId { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Category { get; set; }

        public Models.Post Post { get; set; }

        [BindProperty]
        public Models.Comment Comment { get; set; }

        [BindProperty]
        public Models.Reply Reply { get; set; }

        private readonly UserManager<AgoraFEUser> _userManager;

        private readonly PostManager _postManager;

        private readonly CommentManager _commentManager;

        private readonly ReplyManager _replyManager;

        public Tools _tools;
        public PostModel(PostManager postManager, Tools tools, UserManager<AgoraFEUser> userManager, CommentManager commentManager, ReplyManager replyManager)
        {
            _userManager = userManager;
            _postManager = postManager;
            _commentManager = commentManager;
            _replyManager = replyManager;
            _tools = tools;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            if (PostId != 0)
            {
                Post = await _postManager.GetPost(PostId);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Comment.text != null)
            {
                await _commentManager.AddComment(Comment);
            }

            if (Reply.text != null)
            {
                await _replyManager.AddReply(Reply);
            }
            return RedirectToPage("Post", new {Category = Category, PostId = PostId });
        }
    }
}
