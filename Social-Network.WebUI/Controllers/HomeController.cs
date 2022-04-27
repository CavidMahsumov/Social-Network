using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        public IActionResult Default()
        {
            return View();
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
        public IActionResult AccountInformation()
        {
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
