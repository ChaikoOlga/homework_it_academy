//task1 +.-.*./.%.0exit
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {


       
        var msg=string.Empty;
        bool isNumber;
        var firstValue=0;
        var secondValue=0;

        //input first
        Console.WriteLine("Enter first number");
        msg = Console.ReadLine();
        if (isNumber = int.TryParse(msg, out firstValue))
        {
            Console.WriteLine($"You enter: {firstValue}");

        } 
        else
        {
         
            Console.WriteLine("Error: In is not a number!");
         
        }



        Console.WriteLine("Enter second number");
        msg = Console.ReadLine();
        isNumber = int.TryParse(msg, out secondValue);
        if (isNumber = int.TryParse(msg, out secondValue))
        {
            Console.WriteLine($"You enter: {secondValue}");
        }
        else
        {
            Console.WriteLine("Error: In is not a number!");
        }
     
       
 

        Console.WriteLine("Enter math operator: +, -, *, /, %");
        string mathOperator = Console.ReadLine();

        //summa
        if (mathOperator == "+")
        {
            
            Console.WriteLine(firstValue + secondValue);
        }
        else if

            (mathOperator == "-")
        {
           
            Console.WriteLine(firstValue - secondValue);
        }
        else if

            (mathOperator == "*")
        {
            
            Console.WriteLine(firstValue * secondValue);
        }
        else if

            (mathOperator == "/")
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
        else if

            (mathOperator == "%")
        {
            
            Console.WriteLine(firstValue % secondValue);
        } 
    }
}