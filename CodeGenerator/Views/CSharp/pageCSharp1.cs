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
using System.IO;
using System.Net.NetworkInformation;
using CodeGenerator.Controller;

namespace CodeGenerator
{
    public partial class pageCSharp1 : UserControl
    {
        public static ProjectProperty project = new ProjectProperty();
        public static List<string> listPathFolderMVCS = new List<string>();
        private bool statusTutorial = false;
        List<string> listPathFolder = new List<string>();
        private int pageNumber = 1;

        ViewsController controller = new ViewsController();

        public pageCSharp1()
        {
            InitializeComponent();
        }

        private void pageCSharp1_Load(object sender, EventArgs e)
        {
            this.chkAlready.Checked = false;
            this.SetPage();
        }
        private void SetPage()
        {
            this.txtProjectname.Text = "";
            this.txtLocation.Text = "";
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog selectFolder = new FolderBrowserDialog();
            DialogResult result = selectFolder.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectFolder.SelectedPath))
            {
                this.txtLocation.Text = selectFolder.SelectedPath;
                listPathFolder = Directory.GetDirectories(selectFolder.SelectedPath).ToList();
            }
        }
        private void chkAlready_OnChange(object sender, EventArgs e)
        {
            if (chkAlready.Checked)
            {
                if (this.txtLocation.Text == "") 
                { 
                    MessageBox.Show("Not found Location project" + Environment.NewLine + "Please browse path project", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    chkAlready.Checked = false;
                    return; 
                }
                if (this.txtProjectname.Text == "") 
                { 
                    MessageBox.Show("Not found Project name" + Environment.NewLine + "Please enter Project name", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    chkAlready.Checked = false;
                    return;
                }
                project = new ProjectProperty
                {
                    PROJECT_NAME = this.txtProjectname.Text.Trim(),
                    PATH_PROJECT = this.txtLocation.Text.Trim()
                };
                if (!controller.CheckPathProject(project)) { chkAlready.Checked = false; return; }
                listPathFolderMVCS = controller.GetPathFolderMVC(project);
                if (listPathFolderMVCS.Count <= 0 && listPathFolderMVCS == null)
                {
                    MessageBox.Show("Program can't get path folder MVCS" + Environment.NewLine + "Please check path or program", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    chkAlready.Checked = false;
                    return;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!chkAlready.Checked)
            {
                MessageBox.Show("Please check 'Already Done'", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); return;
            }
            if (controller.CreateFolderMVC(listPathFolderMVCS))
            {
                this.LoadPageCSharp2();
            }
        }
        private void LoadPageCSharp2()
        {
            pageCSharp2 _pageCShar2 = new pageCSharp2();
            frmMain.pnlBodyMain.Controls.Clear();
            frmMain.pnlBodyMain.Controls.Add(_pageCShar2);
            _pageCShar2.Dock = DockStyle.Fill;
            _pageCShar2.BringToFront();
        }
        private void lblAreadyDone_Click(object sender, EventArgs e)
        {
            this.chkAlready.Checked = (this.chkAlready.Checked) ? false : true;
            chkAlready_OnChange(this, null);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.LoadPageSelectLanguage();
        }
        private void LoadPageSelectLanguage()
        {
            pageSelectLanguage _pageSerlectLanguage = new pageSelectLanguage();
            frmMain.pnlBodyMain.Controls.Clear();
            frmMain.pnlBodyMain.Controls.Add(_pageSerlectLanguage);
            _pageSerlectLanguage.Dock = DockStyle.Fill;
            _pageSerlectLanguage.BringToFront();

        }

        #region Tutorial
        private void picPrevios_Click(object sender, EventArgs e)
        {
            if (pageNumber == 1) { return; }
            pageNumber -= 1;
            this.SetPageTutorial(pageNumber);
            statusTutorial = false;
            this.tmrTutorial.Start();
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            if (pageNumber == 6) { return; }
            pageNumber += 1;
            this.SetPageTutorial(pageNumber);
            statusTutorial = true;
            this.tmrTutorial.Start();
        }
        private void SetPageTutorial(int page)
        {
            this.lblPage.Text =  page + " of 6";
        }
        private void tmrTutorial_Tick(object sender, EventArgs e)
        {
            Point temp;
            int locationPage = (-830) * (pageNumber - 1);
            if (statusTutorial)
            {
                temp = this.pageTutoria.Location;
                temp.X -= 83;
                this.pageTutoria.Location = temp;
            }
            else
            {
                temp = this.pageTutoria.Location;
                temp.X += 83;
                this.pageTutoria.Location = temp;
            }
            if (pageNumber == 1 && temp.X == 0)
            {
                tmrTutorial.Stop();
            }
            else if (pageNumber == 2 && temp.X == locationPage)
            {
                tmrTutorial.Stop();
            }
            else if (pageNumber == 3 && temp.X == locationPage)
            {
                tmrTutorial.Stop();
            }
            else if (pageNumber == 4 && temp.X == locationPage)
            {
                tmrTutorial.Stop();
            }
            else if (pageNumber == 5 && temp.X == locationPage)
            {
                tmrTutorial.Stop();
            }
            else if (pageNumber == 6 && temp.X == locationPage)
            {
                tmrTutorial.Stop();
            }

        }
        #endregion

      
    }
}
