namespace CodeGenerator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTaskbar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNameProgram = new System.Windows.Forms.Label();
            this.picMinimizer = new System.Windows.Forms.PictureBox();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlTaskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(0, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(981, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright © 2020 By Davelopment Team";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTaskbar
            // 
            this.pnlTaskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTaskbar.Controls.Add(this.pictureBox2);
            this.pnlTaskbar.Controls.Add(this.lblNameProgram);
            this.pnlTaskbar.Controls.Add(this.picMinimizer);
            this.pnlTaskbar.Controls.Add(this.picMaximize);
            this.pnlTaskbar.Controls.Add(this.picClose);
            this.pnlTaskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskbar.ForeColor = System.Drawing.Color.Cyan;
            this.pnlTaskbar.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskbar.Name = "pnlTaskbar";
            this.pnlTaskbar.Size = new System.Drawing.Size(981, 25);
            this.pnlTaskbar.TabIndex = 10;
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
            // picMinimizer
            // 
            this.picMinimizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizer.Image = global::CodeGenerator.Properties.Resources.picMinimizeLeave;
            this.picMinimizer.Location = new System.Drawing.Point(915, 4);
            this.picMinimizer.Name = "picMinimizer";
            this.picMinimizer.Size = new System.Drawing.Size(16, 16);
            this.picMinimizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimizer.TabIndex = 4;
            this.picMinimizer.TabStop = false;
            this.toolTip1.SetToolTip(this.picMinimizer, "Minimize");
            this.picMinimizer.Click += new System.EventHandler(this.picMinimizer_Click);
            this.picMinimizer.MouseEnter += new System.EventHandler(this.TabBarMouseEnter);
            this.picMinimizer.MouseLeave += new System.EventHandler(this.TabBarMouseLeave);
            // 
            // picMaximize
            // 
            this.picMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximize.Enabled = false;
            this.picMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picMaximize.Image")));
            this.picMaximize.Location = new System.Drawing.Point(937, 4);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(16, 16);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaximize.TabIndex = 4;
            this.picMaximize.TabStop = false;
            this.toolTip1.SetToolTip(this.picMaximize, "Maximize");
            this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
            this.picMaximize.MouseEnter += new System.EventHandler(this.TabBarMouseEnter);
            this.picMaximize.MouseLeave += new System.EventHandler(this.TabBarMouseLeave);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::CodeGenerator.Properties.Resources.picCloseLeave;
            this.picClose.Location = new System.Drawing.Point(959, 4);
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
            this.panel5.Location = new System.Drawing.Point(979, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 672);
            this.panel5.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 672);
            this.panel1.TabIndex = 21;
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(2, 25);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(977, 672);
            this.pnlBody.TabIndex = 22;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 719);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlTaskbar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTaskbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTaskbar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNameProgram;
        private System.Windows.Forms.PictureBox picMinimizer;
        private System.Windows.Forms.PictureBox picMaximize;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBody;
    }
}

