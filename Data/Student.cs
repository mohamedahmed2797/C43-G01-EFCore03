using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace C43_G01_EFCore03.Data
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public virtual Department? Dept_Id { get; set; } = null!;

        public virtual ICollection<Stud_Course>? Stud_Courses { get; set; } = new HashSet<Stud_Course>();

    }
}
