using System;
using System.Collections.Generic;

namespace hw7task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Report> reports = new List<Report>();

            reports.Add(new Report
            {
                Name = "Sales",
                Date = new DateTime(2026, 7, 10)
            });

            reports.Add(new Report
            {
                Name = "Finance",
                Date = new DateTime(2026, 7, 11)
            });

            reports.Add(new Report
            {
                Name = "Audit",
                Date = new DateTime(2026, 7, 10)
            });

            reports.Sort();

            foreach (Report report in reports)
            {
                Console.WriteLine(report.Date + " - " + report.Name);
            }
        }
    }
}
