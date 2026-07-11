using System;
using System.Collections.Generic;
using System.Text;

namespace hw7task2
{
    public class OrdersController
    {
        private IOrderService service;
        public OrdersController(IOrderService service)
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
