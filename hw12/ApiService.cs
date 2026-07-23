using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace hw12
{
    public class ApiService
    {
        // Task 1
        // Read data page by page
        public async IAsyncEnumerable<Product> GetProductsAsync(
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int page = 1; page <= 3; page++)
            {
                Console.WriteLine("Loading page " + page);

                await Task.Delay(1000, cancellationToken);

                for (int i = 1; i <= 2; i++)
                {
                    yield return new Product
                    {
                        Id = (page - 1) * 2 + i,
                        Name = "Product " + ((page - 1) * 2 + i)
                    };
                }
            }
        }

        // Task 2
        // Long request with timeout
        public async Task LongRequestAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Request started");

            await Task.Delay(5000, cancellationToken);

            Console.WriteLine("Request completed");
        }
    }
}
