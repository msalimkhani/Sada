using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Entities
{
    public class ClassStudent
    {
        [Key]
        public int CS_ID { get; set; }
        [ForeignKey(nameof(SchoolClass))]
        public int ClassId { get; set; }
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
    }
}
