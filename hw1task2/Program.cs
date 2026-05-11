// See https://aka.ms/new-console-template for more information

var age = 0;
bool isNumber;
Console.WriteLine("Enter age");
var msg = Console.ReadLine();
if (isNumber = int.TryParse(msg, out age))
{
    if (age >= 18)
    {
        Console.WriteLine("You are already an adult");

    }
    else
    {
        Console.WriteLine("You are not an adult");
    }
    ;
}
else {
    Console.WriteLine("Error: In is not a number!");
}

