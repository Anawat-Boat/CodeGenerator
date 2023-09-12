using CodeGenerator.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Controller.CSharp
{
    public class GenCodeClassServices
    {
        public string CodeClassServices(ClassProperty dataItem)
        {
            string result = @"
using BusinessData.Interface;
using BusinessData.Property;
using dataItem.PROJECT_NAMEManagement.SQLFactory;
using dataItem.PROJECT_NAMEManagement.Property;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataItem.PROJECT_NAMEManagement.Services 
{
    public class dataItem.CLASS_NAMEServices : DatabaseAction<dataItem.CLASS_NAMEProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        dataItem.CLASS_NAMESQLFactory sqlFactory = new dataItem.CLASS_NAMESQLFactory();
        private string sql;

        public override OutputOnDbProperty Search(dataItem.CLASS_NAMEProperty dataItem)
        {
            sql = sqlFactory.Search(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Search()
        {
            sql = sqlFactory.Search();
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Insert(dataItem.CLASS_NAMEProperty dataItem)
        {
            sql = sqlFactory.Insert(dataItem);
            resultData = base.InsertBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Update(dataItem.CLASS_NAMEProperty dataItem)
        {
            sql = sqlFactory.Update(dataItem);
            resultData = base.UpdateBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Delete(dataItem.CLASS_NAMEProperty dataItem)
        {
            sql = sqlFactory.Delete(dataItem);
            resultData = base.DeleteBySql(sql);
            return resultData;
        }
    }
}";

            return result;
        }
    }
}
