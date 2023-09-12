using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator.UIDesign
{
    public partial class UISelectProperty : UserControl
    {
        public UISelectProperty()
        {
            InitializeComponent();
        }

        private void UISelectProperty_Load(object sender, EventArgs e)
        {

        }
        public string PropertyName
        {
            get { return lblPropertyName.Text; }
            set { lblPropertyName.Text = value; }
        }
        public bool CheckDateTime
        {
            get { return chkDateTime.Checked; }
            set { chkDateTime.Checked = value; }
        }
        public bool CheckSelect
        {
            get { return chkSelect.Checked; }
            set { chkSelect.Checked = value; }
        }
        public bool CheckSelectAll
        {
            get { return chkSelectAll.Checked; }
            set { chkSelectAll.Checked = value; }
        }
        public bool CheckGetMaxID
        {
            get { return chkGetMaxId.Checked; }
            set { chkGetMaxId.Checked = value; }
        }
        public bool CheckInsert
        {
            get { return chkInsert.Checked; }
            set { chkInsert.Checked = value; }
        }
        public bool CheckUpdate
        {
            get { return chkUpdate.Checked; }
            set { chkUpdate.Checked = value; }
        }
        public bool CheckWhereSelect
        {
            get { return chkWhereSelect.Checked; }
            set { chkWhereSelect.Checked = value; }
        }
        public bool CheckWhereUpdate
        {
            get { return chkWhereUpdate.Checked; }
            set { chkWhereUpdate.Checked = value; }
        }
        public bool CheckWhereDelete
        {
            get { return chkWhereDelete.Checked; }
            set { chkWhereDelete.Checked = value; }
        }
    }
}
