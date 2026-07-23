namespace hw9task1_4
{
    class Program
    {
        static void Main(string[] args)
        {

            IProductRepository repository =
                new ProductRepository();


            ProductService service =
                new ProductService(repository);


            Console.WriteLine("Filter by price:");

            var filteredProducts = service.FilterByPrice(600);

            foreach (var product in filteredProducts)
            {
                Console.WriteLine(product.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Sort by id descending:");

            var sortedDescending = service.SortById(true);

            foreach (var product in sortedDescending)
            {
                Console.WriteLine(product.Id + " - " + product.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Sort by id ascending:");

            var sortedAscending = service.SortById(false);

            foreach (var product in sortedAscending)
            {
                Console.WriteLine(product.Id + " - " + product.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Product names:");

            var names = service.GetProductNames();

            foreach (var item in (dynamic)names)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("Finished");
        }
    }
}
