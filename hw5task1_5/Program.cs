namespace hw5task1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            int[] data = { 3, 10, -1, 7 };
            int sum = 0;

            foreach (int number in data)
            {
                sum += number;
            }

            Console.WriteLine("Summ = " + sum);
        }
    }
}
