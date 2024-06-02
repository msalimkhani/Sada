namespace Sada.Core.Domain.Models
{
    public abstract class Person
    {
        public required long NationalCode { get; set; }
        public required int Serial { get; set; }
        public required string Name { get; set; }
        public required string FatherName { get; set; }
        public required ShamsiDate BirthDate { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public required string PostalCode { get; set; }
    }
}
