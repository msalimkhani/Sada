using Sada.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Entities
{
    public class Student : Person
    {
        [Key]
        public int StudentId { get; set; }
        [ForeignKey(nameof(SchoolClass))]
        public int? ClassId { get; set; }

        public virtual ICollection<LessonPoint>? LessonPoints { get; set; }
    }
}
