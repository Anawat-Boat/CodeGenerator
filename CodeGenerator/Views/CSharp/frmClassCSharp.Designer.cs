namespace CodeGenerator
{
    partial class frmClassCSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassCSharp));
            this.pnlTaskbar = new System.Windows.Forms.Panel();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNameProgram = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnGenerateCode = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtDetailClass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProperty = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnServices = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSQLFactory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModels = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnControllers = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTaskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTaskbar
            // 
            this.pnlTaskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTaskbar.Controls.Add(this.picMaximize);
            this.pnlTaskbar.Controls.Add(this.pictureBox2);
            this.pnlTaskbar.Controls.Add(this.lblNameProgram);
            this.pnlTaskbar.Controls.Add(this.picClose);
            this.pnlTaskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskbar.ForeColor = System.Drawing.Color.Cyan;
            this.pnlTaskbar.Location = new System.Drawing.Point(2, 0);
            this.pnlTaskbar.Name = "pnlTaskbar";
            this.pnlTaskbar.Size = new System.Drawing.Size(868, 25);
            this.pnlTaskbar.TabIndex = 28;
            this.pnlTaskbar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_DoubleClick);
            this.pnlTaskbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseDown);
            this.pnlTaskbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseMove);
            this.pnlTaskbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseUp);
            // 
            // picMaximize
            // 
            this.picMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMaximize.Image = global::CodeGenerator.Properties.Resources.picMaximizeLeave;
            this.picMaximize.Location = new System.Drawing.Point(824, 4);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(16, 16);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaximize.TabIndex = 128;
            this.picMaximize.TabStop = false;
            this.toolTip1.SetToolTip(this.picMaximize, "Maximize");
            this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
            this.picMaximize.MouseEnter += new System.EventHandler(this.TabBarMouseEnter);
            this.picMaximize.MouseLeave += new System.EventHandler(this.TabBarMouseLeave);
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
            this.pictureBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_DoubleClick);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseUp);
            // 
            // lblNameProgram
            // 
            this.lblNameProgram.BackColor = System.Drawing.Color.Transparent;
            this.lblNameProgram.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNameProgram.ForeColor = System.Drawing.Color.DimGray;
            this.lblNameProgram.Location = new System.Drawing.Point(27, 0);
            this.lblNameProgram.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.lblNameProgram.Name = "lblNameProgram";
            this.lblNameProgram.Size = new System.Drawing.Size(119, 23);
            this.lblNameProgram.TabIndex = 126;
            this.lblNameProgram.Text = "Code Generate";
            this.lblNameProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameProgram.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_DoubleClick);
            this.lblNameProgram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseDown);
            this.lblNameProgram.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseMove);
            this.lblNameProgram.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTaskbar_MouseUp);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::CodeGenerator.Properties.Resources.picCloseLeave;
            this.picClose.Location = new System.Drawing.Point(846, 4);
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
            this.panel5.Location = new System.Drawing.Point(870, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 434);
            this.panel5.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 434);
            this.panel1.TabIndex = 30;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.btnGenerateCode);
            this.pnlBody.Controls.Add(this.txtDetailClass);
            this.pnlBody.Controls.Add(this.panel3);
            this.pnlBody.Controls.Add(this.btnProperty);
            this.pnlBody.Controls.Add(this.btnServices);
            this.pnlBody.Controls.Add(this.btnSQLFactory);
            this.pnlBody.Controls.Add(this.btnModels);
            this.pnlBody.Controls.Add(this.btnControllers);
            this.pnlBody.Controls.Add(this.panel2);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(2, 25);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(868, 409);
            this.pnlBody.TabIndex = 32;
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.ActiveBorderThickness = 2;
            this.btnGenerateCode.ActiveCornerRadius = 10;
            this.btnGenerateCode.ActiveFillColor = System.Drawing.Color.White;
            this.btnGenerateCode.ActiveForecolor = System.Drawing.Color.YellowGreen;
            this.btnGenerateCode.ActiveLineColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGenerateCode.BackColor = System.Drawing.Color.White;
            this.btnGenerateCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerateCode.BackgroundImage")));
            this.btnGenerateCode.ButtonText = "Generate Code";
            this.btnGenerateCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerateCode.ForeColor = System.Drawing.Color.Sienna;
            this.btnGenerateCode.IdleBorderThickness = 2;
            this.btnGenerateCode.IdleCornerRadius = 8;
            this.btnGenerateCode.IdleFillColor = System.Drawing.Color.YellowGreen;
            this.btnGenerateCode.IdleForecolor = System.Drawing.Color.White;
            this.btnGenerateCode.IdleLineColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGenerateCode.Location = new System.Drawing.Point(17, 8);
            this.btnGenerateCode.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(180, 93);
            this.btnGenerateCode.TabIndex = 34;
            this.btnGenerateCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // txtDetailClass
            // 
            this.txtDetailClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetailClass.BackColor = System.Drawing.Color.White;
            this.txtDetailClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetailClass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDetailClass.Location = new System.Drawing.Point(240, 8);
            this.txtDetailClass.Multiline = true;
            this.txtDetailClass.Name = "txtDetailClass";
            this.txtDetailClass.ReadOnly = true;
            this.txtDetailClass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetailClass.Size = new System.Drawing.Size(625, 389);
            this.txtDetailClass.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(212, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 393);
            this.panel3.TabIndex = 32;
            // 
            // btnProperty
            // 
            this.btnProperty.ActiveBorderThickness = 2;
            this.btnProperty.ActiveCornerRadius = 10;
            this.btnProperty.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(211)))));
            this.btnProperty.ActiveForecolor = System.Drawing.Color.White;
            this.btnProperty.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btnProperty.BackColor = System.Drawing.Color.White;
            this.btnProperty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProperty.BackgroundImage")));
            this.btnProperty.ButtonText = "Property";
            this.btnProperty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProperty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnProperty.ForeColor = System.Drawing.Color.Sienna;
            this.btnProperty.IdleBorderThickness = 2;
            this.btnProperty.IdleCornerRadius = 8;
            this.btnProperty.IdleFillColor = System.Drawing.Color.White;
            this.btnProperty.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(211)))));
            this.btnProperty.IdleLineColor = System.Drawing.Color.DimGray;
            this.btnProperty.Location = new System.Drawing.Point(17, 351);
            this.btnProperty.Margin = new System.Windows.Forms.Padding(5);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(180, 50);
            this.btnProperty.TabIndex = 31;
            this.btnProperty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnServices
            // 
            this.btnServices.ActiveBorderThickness = 2;
            this.btnServices.ActiveCornerRadius = 10;
            this.btnServices.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(211)))));
            this.btnServices.ActiveForecolor = System.Drawing.Color.White;
            this.btnServices.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btnServices.BackColor = System.Drawing.Color.White;
            this.btnServices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServices.BackgroundImage")));
            this.btnServices.ButtonText = "Services";
            this.btnServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnServices.ForeColor = System.Drawing.Color.Sienna;
            this.btnServices.IdleBorderThickness = 2;
            this.btnServices.IdleCornerRadius = 8;
            this.btnServices.IdleFillColor = System.Drawing.Color.White;
            this.btnServices.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(211)))));
            this.btnServices.IdleLineColor = System.Drawing.Color.DimGray;
            this.btnServices.Location = new System.Drawing.Point(17, 231);
            this.btnServices.Margin = new System.Windows.Forms.Padding(5);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(180, 50);
            this.btnServices.TabIndex = 30;
            this.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnSQLFactory
            // 
            this.btnSQLFactory.ActiveBorderThickness = 2;
            this.btnSQLFactory.ActiveCornerRadius = 10;
            this.btnSQLFactory.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(211)))));
            this.btnSQLFactory.ActiveForecolor = System.Drawing.Color.White;
            this.btnSQLFactory.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btnSQLFactory.BackColor = System.Drawing.Color.White;
            this.btnSQLFactory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSQLFactory.BackgroundImage")));
            this.btnSQLFactory.ButtonText = "SQLFactory";
            this.btnSQLFactory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSQLFactory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSQLFactory.ForeColor = System.Drawing.Color.Sienna;
            this.btnSQLFactory.IdleBorderThickness = 2;
            this.btnSQLFactory.IdleCornerRadius = 8;
            this.btnSQLFactory.IdleFillColor = System.Drawing.Color.White;
            this.btnSQLFactory.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(211)))));
            this.btnSQLFactory.IdleLineColor = System.Drawing.Color.DimGray;
            this.btnSQLFactory.Location = new System.Drawing.Point(17, 291);
            this.btnSQLFactory.Margin = new System.Windows.Forms.Padding(5);
            this.btnSQLFactory.Name = "btnSQLFactory";
            this.btnSQLFactory.Size = new System.Drawing.Size(180, 50);
            this.btnSQLFactory.TabIndex = 29;
            this.btnSQLFactory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSQLFactory.Click += new System.EventHandler(this.btnSQLFactory_Click);
            // 
            // btnModels
            // 
            this.btnModels.ActiveBorderThickness = 2;
            this.btnModels.ActiveCornerRadius = 10;
            this.btnModels.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(211)))));
            this.btnModels.ActiveForecolor = System.Drawing.Color.White;
            this.btnModels.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btnModels.BackColor = System.Drawing.Color.White;
            this.btnModels.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModels.BackgroundImage")));
            this.btnModels.ButtonText = "Models";
            this.btnModels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModels.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnModels.ForeColor = System.Drawing.Color.Sienna;
            this.btnModels.IdleBorderThickness = 2;
            this.btnModels.IdleCornerRadius = 8;
            this.btnModels.IdleFillColor = System.Drawing.Color.White;
            this.btnModels.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(211)))));
            this.btnModels.IdleLineColor = System.Drawing.Color.DimGray;
            this.btnModels.Location = new System.Drawing.Point(17, 171);
            this.btnModels.Margin = new System.Windows.Forms.Padding(5);
            this.btnModels.Name = "btnModels";
            this.btnModels.Size = new System.Drawing.Size(180, 50);
            this.btnModels.TabIndex = 28;
            this.btnModels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModels.Click += new System.EventHandler(this.btnModels_Click);
            // 
            // btnControllers
            // 
            this.btnControllers.ActiveBorderThickness = 2;
            this.btnControllers.ActiveCornerRadius = 10;
            this.btnControllers.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(211)))));
            this.btnControllers.ActiveForecolor = System.Drawing.Color.White;
            this.btnControllers.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btnControllers.BackColor = System.Drawing.Color.White;
            this.btnControllers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnControllers.BackgroundImage")));
            this.btnControllers.ButtonText = "Controllers";
            this.btnControllers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControllers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnControllers.ForeColor = System.Drawing.Color.Sienna;
            this.btnControllers.IdleBorderThickness = 2;
            this.btnControllers.IdleCornerRadius = 8;
            this.btnControllers.IdleFillColor = System.Drawing.Color.White;
            this.btnControllers.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(211)))));
            this.btnControllers.IdleLineColor = System.Drawing.Color.DimGray;
            this.btnControllers.Location = new System.Drawing.Point(17, 111);
            this.btnControllers.Margin = new System.Windows.Forms.Padding(5);
            this.btnControllers.Name = "btnControllers";
            this.btnControllers.Size = new System.Drawing.Size(180, 50);
            this.btnControllers.TabIndex = 27;
            this.btnControllers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnControllers.Click += new System.EventHandler(this.btnControllers_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 2);
            this.panel2.TabIndex = 26;
            // 
            // frmClassCSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 434);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTaskbar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClassCSharp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmClassCSharp";
            this.Load += new System.EventHandler(this.frmClassCSharp_Load);
            this.pnlTaskbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
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
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnProperty;
        private Bunifu.Framework.UI.BunifuThinButton2 btnServices;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSQLFactory;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModels;
        private Bunifu.Framework.UI.BunifuThinButton2 btnControllers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDetailClass;
        private System.Windows.Forms.PictureBox picMaximize;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGenerateCode;
    }
}