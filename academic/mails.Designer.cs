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
            this.panel_pop = new System.Windows.Forms.Panel();
            this.t_pop_msg = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_head_line = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_pop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tb_mail_last_name);
            this.panel1.Controls.Add(this.bunifuThinButton1);
            this.panel1.Controls.Add(this.tb_mail_first_name);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.panel1.Location = new System.Drawing.Point(263, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 458);
            this.panel1.TabIndex = 0;
            // 
            // tb_mail_last_name
            // 
            this.tb_mail_last_name.BackColor = System.Drawing.Color.White;
            this.tb_mail_last_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_mail_last_name.BackgroundImage")));
            this.tb_mail_last_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_mail_last_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tb_mail_last_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_mail_last_name.Icon")));
            this.tb_mail_last_name.Location = new System.Drawing.Point(17, 88);
            this.tb_mail_last_name.Name = "tb_mail_last_name";
            this.tb_mail_last_name.Size = new System.Drawing.Size(250, 42);
            this.tb_mail_last_name.TabIndex = 3;
            this.tb_mail_last_name.text = "Last Name";
            this.tb_mail_last_name.Enter += new System.EventHandler(this.tb_mail_last_name_Enter);
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "Send";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(17, 404);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(223, 46);
            this.bunifuThinButton1.TabIndex = 2;
            this.bunifuThinButton1.Click += new System.EventHandler(this.bunifuThinButton1_Click);
            // 
            // rtb_msg_mail
            // 
            this.rtb_msg_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_msg_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.rtb_msg_mail.Location = new System.Drawing.Point(-1, -1);
            this.rtb_msg_mail.Name = "rtb_msg_mail";
            this.rtb_msg_mail.Size = new System.Drawing.Size(755, 234);
            this.rtb_msg_mail.TabIndex = 1;
            this.rtb_msg_mail.Text = "";
            // 
            // tb_mail_first_name
            // 
            this.tb_mail_first_name.BackColor = System.Drawing.Color.White;
            this.tb_mail_first_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_mail_first_name.BackgroundImage")));
            this.tb_mail_first_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_mail_first_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tb_mail_first_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_mail_first_name.Icon")));
            this.tb_mail_first_name.Location = new System.Drawing.Point(17, 16);
            this.tb_mail_first_name.Name = "tb_mail_first_name";
            this.tb_mail_first_name.Size = new System.Drawing.Size(250, 42);
            this.tb_mail_first_name.TabIndex = 0;
            this.tb_mail_first_name.text = "First Name";
            this.tb_mail_first_name.Enter += new System.EventHandler(this.tb_mail_first_name_Enter);
            // 
            // panel_pop
            // 
            this.panel_pop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.panel_pop.Controls.Add(this.t_pop_msg);
            this.panel_pop.Controls.Add(this.t_head_line);
            this.panel_pop.Location = new System.Drawing.Point(263, 0);
            this.panel_pop.Name = "panel_pop";
            this.panel_pop.Size = new System.Drawing.Size(303, 87);
            this.panel_pop.TabIndex = 4;
            // 
            // t_pop_msg
            // 
            this.t_pop_msg.AutoSize = true;
            this.t_pop_msg.BackColor = System.Drawing.Color.Transparent;
            this.t_pop_msg.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_pop_msg.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.t_pop_msg.ForeColor = System.Drawing.Color.White;
            this.t_pop_msg.Location = new System.Drawing.Point(13, 46);
            this.t_pop_msg.Name = "t_pop_msg";
            this.t_pop_msg.Size = new System.Drawing.Size(23, 16);
            this.t_pop_msg.TabIndex = 13;
            this.t_pop_msg.Text = "HL";
            // 
            // t_head_line
            // 
            this.t_head_line.AutoSize = true;
            this.t_head_line.BackColor = System.Drawing.Color.Transparent;
            this.t_head_line.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_head_line.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_head_line.ForeColor = System.Drawing.Color.White;
            this.t_head_line.Location = new System.Drawing.Point(3, 13);
            this.t_head_line.Name = "t_head_line";
            this.t_head_line.Size = new System.Drawing.Size(27, 19);
            this.t_head_line.TabIndex = 12;
            this.t_head_line.Text = "HL";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rtb_msg_mail);
            this.panel2.Location = new System.Drawing.Point(17, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 234);
            this.panel2.TabIndex = 5;
            // 
            // mails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_pop);
            this.Controls.Add(this.panel1);
            this.Name = "mails";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.ResumeLayout(false);
            this.panel_pop.ResumeLayout(false);
            this.panel_pop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox tb_mail_first_name;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
        private System.Windows.Forms.RichTextBox rtb_msg_mail;
        private Bunifu.Framework.UI.BunifuTextbox tb_mail_last_name;
        private System.Windows.Forms.Panel panel_pop;
        private Bunifu.Framework.UI.BunifuCustomLabel t_pop_msg;
        private Bunifu.Framework.UI.BunifuCustomLabel t_head_line;
        private System.Windows.Forms.Panel panel2;
    }
}
