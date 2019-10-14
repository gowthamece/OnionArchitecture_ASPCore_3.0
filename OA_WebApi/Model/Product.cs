using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OA_WebApi.Model
{
    public class Product
    {
        [HiddenInput]
        public int ProductId { get; set; }
        [Display(Name = "Department")]
        public string Department { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
    }
}
