using OA_DataAccess;
using OA_Repository;
using OA_Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service.Implementation
{
   public class ProductDetailsService: IProductDetailsService
    {
        private IRepository<ProductDetails> productDetailsRepository;

        public ProductDetailsService(IRepository<ProductDetails> productDetailsRepository)
        {
            this.productDetailsRepository = productDetailsRepository;
        }

        public ProductDetails GetUserProfile(int id)
        {
            return productDetailsRepository.Get(id);
        }
    }
}
