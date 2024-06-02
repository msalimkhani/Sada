using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Entities
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public required string LessonName { get; set;}
        public int? LessonPointId { get; set; }

        public Lesson(string lessonName)
        {
            LessonName = lessonName;
        }
        public virtual LessonPoint? Point { get; set; }
    }
}
