using System;
using System.Collections.Generic;
using System.Text;

namespace OA_DataAccess
{
  public class Product : BaseEntity
    {

        public string ProductName { get; set; }
        public virtual ProductDetails ProductDetails { get; set; }
    }
}
