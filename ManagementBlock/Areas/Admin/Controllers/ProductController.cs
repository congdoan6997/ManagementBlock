using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementBlock.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ManagementBlock.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Ajax API
        [HttpGet]
        public IActionResult GetAll()
        {
            return new OkObjectResult(_productService.GetAll());
        }
        #endregion
    }
}