using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Entities
{
    public class LessonPoint
    {
        public int LessonPointId { get; set; }
        public required int LessonId { get; set; }
        public required int Point { get; set; }
        public LessonPoint(int point, int lessonId) 
        {
            Point = point;
            LessonId = lessonId;
        }
    }
}
