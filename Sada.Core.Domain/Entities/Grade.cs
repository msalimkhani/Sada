namespace Sada.Core.Domain.Entities
{
    public class Grade
    {
        public int GradeId { get; set; }
        public required int SchoolId { get; set; }
        public required string GradeName { get; set; }

        public Grade(string gradeName, int schoolId)
        {
            GradeName = gradeName;
            SchoolId = schoolId;
        }
        public virtual ICollection<Lesson>? Lessons { get; set; }
        public virtual ICollection<Class>? Classes { get; set; }
    }
}
