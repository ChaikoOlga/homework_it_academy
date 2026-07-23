namespace hw5task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] grades = { 45, 78, 90, 55, 60, 32 };

            if (grades.Length == 0)
            {
                Console.WriteLine("no data");
            }
            else
            {
                foreach (int grade in grades)
                {
                    if (grade >= 60)
                    {
                        Console.WriteLine(grade);
                    }
                }
            }

            Console.WriteLine();



            int[] emptyGrades = { };

            if (emptyGrades.Length == 0)
            {
                Console.WriteLine("no data");
            }
            else
            {
                foreach (int grade in emptyGrades)
                {
                    if (grade >= 60)
                    {
                        Console.WriteLine(grade);
                    }
                }
            }
        }
    }
}


