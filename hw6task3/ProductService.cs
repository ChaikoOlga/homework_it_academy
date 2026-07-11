using System;
using System.Collections.Generic;
using System.Text;

namespace hw6task3
{
    public class ProductService
    {
        public ProductResponse GetProduct()
        {
            Product product = new Product();

            product.Id = 1;
            product.Name = "Laptop";
            product.Price = 1200;

            ProductResponse response = new ProductResponse();

            response.Name = product.Name;
            response.Price = product.Price;

            return response;
        }
    }
}
