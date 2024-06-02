using Sada.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Entities
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public int? ClassId { get; set; }

        public virtual ICollection<LessonPoint>? LessonPoints { get; set; }
    }
}
