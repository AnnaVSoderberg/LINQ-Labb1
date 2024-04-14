using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    internal class ModelCourse
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string CourseName { get; set; }

        public ICollection<ModelStudent> Students { get; set; }
        public ICollection<ModelSubject> Subjects { get; set; }
        public ICollection<ModelTeacher> Teachers { get; set; }
    }
}
