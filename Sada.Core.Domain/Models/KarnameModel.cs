using Sada.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Models
{
    public class KarnameModel
    {
        public string StName { get; set; }
        public int StId { get; set; }
        public int KarnameId { get; set; }
        public IEnumerable<LessonPoint> Points { get; set; }
        public double AvarageScore { get; set; }
    }
}
