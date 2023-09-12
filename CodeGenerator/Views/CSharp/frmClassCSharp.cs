using CodeGenerator.Properties;
using CodeGenerator.Property;
using CodeGenerator.Controller.CSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGenerator.Controller;

namespace CodeGenerator
{
    public partial class frmClassCSharp : Form
    {
        #region TopBar
        private bool drangging = false;
        private Point startPoint = new Point(0, 0);
        private bool maximinze = false;
        private void pnlTaskbar_MouseDown(object sender, MouseEventArgs e)
        {
            drangging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pnlTaskbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drangging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void pnlTaskbar_MouseUp(object sender, MouseEventArgs e)
        {
            drangging = false;
        }

        private void TabBarMouseLeave(object sender, EventArgs e)
        {
            this.picClose.Image = Resources.picCloseLeave;
            this.picMaximize.Image = Resources.picMaximizeLeave;
            //this.picMinimizer.Image = Resources.picMinimizeLeave;
        }
        private void TabBarMouseEnter(object sender, EventArgs e)
        {
            this.picClose.Image = Resources.picCloseEnter;
            this.picMaximize.Image = Resources.picMaximizeEnter;
            //this.picMinimizer.Image = Resources.picMinimizeEnter;

        }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picMaximize_Click(object sender, EventArgs e)
        {
            if (maximinze)
            {
                WindowState = FormWindowState.Normal;
                maximinze = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                maximinze = true;
            }
        }
        private void picMinimizer_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void pnlTaskbar_DoubleClick(object sender, MouseEventArgs e)
        {
            if (maximinze)
            {
                WindowState = FormWindowState.Normal;
                maximinze = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                maximinze = true;
            }
        }
        #endregion
        ClassProperty detailClassProperty;

        GenCodeClassControllers genCodeClassControllers = new GenCodeClassControllers();
        GenCodeClassModels genCodeClassModels = new GenCodeClassModels();
        GenCodeClassServices genCodeClassServices = new GenCodeClassServices();
        GenCodeClassSQLFactory genCodeClassSQLFactory = new GenCodeClassSQLFactory();
        GenCodeClassProperty genCodeClassProperty = new GenCodeClassProperty();
        MVCSProperty mvcs;
        List<string> listClass; 
        public frmClassCSharp(ClassProperty obj)
        {
            InitializeComponent();
            detailClassProperty = obj;
        }
        
        private void frmClassCSharp_Load(object sender, EventArgs e)
        {
            ClassProperty propertyDetail = detailClassProperty;
            mvcs = new MVCSProperty
            {
                CONTROLLERS = GenClassControllers(propertyDetail),
                MODELS = GenClassModels(propertyDetail),
                SERIVCES = GenClasServices(propertyDetail),
                SQLFACTORY = GenClasSQLFactory(propertyDetail),
                PROPERTY = GenClassProperty(propertyDetail),
            };

            listClass = new List<string>
            {
                mvcs.CONTROLLERS,
                mvcs.MODELS,
                mvcs.SERIVCES,
                mvcs.SQLFACTORY,
                mvcs.PROPERTY
            };
        }

        private string GenClassControllers(ClassProperty dataItem)
        {
            string classControllers = "";
            try
            {
                classControllers = genCodeClassControllers.CodeClassControllers(dataItem);
                string detailSelectAll = genCodeClassControllers.DetailControllers(dataItem.ListDetailProperty.FindAll(x => x.SELECT_ALL));
                string detailSelect = genCodeClassControllers.DetailControllers(dataItem.ListDetailProperty.FindAll(x => x.SELECT));

                classControllers = classControllers.Replace("dataItem.DETAIL_GETALL", detailSelectAll);
                classControllers = classControllers.Replace("dataItem.DETAIL_SEARCH", detailSelect);
                classControllers = classControllers.Replace("dataItem.PROJECT_NAME", dataItem.PROJECT_NAME);
                classControllers = classControllers.Replace("dataItem.CLASS_NAME", dataItem.CLASS_NAME);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error function 'GenCodeClassControllers'" + Environment.NewLine +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                classControllers = "";
            }
            return classControllers;
        }
        private string GenClassModels(ClassProperty dataItem)
        {
            string classModels = "";
            try
            {
                classModels = genCodeClassModels.CodeClassModels(dataItem);
                classModels = classModels.Replace("dataItem.PROJECT_NAME", dataItem.PROJECT_NAME);
                classModels = classModels.Replace("dataItem.CLASS_NAME", dataItem.CLASS_NAME);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error function 'GenCodeClassModels'" + Environment.NewLine +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                classModels = "";
            }
            return classModels;
        }
        private string GenClasServices(ClassProperty dataItem)
        {
            string classServices = "";
            try
            {
                classServices = genCodeClassServices.CodeClassServices(dataItem);

                classServices = classServices.Replace("dataItem.PROJECT_NAME", dataItem.PROJECT_NAME);
                classServices = classServices.Replace("dataItem.CLASS_NAME", dataItem.CLASS_NAME);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error function 'GenCodeClassServicess'" + Environment.NewLine +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                classServices = "";
            }
            return classServices;
        }
        private string GenClasSQLFactory(ClassProperty dataItem)
        {
            string classSQLFactory = "";
            try
            {
                classSQLFactory = genCodeClassSQLFactory.CodeClassSQLFactory(dataItem);

                string detailGetAll = genCodeClassSQLFactory.DetailGetAllSQLFactory(dataItem);
                string selectGetAll = genCodeClassSQLFactory.SelectGetAllSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.SELECT_ALL));
                detailGetAll = detailGetAll.Replace("dataItem.SELECT", selectGetAll);

                string detailSearch = genCodeClassSQLFactory.DetailSearchSQLFactory(dataItem);
                string selectSearch = genCodeClassSQLFactory.SelectSearchSQLFactory(dataItem.ListDetailProperty); 
                string whereSearch = genCodeClassSQLFactory.WhereSearchSQLFactory((dataItem.ListDetailProperty.FindAll(x => x.WHERE_SELECT)));
                detailSearch = detailSearch.Replace("dataItem.SELECT", selectSearch);
                detailSearch = detailSearch.Replace("dataItem.WHERE", whereSearch);

                string detailInsert = genCodeClassSQLFactory.DetailInsertSQLFactory(dataItem);
                string columnInsert = genCodeClassSQLFactory.ColumnInsertSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.INSERT));
                string columnValue = genCodeClassSQLFactory.ValuesInsertSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.INSERT));
                detailInsert = detailInsert.Replace("dataItem.COLUMN_INSERT", columnInsert);
                detailInsert = detailInsert.Replace("dataItem.VALUES_INSERT", columnValue);

                string detailUpdate = genCodeClassSQLFactory.DetailUpdateSQLFactory(dataItem);
                string columnUpdate = genCodeClassSQLFactory.ColumnUpdateSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.UPDATE));
                string WhereUpdate = genCodeClassSQLFactory.WhereUpdateSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.WHERE_UPDATE));
                detailUpdate = detailUpdate.Replace("dataItem.COLUMN_UPDATE", columnUpdate);
                detailUpdate = detailUpdate.Replace("dataItem.WHERE_UPDATE", WhereUpdate);

                string detailDelete = genCodeClassSQLFactory.DetailDeleteSQLFactory(dataItem);
                string whereDelete = genCodeClassSQLFactory.WhereDeleteSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.WHERE_DELETE));
                detailDelete = detailDelete.Replace("dataItem.WHERE_DELETE", whereDelete);

                classSQLFactory = classSQLFactory.Replace("dataItem.DetailGETALL", detailGetAll);
                classSQLFactory = classSQLFactory.Replace("dataItem.DetailSEARCH", detailSearch);
                classSQLFactory = classSQLFactory.Replace("dataItem.DetailINSERT", detailInsert);
                classSQLFactory = classSQLFactory.Replace("dataItem.DetailUPDATE", detailUpdate);
                classSQLFactory = classSQLFactory.Replace("dataItem.DetailDELETE", detailDelete);

                classSQLFactory = classSQLFactory.Replace("dataItem.REPLACE.SEARCH", genCodeClassSQLFactory.ReplaceSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.WHERE_SELECT)));
                classSQLFactory = classSQLFactory.Replace("dataItem.REPLACE.INSERT", genCodeClassSQLFactory.ReplaceSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.INSERT && !x.GET_MAX_ID)));
                classSQLFactory = classSQLFactory.Replace("dataItem.REPLACE.UPDATE", genCodeClassSQLFactory.ReplaceSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.WHERE_UPDATE || x.UPDATE)));
                classSQLFactory = classSQLFactory.Replace("dataItem.REPLACE.DELETE", genCodeClassSQLFactory.ReplaceSQLFactory(dataItem.ListDetailProperty.FindAll(x => x.WHERE_DELETE)));


                classSQLFactory = classSQLFactory.Replace("dataItem.TABLE_NAME", dataItem.TABLE_NAME);
                classSQLFactory = classSQLFactory.Replace("dataItem.PROJECT_NAME", detailClassProperty.PROJECT_NAME);
                classSQLFactory = classSQLFactory.Replace("dataItem.CLASS_NAME", detailClassProperty.CLASS_NAME);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error function 'GenCodeClassSQLFactory'" + Environment.NewLine +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                classSQLFactory = "";
            }
            return classSQLFactory;
        }
        private string GenClassProperty(ClassProperty dataItem)
        {
            string classProperty = "";
            try
            {
                classProperty = genCodeClassProperty.CodeClassProperty(dataItem);
                string detailProperty = genCodeClassProperty.DetailClassProperty(dataItem.ListDetailProperty);
                classProperty = classProperty.Replace("dataItem.DetailProperty", detailProperty);
                classProperty = classProperty.Replace("dataItem.PROJECT_NAME", dataItem.PROJECT_NAME);
                classProperty = classProperty.Replace("dataItem.CLASS_NAME", dataItem.CLASS_NAME);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error function 'GenCodeClassProperty'" + Environment.NewLine +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                classProperty = "";
            }
            return classProperty; 
        }
        private void btnControllers_Click(object sender, EventArgs e)
        {
            this.ShowClassDetail(mvcs.CONTROLLERS);
        }
        private void btnModels_Click(object sender, EventArgs e)
        {
            this.ShowClassDetail(mvcs.MODELS);
        }
        private void btnServices_Click(object sender, EventArgs e)
        {
            this.ShowClassDetail(mvcs.SERIVCES);
        }
        private void btnSQLFactory_Click(object sender, EventArgs e)
        {
            this.ShowClassDetail(mvcs.SQLFACTORY);
        }
        private void btnProperty_Click(object sender, EventArgs e)
        {
            this.ShowClassDetail(mvcs.PROPERTY);
        }
        private void ShowClassDetail(string classDetail)
        {
            this.txtDetailClass.Text = classDetail;
        }
        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            ViewsController controller = new ViewsController();
            List<string> listPathFileClass = new List<string>();

            listPathFileClass = controller.GetPathClassMVCS(pageCSharp1.listPathFolderMVCS, detailClassProperty);
            if (controller.CheckFileExist(listPathFileClass))
            {
                if (controller.CreateFileMVCS(listPathFileClass, listClass))
                {
                    MessageBox.Show("Create class already finish.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        
    }
}
