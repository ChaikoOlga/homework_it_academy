
using System;
using System.Collections.Generic;
using System.Text;

namespace hw5task4
{
    internal class Program
    {
        static void Main()
        {
            List<string> lines = new List<string>()
        {
            "One", "Two", "Three", "Four", "Five",
            "Six", "Seven", "Eight", "Nine", "Ten",
            "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
            "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty"
        };

            StringBuilder sb = new StringBuilder();

            foreach (string line in lines)
            {
                sb.Append(line);
            }

            string text = sb.ToString();

            Console.WriteLine(text.Length);
        }
    }
}
