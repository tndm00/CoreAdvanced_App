using CoreAdvanced_App.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreAdvanced_App.Controllers.Components
{
    public class MobileMenuViewComponent : ViewComponent
    {
        private IProductCategoryService _productCategoryService;

        public MobileMenuViewComponent(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_productCategoryService.GetAll());
        }
    }
}