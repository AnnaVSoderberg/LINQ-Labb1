using LINQ.Models;
using LINQ.Data;
using Microsoft.EntityFrameworkCore;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using LinqDbContext db = new LinqDbContext();

            //var teacher1 = new ModelTeacher { TeacherName = "Anas" };
            //var teacher2 = new ModelTeacher { TeacherName = "Reidar" };
            //var teacher3 = new ModelTeacher { TeacherName = "Hanna" };
            //var teacher4 = new ModelTeacher { TeacherName = "Erik" };
            //var teacher5 = new ModelTeacher { TeacherName = "Tobias" };
            //var teacher6 = new ModelTeacher { TeacherName = "Wilma" };
            //db.TblTeachers.AddRange(teacher1, teacher2, teacher3, teacher4, teacher5, teacher6);

            //var subject1 = new ModelSubject { SubjectName = "OOP", Teachers = new List<ModelTeacher> {teacher1, teacher3} };
            //var subject2 = new ModelSubject { SubjectName = "SQL", Teachers = new List<ModelTeacher> {teacher4, teacher1 } };
            //var subject3 = new ModelSubject { SubjectName = "Matte", Teachers = new List<ModelTeacher> { teacher2, teacher6 } };
            //var subject4 = new ModelSubject { SubjectName = "Programmering 2", Teachers = new List<ModelTeacher> { teacher5, teacher1 } };
            //var subject5 = new ModelSubject { SubjectName = ".NET Teori", Teachers = new List<ModelTeacher> { teacher4, teacher2 } };
            //var subject6 = new ModelSubject { SubjectName = "SQL2", Teachers = new List<ModelTeacher> { teacher5, teacher1, teacher3} };
            //db.TblSubjects.AddRange(subject1, subject2, subject3, subject4, subject5, subject6);

            //var course1 = new ModelCourse
            //{
            //    CourseName = "SUT22",
            //    Teachers = new List<ModelTeacher> { teacher1, teacher4, teacher2 },
            //    Subjects = new List<ModelSubject> { subject1, subject5, subject3 }
            //};

            //var course2 = new ModelCourse
            //{
            //    CourseName = "SUT23",
            //    Teachers = new List<ModelTeacher> { teacher5, teacher3, teacher1 },
            //    Subjects = new List<ModelSubject> { subject3, subject6, subject4 }
            //};
            //db.TblCourses.AddRange(course1, course2);

            //var student1 = new ModelStudent { StudentName = "Johanna Zuur", Course = course1};
            //var student2 = new ModelStudent { StudentName = "Ferat Zymeri", Course = course1};
            //var student3 = new ModelStudent { StudentName = "Ebba Carlsson", Course = course1};
            //var student4 = new ModelStudent { StudentName = "Fredrik Larsson", Course = course2};
            //var student5 = new ModelStudent { StudentName = "Morgan Thorsson", Course = course2};
            //var student6 = new ModelStudent { StudentName = "Klara Johansson", Course = course2};
            //db.TblStudents.AddRange(student1,student2,student3,student4,student5,student6);

            //db.SaveChanges();


            Menu.StartMenu();
        }
    }
}
