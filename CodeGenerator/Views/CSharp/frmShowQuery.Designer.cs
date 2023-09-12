namespace CodeGenerator
{
    partial class frmShowQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowQuery));
            this.pnlTaskbar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNameProgram = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBody = new System.Windows.Forms.Panel();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTaskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTaskbar
            // 
            this.pnlTaskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTaskbar.Controls.Add(this.pictureBox2);
            this.pnlTaskbar.Controls.Add(this.lblNameProgram);
            this.pnlTaskbar.Controls.Add(this.picClose);
            this.pnlTaskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskbar.ForeColor = System.Drawing.Color.Cyan;
            this.pnlTaskbar.Location = new System.Drawing.Point(2, 0);
            this.pnlTaskbar.Name = "pnlTaskbar";
            this.pnlTaskbar.Size = new System.Drawing.Size(421, 25);
            this.pnlTaskbar.TabIndex = 24;
            this.pnlTaskbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseDown);
            this.pnlTaskbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseMove);
            this.pnlTaskbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 127;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseUp);
            // 
            // lblNameProgram
            // 
            this.lblNameProgram.BackColor = System.Drawing.Color.Transparent;
            this.lblNameProgram.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProgram.ForeColor = System.Drawing.Color.DimGray;
            this.lblNameProgram.Location = new System.Drawing.Point(27, 0);
            this.lblNameProgram.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.lblNameProgram.Name = "lblNameProgram";
            this.lblNameProgram.Size = new System.Drawing.Size(119, 23);
            this.lblNameProgram.TabIndex = 126;
            this.lblNameProgram.Text = "Code Generate";
            this.lblNameProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameProgram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseDown);
            this.lblNameProgram.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseMove);
            this.lblNameProgram.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseUp);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::CodeGenerator.Properties.Resources.picCloseLeave;
            this.picClose.Location = new System.Drawing.Point(399, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(16, 16);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 3;
            this.picClose.TabStop = false;
            this.toolTip1.SetToolTip(this.picClose, "Close");
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.TabBarMouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.TabBarMouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(423, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 213);
            this.panel5.TabIndex = 25;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.txtQuery);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.panel2);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(2, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(423, 213);
            this.pnlBody.TabIndex = 27;
            // 
            // txtQuery
            // 
            this.txtQuery.BackColor = System.Drawing.Color.White;
            this.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuery.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(30, 86);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ReadOnly = true;
            this.txtQuery.Size = new System.Drawing.Size(381, 87);
            this.txtQuery.TabIndex = 29;
            this.txtQuery.Text = "SELECT `COLUMN_NAME`\r\nFROM `INFORMATION_SCHEMA`.`COLUMNS` \r\nWHERE `TABLE_SCHEMA`=" +
    "\'dataItem.SCHEMA_NAME\' \r\nAND `TABLE_NAME`=\'dataItem.TABLE_NAME\';";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Command Get Column Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 2);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 213);
            this.panel1.TabIndex = 26;
            // 
            // frmShowQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 213);
            this.Controls.Add(this.pnlTaskbar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShowQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmShowQuery";
            this.Load += new System.EventHandler(this.frmShowQuery_Load);
            this.pnlTaskbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTaskbar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNameProgram;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuery;
    }
}