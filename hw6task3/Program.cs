namespace hw6task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService service = new ProductService();

            ProductsController controller = new ProductsController(service);

            ProductResponse product = controller.Get();

            Console.WriteLine("Product name: " + product.Name);
            Console.WriteLine("Product price: " + product.Price);
        }
    }
}
