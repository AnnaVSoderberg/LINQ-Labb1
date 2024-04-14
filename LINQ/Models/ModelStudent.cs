using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    internal class ModelStudent
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string StudentName { get; set; }

        public int CourseID { get; set; }
        public ModelCourse Course { get; set; }
    }
}
