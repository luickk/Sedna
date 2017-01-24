namespace academic
{
    partial class show_msg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_msg));
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtb_answer_val = new System.Windows.Forms.RichTextBox();
            this.btn_answer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtb_answer_val);
            this.panel2.Controls.Add(this.btn_answer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(469, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 526);
            this.panel2.TabIndex = 2;
            // 
            // rtb_answer_val
            // 
            this.rtb_answer_val.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_answer_val.Location = new System.Drawing.Point(54, 281);
            this.rtb_answer_val.Name = "rtb_answer_val";
            this.rtb_answer_val.Size = new System.Drawing.Size(682, 159);
            this.rtb_answer_val.TabIndex = 4;
            this.rtb_answer_val.Text = "";
            // 
            // btn_answer
            // 
            this.btn_answer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btn_answer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_answer.BorderRadius = 0;
            this.btn_answer.ButtonText = "Answer";
            this.btn_answer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_answer.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_answer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_answer.Iconimage")));
            this.btn_answer.Iconimage_right = null;
            this.btn_answer.Iconimage_right_Selected = null;
            this.btn_answer.Iconimage_Selected = null;
            this.btn_answer.IconZoom = 90D;
            this.btn_answer.IsTab = false;
            this.btn_answer.Location = new System.Drawing.Point(54, 446);
            this.btn_answer.Name = "btn_answer";
            this.btn_answer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_answer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_answer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_answer.selected = false;
            this.btn_answer.Size = new System.Drawing.Size(241, 48);
            this.btn_answer.TabIndex = 3;
            this.btn_answer.Textcolor = System.Drawing.Color.White;
            this.btn_answer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_answer.Click += new System.EventHandler(this.btn_answer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // show_msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "show_msg";
            this.Size = new System.Drawing.Size(1922, 1080);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_answer;
        private System.Windows.Forms.RichTextBox rtb_answer_val;
    }
}
