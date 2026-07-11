using System;
using System.Collections.Generic;
using System.Text;

namespace hw7task2
{
    public class OrderRepository :
    IOrderRepository,
    ISearchRepository,
    IStatisticsRepository
    {

        private List<Order> orders = new List<Order>();


        public Order Create(Order order)
        {
            try
            {
                if (order == null)
                {
                    throw new Exception("Order is empty");
                }

                order.Id = orders.Count + 1;

                orders.Add(order);

                return order;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Order> GetAll()
        {
            try
            {
                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Order GetById(int id)
        {
            try
            {
                Order order = orders.Find(x => x.Id == id);

                if (order == null)
                {
                    throw new Exception("Order not found");
                }

                return order;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Order Update(int id, Order newOrder)
        {
            try
            {
                Order order = GetById(id);

                order.ProductName = newOrder.ProductName;
                order.Price = newOrder.Price;

                return order;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                Order order = GetById(id);
                orders.Remove(order);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Order> SearchByName(string name)
        {
            try
            {
                return orders.FindAll(x => x.ProductName == name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int GetCount()
        {
            try
            {
                return orders.Count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

