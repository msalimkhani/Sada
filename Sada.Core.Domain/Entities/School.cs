namespace Sada.Core.Domain.Entities
{
    public class School
    {
        public int SchoolId { get; set; }
        public required string SchoolName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public required int PostalCode { get; set; }
        public School(string schoolName, string phoneNumber, string address, int postalCode)
        {
            SchoolName = schoolName;
            PhoneNumber = phoneNumber;
            Address = address;
            PostalCode = postalCode;
        }
        public virtual ICollection<Grade>? Grades { get; set; }
    }
}
