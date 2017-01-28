namespace academic
{
    partial class chat_mod_all
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chat_mod_all));
            this.tb_send_msg = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_send_msg = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_msgs = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t_alert_login = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send_msg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_send_msg
            // 
            this.tb_send_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tb_send_msg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_send_msg.BackgroundImage")));
            this.tb_send_msg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_send_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tb_send_msg.Icon = ((System.Drawing.Image)(resources.GetObject("tb_send_msg.Icon")));
            this.tb_send_msg.Location = new System.Drawing.Point(324, 402);
            this.tb_send_msg.Name = "tb_send_msg";
            this.tb_send_msg.Size = new System.Drawing.Size(265, 38);
            this.tb_send_msg.TabIndex = 0;
            this.tb_send_msg.text = "";
            this.tb_send_msg.OnTextChange += new System.EventHandler(this.tb_send_msg_OnTextChange);
            this.tb_send_msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_send_msg_KeyDown);
            // 
            // btn_send_msg
            // 
            this.btn_send_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_send_msg.Image = ((System.Drawing.Image)(resources.GetObject("btn_send_msg.Image")));
            this.btn_send_msg.ImageActive = null;
            this.btn_send_msg.Location = new System.Drawing.Point(595, 402);
            this.btn_send_msg.Name = "btn_send_msg";
            this.btn_send_msg.Size = new System.Drawing.Size(28, 38);
            this.btn_send_msg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_send_msg.TabIndex = 1;
            this.btn_send_msg.TabStop = false;
            this.btn_send_msg.Zoom = 10;
            this.btn_send_msg.Click += new System.EventHandler(this.btn_send_msg_Click);
            // 
            // lb_msgs
            // 
            this.lb_msgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lb_msgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_msgs.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_msgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.lb_msgs.FormattingEnabled = true;
            this.lb_msgs.ItemHeight = 21;
            this.lb_msgs.Location = new System.Drawing.Point(324, 86);
            this.lb_msgs.Name = "lb_msgs";
            this.lb_msgs.Size = new System.Drawing.Size(515, 294);
            this.lb_msgs.TabIndex = 2;
            this.lb_msgs.SelectedIndexChanged += new System.EventHandler(this.lb_msgs_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(806, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // t_alert_login
            // 
            this.t_alert_login.AutoSize = true;
            this.t_alert_login.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_alert_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.t_alert_login.Location = new System.Drawing.Point(334, 453);
            this.t_alert_login.Name = "t_alert_login";
            this.t_alert_login.Size = new System.Drawing.Size(255, 33);
            this.t_alert_login.TabIndex = 29;
            this.t_alert_login.Text = "You are BLOCKED!";
            // 
            // chat_mod_all
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.t_alert_login);
            this.Controls.Add(this.lb_msgs);
            this.Controls.Add(this.btn_send_msg);
            this.Controls.Add(this.tb_send_msg);
            this.Name = "chat_mod_all";
            this.Size = new System.Drawing.Size(1922, 1080);
            this.Load += new System.EventHandler(this.chat_mod_all_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_send_msg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox tb_send_msg;
        private Bunifu.Framework.UI.BunifuImageButton btn_send_msg;
        private System.Windows.Forms.ListBox lb_msgs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel t_alert_login;
    }
}
