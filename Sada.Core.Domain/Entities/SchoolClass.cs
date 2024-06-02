using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Entities
{
    public class SchoolClass
    {
        public int ClassId { get; set; }
        public required int GradeId { get; set; }
        public required string ClassName { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
    }
}
