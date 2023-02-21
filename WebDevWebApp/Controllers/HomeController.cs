using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebDevWebApp.Models;

namespace WebDevWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private const string PageViews = "PageViews";
     

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult GDPR()
        {
            return View();
        }

        public IActionResult Index()
        {
            UpdatePageViewCookie();

            return View();
        }

        public IActionResult Privacy()
        {
            UpdatePageViewCookie();

            return View();
        }
        public IActionResult Portfolio()
        {
            UpdatePageViewCookie();

            return View();
        }
        public IActionResult Contact()
        {
            UpdatePageViewCookie();

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public void UpdatePageViewCookie()
        {
            var trackingcookie = Request.Cookies[PageViews];

            if (trackingcookie == null)
            {
                Response.Cookies.Append(PageViews, "1");
            }
            else
            {
                var newCookieValue = short.Parse(trackingcookie) + 1;

                Response.Cookies.Append(PageViews, newCookieValue.ToString());
            }
        }



    }

}
