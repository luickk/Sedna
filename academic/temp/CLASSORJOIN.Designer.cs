namespace academic
{
    partial class CLASSORJOIN
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
            this.bunifuCustomLabel_err = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel_err
            // 
            this.bunifuCustomLabel_err.AutoSize = true;
            this.bunifuCustomLabel_err.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel_err.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel_err.Location = new System.Drawing.Point(880, 427);
            this.bunifuCustomLabel_err.Name = "bunifuCustomLabel_err";
            this.bunifuCustomLabel_err.Size = new System.Drawing.Size(121, 19);
            this.bunifuCustomLabel_err.TabIndex = 10;
            this.bunifuCustomLabel_err.Text = "Create a class!";
            // 
            // CLASSORJOIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel_err);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "CLASSORJOIN";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel_err;
    }
}
