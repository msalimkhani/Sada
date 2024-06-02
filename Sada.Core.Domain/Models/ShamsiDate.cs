namespace Sada.Core.Domain.Models
{
    public class ShamsiDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
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
