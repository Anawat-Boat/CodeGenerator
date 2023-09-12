namespace CodeGenerator
{
    partial class pageSelectLanguage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCSharp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCSharp)).BeginInit();
            this.SuspendLayout();
            // 
            // picCSharp
            // 
            this.picCSharp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picCSharp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCSharp.Image = global::CodeGenerator.Properties.Resources.C_MouseLeave4;
            this.picCSharp.Location = new System.Drawing.Point(233, 75);
            this.picCSharp.Name = "picCSharp";
            this.picCSharp.Size = new System.Drawing.Size(502, 167);
            this.picCSharp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCSharp.TabIndex = 0;
            this.picCSharp.TabStop = false;
            this.picCSharp.Click += new System.EventHandler(this.picCSharp_Click);
            this.picCSharp.MouseEnter += new System.EventHandler(this.picCSharp_MouseEnter);
            this.picCSharp.MouseLeave += new System.EventHandler(this.picCSharp_MouseLeave);
            // 
            // pageSelectLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picCSharp);
            this.Name = "pageSelectLanguage";
            this.Size = new System.Drawing.Size(981, 697);
            ((System.ComponentModel.ISupportInitialize)(this.picCSharp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCSharp;
    }
}
