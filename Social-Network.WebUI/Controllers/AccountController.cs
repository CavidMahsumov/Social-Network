using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Social_Network.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;
        private RoleManager<CustomIdentityRole> _roleManager;
        private SignInManager<CustomIdentityUser> _signInManager;

        public AccountController(UserManager<CustomIdentityUser> userManager,
            RoleManager<CustomIdentityRole> roleManager,
            SignInManager<CustomIdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

    }
}
