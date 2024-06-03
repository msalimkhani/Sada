using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sada.Core.Domain.Entities
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        [ForeignKey(nameof(School))]
        public required int SchoolId { get; set; }
        public required string GradeName { get; set; }

        public virtual ICollection<Lesson>? Lessons { get; set; }
        public virtual ICollection<SchoolClass>? Classes { get; set; }
    }
}
