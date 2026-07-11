using System;
using System.Collections.Generic;
using System.Text;

namespace hw6task3
{
    public class ProductsController
    {
        private ProductService service;

        public ProductsController(ProductService service)
        {
            this.service = service;
        }

        public ProductResponse Get()
        {
            return service.GetProduct();
        }
    }
}
