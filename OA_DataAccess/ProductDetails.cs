using System;
using System.Collections.Generic;
using System.Text;

namespace OA_DataAccess
{
    public class ProductDetails : BaseEntity
    {      
        public string ProductName { get; set; }
        public int StockAvailable { get; set; }
        public decimal Price { get; set; }
        public virtual Product Product{get;set;}
    }
}
