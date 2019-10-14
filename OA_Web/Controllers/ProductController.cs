using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OA_DataAccess;
using OA_Service.Interface;
using OA_Web.Models;

namespace OA_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IProductDetailsService productDetailsService;

        public ProductController(IProductService productService, IProductDetailsService productDetailsService)
        {
            this.productService = productService;
            this.productDetailsService = productDetailsService;
        }
        public IActionResult Index()
        {
            //List<Product> model = new List<Product>();
            //productService.GetProduct().ToList().ForEach(p =>
            //{
            //    ProductDetails productDetails = productDetailsService.GetUserProfile(p.ProductId);
            //    Product user = new Product
            //    {
            //       ProductId = p.ProductId,
            //        ProductName = productD.ProductName,
            //        Email = u.Email,
            //        Address = userProfile.Address
            //    };
            //    model.Add(user);
            //});

            //return View(model);
            return View();
        }
    }
}