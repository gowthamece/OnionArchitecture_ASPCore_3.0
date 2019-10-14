using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_DataAccess
{
    public class ProductDetailMap
    {
        public ProductDetailMap(EntityTypeBuilder<ProductDetails> entityBuilder)
        {
            entityBuilder.HasKey(p => p.ProductId);
            entityBuilder.Property(p => p.ProductName).IsRequired();
            entityBuilder.Property(p => p.StockAvailable).IsRequired();
            entityBuilder.Property(p => p.Price);
        }
    }
}
