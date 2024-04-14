using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;

namespace LINQ.Data
{
    internal class LinqDbContext : DbContext
    {
        public DbSet<ModelStudent> TblStudents { get; set; }
        public DbSet<ModelTeacher> TblTeachers { get; set; }
        public DbSet<ModelSubject> TblSubjects { get; set; }
        public DbSet<ModelCourse> TblCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-LNIG6K5;Initial Catalog = LINQ;Integrated security = True; TrustServerCertificate = True");
        }
    }
}
