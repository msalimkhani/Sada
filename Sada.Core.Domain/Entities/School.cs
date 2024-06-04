using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sada.Core.Domain.Entities
{
    public class School
    {
        [Key]
        public int SchoolId { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public required string SchoolName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public required string PostalCode { get; set; }
        public virtual ICollection<Grade>? Grades { get; set; }
    }
}
