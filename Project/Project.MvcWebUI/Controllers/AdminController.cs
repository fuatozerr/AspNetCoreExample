﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.MvcWebUI.Models;
using Project.Northwind.Entities.Concreate;

namespace Project.MvcWebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public AdminController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var productListViewModel = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };

            return View(productListViewModel);
        }
        
        public IActionResult Insert()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Insert(Product product)
        {
            if(ModelState.IsValid)
            {
                _productService.Add(product);
                TempData.Add("message", "Product was succesfully added");

            }

            return RedirectToAction("Insert");
        }

        public ActionResult Update(int productId)
        {
            var product = _productService.GetById(productId);

            var model = new ProductUpdateViewModel
            {
                Product =_productService.GetById(productId),
                Categories=_categoryService.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            _productService.Update(product);
            return RedirectToAction("Update");
        }

        public ActionResult Delete(int productId)
        {
            _productService.Delete(productId);
          return  RedirectToAction("Index");
        }
    }
}