using ManagementBlock.Data.Entities;
using ManagementBlock.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementBlock.Data.EF
{
    public class DbInit
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;
        private RoleManager<AppRole> _roleManager;
        public DbInit(AppDbContext context, UserManager<AppUser> appuser, RoleManager<AppRole> approle)
        {
            _context = context;
            _userManager = appuser;
            _roleManager = approle;
        }
        public async Task SeedAsync()
        {
            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Description = "Top manager"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Member",
                    NormalizedName = "Member",
                    Description = "Member"
                });
            }

            if (!_userManager.Users.Any())
            {
                await _userManager.CreateAsync(new AppUser()
                {
                    UserName = "admin",
                    FullName = "Administrator",
                    Email = "admin@gmail.com",
                    Money = 0,
                }, "Buicongdoan97");
                var user = await _userManager.FindByNameAsync("admin");
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            if (_context.Menus.Count() == 0)
            {
                _context.Menus.AddRange(new List<Menu>()
                {
                    new Menu() {Id = "SYSTEM", Name = "System",ParentId = null,SortNumber = 1,Status = Status.Active,Url = "/",IconCss = "fa-desktop"  },
                    new Menu() {Id = "ROLE", Name = "Role",ParentId = "SYSTEM",SortNumber = 1,Status = Status.Active,Url = "/admin/role/index",IconCss = "fa-home"  },
                    new Menu() {Id = "Menu", Name = "Menu",ParentId = "SYSTEM",SortNumber = 2,Status = Status.Active,Url = "/admin/Menu/index",IconCss = "fa-home"  },
                    new Menu() {Id = "USER", Name = "User",ParentId = "SYSTEM",SortNumber =3,Status = Status.Active,Url = "/admin/user/index",IconCss = "fa-home"  },
                    new Menu() {Id = "ACTIVITY", Name = "Activity",ParentId = "SYSTEM",SortNumber = 4,Status = Status.Active,Url = "/admin/activity/index",IconCss = "fa-home"  },
                    new Menu() {Id = "ERROR", Name = "Error",ParentId = "SYSTEM",SortNumber = 5,Status = Status.Active,Url = "/admin/error/index",IconCss = "fa-home"  },
                    new Menu() {Id = "SETTING", Name = "Configuration",ParentId = "SYSTEM",SortNumber = 6,Status = Status.Active,Url = "/admin/setting/index",IconCss = "fa-home"  },
                    new Menu() {Id = "PRODUCT",Name = "Product Management",ParentId = null,SortNumber = 2,Status = Status.Active,Url = "/",IconCss = "fa-chevron-down"  },
                    new Menu() {Id = "PRODUCT_CATEGORY",Name = "Category",ParentId = "PRODUCT",SortNumber =1,Status = Status.Active,Url = "/admin/productcategory/index",IconCss = "fa-chevron-down"  },
                    new Menu() {Id = "PRODUCT_LIST",Name = "Product",ParentId = "PRODUCT",SortNumber = 2,Status = Status.Active,Url = "/admin/product/index",IconCss = "fa-chevron-down"  },
                    new Menu() {Id = "BILL",Name = "Bill",ParentId = "PRODUCT",SortNumber = 3,Status = Status.Active,Url = "/admin/bill/index",IconCss = "fa-chevron-down"  },
                    new Menu() {Id = "CONTENT",Name = "Content",ParentId = null,SortNumber = 3,Status = Status.Active,Url = "/",IconCss = "fa-table"  },
                    new Menu() {Id = "BLOG",Name = "Blog",ParentId = "CONTENT",SortNumber = 1,Status = Status.Active,Url = "/admin/blog/index",IconCss = "fa-table"  },
                    new Menu() {Id = "UTILITY",Name = "Utilities",ParentId = null,SortNumber = 4,Status = Status.Active,Url = "/",IconCss = "fa-clone"  },
                    new Menu() {Id = "FOOTER",Name = "Footer",ParentId = "UTILITY",SortNumber = 1,Status = Status.Active,Url = "/admin/footer/index",IconCss = "fa-clone"  },
                    new Menu() {Id = "FEEDBACK",Name = "Feedback",ParentId = "UTILITY",SortNumber = 2,Status = Status.Active,Url = "/admin/feedback/index",IconCss = "fa-clone"  },
                    new Menu() {Id = "ANNOUNCEMENT",Name = "Announcement",ParentId = "UTILITY",SortNumber = 3,Status = Status.Active,Url = "/admin/announcement/index",IconCss = "fa-clone"  },
                    new Menu() {Id = "CONTACT",Name = "Contact",ParentId = "UTILITY",SortNumber = 4,Status = Status.Active,Url = "/admin/contact/index",IconCss = "fa-clone"  },
                    new Menu() {Id = "SLIDE",Name = "Slide",ParentId = "UTILITY",SortNumber = 5,Status = Status.Active,Url = "/admin/slide/index",IconCss = "fa-clone"  },
                    new Menu() {Id = "ADVERTISMENT",Name = "Advertisment",ParentId = "UTILITY",SortNumber = 6,Status = Status.Active,Url = "/admin/advertistment/index",IconCss = "fa-clone"  },

                    new Menu() {Id = "REPORT",Name = "Report",ParentId = null,SortNumber = 5,Status = Status.Active,Url = "/",IconCss = "fa-bar-chart-o"  },
                    new Menu() {Id = "REVENUES",Name = "Revenue report",ParentId = "REPORT",SortNumber = 1,Status = Status.Active,Url = "/admin/report/revenues",IconCss = "fa-bar-chart-o"  },
                    new Menu() {Id = "ACCESS",Name = "Visitor Report",ParentId = "REPORT",SortNumber = 2,Status = Status.Active,Url = "/admin/report/visitor",IconCss = "fa-bar-chart-o"  },
                    new Menu() {Id = "READER",Name = "Reader Report",ParentId = "REPORT",SortNumber = 3,Status = Status.Active,Url = "/admin/report/reader",IconCss = "fa-bar-chart-o"  },
                });
            }
            if (_context.Products.Count() == 0)
            {
                _context.Products.AddRange(new List<Product>()
                {
                    new Product(){Name = "Product 1",DateCreated=DateTime.Now,Image="/admin-side/images/prod-1.jpg",Status = Status.Active},
                           new Product(){Name = "Product 2",DateCreated=DateTime.Now,Image="/admin-side/images/prod-1.jpg", Status = Status.Active},
                            new Product(){Name = "Product 3",DateCreated=DateTime.Now,Image="/admin-side/images/prod-1.jpg",Status = Status.Active},
                            new Product(){Name = "Product 4",DateCreated=DateTime.Now,Image="/admin-side/images/prod-1.jpg",Status = Status.Active},
                            new Product(){Name = "Product 5",DateCreated=DateTime.Now,Image="/admin-side/images/prod-1.jpg",Status = Status.Active},
                });
            }
            await _context.SaveChangesAsync();
        }
    }
}
