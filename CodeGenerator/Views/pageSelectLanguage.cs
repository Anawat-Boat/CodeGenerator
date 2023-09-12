using CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class pageSelectLanguage : UserControl
    {
        public pageSelectLanguage()
        {
            InitializeComponent();
        }
        private void picCSharp_MouseLeave(object sender, EventArgs e)
        {
            this.picCSharp.Image = Resources.C_MouseLeave4;
        }
        private void picCSharp_MouseEnter(object sender, EventArgs e)
        {
            this.picCSharp.Image = Resources.C_MouseEnter;
        }
        private void picCSharp_Click(object sender, EventArgs e)
        {
            this.LoadPageCsharp();
        }
        private void LoadPageCsharp()
        {
            pageCSharp1 _pageCSharp1 = new pageCSharp1();
            frmMain.pnlBodyMain.Controls.Clear();
            frmMain.pnlBodyMain.Controls.Add(_pageCSharp1);
            _pageCSharp1.Dock = DockStyle.Fill;
            _pageCSharp1.BringToFront();
        }
    }
}
