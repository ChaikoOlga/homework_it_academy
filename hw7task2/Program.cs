namespace hw7task2
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderService service = new OrderService();


            OrdersController ordersController =
                new OrdersController(service);


            AdminOrdersController adminController =
                new AdminOrdersController(service);


            OrderDto dto = new OrderDto();

            dto.ProductName = "Laptop";
            dto.Price = 1000;

            Order order = ordersController.Create(dto);

            Console.WriteLine("Created order: " + order.ProductName);

            var orders = ordersController.GetAll();

            Console.WriteLine("Orders count: " + orders.Count);

            OrderDto updateDto = new OrderDto();

            updateDto.ProductName = "Phone";
            updateDto.Price = 500;

            adminController.Update(1, updateDto);

            adminController.Delete(1);

            Console.WriteLine("Order deleted");
        }
    }
}
