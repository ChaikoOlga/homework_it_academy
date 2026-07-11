using System;
using System.Collections.Generic;
using System.Text;

namespace hw7task2
{
    public class OrderService : IOrderService
    {
        private List<Order> orders = new List<Order>();
        public Order Create(OrderDto dto)
        {
            Order order = new Order();

            order.Id = orders.Count + 1;
            order.ProductName = dto.ProductName;
            order.Price = dto.Price;

            orders.Add(order);

            return order;
        }

        public List<Order> GetAll()
        {
            return orders;
        }
        public Order Update(int id, OrderDto dto)
        {
            Order order = orders.Find(x => x.Id == id);

            order.ProductName = dto.ProductName;
            order.Price = dto.Price;

            return order;
        }
        public void Delete(int id)
        {
            Order order = orders.Find(x => x.Id == id);

            orders.Remove(order);
        }
    }
}
