using System;
using System.Collections.Generic;
using System.Text;

namespace hw9task1_4
{
    public class ProductRepository : IProductRepository
    {

        private List<Product> products = new List<Product>()
    {
        new Product
        {
            Id = 1,
            Name = "Laptop",
            Status = "Available",
            Price = 1000
        },

        new Product
        {
            Id = 2,
            Name = "Phone",
            Status = "Sold",
            Price = 500
        },

        new Product
        {
            Id = 3,
            Name = "Tablet",
            Status = "Available",
            Price = 700
        },

        new Product
        {
            Id = 4,
            Name = "Monitor",
            Status = "Sold",
            Price = 300
        }
    };
        public List<Product> GetAll()
        {
            return products;
        }

    }
}
