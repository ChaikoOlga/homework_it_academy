using System;
using System.Collections.Generic;
using System.Text;

namespace hw7task2
{
    public class OrdersController
    {

        private OrderService service;
        public OrdersController(OrderService service)
        {
            this.service = service;
        }
        public Order Create(OrderDto dto)
        {
            return service.Create(dto);
        }
        public List<Order> GetAll()
        {
            return service.GetAll();
        }

    }
}
