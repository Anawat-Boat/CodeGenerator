using CodeGenerator.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CodeGenerator.Controller
{
    class ViewsController
    {
        string[] arrayFileNameMVC = { "Controller.cs", "Models.cs", "Services.cs", "SQLFactory.cs", "Property.cs" };
        public bool CheckPathProject(ProjectProperty dataItme)
        {
            bool result = true;
            try
            {
                string pathProjectMain = Path.Combine(dataItme.PATH_PROJECT, dataItme.PROJECT_NAME);
                string pathProjectManagement = Path.Combine(dataItme.PATH_PROJECT, dataItme.PROJECT_NAME + "Management");
                if (!Directory.Exists(dataItme.PATH_PROJECT))
                {
                    result = false;
                    MessageBox.Show("Not found path :" + dataItme.PATH_PROJECT + 
                        Environment.NewLine + Environment.NewLine + "Please check path project.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if(!Directory.Exists(pathProjectMain))
                {
                    result = false;
                    MessageBox.Show("Not found project name : " + dataItme.PROJECT_NAME + "." + 
                        Environment.NewLine + Environment.NewLine + "In path >>> " + pathProjectMain + 
                        Environment.NewLine + Environment.NewLine + "Please check path project or create project.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (!Directory.Exists(pathProjectManagement))
                {
                    result = false;
                    MessageBox.Show("Not found project name : " + dataItme.PROJECT_NAME + "Management." +
                        Environment.NewLine + Environment.NewLine + "In path >>> " + pathProjectManagement +
                        Environment.NewLine + Environment.NewLine + "Please check path project or create project.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }
        public List<string> GetPathFolderMVC(ProjectProperty dataItme)
        {
            List<string> result = new List<string>();
            try
            {
                result.Add(Path.Combine(dataItme.PATH_PROJECT, dataItme.PROJECT_NAME, "Controllers"));
                result.Add(Path.Combine(dataItme.PATH_PROJECT, dataItme.PROJECT_NAME + "Management", "Models"));
                result.Add(Path.Combine(dataItme.PATH_PROJECT, dataItme.PROJECT_NAME + "Management", "Services"));
                result.Add(Path.Combine(dataItme.PATH_PROJECT, dataItme.PROJECT_NAME + "Management", "SQLFactory"));
                result.Add(Path.Combine(dataItme.PATH_PROJECT, dataItme.PROJECT_NAME + "Management", "Property"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public bool CreateFolderMVC(List<string> pathFolderMVCS)
        {
            bool result = false;
            try
            {
                foreach (string path in pathFolderMVCS)
                {
                    if (!File.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public List<string> GetPathClassMVCS(List<string> pathFolderMVCS, ClassProperty dataItem)
        {
            List<string> result = new List<string>();
            try
            {
                pathFolderMVCS.ForEach(x => result.Add(x));
                for (int i = 0; i < result.Count; i++)
                {
                    result[i] = Path.Combine(result[i], dataItem.CLASS_NAME + arrayFileNameMVC[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public bool CheckFileExist(List<string> pathFileMVCS)
        {
            bool result = true;
            try
            {
                foreach (string path in pathFileMVCS)
                {
                    if (File.Exists(path))
                    {
                        MessageBox.Show("File => " + Path.GetFileName(path) + " Exist" ,"Stop",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        result = false;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public bool CreateFileMVCS(List<string> listPathFileClassMVCS , List<string> listDetailClass)
        {
            bool result = false;
            try
            {
                for (int i = 0; i < listPathFileClassMVCS.Count; i++)
                {
                    string pathFile = listPathFileClassMVCS[i];
                    string detailClass = listDetailClass[i];
                    using (StreamWriter file = new StreamWriter(pathFile))
                    {
                       file.WriteLine(detailClass);
                    }
                    //StreamWriter file = new StreamWriter(pathFileClassMVCS[i]);
                    //file.WriteLine(detailClass[i]);
                }
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
