namespace Sada.Core.Domain.Entities
{
    public class Grade
    {
        public int GradeId { get; set; }
        public required int SchoolId { get; set; }
        public required string GradeName { get; set; }

        public virtual ICollection<Lesson>? Lessons { get; set; }
        public virtual ICollection<SchoolClass>? Classes { get; set; }
    }
}
