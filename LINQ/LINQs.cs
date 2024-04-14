using LINQ.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQs
    {
        public static void AllTeachersInMath()
        {
            using LinqDbContext db = new LinqDbContext();

            Console.WriteLine("- - - - Lärare som undervisar i Matematik - - - - ");

            var MathTea = db.TblTeachers
                .Where(x => x.Subjects
                .Any (k =>k.SubjectName == "Matte"))
                .ToList();

            foreach (var teacher in MathTea)
            {
                Console.WriteLine(teacher.TeacherName);
            }


          
            Console.WriteLine("\nTryck Enter för att komma tillbaka till menyn");
            Console.ReadKey();
            Console.Clear();
        }



        public static void StudentsAndTeachers()
        {
            using LinqDbContext db = new LinqDbContext();
            Console.WriteLine("- - - - Studenter och deras Lärare - - - -\n");

            var studAndTeacher = db.TblStudents.
                Include(x => x.Course)
                .ThenInclude(y => y.Teachers)
                .Select(x => new
                {
                    StudName = x.StudentName,
                    Teachers = x.Course.Teachers.
                    Select(t => t.TeacherName).Distinct().ToList()
                });

            foreach (var s in studAndTeacher)
            {
                string teachersList = string.Join(",", s.Teachers);
                Console.WriteLine("Student: {0} - Lärare: {1}", s.StudName, teachersList);
            }


            Console.WriteLine();
            Console.WriteLine("Tryck Enter för att komma tillbaka till menyn");
            Console.ReadKey();
            Console.Clear();
        }



        public static void SubjectContainProgrammering1()
        {
            using LinqDbContext db = new LinqDbContext();
            Console.WriteLine("- - - - Innehåller Tabellen Ämne kursen Programmering 1? - - - -");


            bool containMath = db.TblSubjects.Any(x => x.SubjectName.Contains("Programmering 1"));

            if (containMath)
            {
                Console.WriteLine("- - Ämnet Programmering 1 finns med i tabellen - -");
            }
            else
            {
                Console.WriteLine("- - Ämnet Programmering 1 finns inte med i tabellen - - ");
            }

            Console.WriteLine("Kurser: ");
            foreach (var sub in db.TblSubjects)
            {
                Console.WriteLine(sub.SubjectName);
            }

            Console.WriteLine();
            Console.WriteLine("Tryck Enter för att komma tillbaka till menyn");
            Console.ReadKey();
            Console.Clear();
        }

        public static void EditProgramming2ToOOP()
        {
            using LinqDbContext db = new LinqDbContext();
            Console.WriteLine("- - - - Editerar Ämne Programmering 2 till OOP - - - -");

            string change = "Programmering 2";
            string changeTo = "OOP";

            var sub = db.TblSubjects.Where(s => s.SubjectName == change).ToList();

            if (sub.Count > 0)
            {
                sub.ForEach(s =>
                {
                    s.SubjectName = changeTo;
                    Console.WriteLine("{0} har ändrats till {1}", change, changeTo);
                });
            }
            else
            {
                Console.WriteLine("Ändringen misslyckades");
            }

            db.SaveChanges();
            Console.WriteLine("Tryck Enter för att komma tillbaka till menyn");
            Console.ReadKey();
            Console.Clear();
        }

        public static void EditOOPTOProgramming2()
        {
            using LinqDbContext db = new LinqDbContext();
            Console.WriteLine("- - - - Editerar Ämne OOP till Programmering 2 - - - -");

            string change = "OOP";
            string changeTo = "Programmering 2";

            var sub = db.TblSubjects.Where(s => s.SubjectName == change).ToList();

            if (sub.Count > 0)
            {
                sub.ForEach(s =>
                {
                    s.SubjectName = changeTo;
                    Console.WriteLine("{0} har ändrats till {1}", change, changeTo);
                });
            }
            else
            {
                Console.WriteLine("Ändringen misslyckades");
            }

            db.SaveChanges();
            Console.WriteLine("Tryck Enter för att komma tillbaka till menyn");
            Console.ReadKey();
            Console.Clear();
        }



        public static void UpdateStudentRecordFromAnasToReidar()
        {
            using LinqDbContext db = new LinqDbContext();
            Console.WriteLine("- - - - Uppdatera ett Student Record med Läraren Anas till Reidar - - - -");



            Console.WriteLine("Tryck Enter för att komma tillbaka till menyn");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
