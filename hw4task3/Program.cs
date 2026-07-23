namespace hw4task3
{
    class OutboxMessage
    {
        public Guid EventId { get; set; }
        public string Payload { get; set; }
        public string Status { get; set; } 
        public int RetryCount { get; set; }
    }

    class Program
    {
        static void Main()
        {
            OutboxMessage message = new OutboxMessage
            {
                EventId = Guid.NewGuid(),
                Payload = "OrderCreated",
                Status = "Pending",
                RetryCount = 0
            };

            message.Status = "Failed";
            message.RetryCount++;

            message.Status = "Sent";
            Console.WriteLine($"Event ID: {message.EventId}");
            Console.WriteLine($"Payload: {message.Payload}");
            Console.WriteLine($"Status: {message.Status}");
            Console.WriteLine($"Retry Count: {message.RetryCount}");
        }
    }
}