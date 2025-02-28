using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C43_G01_EFCore03.Data

{
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        public int Duration { get; set; }
        [Required]
        [Column("EmpName", TypeName = "varchar(50)")]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Topic Top_Id { get; set; } = null!;
        public virtual ICollection<Stud_Course> Crs_Students{ get; set; } = new HashSet<Stud_Course>();
        public virtual ICollection<Course_Inst> Course_Insts{ get; set; } = new HashSet<Course_Inst>();


    }
}
