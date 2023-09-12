using CodeGenerator.UIDesign;
using CodeGenerator.Property;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace CodeGenerator
{
    public partial class pageCSharp2 : UserControl
    {
        public static ProjectProperty project = pageCSharp1.project;
        public static List<string> listPathFolderMVCS = pageCSharp1.listPathFolderMVCS;
        public pageCSharp2()
        {
            InitializeComponent();
        }

        private void pageCShrap2_Load(object sender, EventArgs e)
        {
            this.lblProjectName.Text = pageCSharp1.project.PROJECT_NAME;
            this.txtClassName.Text = "";
            this.txtTableName.Text = "";
            this.rtxColumnName.Text = "";
            this.SetVisibleColumn(false);
        }
        private void SetVisibleColumn(bool status)
        {
            this.picDatetime.Visible = status;
            this.picSelect.Visible = status;
            this.picSelectAll.Visible = status;
            this.picGetMaxID.Visible = status;
            this.picInsert.Visible = status;
            this.picUpdate.Visible = status;
            this.picWhereSelect.Visible = status;
            this.picWhereDelete.Visible = status;
            this.picWhereUpdate.Visible = status;
        }
        public bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name == formType.Name)
                {
                    form.BringToFront();
                    return true;
                }
            }
            return false;
        }

        private void picQuery_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(frmShowQuery)))
            {
                frmShowQuery frmQuery = new frmShowQuery(this.txtTableName.Text.Trim());
                frmQuery.Show();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (rtxColumnName.Text.Trim() == "")
            { 
                MessageBox.Show("Not found columns name" + Environment.NewLine + "Please check columns name","Stop",MessageBoxButtons.OK,MessageBoxIcon.Stop); 
                this.flpDetailProperty.Controls.Clear();
                SetVisibleColumn(false);
                return; 
            }

            SetVisibleColumn(true) ;
            List<string> listColumnName = new List<string>();
            foreach (string columnName in rtxColumnName.Lines)
            {
                if (columnName.Trim() == "") {continue;}
                //Check Dupiclate
                if (!listColumnName.Contains(columnName))
                {
                    listColumnName.Add(columnName.Trim());
                }
            }
            this.GenPropertyDetail(listColumnName);
        }
        private void GenPropertyDetail(List<string> listColumnName)
        {
            this.flpDetailProperty.Controls.Clear();
            int i = 0;
            foreach (string columnName in listColumnName)
            {
                UISelectProperty ui = new UISelectProperty
                {
                    PropertyName = columnName,
                    BackColor = ((i % 2) == 0) ? Color.WhiteSmoke : Color.White,
                    CheckDateTime = (columnName.ToUpper().Contains("DATE")) ? true: false,
                    CheckInsert = (columnName == "CREATE_USER" || columnName == "CREATE_DATE") ? true : false,
                    CheckUpdate = (columnName == "LAST_USER" || columnName == "LAST_DATE") ? true : false
                };
                this.flpDetailProperty.Controls.Add(ui);
                i++;
            }
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            if (this.txtClassName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter value 'Class name'." ,"Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtTableName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter value 'Table name'.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            ClassProperty classProperty = new ClassProperty
            {
                PROJECT_NAME = project.PROJECT_NAME,
                CLASS_NAME = this.txtClassName.Text.Trim(),
                TABLE_NAME = this.txtTableName.Text.Trim(),
                ListDetailProperty = new List<DetailProperty>()
            };
            foreach (UISelectProperty item in this.flpDetailProperty.Controls)
            {
                DetailProperty data = new DetailProperty
                {
                    PROPERTY_NAME = item.PropertyName,
                    DATE_TIME_FORMAT = item.CheckDateTime,
                    SELECT = item.CheckSelect,
                    SELECT_ALL = item.CheckSelectAll,
                    GET_MAX_ID = item.CheckGetMaxID,
                    INSERT = item.CheckInsert,
                    UPDATE = item.CheckUpdate,
                    WHERE_SELECT = item.CheckWhereSelect,
                    WHERE_UPDATE = item.CheckWhereUpdate,
                    WHERE_DELETE = item.CheckWhereDelete
                };
                classProperty.ListDetailProperty.Add(data);
            }
            this.LoadfrmClassCSharp(classProperty);
        }
        private void LoadfrmClassCSharp(ClassProperty classProperty)
        {
            if (!IsFormOpen(typeof(frmClassCSharp)))
            {
                frmClassCSharp _frmClassCSharp = new frmClassCSharp(classProperty);
                _frmClassCSharp.ShowDialog();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.LoadPageCSharp1();
        }
        private void LoadPageCSharp1()
        {
            pageCSharp1 _pageCShar1 = new pageCSharp1();
            frmMain.pnlBodyMain.Controls.Clear();
            frmMain.pnlBodyMain.Controls.Add(_pageCShar1);
            _pageCShar1.Dock = DockStyle.Fill;
            _pageCShar1.BringToFront();
        }
    }
}
