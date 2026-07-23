using System;
using System.Collections.Generic;
using System.Text;

namespace hw7task2
{
    public class AdminOrdersController
    {

        private OrderService service;
        public AdminOrdersController(OrderService service)
        {
            this.service = service;
        }
        public Order Update(int id, OrderDto dto)
        {
            return service.Update(id, dto);
        }

        public void Delete(int id)
        {
            service.Delete(id);
        }

    }
}
