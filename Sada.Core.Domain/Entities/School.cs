namespace Sada.Core.Domain.Entities
{
    public class School
    {
        public int SchoolId { get; set; }
        public required string SchoolName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public required string PostalCode { get; set; }
        public virtual ICollection<Grade>? Grades { get; set; }
    }
}
