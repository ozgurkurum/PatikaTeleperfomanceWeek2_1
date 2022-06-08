using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_OzgurKurum
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute(string name, string type, bool necessity)
        {
            Name = name;
            Type = type;
            Necessity = necessity;
        }

        public string Name { get; }
        public string Type { get; }
        public bool Necessity { get; }

    }
}
