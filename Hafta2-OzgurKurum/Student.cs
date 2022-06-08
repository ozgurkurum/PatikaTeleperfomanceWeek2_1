using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_OzgurKurum
{
    [Table("name")]
    public class Student
    {
        [Column("name", "type", true)]
        public int Id { get; set; }
        [Column("name", "type", true)]
        public string Name { get; set; }

    }
}
