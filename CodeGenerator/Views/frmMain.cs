using CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class frmMain : Form
    {
        public static Panel pnlBodyMain;
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
            //this.picMaximize.Image = Resources.picMaximizeLeave;
            this.picMinimizer.Image = Resources.picMinimizeLeave;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void TabBarMouseEnter(object sender, EventArgs e)
        {
            this.picClose.Image = Resources.picCloseEnter;
            //this.picMaximize.Image = Resources.picMaximizeEnter;
            this.picMinimizer.Image = Resources.picMinimizeEnter;

        }
        #endregion
        public frmMain()
        {
            InitializeComponent();
            pnlBodyMain = pnlBody;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.LoadPageSelectLanguage();
        }
        private void LoadPageSelectLanguage()
        {
            pageSelectLanguage _pageSerlectLanguage = new pageSelectLanguage();
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(_pageSerlectLanguage);
            _pageSerlectLanguage.Dock = DockStyle.Fill;
            _pageSerlectLanguage.BringToFront();
        }
    }
}
