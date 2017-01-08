namespace academic
{
    partial class dashboard_mod_teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_mod_teacher));
            this.btn_join_class = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_create_class = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pan_create_class = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel_err = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.alert_create = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_create = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.tb_class_pw = new Bunifu.Framework.UI.BunifuTextbox();
            this.tb_class_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_dash_update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tv_classes = new System.Windows.Forms.ListView();
            this.pan_join = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.t_join_class_alert = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_join_pw = new Bunifu.Framework.UI.BunifuTextbox();
            this.tb_join_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel_lv_men = new System.Windows.Forms.Panel();
            this.pb_join_class = new System.Windows.Forms.PictureBox();
            this.pb_class_delet = new System.Windows.Forms.PictureBox();
            this.t_selected_class = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_pupup_class = new System.Windows.Forms.Panel();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.Beitreten = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_send_msg_name = new Bunifu.Framework.UI.BunifuFlatButton();
            this.t_date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.t_info_email = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_info_school = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_class_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pan_create_class.SuspendLayout();
            this.pan_join.SuspendLayout();
            this.panel_lv_men.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_join_class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_class_delet)).BeginInit();
            this.panel_pupup_class.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_join_class
            // 
            this.btn_join_class.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_join_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_join_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_join_class.BorderRadius = 0;
            this.btn_join_class.ButtonText = "Join class";
            this.btn_join_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_join_class.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_join_class.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_join_class.Iconimage")));
            this.btn_join_class.Iconimage_right = null;
            this.btn_join_class.Iconimage_right_Selected = null;
            this.btn_join_class.Iconimage_Selected = null;
            this.btn_join_class.IconZoom = 90D;
            this.btn_join_class.IsTab = false;
            this.btn_join_class.Location = new System.Drawing.Point(753, 520);
            this.btn_join_class.Name = "btn_join_class";
            this.btn_join_class.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_join_class.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_join_class.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_join_class.selected = false;
            this.btn_join_class.Size = new System.Drawing.Size(243, 48);
            this.btn_join_class.TabIndex = 0;
            this.btn_join_class.Textcolor = System.Drawing.Color.White;
            this.btn_join_class.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_join_class.Click += new System.EventHandler(this.btn_join_class_Click);
            // 
            // btn_create_class
            // 
            this.btn_create_class.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_create_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_create_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create_class.BorderRadius = 0;
            this.btn_create_class.ButtonText = "Create class";
            this.btn_create_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_class.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_create_class.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_create_class.Iconimage")));
            this.btn_create_class.Iconimage_right = null;
            this.btn_create_class.Iconimage_right_Selected = null;
            this.btn_create_class.Iconimage_Selected = null;
            this.btn_create_class.IconZoom = 90D;
            this.btn_create_class.IsTab = false;
            this.btn_create_class.Location = new System.Drawing.Point(1035, 520);
            this.btn_create_class.Name = "btn_create_class";
            this.btn_create_class.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_create_class.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_create_class.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_create_class.selected = false;
            this.btn_create_class.Size = new System.Drawing.Size(243, 48);
            this.btn_create_class.TabIndex = 1;
            this.btn_create_class.Textcolor = System.Drawing.Color.White;
            this.btn_create_class.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_class.Click += new System.EventHandler(this.btn_create_class_Click);
            // 
            // pan_create_class
            // 
            this.pan_create_class.Controls.Add(this.bunifuCustomLabel_err);
            this.pan_create_class.Controls.Add(this.alert_create);
            this.pan_create_class.Controls.Add(this.btn_create);
            this.pan_create_class.Controls.Add(this.tb_class_pw);
            this.pan_create_class.Controls.Add(this.tb_class_name);
            this.pan_create_class.Location = new System.Drawing.Point(1035, 579);
            this.pan_create_class.Name = "pan_create_class";
            this.pan_create_class.Size = new System.Drawing.Size(375, 277);
            this.pan_create_class.TabIndex = 2;
            // 
            // bunifuCustomLabel_err
            // 
            this.bunifuCustomLabel_err.AutoSize = true;
            this.bunifuCustomLabel_err.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel_err.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel_err.Location = new System.Drawing.Point(16, 7);
            this.bunifuCustomLabel_err.Name = "bunifuCustomLabel_err";
            this.bunifuCustomLabel_err.Size = new System.Drawing.Size(347, 19);
            this.bunifuCustomLabel_err.TabIndex = 21;
            this.bunifuCustomLabel_err.Text = "Create you re class but can create only one!";
            this.bunifuCustomLabel_err.Click += new System.EventHandler(this.bunifuCustomLabel_err_Click);
            // 
            // alert_create
            // 
            this.alert_create.AutoSize = true;
            this.alert_create.Cursor = System.Windows.Forms.Cursors.Default;
            this.alert_create.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.alert_create.Location = new System.Drawing.Point(316, 41);
            this.alert_create.Name = "alert_create";
            this.alert_create.Size = new System.Drawing.Size(0, 19);
            this.alert_create.TabIndex = 22;
            // 
            // btn_create
            // 
            this.btn_create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_create.BackgroundImage")));
            this.btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create.ButtonText = "Create";
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_create.ForeColorHoverState = System.Drawing.Color.White;
            this.btn_create.Iconimage = null;
            this.btn_create.IconVisible = true;
            this.btn_create.IconZoom = 90D;
            this.btn_create.ImageIconOverlay = false;
            this.btn_create.Location = new System.Drawing.Point(20, 194);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(272, 46);
            this.btn_create.TabIndex = 4;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // tb_class_pw
            // 
            this.tb_class_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_class_pw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_class_pw.BackgroundImage")));
            this.tb_class_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_class_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_class_pw.Icon = ((System.Drawing.Image)(resources.GetObject("tb_class_pw.Icon")));
            this.tb_class_pw.Location = new System.Drawing.Point(20, 103);
            this.tb_class_pw.Name = "tb_class_pw";
            this.tb_class_pw.Size = new System.Drawing.Size(272, 70);
            this.tb_class_pw.TabIndex = 20;
            this.tb_class_pw.text = "Class Password";
            this.tb_class_pw.Enter += new System.EventHandler(this.tb_class_pw_Enter);
            // 
            // tb_class_name
            // 
            this.tb_class_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_class_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_class_name.BackgroundImage")));
            this.tb_class_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_class_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_class_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_class_name.Icon")));
            this.tb_class_name.Location = new System.Drawing.Point(20, 41);
            this.tb_class_name.Name = "tb_class_name";
            this.tb_class_name.Size = new System.Drawing.Size(272, 65);
            this.tb_class_name.TabIndex = 19;
            this.tb_class_name.text = "Class name";
            this.tb_class_name.Enter += new System.EventHandler(this.tb_class_name_Enter);
            // 
            // btn_dash_update
            // 
            this.btn_dash_update.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_dash_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_dash_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dash_update.BorderRadius = 0;
            this.btn_dash_update.ButtonText = "Update List";
            this.btn_dash_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dash_update.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dash_update.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_dash_update.Iconimage")));
            this.btn_dash_update.Iconimage_right = null;
            this.btn_dash_update.Iconimage_right_Selected = null;
            this.btn_dash_update.Iconimage_Selected = null;
            this.btn_dash_update.IconZoom = 90D;
            this.btn_dash_update.IsTab = false;
            this.btn_dash_update.Location = new System.Drawing.Point(470, 520);
            this.btn_dash_update.Name = "btn_dash_update";
            this.btn_dash_update.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_dash_update.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_dash_update.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_dash_update.selected = false;
            this.btn_dash_update.Size = new System.Drawing.Size(243, 48);
            this.btn_dash_update.TabIndex = 4;
            this.btn_dash_update.Textcolor = System.Drawing.Color.White;
            this.btn_dash_update.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dash_update.Click += new System.EventHandler(this.btn_dash_update_Click);
            // 
            // tv_classes
            // 
            this.tv_classes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.tv_classes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv_classes.FullRowSelect = true;
            this.tv_classes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.tv_classes.HideSelection = false;
            this.tv_classes.Location = new System.Drawing.Point(469, 113);
            this.tv_classes.Name = "tv_classes";
            this.tv_classes.Size = new System.Drawing.Size(825, 401);
            this.tv_classes.TabIndex = 5;
            this.tv_classes.UseCompatibleStateImageBehavior = false;
            this.tv_classes.Click += new System.EventHandler(this.tv_classes_Click);
            this.tv_classes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tv_classes_MouseDoubleClick_1);
            // 
            // pan_join
            // 
            this.pan_join.Controls.Add(this.bunifuCustomLabel1);
            this.pan_join.Controls.Add(this.bunifuThinButton1);
            this.pan_join.Controls.Add(this.t_join_class_alert);
            this.pan_join.Controls.Add(this.tb_join_pw);
            this.pan_join.Controls.Add(this.tb_join_name);
            this.pan_join.Location = new System.Drawing.Point(733, 579);
            this.pan_join.Name = "pan_join";
            this.pan_join.Size = new System.Drawing.Size(296, 277);
            this.pan_join.TabIndex = 23;
            this.pan_join.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_join_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(316, 41);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 19);
            this.bunifuCustomLabel1.TabIndex = 22;
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "Join";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(20, 194);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(272, 46);
            this.bunifuThinButton1.TabIndex = 4;
            this.bunifuThinButton1.Click += new System.EventHandler(this.bunifuThinButton1_Click);
            // 
            // t_join_class_alert
            // 
            this.t_join_class_alert.AutoSize = true;
            this.t_join_class_alert.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_join_class_alert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_join_class_alert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.t_join_class_alert.Location = new System.Drawing.Point(16, 7);
            this.t_join_class_alert.Name = "t_join_class_alert";
            this.t_join_class_alert.Size = new System.Drawing.Size(168, 19);
            this.t_join_class_alert.TabIndex = 21;
            this.t_join_class_alert.Text = "Join a random class!";
            // 
            // tb_join_pw
            // 
            this.tb_join_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_join_pw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_join_pw.BackgroundImage")));
            this.tb_join_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_join_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_join_pw.Icon = ((System.Drawing.Image)(resources.GetObject("tb_join_pw.Icon")));
            this.tb_join_pw.Location = new System.Drawing.Point(20, 103);
            this.tb_join_pw.Name = "tb_join_pw";
            this.tb_join_pw.Size = new System.Drawing.Size(272, 70);
            this.tb_join_pw.TabIndex = 20;
            this.tb_join_pw.text = "Class Password";
            this.tb_join_pw.Enter += new System.EventHandler(this.tb_join_pw_Enter);
            // 
            // tb_join_name
            // 
            this.tb_join_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_join_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_join_name.BackgroundImage")));
            this.tb_join_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_join_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_join_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_join_name.Icon")));
            this.tb_join_name.Location = new System.Drawing.Point(20, 41);
            this.tb_join_name.Name = "tb_join_name";
            this.tb_join_name.Size = new System.Drawing.Size(272, 65);
            this.tb_join_name.TabIndex = 19;
            this.tb_join_name.text = "Class name";
            this.tb_join_name.Enter += new System.EventHandler(this.tb_join_name_Enter);
            // 
            // panel_lv_men
            // 
            this.panel_lv_men.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_lv_men.Controls.Add(this.pb_join_class);
            this.panel_lv_men.Controls.Add(this.pb_class_delet);
            this.panel_lv_men.Controls.Add(this.t_selected_class);
            this.panel_lv_men.Location = new System.Drawing.Point(470, 57);
            this.panel_lv_men.Name = "panel_lv_men";
            this.panel_lv_men.Size = new System.Drawing.Size(825, 50);
            this.panel_lv_men.TabIndex = 24;
            // 
            // pb_join_class
            // 
            this.pb_join_class.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_join_class.BackgroundImage")));
            this.pb_join_class.Location = new System.Drawing.Point(724, 3);
            this.pb_join_class.Name = "pb_join_class";
            this.pb_join_class.Size = new System.Drawing.Size(41, 44);
            this.pb_join_class.TabIndex = 25;
            this.pb_join_class.TabStop = false;
            this.pb_join_class.Click += new System.EventHandler(this.pb_join_class_Click);
            // 
            // pb_class_delet
            // 
            this.pb_class_delet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_class_delet.BackgroundImage")));
            this.pb_class_delet.Location = new System.Drawing.Point(771, 0);
            this.pb_class_delet.Name = "pb_class_delet";
            this.pb_class_delet.Size = new System.Drawing.Size(51, 50);
            this.pb_class_delet.TabIndex = 24;
            this.pb_class_delet.TabStop = false;
            this.pb_class_delet.Click += new System.EventHandler(this.pb_class_delet_Click);
            // 
            // t_selected_class
            // 
            this.t_selected_class.AutoSize = true;
            this.t_selected_class.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_selected_class.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_selected_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.t_selected_class.Location = new System.Drawing.Point(42, 18);
            this.t_selected_class.Name = "t_selected_class";
            this.t_selected_class.Size = new System.Drawing.Size(107, 16);
            this.t_selected_class.TabIndex = 23;
            this.t_selected_class.Text = "Selected Class:";
            // 
            // panel_pupup_class
            // 
            this.panel_pupup_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.panel_pupup_class.Controls.Add(this.tb_msg);
            this.panel_pupup_class.Controls.Add(this.Beitreten);
            this.panel_pupup_class.Controls.Add(this.btn_send_msg_name);
            this.panel_pupup_class.Controls.Add(this.t_date);
            this.panel_pupup_class.Controls.Add(this.pictureBox2);
            this.panel_pupup_class.Controls.Add(this.t_info_email);
            this.panel_pupup_class.Controls.Add(this.t_info_school);
            this.panel_pupup_class.Controls.Add(this.t_class_name);
            this.panel_pupup_class.Location = new System.Drawing.Point(733, 3);
            this.panel_pupup_class.Name = "panel_pupup_class";
            this.panel_pupup_class.Size = new System.Drawing.Size(321, 440);
            this.panel_pupup_class.TabIndex = 36;
            // 
            // tb_msg
            // 
            this.tb_msg.Location = new System.Drawing.Point(33, 284);
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(243, 20);
            this.tb_msg.TabIndex = 39;
            this.tb_msg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Beitreten
            // 
            this.Beitreten.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.Beitreten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.Beitreten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Beitreten.BorderRadius = 0;
            this.Beitreten.ButtonText = "Join class";
            this.Beitreten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beitreten.Iconcolor = System.Drawing.Color.Transparent;
            this.Beitreten.Iconimage = ((System.Drawing.Image)(resources.GetObject("Beitreten.Iconimage")));
            this.Beitreten.Iconimage_right = null;
            this.Beitreten.Iconimage_right_Selected = null;
            this.Beitreten.Iconimage_Selected = null;
            this.Beitreten.IconZoom = 90D;
            this.Beitreten.IsTab = false;
            this.Beitreten.Location = new System.Drawing.Point(33, 159);
            this.Beitreten.Name = "Beitreten";
            this.Beitreten.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.Beitreten.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.Beitreten.OnHoverTextColor = System.Drawing.Color.White;
            this.Beitreten.selected = false;
            this.Beitreten.Size = new System.Drawing.Size(243, 48);
            this.Beitreten.TabIndex = 38;
            this.Beitreten.Textcolor = System.Drawing.Color.White;
            this.Beitreten.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beitreten.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btn_send_msg_name
            // 
            this.btn_send_msg_name.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_send_msg_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_send_msg_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_send_msg_name.BorderRadius = 0;
            this.btn_send_msg_name.ButtonText = "Send MSG to class";
            this.btn_send_msg_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send_msg_name.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_send_msg_name.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_send_msg_name.Iconimage")));
            this.btn_send_msg_name.Iconimage_right = null;
            this.btn_send_msg_name.Iconimage_right_Selected = null;
            this.btn_send_msg_name.Iconimage_Selected = null;
            this.btn_send_msg_name.IconZoom = 90D;
            this.btn_send_msg_name.IsTab = false;
            this.btn_send_msg_name.Location = new System.Drawing.Point(33, 230);
            this.btn_send_msg_name.Name = "btn_send_msg_name";
            this.btn_send_msg_name.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_send_msg_name.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_send_msg_name.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_send_msg_name.selected = false;
            this.btn_send_msg_name.Size = new System.Drawing.Size(243, 48);
            this.btn_send_msg_name.TabIndex = 37;
            this.btn_send_msg_name.Textcolor = System.Drawing.Color.White;
            this.btn_send_msg_name.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send_msg_name.Click += new System.EventHandler(this.btn_send_msg_name_Click);
            // 
            // t_date
            // 
            this.t_date.AutoSize = true;
            this.t_date.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_date.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.t_date.Location = new System.Drawing.Point(17, 100);
            this.t_date.Name = "t_date";
            this.t_date.Size = new System.Drawing.Size(38, 16);
            this.t_date.TabIndex = 22;
            this.t_date.Text = "Date";
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
            // t_info_email
            // 
            this.t_info_email.AutoSize = true;
            this.t_info_email.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_info_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.t_info_email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_info_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.t_info_email.Location = new System.Drawing.Point(17, 84);
            this.t_info_email.Name = "t_info_email";
            this.t_info_email.Size = new System.Drawing.Size(130, 16);
            this.t_info_email.TabIndex = 18;
            this.t_info_email.Text = "Class leader Email";
            // 
            // t_info_school
            // 
            this.t_info_school.AutoSize = true;
            this.t_info_school.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_info_school.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_info_school.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.t_info_school.Location = new System.Drawing.Point(17, 68);
            this.t_info_school.Name = "t_info_school";
            this.t_info_school.Size = new System.Drawing.Size(51, 16);
            this.t_info_school.TabIndex = 17;
            this.t_info_school.Text = "School";
            // 
            // t_class_name
            // 
            this.t_class_name.AutoSize = true;
            this.t_class_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_class_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_class_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.t_class_name.Location = new System.Drawing.Point(16, 41);
            this.t_class_name.Name = "t_class_name";
            this.t_class_name.Size = new System.Drawing.Size(101, 19);
            this.t_class_name.TabIndex = 13;
            this.t_class_name.Text = "Class Name";
            // 
            // dashboard_mod_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_create_class);
            this.Controls.Add(this.btn_join_class);
            this.Controls.Add(this.panel_pupup_class);
            this.Controls.Add(this.panel_lv_men);
            this.Controls.Add(this.tv_classes);
            this.Controls.Add(this.btn_dash_update);
            this.Controls.Add(this.pan_join);
            this.Controls.Add(this.pan_create_class);
            this.Name = "dashboard_mod_teacher";
            this.Size = new System.Drawing.Size(1922, 1080);
            this.Load += new System.EventHandler(this.dashboard_mod_Load);
            this.pan_create_class.ResumeLayout(false);
            this.pan_create_class.PerformLayout();
            this.pan_join.ResumeLayout(false);
            this.pan_join.PerformLayout();
            this.panel_lv_men.ResumeLayout(false);
            this.panel_lv_men.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_join_class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_class_delet)).EndInit();
            this.panel_pupup_class.ResumeLayout(false);
            this.panel_pupup_class.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_join_class;
        private Bunifu.Framework.UI.BunifuFlatButton btn_create_class;
        private System.Windows.Forms.Panel pan_create_class;
        private Bunifu.Framework.UI.BunifuTextbox tb_class_name;
        private Bunifu.Framework.UI.BunifuTextbox tb_class_pw;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel_err;
        private WindowsFormsControlLibrary1.BunifuThinButton btn_create;
        private Bunifu.Framework.UI.BunifuCustomLabel alert_create;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dash_update;
        private System.Windows.Forms.ListView tv_classes;
        private System.Windows.Forms.Panel pan_join;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel t_join_class_alert;
        private Bunifu.Framework.UI.BunifuTextbox tb_join_pw;
        private Bunifu.Framework.UI.BunifuTextbox tb_join_name;
        private System.Windows.Forms.Panel panel_lv_men;
        private Bunifu.Framework.UI.BunifuCustomLabel t_selected_class;
        private System.Windows.Forms.PictureBox pb_class_delet;
        private System.Windows.Forms.PictureBox pb_join_class;
        private System.Windows.Forms.Panel panel_pupup_class;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_email;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_school;
        private Bunifu.Framework.UI.BunifuCustomLabel t_class_name;
        private Bunifu.Framework.UI.BunifuCustomLabel t_date;
        private Bunifu.Framework.UI.BunifuFlatButton Beitreten;
        private Bunifu.Framework.UI.BunifuFlatButton btn_send_msg_name;
        private System.Windows.Forms.TextBox tb_msg;
    }
}
