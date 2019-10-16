using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA_WebApi.Model
{
    public class ProductDetails
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int StockAvailable { get; set; }
        public decimal Price { get; set; }
    }
}
