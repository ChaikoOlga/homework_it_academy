using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class PhysicalProduct : Product
    {

        public PhysicalProduct(string sku, string name, decimal price)
            : base(sku, name, price)
        {  }

        public override decimal DeliveryCost()
        {
            return 500;
        }
    }
}
