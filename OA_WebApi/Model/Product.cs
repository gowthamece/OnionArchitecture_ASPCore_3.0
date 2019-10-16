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
        
        public int ProductId { get; set; }                        
        public string ProductName { get; set; }
    }
}
