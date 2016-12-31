namespace academic
{
    partial class class_mod
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(class_mod));
            this.class_pic = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel_err = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.class_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // class_pic
            // 
            this.class_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("class_pic.BackgroundImage")));
            this.class_pic.Location = new System.Drawing.Point(880, 427);
            this.class_pic.Name = "class_pic";
            this.class_pic.Size = new System.Drawing.Size(127, 128);
            this.class_pic.TabIndex = 0;
            this.class_pic.TabStop = false;
            // 
            // bunifuCustomLabel_err
            // 
            this.bunifuCustomLabel_err.AutoSize = true;
            this.bunifuCustomLabel_err.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel_err.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel_err.Location = new System.Drawing.Point(853, 558);
            this.bunifuCustomLabel_err.Name = "bunifuCustomLabel_err";
            this.bunifuCustomLabel_err.Size = new System.Drawing.Size(221, 19);
            this.bunifuCustomLabel_err.TabIndex = 8;
            this.bunifuCustomLabel_err.Text = "You have no class selected!";
            this.bunifuCustomLabel_err.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // class_mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel_err);
            this.Controls.Add(this.class_pic);
            this.Location = new System.Drawing.Point(880, 427);
            this.Name = "class_mod";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.class_mod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.class_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox class_pic;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel_err;
    }
}
