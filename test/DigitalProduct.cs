using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class DigitalProduct : Product
    {

        public DigitalProduct(string sku, string name, decimal price)
            : base(sku, name, price)
        {  }


        public override decimal DeliveryCost()
        {
            return 0;
        }
    }
}
