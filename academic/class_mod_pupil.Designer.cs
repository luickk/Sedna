namespace academic
{
    partial class class_mod_pupil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(class_mod_pupil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tv_user = new System.Windows.Forms.ListView();
            this.lv_teacher = new System.Windows.Forms.ListView();
            this.panel_teacher_pupil_info_popup = new System.Windows.Forms.Panel();
            this.btn_send_msg_name = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.t_info_tel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_info_email = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_info_school = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_info_class = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t__popup_user_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_pop = new System.Windows.Forms.Panel();
            this.t_pop_msg = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_head_line = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_teacher_pupil_info_popup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send_msg_name)).BeginInit();
            this.panel_pop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(844, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tv_user
            // 
            this.tv_user.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.tv_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tv_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tv_user.FullRowSelect = true;
            this.tv_user.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.tv_user.HideSelection = false;
            this.tv_user.Location = new System.Drawing.Point(263, 105);
            this.tv_user.Name = "tv_user";
            this.tv_user.Size = new System.Drawing.Size(614, 184);
            this.tv_user.TabIndex = 32;
            this.tv_user.UseCompatibleStateImageBehavior = false;
            this.tv_user.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tv_user_MouseDoubleClick);
            // 
            // lv_teacher
            // 
            this.lv_teacher.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lv_teacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_teacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.lv_teacher.FullRowSelect = true;
            this.lv_teacher.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_teacher.HideSelection = false;
            this.lv_teacher.Location = new System.Drawing.Point(263, 295);
            this.lv_teacher.Name = "lv_teacher";
            this.lv_teacher.Size = new System.Drawing.Size(614, 183);
            this.lv_teacher.TabIndex = 34;
            this.lv_teacher.UseCompatibleStateImageBehavior = false;
            this.lv_teacher.DoubleClick += new System.EventHandler(this.lv_teacher_DoubleClick);
            // 
            // panel_teacher_pupil_info_popup
            // 
            this.panel_teacher_pupil_info_popup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_teacher_pupil_info_popup.Controls.Add(this.btn_send_msg_name);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.bunifuSeparator1);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.tb_msg);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.bunifuSeparator6);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.t_info_tel);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.t_info_email);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.t_info_school);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.t_info_class);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.t__popup_user_name);
            this.panel_teacher_pupil_info_popup.Location = new System.Drawing.Point(883, 3);
            this.panel_teacher_pupil_info_popup.Name = "panel_teacher_pupil_info_popup";
            this.panel_teacher_pupil_info_popup.Size = new System.Drawing.Size(450, 647);
            this.panel_teacher_pupil_info_popup.TabIndex = 35;
            // 
            // btn_send_msg_name
            // 
            this.btn_send_msg_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_send_msg_name.BackgroundImage")));
            this.btn_send_msg_name.Location = new System.Drawing.Point(273, 217);
            this.btn_send_msg_name.Name = "btn_send_msg_name";
            this.btn_send_msg_name.Size = new System.Drawing.Size(24, 24);
            this.btn_send_msg_name.TabIndex = 49;
            this.btn_send_msg_name.TabStop = false;
            this.btn_send_msg_name.Click += new System.EventHandler(this.btn_send_msg_name_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 106);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 369);
            this.bunifuSeparator1.TabIndex = 48;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // tb_msg
            // 
            this.tb_msg.Location = new System.Drawing.Point(24, 217);
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(243, 20);
            this.tb_msg.TabIndex = 41;
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(14, 90);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(342, 10);
            this.bunifuSeparator6.TabIndex = 47;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // t_info_tel
            // 
            this.t_info_tel.AutoSize = true;
            this.t_info_tel.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_info_tel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_info_tel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.t_info_tel.Location = new System.Drawing.Point(21, 183);
            this.t_info_tel.Name = "t_info_tel";
            this.t_info_tel.Size = new System.Drawing.Size(75, 16);
            this.t_info_tel.TabIndex = 19;
            this.t_info_tel.Text = "Telephone";
            // 
            // t_info_email
            // 
            this.t_info_email.AutoSize = true;
            this.t_info_email.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_info_email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_info_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.t_info_email.Location = new System.Drawing.Point(21, 167);
            this.t_info_email.Name = "t_info_email";
            this.t_info_email.Size = new System.Drawing.Size(44, 16);
            this.t_info_email.TabIndex = 18;
            this.t_info_email.Text = "Email";
            // 
            // t_info_school
            // 
            this.t_info_school.AutoSize = true;
            this.t_info_school.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_info_school.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_info_school.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.t_info_school.Location = new System.Drawing.Point(21, 151);
            this.t_info_school.Name = "t_info_school";
            this.t_info_school.Size = new System.Drawing.Size(51, 16);
            this.t_info_school.TabIndex = 17;
            this.t_info_school.Text = "School";
            this.t_info_school.Click += new System.EventHandler(this.t_info_school_Click);
            // 
            // t_info_class
            // 
            this.t_info_class.AutoSize = true;
            this.t_info_class.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_info_class.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_info_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.t_info_class.Location = new System.Drawing.Point(19, 123);
            this.t_info_class.Name = "t_info_class";
            this.t_info_class.Size = new System.Drawing.Size(65, 25);
            this.t_info_class.TabIndex = 16;
            this.t_info_class.Text = "Class";
            // 
            // t__popup_user_name
            // 
            this.t__popup_user_name.AutoSize = true;
            this.t__popup_user_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.t__popup_user_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t__popup_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.t__popup_user_name.Location = new System.Drawing.Point(20, 103);
            this.t__popup_user_name.Name = "t__popup_user_name";
            this.t__popup_user_name.Size = new System.Drawing.Size(166, 19);
            this.t__popup_user_name.TabIndex = 13;
            this.t__popup_user_name.Text = "FirstName,LastName";
            // 
            // panel_pop
            // 
            this.panel_pop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.panel_pop.Controls.Add(this.t_pop_msg);
            this.panel_pop.Controls.Add(this.t_head_line);
            this.panel_pop.Location = new System.Drawing.Point(263, 0);
            this.panel_pop.Name = "panel_pop";
            this.panel_pop.Size = new System.Drawing.Size(303, 87);
            this.panel_pop.TabIndex = 39;
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
            // class_mod_pupil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_pop);
            this.Controls.Add(this.panel_teacher_pupil_info_popup);
            this.Controls.Add(this.lv_teacher);
            this.Controls.Add(this.tv_user);
            this.Name = "class_mod_pupil";
            this.Size = new System.Drawing.Size(1922, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_teacher_pupil_info_popup.ResumeLayout(false);
            this.panel_teacher_pupil_info_popup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send_msg_name)).EndInit();
            this.panel_pop.ResumeLayout(false);
            this.panel_pop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView tv_user;
        private System.Windows.Forms.ListView lv_teacher;
        private System.Windows.Forms.Panel panel_teacher_pupil_info_popup;
        private Bunifu.Framework.UI.BunifuCustomLabel t__popup_user_name;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_tel;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_email;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_school;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_class;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.Panel panel_pop;
        private Bunifu.Framework.UI.BunifuCustomLabel t_pop_msg;
        private Bunifu.Framework.UI.BunifuCustomLabel t_head_line;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private System.Windows.Forms.PictureBox btn_send_msg_name;
    }
}
