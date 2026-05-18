//task1 +.-.*./.%.0exit


class Program
{
    static void Main()
    {
        string msg = string.Empty;
        var firstValue = 0;
        var secondValue = 0;

        //input first
        Console.WriteLine("Enter first number");
        msg = Console.ReadLine();

        if (int.TryParse(msg, out firstValue))
        {
            Console.WriteLine($"You enter: {firstValue}");
        }
        else
        {
            Console.WriteLine("Error: In is not a number!");
        }

        Console.WriteLine("Enter second number");
        msg = Console.ReadLine();

        if (int.TryParse(msg, out secondValue))
        {
            Console.WriteLine($"You enter: {secondValue}");
        }
        else
        {
            Console.WriteLine("Error: In is not a number!");
        }

        Console.WriteLine("Enter math operator: +, -, *, /, %");
        string mathOperator = Console.ReadLine();

        if (mathOperator == "+")
        {
            Console.WriteLine(firstValue + secondValue);
        }
        else if (mathOperator == "-")
        {
            Console.WriteLine(firstValue - secondValue);
        }
        else if (mathOperator == "*")
        {
            Console.WriteLine(firstValue * secondValue);
        }
        else if (mathOperator == "/")
        {
            if (secondValue == 0)
            {
                Console.WriteLine("Error: Devision by zero!");
            }
            else
            {
                Console.WriteLine((double)firstValue / secondValue);
            }
        }
        else if (mathOperator == "%")
        {
            if (secondValue == 0)
            {
                Console.WriteLine("Error: Devision by zero!");
            }
            else
            {
                Console.WriteLine(firstValue % secondValue);
            }
        }
    }
}