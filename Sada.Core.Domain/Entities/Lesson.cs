using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Entities
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        [ForeignKey(nameof(Grade))]
        public required int GradeId { get; set; }
        public required string LessonName { get; set;}
    }
}
