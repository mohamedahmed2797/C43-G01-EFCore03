using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore03.Data
{
    [PrimaryKey(nameof(Stud_Id) , nameof(Course_Id))]
    internal class Stud_Course
    {
        [ForeignKey(nameof(Student))]
        public int Stud_Id { get; set; }

        [ForeignKey(nameof(Course))]
        public int Course_Id { get; set; }
        public char Grade { get; set; }
        public virtual Student Student { get; set; } = null!;
        public virtual Course Course { get; set; } 
    }
}
