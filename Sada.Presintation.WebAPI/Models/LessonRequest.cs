using System.ComponentModel.DataAnnotations;

namespace Sada.Presintation.WebAPI.Models
{
    public class LessonPostRequest
    {
        [Required]
        public required string LessonName { get; set; }
    }
    public class LessonPutRequest
    {
        [Required]
        public int LessonId { get; set; }
        [Required]
        public required int GradeId { get; set; }
        [Required]
        public required string LessonName { get; set; }
    }
}
