namespace Sada.Presintation.WebAPI.Models
{
    public class ClassPostRequest
    {
        public required int GradeId { get; set; }
        public required string ClassName { get; set; }
    }
    public class ClassPutRequest
    {
        public required int ClassId { get; set; }
        public required int GradeId { get; set; }
        public required string ClassName { get; set; }
    }
}
