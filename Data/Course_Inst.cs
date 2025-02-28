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
    internal class Course_Inst
    {
        
        public int Id { get; set; }
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string evaluate { get; set; }
        public virtual Course Course { get; set; } = null!;
        public virtual Instructor Instructor { get; set; } = null!;
    }
}
