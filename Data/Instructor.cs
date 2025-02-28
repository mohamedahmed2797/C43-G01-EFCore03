using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore03.Data
{
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        public virtual Department Dept_Id { get; set; } = null!;
        public virtual ICollection<Course_Inst> Instructor_Crs { get; set; } = new HashSet<Course_Inst>();



    }
}
