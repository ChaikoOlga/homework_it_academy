using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public abstract class Product : IIdentifiable
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public decimal Price { get; private set; }
        public string Id => Sku;


        protected Product(string sku, string name, decimal price)
        {
            Sku = sku;
            Name = name;

            ChangePrice(price);
        }


        public void ChangePrice(decimal price)
        {
            if (price <= 0)
            {
                throw new ArgumentException("Price can be < 0");
            }

            Price = price;
        }


        public abstract decimal DeliveryCost();


        public override string ToString()
        {
            return $"{Sku} | {Name} | {Price} byn.";
        }
    }
}
