using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace C43_G01_EFCore03.Data
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Ins_Id { get; set; }
        public DateOnly HiringDate { get; set; }
        public virtual ICollection<Student>? Students { get; set; } = new HashSet<Student>();
        public virtual ICollection<Instructor>? Instructors { get; set; } = new HashSet<Instructor>();

    }
}
