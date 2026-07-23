namespace hw7task2
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {

                OrderRepository repository = new OrderRepository();

                OrderService service = new OrderService(repository);

                OrdersController controller =
                    new OrdersController(service);

                AdminOrdersController adminController =
                    new AdminOrdersController(service);

                OrderDto dto = new OrderDto();

                dto.ProductName = "Laptop";
                dto.Price = 1000;

                controller.Create(dto);

                foreach (Order order in controller.GetAll())
                {
                    Console.WriteLine(order.ProductName);
                }

                OrderDto update = new OrderDto();

                update.ProductName = "Phone";
                update.Price = 500;

                adminController.Update(1, update);

                adminController.Delete(1);

                Console.WriteLine("Finished");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}