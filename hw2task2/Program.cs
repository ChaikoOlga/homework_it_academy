namespace hw2task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayHours = 0;
            int nightHours = 0;
            decimal dayRate = 0;
            decimal nightRate = 0;
            int totalHours = 0;
            decimal salary = 0;
            bool weekendShift = false;
            int baseHours = 160;
            int extraHours = 0;
            var tax = 10;

            Console.Write("Enter dayRate: ");
            var msgDayRate = Console.ReadLine();
            decimal.TryParse(msgDayRate, out dayRate);

            Console.Write("Enter dayHours: ");
            var msgDay = Console.ReadLine();
            int.TryParse(msgDay, out dayHours);

            Console.Write("Enter nightRate: ");
            var msgNightRate = Console.ReadLine();
            decimal.TryParse(msgNightRate, out nightRate);

            Console.Write("Enter nightHours: ");
            var msgNight = Console.ReadLine();
            int.TryParse(msgNight, out nightHours);

            Console.Write("Are you work on weekend? (y/n): ");
            string msg = Console.ReadLine();
            weekendShift = msg == "y";

            totalHours = dayHours + nightHours;
            extraHours = totalHours - baseHours;
            salary = (dayHours * dayRate) + (nightHours * nightRate);

            if (weekendShift)
            {
                salary = salary + (salary / 2);
            }

            if (totalHours >= baseHours)
            {
                salary = (dayHours * dayRate) + (nightHours * nightRate) + (extraHours * (dayRate * 1.5m));
            }

            Console.WriteLine($"Your GROSS: {salary}");
            Console.WriteLine($"Your NET: {salary - (salary * tax / 100)}");

        }
    }
}
