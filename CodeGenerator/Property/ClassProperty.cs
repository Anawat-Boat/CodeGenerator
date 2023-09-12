using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Property
{
    public class ClassProperty
    {
        public string PROJECT_NAME { get; set; }
        public string CLASS_NAME { get; set; }
        public string TABLE_NAME { get; set; }
        public List<DetailProperty> ListDetailProperty { get; set; }
    }
}
