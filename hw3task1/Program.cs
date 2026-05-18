

namespace hw3task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            string vowels = "euoaiEUOAI";

            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("text is missing");
                return;
            }

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
