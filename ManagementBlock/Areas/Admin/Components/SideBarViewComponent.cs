using ManagementBlock.Application.Interfaces;
using ManagementBlock.Application.ViewModels;
using ManagementBlock.Extensions;
using ManagementBlock.Utilities.Constants;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ManagementBlock.Areas.Admin.Components
{
    public class SideBarViewComponent : ViewComponent
    {
        private IMenuService _menuService;
        public SideBarViewComponent(IMenuService menuService)
        {
            _menuService = menuService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var roles = ((ClaimsPrincipal)User).GetSpecificClaim("Roles");
            List<MenuViewModel> menuViewModels;
            if (roles.Split(";").Contains(CommonConstants.AdminRole))
            {
                menuViewModels = await _menuService.GetAll();
            }
            else
            {
                menuViewModels = new List<MenuViewModel>();
            }
            return View(menuViewModels);
        }
    }
}
