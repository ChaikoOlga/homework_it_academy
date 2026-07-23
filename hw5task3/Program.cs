namespace hw5task3
{
    internal class Program
    {
        static bool TryDivide(double a, double b, out double result)
        {
            if (b == 0)
            {
                result = 0;
                return false;
            }

            result = a / b;
            return true;
        }

        static void Main()
        {
            double result;

            if (TryDivide(10, 2, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Division by zero is impossible");
            }
        }
    }
}
