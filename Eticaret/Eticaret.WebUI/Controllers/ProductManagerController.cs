// SPDX-FileCopyrightText: 2026 Bora Yarkın
// SPDX-License-Identifier: GPL-3.0-only

﻿using Eticaret.Core.Contracts;
using Eticaret.Core.Models;
using Eticaret.Core.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Eticaret.WebUI.Controllers
{
    [Authorize]
    public class ProductManagerController : Controller
    {
        IRepository<Product> context;
        IRepository<ProductCategory> productCategories;
        readonly IWebHostEnvironment hostingEnvironment;

        public ProductManagerController(IRepository<Product> productContext, IRepository<ProductCategory> productCategoryContext, IWebHostEnvironment hostingEnvironment)
        {
            context = productContext;
            productCategories = productCategoryContext;
            this.hostingEnvironment = hostingEnvironment;
        }
        // GET: ProductManager
        public IActionResult Index()
        {
            List<Product> products = context.Collection().ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            ProductManagerViewModel viewModel = new ProductManagerViewModel();

            viewModel.Product = new Product();
            viewModel.ProductCategories = productCategories.Collection();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            else
            {

                if (file != null && file.Length > 0)
                {
                    var imagesPath = EnsureProductImagesPath();
                    product.Image = product.Id + Path.GetExtension(file.FileName);
                    var filePath = Path.Combine(imagesPath, product.Image);
                    using var stream = System.IO.File.Create(filePath);
                    file.CopyTo(stream);
                }

                context.Insert(product);
                context.Commit();

                return RedirectToAction("Index");
            }

        }

        public IActionResult Edit(string Id)
        {
            Product product = context.Find(Id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                ProductManagerViewModel viewModel = new ProductManagerViewModel();
                viewModel.Product = product;
                viewModel.ProductCategories = productCategories.Collection();

                return View(viewModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product, string Id, IFormFile file)
        {
            Product productToEdit = context.Find(Id);

            if (productToEdit == null)
            {
                return NotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(product);
                }

                if (file != null && file.Length > 0)
                {
                    var imagesPath = EnsureProductImagesPath();
                    productToEdit.Image = product.Id + Path.GetExtension(file.FileName);
                    var filePath = Path.Combine(imagesPath, productToEdit.Image);
                    using var stream = System.IO.File.Create(filePath);
                    file.CopyTo(stream);
                }

                productToEdit.Category = product.Category;
                productToEdit.Description = product.Description;
                productToEdit.Name = product.Name;
                productToEdit.Price = product.Price;

                context.Commit();

                return RedirectToAction("Index");
            }
        }


        public IActionResult Delete(string Id)
        {
            Product productToDelete = context.Find(Id);

            if (productToDelete == null)
            {
                return NotFound();
            }
            else
            {
                return View(productToDelete);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(string Id)
        {
            Product productToDelete = context.Find(Id);

            if (productToDelete == null)
            {
                return NotFound();
            }
            else
            {
                context.Delete(Id);
                context.Commit();
                return RedirectToAction("Index");
            }
        }

        private string EnsureProductImagesPath()
        {
            var imagesPath = Path.Combine(hostingEnvironment.WebRootPath, "Content", "ProductImages");
            Directory.CreateDirectory(imagesPath);
            return imagesPath;
        }
    }
}
