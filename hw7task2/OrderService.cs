using System;
using System.Collections.Generic;
using System.Text;

namespace hw7task2
{
    public class OrderService
    {

        private IOrderRepository repository;

        public OrderService(IOrderRepository repository)
        {
            this.repository = repository;
        }

        public Order Create(OrderDto dto)
        {
            try
            {
                Order order = new Order();

                order.ProductName = dto.ProductName;
                order.Price = dto.Price;

                return repository.Create(order);
            }
            catch
            {
                throw;
            }
        }

        public List<Order> GetAll()
        {
            try
            {
                return repository.GetAll();
            }
            catch
            {
                throw;
            }
        }

        public Order Update(int id, OrderDto dto)
        {
            try
            {
                Order order = new Order();

                order.ProductName = dto.ProductName;
                order.Price = dto.Price;


                return repository.Update(id, order);
            }
            catch
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                repository.Delete(id);
            }
            catch
            {
                throw;
            }
        }
    }
}
