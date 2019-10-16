using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_DataAccess
{
   public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {

            entityBuilder.HasKey(p => p.ProductId);
            entityBuilder.Property(p => p.ProductName).IsRequired();           
            entityBuilder.HasOne(p => p.ProductDetails).WithOne(p => p.Product).HasForeignKey<ProductDetails>(x => x.ProductId);
        }
    }
}
