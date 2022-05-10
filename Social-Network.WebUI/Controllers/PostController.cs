using Microsoft.AspNetCore.Mvc;

namespace Social_Network.WebUI.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
