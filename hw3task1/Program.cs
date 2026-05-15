using static System.Net.Mime.MediaTypeNames;

namespace hw3task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            var msg = Console.ReadLine();
            string text = msg;
            string vowels = "euoaiEUOAI";

            int count = 0;

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of vovels: {count}");

        }
    }
}
