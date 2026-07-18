namespace hw12
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ApiService service = new ApiService();

            Console.WriteLine("Task 1");

            await foreach (Product product in service.GetProductsAsync())
            {
                Console.WriteLine(product.Id + " " + product.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Task 2");

            CancellationTokenSource source =
                new CancellationTokenSource();

            source.CancelAfter(3000);

            try
            {
                await service.LongRequestAsync(source.Token);
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("Request cancelled");
            }

            Console.WriteLine("Finished");
        }
    }
}
