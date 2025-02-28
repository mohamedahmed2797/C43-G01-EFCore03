
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore03.Data
{
    internal class Topic
    {
        [Required]
        [Column("Topic_Id")]
        public int Id { get; set; }
        [Column("Topic_Name")]
        public string Name { get; set; }
        public virtual ICollection<Course>? courses { get; set; } = new HashSet<Course>();

    }
}
