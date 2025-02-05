using Microsoft.AspNetCore.Mvc;

namespace CodeZone.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewBag.ErrorMessage = HttpContext.Items["errorMessage"] as string;
            ViewBag.ErrorCode = HttpContext.Response.StatusCode;
            return View();
        }
    }
}
