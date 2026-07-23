namespace hw10taskk1_3
{
    class Program
    {
        static void Main(string[] args)
        {

            OrderService service = new OrderService();

            // Task 1

            List<Order> orders = new List<Order>();

            Order order = new Order();

            order.Id = 1;
            order.TotalAmount = 100;
            order.Payments = new List<Payment>()
        {
            new Payment
            {
                Id = 1,
                Amount = 50
            }
        };

            order.Items = new List<OrderItem>();
            orders.Add(order);

            List<Order> wrongOrders =
                service.FindOrdersWithWrongPayment(orders);

            Console.WriteLine("Orders with wrong payment: "
                + wrongOrders.Count);

            // Task 2

            OrderItem item = new OrderItem();

            item.ProductName = "Laptop";
            item.Quantity = 2;
            item.Price = 500;

            order.Items.Add(item);

            decimal total =
                service.CalculateOrderTotal(order);

            Console.WriteLine("Order total: " + total);

            // Task 3

            List<string> emails = new List<string>()
        {
            "test@mail.com",
            "TEST@mail.com",
            "user@mail.com"
        };

            List<string> uniqueEmails =
                service.GetUniqueEmails(emails);

            Console.WriteLine("Unique emails:");

            foreach (string email in uniqueEmails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine("Finished");
        }
    }
}
