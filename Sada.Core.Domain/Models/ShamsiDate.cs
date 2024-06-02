using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Models
{
    public class ShamsiDate
    {
        public required int Year { get; set; }
        public required int Month { get; set; }
        public required int Day { get; set; }
        public string ToString(string format)
        {
            return string.Format(format, Year, Month, Day);
        }
        public ShamsiDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
    }
}
