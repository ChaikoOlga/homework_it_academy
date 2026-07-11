using System;
using System.Collections.Generic;
using System.Text;

namespace hw7task2
{
    public class AdminOrdersController
    {
        private IOrderService service;
        public AdminOrdersController(IOrderService service)
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
