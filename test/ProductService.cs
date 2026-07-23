using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class ProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public void AddProduct(Product product)
        {
            if (Products.Any(x => x.Sku == product.Sku))
            {
                throw new DuplicateSkuException("This SKU is exist");
            }
            Products.Add(product);
        }

        public void ShowProducts()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine(
                    $"{product} | Delivery: {product.DeliveryCost()} byn.");
            }
        }

        public void Report(decimal minPrice)
        {
            Console.WriteLine("\nLINQ list:");

            var result = Products
                .Where(x => x.Price >= minPrice)
                .GroupBy(x => x.GetType().Name)
                .Select(x => new
                {
                    Type = x.Key,
                    Count = x.Count(),
                    Average = x.Average(p => p.Price)
                })
                .OrderByDescending(x => x.Average)
                .ToList();


            foreach (var item in result)
            {
                Console.WriteLine(
                    $"{item.Type}: Quantity {item.Count}, Midle prise {item.Average}");
            }

            Product expensive = Products.MaxBy(x => x.Price);

            Console.WriteLine(
                $"The most expensive product : {expensive.Name} {expensive.Price}");



            // query syntax
            var query =
                from product in Products
                where product.Price >= minPrice
                select product;

            Console.WriteLine("\nSelection query syntax:");

            foreach (var product in query)
            {
                Console.WriteLine(product);
            }
        }

    }
}
