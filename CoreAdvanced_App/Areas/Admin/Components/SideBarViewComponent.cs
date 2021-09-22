using CoreAdvanced_App.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using CoreAdvanced_App.Extensions;
using CoreAdvanced_App.Application.ViewModels.System;
using System.Collections.Generic;
using System.Linq;
using CoreAdvanced_App.Utilities.Constants;

namespace CoreAdvanced_App.Areas.Admin.Components
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly IFunctionService _functionService;

        public SideBarViewComponent(IFunctionService functionService)
        {
            _functionService = functionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var roles = ((ClaimsPrincipal)User).GetSpecificClaim("Roles");
            List<FunctionViewModel> lstFunction;

            if (roles.Split(";").Contains(SystemConstants.AppRole.AdminRole))
            {
                lstFunction = await _functionService.GetAll(string.Empty);
            }
            else
            {
                //TODO:
                lstFunction = new List<FunctionViewModel>();
            }

            return View(lstFunction);
        }
    }
}