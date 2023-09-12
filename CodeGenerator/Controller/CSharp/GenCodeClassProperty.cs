using CodeGenerator.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Controller.CSharp
{
    class GenCodeClassProperty
    {
        public string CodeClassProperty(ClassProperty dataItem)
        {
            string result = @"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataItem.PROJECT_NAMEManagement.Property
{
    public class dataItem.CLASS_NAMEProperty
    {
        dataItem.DetailProperty
    }
}
";
            return result;
        }
        public string DetailClassProperty(List<DetailProperty> dataItem)
        {
            string result = "";
            foreach (DetailProperty item in dataItem)
            {
                string strDataReplace = "";
                strDataReplace = @"public string item.PROPERTY_NAME { get; set; }";
                strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                result += (result == "") ? strDataReplace : Environment.NewLine + "            " + strDataReplace;
            }
            return result;
        }
    }
}
