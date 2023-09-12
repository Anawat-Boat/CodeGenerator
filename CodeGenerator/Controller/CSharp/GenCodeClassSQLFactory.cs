using CodeGenerator.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeGenerator.Controller.CSharp
{
    public class GenCodeClassSQLFactory
    {
        public string CodeClassSQLFactory(ClassProperty dataItem)
        {
            string result = @"
using dataItem.PROJECT_NAMEManagement.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  dataItem.PROJECT_NAMEManagement.SQLFactory
{
    public class dataItem.CLASS_NAMESQLFactory
    {
        private string sql = """";


        public string Search()
        {
            sql  = @""dataItem.DetailGETALL"";
            return sql;
        }
        public string Search(dataItem.CLASS_NAMEProperty dataItem)
        {
            sql = @""dataItem.DetailSEARCH"";

            dataItem.REPLACE.SEARCH
            return sql;
            
        }
        public string Insert(dataItem.CLASS_NAMEProperty dataItem)
        {
            sql = @""dataItem.DetailINSERT"";

            dataItem.REPLACE.INSERT
            return sql;
        }
        public string Update(dataItem.CLASS_NAMEProperty dataItem)
        {
            sql = @""dataItem.DetailUPDATE"";

            dataItem.REPLACE.UPDATE
            return sql;
            
        }
        public string Delete(dataItem.CLASS_NAMEProperty dataItem)
        {
            sql = @""dataItem.DetailDELETE"";

            dataItem.REPLACE.DELETE
            return sql;
        }
    }
}
";
            return result;
        }
        public string ReplaceSQLFactory(List<DetailProperty> dataItem)
        {
            string result = "";
            foreach (DetailProperty item in dataItem)
            {
                string strDataReplace = "";
                if (!item.DATE_TIME_FORMAT)
                {
                    strDataReplace = @"sql = sql.Replace(""dataItem.item.PROPERTY_NAME"", dataItem.item.PROPERTY_NAME);";
                    strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                    result += result == "" ? strDataReplace : Environment.NewLine + "            " + strDataReplace;
                }
            }
            //result = (result == "") ? result : result.Substring(0, result.Count() - 2);
            return result;
        }

        public string DetailGetAllSQLFactory(ClassProperty dataItem)
        {
            string result = @"
                            SELECT
                                dataItem.SELECT
                            FROM `dataItem.TABLE_NAME`";
            return result;
        }
        public string SelectGetAllSQLFactory(List<DetailProperty> dataItem)
        {
            string result = "";

            foreach (DetailProperty item in dataItem)
            {
                string strDataReplace = "";

                if (item.DATE_TIME_FORMAT)
                {
                    strDataReplace = @"DATE_FORMAT(`item.PROPERTY_NAME`, '%d/%m/%Y %H:%I:%i') AS item.PROPERTY_NAME,";
                    strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                    result += result == "" ? strDataReplace : Environment.NewLine + "\t\t" + strDataReplace;
                    continue;
                }
                strDataReplace = @"`item.PROPERTY_NAME`,";
                strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                result += result == "" ? strDataReplace : Environment.NewLine + "\t\t" + strDataReplace;
            }
            result = (result == "") ? result : result.Substring(0, result.Count() - 1);
            return result;
        }

        public string DetailSearchSQLFactory(ClassProperty dataItem)
        {
            string result = @"
                            SELECT 
                                dataItem.SELECT
                            FROM `dataItem.TABLE_NAME`
                            dataItem.WHERE";

            return result;
        }
        public string SelectSearchSQLFactory(List<DetailProperty> dataItem)
        {
            string result = "";
            foreach (DetailProperty item in dataItem)
            {
                string strDataReplace = "";
                if (item.DATE_TIME_FORMAT)
                {
                    strDataReplace = @"DATE_FORMAT(`item.PROPERTY_NAME`, '%d/%m/%Y %H:%I:%i') AS item.PROPERTY_NAME,";
                    strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                    result += result == "" ? strDataReplace : Environment.NewLine + "\t\t" + strDataReplace;
                    continue;
                }
                strDataReplace = @"`item.PROPERTY_NAME`,";
                strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                result += result == "" ? strDataReplace : Environment.NewLine + "\t\t" + strDataReplace;
            }
            result = (result == "" ) ? result : result.Substring(0, result.Count() - 1);
            return result;
        }
        public string WhereSearchSQLFactory(List<DetailProperty> dataItem)
        {
            string result = @"";
            foreach (DetailProperty item in dataItem)
            {
                string strDataReplace = "";
                strDataReplace = @"`item.PROPERTY_NAME` LIKE 'dataItem.item.PROPERTY_NAME%'" + Environment.NewLine + "\t            " + "AND ";
                strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                result += strDataReplace;
                continue;
            }
            result = (result == "") ? result : "WHERE " + result.Substring(0, result.Count() - 6);
            return result;
        }

        public string DetailInsertSQLFactory(ClassProperty dataItem)
        {
            string result = @"
                            INSERT INTO `dataItem.TABLE_NAME`
                            (
                                dataItem.COLUMN_INSERT
                            )
                            VALUES
                            (
                                dataItem.VALUES_INSERT
                            )";
            return result;
        }
        public string ColumnInsertSQLFactory(List<DetailProperty> dataItem)
        {
            string result = "";
            foreach (DetailProperty item in dataItem)
            {
                string strDataReplace = "";
                strDataReplace = @"`item.PROPERTY_NAME`,";
                strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                result += result == "" ? strDataReplace : Environment.NewLine + "\t\t" + strDataReplace;
            }
            result = (result == "" ) ? result : result.Substring(0, result.Count() - 1);
            return result;
        }
        public string ValuesInsertSQLFactory(List<DetailProperty> dataItem)
        {
            string result = "";
            foreach (DetailProperty item in dataItem)
            {
                string strDataReplace = "";
                if (item.GET_MAX_ID)
                {
                    strDataReplace = @"(SELECT IFNULL( MAX(item.PROPERTY_NAME), 0 ) + 1 AS MAX_VAL FROM dataItem.TABLE_NAME MAX_ID),";
                    strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                }
                else if (item.DATE_TIME_FORMAT)
                {
                    strDataReplace = "CURRENT_TIMESTAMP(),";
                }
                else
                {
                    strDataReplace = @"'dataItem.item.PROPERTY_NAME',";
                    strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                }
                result += result == "" ? strDataReplace : Environment.NewLine + "\t\t" + strDataReplace;
            }
            result =  (result == "") ? result : result.Substring(0, result.Count() - 1);
            return result;
        }
        public string DetailUpdateSQLFactory(ClassProperty dataItem)
        {
            string result = @"
                            UPDATE dataItem.TABLE_NAME SET
                                dataItem.COLUMN_UPDATE
                            dataItem.WHERE_UPDATE";

            result = result.Replace("dataItem.COLUMN_UPDATE", ColumnUpdateSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.UPDATE)));
            result = result.Replace("dataItem.WHERE_UPDATE", WhereUpdateSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.WHERE_UPDATE)));
            return result;
        }
        public string ColumnUpdateSQLFactory(List<DetailProperty> dataItem)
        {
            string result = "";
            foreach (DetailProperty item in dataItem)
            {
                string strDataReplace = "";
                if (item.DATE_TIME_FORMAT)
                {
                    strDataReplace = @"`item.PROPERTY_NAME` = CURRENT_TIMESTAMP(),";
                    strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                    result += result == "" ? strDataReplace : Environment.NewLine + "\t\t" + strDataReplace;
                    continue;
                }
                strDataReplace = @"`item.PROPERTY_NAME` = 'dataItem.item.PROPERTY_NAME',";
                strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                result += result == "" ? strDataReplace : Environment.NewLine + "\t\t" + strDataReplace;
            }
            result = (result == "") ? result : result.Substring(0, result.Count() - 1);
            return result;
        }
        public string WhereUpdateSQLFactory(List<DetailProperty> dataItem)
        {
            string result = "";
            foreach (DetailProperty item in dataItem)
            {
                string strDataReplace = "";
                strDataReplace = @"`item.PROPERTY_NAME` = 'dataItem.item.PROPERTY_NAME'" + Environment.NewLine + "\t            " + "AND ";
                strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                result += strDataReplace;
                continue;
            }
            result = (result == "") ? result : "WHERE " + result.Substring(0, result.Count() - 6);
            return result;
        }


        public string DetailDeleteSQLFactory(ClassProperty dataItem)
        {
            string result = @"
                            DELETE FROM dataItem.TABLE_NAME
                            dataItem.WHERE_DELETE";
            return result;
        }
        public string WhereDeleteSQLFactory(List<DetailProperty> dataItem)
        {
            string result = "";
            foreach (DetailProperty item in dataItem)
            {
                string strDataReplace = "";
                strDataReplace = @"`item.PROPERTY_NAME` = 'dataItem.item.PROPERTY_NAME'" + Environment.NewLine + "\t            " + "AND ";
                strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                result += strDataReplace;
                continue;
            }
            result = (result == "") ? result : "WHERE " + result.Substring(0, result.Count() - 6);
            return result;
        }
    }
}