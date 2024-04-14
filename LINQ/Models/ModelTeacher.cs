using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    internal class ModelTeacher
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        public string TeacherName { get; set; }
        public ICollection<ModelSubject> Subjects { get; set; }
        public ICollection<ModelCourse> Courses { get; set; }
    }
}
