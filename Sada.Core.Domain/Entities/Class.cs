using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Entities
{
    public class Class
    {
        public int ClassId { get; set; }
        public required int GradeId { get; set; }
        public required string ClassName { get; set; }
        public Class(int gradeId, string className)
        {
            GradeId = gradeId;
            ClassName = className;
        }
    }
}
