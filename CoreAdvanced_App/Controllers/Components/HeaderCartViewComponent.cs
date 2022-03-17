using CoreAdvanced_App.Models;
using CoreAdvanced_App.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAdvanced_App.Controllers.Components
{
    public class HeaderCartViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            var cart = new List<ShoppingCartViewModel>();
            if(session != null)
            {
                cart = JsonConvert.DeserializeObject<List<ShoppingCartViewModel>>(session);
            }
            return View(cart);
        }
    }
}
