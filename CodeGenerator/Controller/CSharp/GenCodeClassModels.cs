using CodeGenerator.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Controller.CSharp
{
    public class GenCodeClassModels
    {
        public string CodeClassModels(ClassProperty dataItem)
        {
            string result = @"
using BusinessData.Property;
using dataItem.PROJECT_NAMEManagement.Services;
using dataItem.PROJECT_NAMEManagement.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataItem.PROJECT_NAMEManagement.Models
{
    public class dataItem.CLASS_NAMEModels
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        dataItem.CLASS_NAMEServices services = new dataItem.CLASS_NAMEServices();

        public OutputOnDbProperty Search()
        {
            resultData = services.Search();
            return resultData;
        }

        public OutputOnDbProperty Search(dataItem.CLASS_NAMEProperty dataItem)
        {
            resultData = services.Search(dataItem);
            return resultData;
        }

        public OutputOnDbProperty Insert(dataItem.CLASS_NAMEProperty dataItem)
        {
            resultData = services.Insert(dataItem);
            return resultData;
        }

        public OutputOnDbProperty Update(dataItem.CLASS_NAMEProperty dataItem)
        {
            resultData = services.Update(dataItem);
            return resultData;
        }

        public OutputOnDbProperty Delete(dataItem.CLASS_NAMEProperty dataItem)
        {
            resultData = services.Delete(dataItem);
            return resultData;
        }
    }
}";
            return result;
        }
    }
}
