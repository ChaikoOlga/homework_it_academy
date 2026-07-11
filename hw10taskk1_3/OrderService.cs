using System;
using System.Collections.Generic;
using System.Text;

namespace hw10taskk1_3
{
    public class OrderService
    {

        // 1. Find orders where total amount does not match any payment
        public List<Order> FindOrdersWithWrongPayment(List<Order> orders)
        {
            List<Order> result = new List<Order>();

            foreach (Order order in orders)
            {
                bool paymentFound = false;

                foreach (Payment payment in order.Payments)
                {
                    if (payment.Amount == order.TotalAmount)
                    {
                        paymentFound = true;
                    }
                }

                if (paymentFound == false)
                {
                    result.Add(order);
                }
            }

            return result;
        }

        // 2. Check positive quantity and calculate total
        public decimal CalculateOrderTotal(Order order)
        {
            decimal total = 0;

            foreach (OrderItem item in order.Items)
            {
                if (item.Quantity <= 0)
                {
                    throw new Exception("Quantity must be positive");
                }

                total = total + (item.Price * item.Quantity);
            }

            return total;
        }

        // 3. Return unique emails without case sensitivity
        public List<string> GetUniqueEmails(List<string> emails)
        {
            return emails
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();
        }

    }
}
