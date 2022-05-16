using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Social_Network.Business.Abstract;
using Social_Network.WebUI.Entities;
using Social_Network.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {

        private IUserService _userService;
        private IHttpContextAccessor _httpContext;
        private UserManager<CustomIdentityUser> _userManager;
        private readonly IWebHostEnvironment _webhost;
        private IPostService _postService;

        public HomeController(IUserService userService, IHttpContextAccessor httpContext, UserManager<CustomIdentityUser> userManager, IWebHostEnvironment webhost, IPostService postService)
        {
            _userService = userService;
            _httpContext = httpContext;
            _userManager = userManager;
            _webhost = webhost;
            _postService = postService;
        }
        public IActionResult Default()
        {
            var list=_postService.GetAll();
            return View(list);
        }
        public IActionResult DefaultStorie()
        {
            return View();
        } 
        public IActionResult DefaultVideo()
        {
            return View();
        }
       public IActionResult DefaultGroup()
        {
            return View();
        }
        public IActionResult Shop2()
        {
            return View();
        }
        public IActionResult DefaultSettings()
        {
            return View();
        }
       public IActionResult Badges()
        {
            return View();
        }
        public IActionResult UserPage()
        {
            return View();
        }
        public IActionResult DefaultEmailBox()
        {
            return View();
        }
        public IActionResult DefaultHotel()
        {
            return View();
        }
        public IActionResult DefaultEvent()
        {
            return View();
        }
        public IActionResult LiveStream()
        {
            return View();
        }
        public IActionResult DefaultAnalytics()
        {
            return View();
        }
        public IActionResult DefaultMessage()
        {
            return View();
        }
        public IActionResult DefaultEmailOpen()
        {
            return View();
        }
        public async Task<IActionResult> AccountInformation()
        {
            var userId = _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

          

            return View();
        }
        public IActionResult ContactInformation()
        {
            return View();
        }
        public IActionResult Social()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult Password()
        {
            return View();
        }
        public IActionResult DefaultNotfication()
        {
            return View();
        }
        public IActionResult HelpBox()
        {
            return View();
        }
        public IActionResult HotelDetails()
        {
            return View();
        }
        
    }
}
