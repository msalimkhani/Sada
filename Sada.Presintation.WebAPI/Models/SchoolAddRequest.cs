using System.ComponentModel.DataAnnotations;

namespace Sada.Presintation.WebAPI.Models
{
    public class SchoolAddRequest
    {
        [Required]
        public string SchoolName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PostalCode { get; set; }
    }
}
