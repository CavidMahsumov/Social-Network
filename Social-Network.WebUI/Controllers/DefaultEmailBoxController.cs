using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Controllers
{
    public class DefaultEmailBoxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
