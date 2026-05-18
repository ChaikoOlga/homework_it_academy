// See https://aka.ms/new-console-template for more information

bool isNumber;
Console.WriteLine("Enter age");
var msg = Console.ReadLine();

if (int.TryParse(msg, out int age))
{
    if (age >= 18)
    {
        Console.WriteLine("You are already an adult");
    }
    else
    {
        Console.WriteLine("You are not an adult");
    }
}
else
{
    Console.WriteLine("Error: In is not a number!");
}

