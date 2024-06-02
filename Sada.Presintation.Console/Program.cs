using Sada.Core.Domain;
using Sada.Core.Domain.Entities;
namespace Sada.Presintation.ConsoleTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School()
            {
                SchoolId = 1,
                SchoolName = "A School",
                PostalCode = "12345",
                Address = "some address",
                PhoneNumber = "12345",
            };
            Grade g1 = new Grade() 
            { 
                SchoolId = 1,
                GradeId = 1,
                GradeName = "avval",
            };
            Grade g2 = new Grade()
            {
                SchoolId = 1,
                GradeId = 2,
                GradeName = "dovvom",
            };
            List<Grade> grades = new List<Grade>() { g1, g2 };
            school.Grades = grades;
            Lesson l1 = new Lesson() 
            {
                LessonId = 1,
                LessonName = "Math",
                GredeId = 1
            };
            Lesson l2 = new Lesson()
            {
                LessonId = 2,
                LessonName = "Physics",
                GredeId = 1
            };
            List<Lesson> lessons = new List<Lesson>() { l1, l2 };
            g1.Lessons = lessons;
            g2.Lessons = lessons;
            SchoolClass c1 = new SchoolClass()
            {
                ClassId = 1,
                GradeId = 1,
                ClassName = "A Class 1"
            };
            SchoolClass c2 = new SchoolClass()
            {
                ClassId = 2,
                GradeId = 2,
                ClassName = "A Class 2"
            };
            g1.Classes = new List<SchoolClass>() { c1 };
            g2.Classes = new List<SchoolClass>() { c2 };
            Student st1 = new Student()
            {
                StudentId = 1,
                Name = "Mahdi",
                NationalCode = 1364896875,
                BirthDate = new Core.Domain.Models.ShamsiDate(1384, 11, 17),
                ClassId = 1,
                FatherName = "father",
                PhoneNumber = "085042",
                Serial = 1234,
                PostalCode = "1234",
                Address = "addrerss"
            };
            Student st2 = new Student()
            {
                StudentId = 2,
                Name = "Akbar",
                NationalCode = 1364896875,
                BirthDate = new Core.Domain.Models.ShamsiDate(1384, 12, 17),
                ClassId = 2,
                FatherName = "father",
                PhoneNumber = "085042",
                Serial = 1234,
                PostalCode = "1234",
                Address = "addrerss"
            };

            c1.Students = new List<Student>() { st1 };
            c2.Students = new List<Student>() { st2 };
            LessonPoint lp1 = new LessonPoint() 
            {
                LessonId = 1,
                Point = 15,
                LessonPointId = 1
            };
            LessonPoint lp2 = new LessonPoint()
            {
                LessonId = 2,
                Point = 16,
                LessonPointId = 2
            };
            st1.LessonPoints = new List<LessonPoint>() { lp1, lp2 };
            st2.LessonPoints = new List<LessonPoint>() { lp1, lp2 };
        
        }
    }
}
