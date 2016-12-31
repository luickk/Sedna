namespace academic
{
    partial class mails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_mail_last_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.rtb_msg_mail = new System.Windows.Forms.RichTextBox();
            this.tb_mail_first_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tb_mail_last_name);
            this.panel1.Controls.Add(this.bunifuThinButton1);
            this.panel1.Controls.Add(this.rtb_msg_mail);
            this.panel1.Controls.Add(this.tb_mail_first_name);
            this.panel1.Location = new System.Drawing.Point(368, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 526);
            this.panel1.TabIndex = 0;
            // 
            // tb_mail_last_name
            // 
            this.tb_mail_last_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_mail_last_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_mail_last_name.BackgroundImage")));
            this.tb_mail_last_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_mail_last_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_mail_last_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_mail_last_name.Icon")));
            this.tb_mail_last_name.Location = new System.Drawing.Point(17, 88);
            this.tb_mail_last_name.Name = "tb_mail_last_name";
            this.tb_mail_last_name.Size = new System.Drawing.Size(250, 42);
            this.tb_mail_last_name.TabIndex = 3;
            this.tb_mail_last_name.text = "Last Name";
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "Bunifu Button";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(17, 464);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(223, 46);
            this.bunifuThinButton1.TabIndex = 2;
            this.bunifuThinButton1.Click += new System.EventHandler(this.bunifuThinButton1_Click);
            // 
            // rtb_msg_mail
            // 
            this.rtb_msg_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_msg_mail.Location = new System.Drawing.Point(17, 164);
            this.rtb_msg_mail.Name = "rtb_msg_mail";
            this.rtb_msg_mail.Size = new System.Drawing.Size(755, 294);
            this.rtb_msg_mail.TabIndex = 1;
            this.rtb_msg_mail.Text = "";
            // 
            // tb_mail_first_name
            // 
            this.tb_mail_first_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_mail_first_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_mail_first_name.BackgroundImage")));
            this.tb_mail_first_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_mail_first_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_mail_first_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_mail_first_name.Icon")));
            this.tb_mail_first_name.Location = new System.Drawing.Point(17, 16);
            this.tb_mail_first_name.Name = "tb_mail_first_name";
            this.tb_mail_first_name.Size = new System.Drawing.Size(250, 42);
            this.tb_mail_first_name.TabIndex = 0;
            this.tb_mail_first_name.text = "First Name";
            // 
            // mails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "mails";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox tb_mail_first_name;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
        private System.Windows.Forms.RichTextBox rtb_msg_mail;
        private Bunifu.Framework.UI.BunifuTextbox tb_mail_last_name;
    }
}
