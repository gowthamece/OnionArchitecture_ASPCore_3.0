using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA_Service.Interface;
using OA_WebApi.Model;

namespace OA_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IProductDetailsService productDetailsService;

        public ProductController(IProductService productService, IProductDetailsService productDetailsService)
        {
            this.productService = productService;
            this.productDetailsService = productDetailsService;
        }
        [HttpGet]
        public List<Product> Get()
        {
            List<Product> productList = new List<Product>();

            var products = productService.GetProduct().ToList();
            foreach (var product in products)
            {
                Product item = new Product
                {
                    ProductId = product.ProductId,
                    Department = product.Department,

                };
                productList.Add(item);
            }
            return productList;
            

        }
    }
    }