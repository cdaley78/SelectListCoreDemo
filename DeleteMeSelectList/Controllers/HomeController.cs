using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DeleteMeSelectList.Models;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DeleteMeSelectList.Controllers
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
            var listWebSites = GetWebSites();

            var homeVm = new HomeViewModel
            {
                CurrentWebSiteId = 2,
                WebSites = new SelectList(listWebSites, nameof(WebSiteProxy.WebSiteId), nameof(WebSiteProxy.WebSiteName))
            };

            return View(homeVm);
        }

        public IActionResult Detail(int? id)
        {
            var listWebSites = GetWebSites();

            var homeVmDetail = new HomeViewModelDetail
            {
                WebSites = new SelectList(listWebSites, nameof(WebSiteProxy.WebSiteId), nameof(WebSiteProxy.WebSiteName), id)
            };

            return View(homeVmDetail);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public List<WebSiteProxy> GetWebSites()
        {
            List<WebSiteProxy> webSites = new List<WebSiteProxy>
            {
                new WebSiteProxy
                {
                    WebSiteId = 1,
                    WebSiteName = "WebSite 1"
                },
                new WebSiteProxy
                {
                    WebSiteId = 2,
                    WebSiteName = "WebSite 2"
                },
                new WebSiteProxy
                {
                    WebSiteId = 3,
                    WebSiteName = "WebSite 3"
                }
            };

            return webSites;
        }
    }
}
