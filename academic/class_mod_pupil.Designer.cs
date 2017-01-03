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
            this.panel_lv_men = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tv_user = new System.Windows.Forms.ListView();
            this.lv_teacher = new System.Windows.Forms.ListView();
            this.panel_teacher_pupil_info_popup = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_send_msg_name = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.t_info_tel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_info_email = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_info_school = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_info_class = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t__popup_user_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_lv_men.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_teacher_pupil_info_popup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_lv_men
            // 
            this.panel_lv_men.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_lv_men.Controls.Add(this.pictureBox1);
            this.panel_lv_men.Location = new System.Drawing.Point(459, 57);
            this.panel_lv_men.Name = "panel_lv_men";
            this.panel_lv_men.Size = new System.Drawing.Size(1002, 50);
            this.panel_lv_men.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tv_user
            // 
            this.tv_user.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.tv_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv_user.FullRowSelect = true;
            this.tv_user.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.tv_user.HideSelection = false;
            this.tv_user.Location = new System.Drawing.Point(459, 113);
            this.tv_user.Name = "tv_user";
            this.tv_user.Size = new System.Drawing.Size(835, 401);
            this.tv_user.TabIndex = 32;
            this.tv_user.UseCompatibleStateImageBehavior = false;
            this.tv_user.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tv_user_MouseDoubleClick);
            // 
            // lv_teacher
            // 
            this.lv_teacher.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_teacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_teacher.FullRowSelect = true;
            this.lv_teacher.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_teacher.HideSelection = false;
            this.lv_teacher.Location = new System.Drawing.Point(1300, 113);
            this.lv_teacher.Name = "lv_teacher";
            this.lv_teacher.Size = new System.Drawing.Size(161, 401);
            this.lv_teacher.TabIndex = 34;
            this.lv_teacher.UseCompatibleStateImageBehavior = false;
            this.lv_teacher.DoubleClick += new System.EventHandler(this.lv_teacher_DoubleClick);
            // 
            // panel_teacher_pupil_info_popup
            // 
            this.panel_teacher_pupil_info_popup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.panel_teacher_pupil_info_popup.Controls.Add(this.textBox1);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.btn_send_msg_name);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.pictureBox2);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.t_info_tel);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.t_info_email);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.t_info_school);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.t_info_class);
            this.panel_teacher_pupil_info_popup.Controls.Add(this.t__popup_user_name);
            this.panel_teacher_pupil_info_popup.Location = new System.Drawing.Point(755, 19);
            this.panel_teacher_pupil_info_popup.Name = "panel_teacher_pupil_info_popup";
            this.panel_teacher_pupil_info_popup.Size = new System.Drawing.Size(321, 440);
            this.panel_teacher_pupil_info_popup.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 41;
            // 
            // btn_send_msg_name
            // 
            this.btn_send_msg_name.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_send_msg_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_send_msg_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_send_msg_name.BorderRadius = 0;
            this.btn_send_msg_name.ButtonText = "Send MSG";
            this.btn_send_msg_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send_msg_name.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_send_msg_name.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_send_msg_name.Iconimage")));
            this.btn_send_msg_name.Iconimage_right = null;
            this.btn_send_msg_name.Iconimage_right_Selected = null;
            this.btn_send_msg_name.Iconimage_Selected = null;
            this.btn_send_msg_name.IconZoom = 90D;
            this.btn_send_msg_name.IsTab = false;
            this.btn_send_msg_name.Location = new System.Drawing.Point(36, 199);
            this.btn_send_msg_name.Name = "btn_send_msg_name";
            this.btn_send_msg_name.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_send_msg_name.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_send_msg_name.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_send_msg_name.selected = false;
            this.btn_send_msg_name.Size = new System.Drawing.Size(243, 48);
            this.btn_send_msg_name.TabIndex = 40;
            this.btn_send_msg_name.Textcolor = System.Drawing.Color.White;
            this.btn_send_msg_name.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send_msg_name.Click += new System.EventHandler(this.btn_send_msg_name_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(285, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // t_info_tel
            // 
            this.t_info_tel.AutoSize = true;
            this.t_info_tel.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_info_tel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_info_tel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.t_info_tel.Location = new System.Drawing.Point(17, 121);
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
            this.t_info_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.t_info_email.Location = new System.Drawing.Point(17, 105);
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
            this.t_info_school.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.t_info_school.Location = new System.Drawing.Point(17, 89);
            this.t_info_school.Name = "t_info_school";
            this.t_info_school.Size = new System.Drawing.Size(51, 16);
            this.t_info_school.TabIndex = 17;
            this.t_info_school.Text = "School";
            // 
            // t_info_class
            // 
            this.t_info_class.AutoSize = true;
            this.t_info_class.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_info_class.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_info_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.t_info_class.Location = new System.Drawing.Point(15, 61);
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
            this.t__popup_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.t__popup_user_name.Location = new System.Drawing.Point(16, 41);
            this.t__popup_user_name.Name = "t__popup_user_name";
            this.t__popup_user_name.Size = new System.Drawing.Size(166, 19);
            this.t__popup_user_name.TabIndex = 13;
            this.t__popup_user_name.Text = "FirstName,LastName";
            // 
            // class_mod_pupil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_teacher_pupil_info_popup);
            this.Controls.Add(this.lv_teacher);
            this.Controls.Add(this.panel_lv_men);
            this.Controls.Add(this.tv_user);
            this.Name = "class_mod_pupil";
            this.Size = new System.Drawing.Size(1922, 1080);
            this.panel_lv_men.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_teacher_pupil_info_popup.ResumeLayout(false);
            this.panel_teacher_pupil_info_popup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lv_men;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView tv_user;
        private System.Windows.Forms.ListView lv_teacher;
        private System.Windows.Forms.Panel panel_teacher_pupil_info_popup;
        private Bunifu.Framework.UI.BunifuCustomLabel t__popup_user_name;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_tel;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_email;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_school;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_class;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_send_msg_name;
    }
}
