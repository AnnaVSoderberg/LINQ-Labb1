using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    internal class ModelSubject
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string SubjectName { get; set; }
        public ICollection<ModelTeacher> Teachers { get; set; }
    }
}
