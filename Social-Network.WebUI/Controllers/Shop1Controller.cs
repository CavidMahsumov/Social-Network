using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Controllers
{
    public class Shop1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
