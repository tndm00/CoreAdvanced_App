using CoreAdvanced_App.Application.Interfaces;
using CoreAdvanced_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CoreAdvanced_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService _productService;
        private IProductCategoryService _productCategoryService;

        private IBlogService _blogService;
        private ICommonService _commonService;

        public HomeController(ILogger<HomeController> logger,
            IProductService productService,
            IProductCategoryService productCategoryService,
            IBlogService blogService,
            ICommonService commonService)
        {
            _logger = logger;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _blogService = blogService;
            _commonService = commonService;
        }

        public IActionResult Index()
        {
            ViewData["BodyClass"] = "cms-index-index cms-home-page";
            var homeVm = new HomeViewModel();
            homeVm.HomeCategories = _productCategoryService.GetHomeCategories(5);
            homeVm.HotProducts = _productService.GetHotProduct(5);
            homeVm.TopSellProducts = _productService.GetLastest(5);
            homeVm.LastestBlogs = _blogService.GetLastest(5);
            homeVm.HomeSlides = _commonService.GetSlides("top");
            return View(homeVm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}