using System;
using System.Collections.Generic;
using System.Text;

namespace hw10taskk1_3
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItem> Items { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
