using System;
using System.Collections.Generic;
using System.Text;

namespace hw7task2
{
    public interface IOrderService
    {
        Order Create(OrderDto dto);
        List<Order> GetAll();
        Order Update(int id, OrderDto dto);
        void Delete(int id);
    }
}
