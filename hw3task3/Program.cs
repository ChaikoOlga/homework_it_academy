using static System.Net.Mime.MediaTypeNames;

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

                if (string.IsNullOrEmpty(login))
                {
                    Console.WriteLine("Login is empty");
                    break;
                }

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("Password is empty");
                    break;
                }

                if (login.Equals(correctLogin) && password.Equals(correctPassword))
                {
                    Console.WriteLine("Allowed");
                    break;
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
