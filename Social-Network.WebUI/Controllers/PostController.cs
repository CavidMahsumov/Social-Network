using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Social_Network.Business.Abstract;
using Social_Network.Entities.Concrete;
using Social_Network.WebUI.Entities;
using Social_Network.WebUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        private UserManager<CustomIdentityUser> _userManager;
        public PostController(IPostService postService, UserManager<CustomIdentityUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _postService = postService;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(PostViewModel postViewModel)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            _postService.Add(new Post {  UserId="1", Description = postViewModel.Content, Date=System.DateTime.Now, ImageUrl= "/images/user-9.png", Rating=10, VideoUrl="video"    });


            return RedirectToAction("Default", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Index(IList<IFormFile> files)
        {
            foreach (IFormFile source in files)
            {
                string filename = ContentDispositionHeaderValue.Parse(source.ContentDisposition).FileName.Trim('"');

                filename = this.EnsureCorrectFilename(filename);

                using (FileStream output = System.IO.File.Create(this.GetPathAndFilename(filename)))
                    await source.CopyToAsync(output);//output return file path
            }

            return this.View();
        }

        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }

        private string GetPathAndFilename(string filename)
        {
            return this._webHostEnvironment.WebRootPath + "\\" + filename;
        }
    }
}
