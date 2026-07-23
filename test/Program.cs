namespace test
{
    class Program
    {
        static void Main()
        {
            ProductService service = new ProductService();

            service.AddProduct(
                new PhysicalProduct("001", "Phone", 30000));

            service.AddProduct(
                new PhysicalProduct("002", "Laptop", 70000));

            service.AddProduct(
                new DigitalProduct("003", "Game", 2000));

            int choice;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Show catalog");
                Console.WriteLine("2 - Add product");
                Console.WriteLine("3 - LINQ report");
                Console.WriteLine("0 - Exit");

                Console.Write("Choose option: ");

                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        service.ShowProducts();
                        break;

                    case 2:

                        try
                        {
                            Console.Write("Enter SKU: ");
                            string sku = Console.ReadLine();

                            Console.Write("Enter product name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter price: ");

                            decimal.TryParse(
                                Console.ReadLine(),
                                out decimal price);


                            Console.WriteLine("Choose product type:");
                            Console.WriteLine("1 - Physical product");
                            Console.WriteLine("2 - Digital product");

                            int type;

                            int.TryParse(
                                Console.ReadLine(),
                                out type);

                            Product product;

                            if (type == 1)
                            {
                                product = new PhysicalProduct(
                                    sku,
                                    name,
                                    price);
                            }
                            else
                            {
                                product = new DigitalProduct(
                                    sku,
                                    name,
                                    price);
                            }

                            service.AddProduct(product);

                            Console.WriteLine("Product added successfully");

                        }
                        catch (DuplicateSkuException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }

                        break;

                    case 3:

                        Console.Write("Enter minimum price: ");


                        decimal.TryParse(
                            Console.ReadLine(),
                            out decimal minPrice);

                        service.Report(minPrice);

                        break;

                    case 0:

                        Console.WriteLine("Application closed");

                        break;

                    default:

                        Console.WriteLine("Invalid menu option");

                        break;
                }

            } while (choice != 0);
        }
    }
}
