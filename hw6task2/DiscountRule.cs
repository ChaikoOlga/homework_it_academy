using System;
using System.Collections.Generic;
using System.Text;

namespace hw6task2
{
    class DiscountRule
    {
        public string Name;
        public double Percent;

        public DiscountRule(string name, double percent)
        {
            Name = name;
            Percent = percent;
        }

        public double Apply(double price)
        {
            return price - (price * Percent / 100);
        }
    }
}
