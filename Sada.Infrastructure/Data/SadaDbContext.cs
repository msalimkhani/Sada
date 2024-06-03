using Microsoft.EntityFrameworkCore;
using Sada.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Infrastructure.Data
{
    public class SadaDbContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonPoint> LessonPoints { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public SadaDbContext(DbContextOptions<SadaDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
