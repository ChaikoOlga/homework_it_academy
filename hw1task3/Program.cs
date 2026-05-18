using System.Text.RegularExpressions;

namespace hw1task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            decimal salary;
            var kpi = 0;
            var incomeTax = 13;
            var pensionFund = 1;
            bool isNumber;
            var msg = string.Empty;
            var bonus = 0;
            decimal totalSalary = 0;

            Console.Write("Enter employee name");
            name = Console.ReadLine();

            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Name is not correct!");
            }

            Console.WriteLine("Enter salary");
            msg = Console.ReadLine();

            if (isNumber = decimal.TryParse(msg, out salary))
            {
                Console.WriteLine($"Your salary: {salary}");
            }
            else
            {
                Console.WriteLine("Error: In is not a number!");
            }

            Console.WriteLine("Enter kpi");
            msg = Console.ReadLine();

            if (isNumber = int.TryParse(msg, out kpi))
            {
                Console.WriteLine($"Your kpi: {kpi}");
            }
            else
            {
                Console.WriteLine("Error: In is not a number!");
            }

            if (kpi >= 90)
            {
                bonus = 20;
            }
            else if (kpi >= 75)
            {
                bonus = 10;
            }
            else
            {
                bonus = 0;
            }
            totalSalary = salary + (salary * bonus / 100);

            Console.WriteLine($"Your issued: {(totalSalary) - ((totalSalary) * incomeTax / 100) - ((totalSalary) * pensionFund / 100)}");
        }
    }
}
