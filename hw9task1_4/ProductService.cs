using System;
using System.Collections.Generic;
using System.Text;

namespace hw9task1_4
{
    public class ProductService
    {

        private IProductRepository repository;
        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }
        // Filter products by price threshold
        public List<Product> FilterByPrice(decimal price)
        {
            List<Product> products = repository.GetAll();

            return products
                .Where(x => x.Price >= price)
                .ToList();
        }

        // Group products by status
        public object GroupByStatus()
        {
            List<Product> products = repository.GetAll();

            var result = products
                .GroupBy(x => x.Status)
                .Select(group => new
                {
                    Status = group.Key,
                    Products = group.ToList()
                });

            return result;
        }
        // Sort products by id
        public List<Product> SortById(bool descending)
        {
            List<Product> products = repository.GetAll();

            if (descending)
            {
                return products
                    .OrderByDescending(x => x.Id)
                    .ToList();
            }

            return products
                .OrderBy(x => x.Id)
                .ToList();
        }

        // Return anonymous type with product names
        public object GetProductNames()
        {
            List<Product> products = repository.GetAll();

            var result = products.Select(x => new
            {
                ProductName = x.Name
            });

            return result;
        }

    }
}
