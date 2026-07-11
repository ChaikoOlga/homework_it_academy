using System;
using System.Collections.Generic;
using System.Text;

namespace hw7task1
{
    public class Report : IComparable<Report>
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public int CompareTo(Report other)
        {

            int dateCompare = other.Date.CompareTo(this.Date);

            if (dateCompare != 0)
            {
                return dateCompare;
            }

            return this.Name.CompareTo(other.Name);
        }
    }
}
