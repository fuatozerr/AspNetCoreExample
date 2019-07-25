using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.MvcWebUI.Models;

namespace Project.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var products=_productService.GetAll();
            ProductListViewModel model = new ProductListViewModel()
            {
                Products = products
               
            };

            return View(model);
        }
    }
}