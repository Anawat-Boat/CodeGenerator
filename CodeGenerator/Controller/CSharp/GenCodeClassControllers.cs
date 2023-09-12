using CodeGenerator.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Controller.CSharp
{
    public class GenCodeClassControllers
    {
        public string CodeClassControllers(ClassProperty dataItem)
        {
            string result = @"
using BusinessData.Property;
using dataItem.PROJECT_NAMEManagement.Models;
using dataItem.PROJECT_NAMEManagement.Property;
using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataItem.PROJECT_NAME.Controllers
{
    public class dataItem.CLASS_NAMEControllers
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        dataItem.CLASS_NAMEModels models = new dataItem.CLASS_NAMEModels();

        public List<dataItem.CLASS_NAMEProperty> GetdataItem.CLASS_NAMEAllToList()
        {
            List<dataItem.CLASS_NAMEProperty> result = new List<dataItem.CLASS_NAMEProperty>();
            try
            {
                resultData = models.Search();
                if (resultData.StatusOnDb == true)
                {
                    if (resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < resultData.ResultOnDb.Rows.Count; i++)
                        {     
                            dataItem.CLASS_NAMEProperty data = new dataItem.CLASS_NAMEProperty
                            {
                                dataItem.DETAIL_GETALL
                            };
                            result.Add(data);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(resultData.MessageOnDb, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return result;
        }
           
        public DataTable GetdataItem.CLASS_NAMEAllToDataTable()
        {
            DataTable result = new DataTable();
            try
            {
                resultData = models.Search();
                if (resultData.StatusOnDb == true)
                {
                    if (resultData.ResultOnDb.Rows.Count > 0)
                    {
                        result = resultData.ResultOnDb;
                    }
                }
                else
                {
                    MessageBox.Show(resultData.MessageOnDb, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return result;
        }

        public List<dataItem.CLASS_NAMEProperty> SearchdataItem.CLASS_NAMEToList (dataItem.CLASS_NAMEProperty dataItem)
        {
            List<dataItem.CLASS_NAMEProperty> result = new List<dataItem.CLASS_NAMEProperty>();
            try
            {
                resultData = models.Search(dataItem);
                if (resultData.StatusOnDb == true)
                {
                    if (resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < resultData.ResultOnDb.Rows.Count; i++)
                        {     
                            dataItem.CLASS_NAMEProperty data = new dataItem.CLASS_NAMEProperty
                            {
                                dataItem.DETAIL_SEARCH
                            };
                            result.Add(data);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(resultData.MessageOnDb, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return result;
        }

        public DataTable SearchdataItem.CLASS_NAMEToDataTable(dataItem.CLASS_NAMEProperty dataItem)
        {
            DataTable result = new DataTable();
            try
            {
                resultData = models.Search(dataItem);
                if (resultData.StatusOnDb == true)
                {
                    if (resultData.ResultOnDb.Rows.Count > 0)
                    {
                        result = resultData.ResultOnDb;
                    }
                }
                else
                {
                    MessageBox.Show(resultData.MessageOnDb, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return result;
        }

        public bool Insert(dataItem.CLASS_NAMEProperty dataItem)
        {
            bool result = false;
            try
            {
                resultData = models.Insert(dataItem);
                if (resultData.StatusOnDb)
                {
                    MessageBox.Show(resultData.MessageOnDb, ""Information"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = resultData.StatusOnDb;
                }
                else
                {
                    MessageBox.Show(resultData.MessageOnDb, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public bool Update(dataItem.CLASS_NAMEProperty dataItem)
        {
            bool result = false;
            try
            {
                resultData = models.Update(dataItem);
                if (resultData.StatusOnDb)
                {
                    MessageBox.Show(resultData.MessageOnDb, ""Information"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = resultData.StatusOnDb;
                }
                else
                {
                    MessageBox.Show(resultData.MessageOnDb, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public bool Delete(dataItem.CLASS_NAMEProperty dataItem)
        {
            bool result = false;
            try
            {
                resultData = models.Delete(dataItem);
                if (resultData.StatusOnDb)
                {
                    MessageBox.Show(resultData.MessageOnDb, ""Information"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = resultData.StatusOnDb;
                }
                else
                {
                    MessageBox.Show(resultData.MessageOnDb, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ""Error"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

    }
}";
            return result;
        }
        public string DetailControllers(List<DetailProperty> dataItem)
        {
            string result = "";
            foreach (DetailProperty item in dataItem)
            {
                string strDataReplace = "";
                strDataReplace = @"item.PROPERTY_NAME = resultData.ResultOnDb.Rows[i][""item.PROPERTY_NAME""].ToString(),";
                strDataReplace = strDataReplace.Replace("item.PROPERTY_NAME", item.PROPERTY_NAME);
                result += result == "" ? strDataReplace : Environment.NewLine + "\t\t" + strDataReplace;
            }
            result = (result == "") ? result : result.Substring(0, result.Count() - 1);
            return result;
        }
    }
}
