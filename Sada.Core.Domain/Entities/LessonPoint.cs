using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Entities
{
    public class LessonPoint
    {
        [Key]
        public int LessonPointId { get; set; }
        [ForeignKey(nameof(Lesson))]
        public required int LessonId { get; set; }
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public required int Point { get; set; }
    }
}
