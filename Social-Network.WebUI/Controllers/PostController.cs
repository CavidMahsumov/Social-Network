using Microsoft.AspNetCore.Mvc;
using Social_Network.Business.Abstract;
using Social_Network.Entities.Concrete;
using Social_Network.WebUI.Models;

namespace Social_Network.WebUI.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(PostViewModel postViewModel)
        {
            _postService.Add(new Post {  UserId=6, Description = postViewModel.Content, Date=System.DateTime.Now, ImageUrl="Images", Rating=10, VideoUrl="video"    });
            return Redirect("index");
        }
    }
}
