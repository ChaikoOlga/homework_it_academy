namespace hw3task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            string msg = Console.ReadLine();

            if (int.TryParse(msg, out int score))
            {
                string grade = score switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F"
                };

                Console.WriteLine(grade);
            }
            else
            {
                Console.WriteLine("Error: You enter an incorrect number!");
            }
            ;
        }
    }
}

