namespace hw3task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctLogin = "admin";
            string correctPassword = "12345";

            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Enter login: ");
                string login = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (login == correctLogin && password == correctPassword)
                {
                    Console.WriteLine("Allowed");
                    return;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Incorrect login or password. Attempts left: {attempts}");
                }
            }

            Console.WriteLine("Denied");
        }
    }
}
