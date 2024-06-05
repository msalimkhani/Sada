
namespace Sada.Presintation.WebAPI.Models
{
    public class SchoolPutRequest
    {
        public int SchoolId { get; set; }
        public required string SchoolName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public required string PostalCode { get; set; }
    }
}
