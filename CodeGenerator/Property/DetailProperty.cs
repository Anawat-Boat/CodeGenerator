using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Property
{
    public class DetailProperty
    {
        public string PROPERTY_NAME { get; set; }
        public bool DATE_TIME_FORMAT { get; set; }
        public bool SELECT { get; set; }
        public bool SELECT_ALL { get; set; }
        public bool WHERE_SELECT { get; set; }
        public bool WHERE_UPDATE { get; set; }
        public bool WHERE_DELETE { get; set; }
        public bool GET_MAX_ID { get; set; }
        public bool INSERT { get; set; }
        public bool UPDATE { get; set; }
    }
}
