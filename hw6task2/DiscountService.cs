using System;
using System.Collections.Generic;
using System.Text;

namespace hw6task2
{
    class DiscountService
    {
        private List<DiscountRule> rules;

        public DiscountService(List<DiscountRule> rules)
        {
            this.rules = rules;
        }

        public double ApplyDiscounts(double price)
        {
            double result = price;

            foreach (DiscountRule rule in rules)
            {
                result = rule.Apply(result);
            }

            return result;
        }
    }
}
