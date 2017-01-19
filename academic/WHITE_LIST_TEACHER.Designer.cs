namespace academic
{
    partial class WHITE_LIST_TEACHER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WHITE_LIST_TEACHER));
            this.tv_user = new System.Windows.Forms.ListView();
            this.panel_pop = new System.Windows.Forms.Panel();
            this.t_pop_msg = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_head_line = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pb_class_delet = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.tb_last_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.tb_first_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_add = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.panel_pop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_class_delet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_user
            // 
            this.tv_user.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.tv_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv_user.FullRowSelect = true;
            this.tv_user.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.tv_user.HideSelection = false;
            this.tv_user.Location = new System.Drawing.Point(263, 105);
            this.tv_user.Name = "tv_user";
            this.tv_user.Size = new System.Drawing.Size(614, 184);
            this.tv_user.TabIndex = 30;
            this.tv_user.UseCompatibleStateImageBehavior = false;
            this.tv_user.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tv_user_MouseDoubleClick);
            // 
            // panel_pop
            // 
            this.panel_pop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.panel_pop.Controls.Add(this.t_pop_msg);
            this.panel_pop.Controls.Add(this.t_head_line);
            this.panel_pop.Location = new System.Drawing.Point(263, 0);
            this.panel_pop.Name = "panel_pop";
            this.panel_pop.Size = new System.Drawing.Size(303, 87);
            this.panel_pop.TabIndex = 38;
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
            // pb_class_delet
            // 
            this.pb_class_delet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_class_delet.BackgroundImage")));
            this.pb_class_delet.Location = new System.Drawing.Point(853, 75);
            this.pb_class_delet.Name = "pb_class_delet";
            this.pb_class_delet.Size = new System.Drawing.Size(24, 24);
            this.pb_class_delet.TabIndex = 39;
            this.pb_class_delet.TabStop = false;
            this.pb_class_delet.Click += new System.EventHandler(this.pb_class_delet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(814, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(263, 295);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(614, 10);
            this.bunifuSeparator3.TabIndex = 41;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // tb_last_name
            // 
            this.tb_last_name.BackColor = System.Drawing.Color.White;
            this.tb_last_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_last_name.BackgroundImage")));
            this.tb_last_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_last_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tb_last_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_last_name.Icon")));
            this.tb_last_name.Location = new System.Drawing.Point(263, 357);
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(186, 40);
            this.tb_last_name.TabIndex = 44;
            this.tb_last_name.text = "Last Name";
            this.tb_last_name.Enter += new System.EventHandler(this.tb_last_name_Enter);
            // 
            // tb_first_name
            // 
            this.tb_first_name.BackColor = System.Drawing.Color.White;
            this.tb_first_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_first_name.BackgroundImage")));
            this.tb_first_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_first_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tb_first_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_first_name.Icon")));
            this.tb_first_name.Location = new System.Drawing.Point(263, 311);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(186, 40);
            this.tb_first_name.TabIndex = 42;
            this.tb_first_name.text = "First Name";
            this.tb_first_name.Enter += new System.EventHandler(this.tb_first_name_Enter);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.ButtonText = "Add";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btn_add.ForeColorHoverState = System.Drawing.Color.White;
            this.btn_add.Iconimage = null;
            this.btn_add.IconVisible = true;
            this.btn_add.IconZoom = 90D;
            this.btn_add.ImageIconOverlay = false;
            this.btn_add.Location = new System.Drawing.Point(263, 403);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(186, 41);
            this.btn_add.TabIndex = 45;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // WHITE_LIST_TEACHER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_last_name);
            this.Controls.Add(this.tb_first_name);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_class_delet);
            this.Controls.Add(this.panel_pop);
            this.Controls.Add(this.tv_user);
            this.Name = "WHITE_LIST_TEACHER";
            this.Size = new System.Drawing.Size(1922, 1080);
            this.panel_pop.ResumeLayout(false);
            this.panel_pop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_class_delet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView tv_user;
        private System.Windows.Forms.Panel panel_pop;
        private Bunifu.Framework.UI.BunifuCustomLabel t_pop_msg;
        private Bunifu.Framework.UI.BunifuCustomLabel t_head_line;
        private System.Windows.Forms.PictureBox pb_class_delet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuTextbox tb_last_name;
        private Bunifu.Framework.UI.BunifuTextbox tb_first_name;
        private WindowsFormsControlLibrary1.BunifuThinButton btn_add;
    }
}
