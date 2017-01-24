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
            this.pan_create_class = new System.Windows.Forms.Panel();
            this.tb_class_pw_class = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_create = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuCustomLabel_err = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.alert_create = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_class_pw = new Bunifu.Framework.UI.BunifuTextbox();
            this.tb_class_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.tv_classes = new System.Windows.Forms.ListView();
            this.pan_join = new System.Windows.Forms.Panel();
            this.tb_join_pw_class = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_join_class_alert = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_join_pw = new Bunifu.Framework.UI.BunifuTextbox();
            this.tb_join_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.pb_class_delet = new System.Windows.Forms.PictureBox();
            this.t_class_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_pupup_class = new System.Windows.Forms.Panel();
            this.btn_dash_update = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.btn_create_class = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.btn_join_class = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btn_send_msg_name = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.t_info_school = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_info_email = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.pan_create_class.SuspendLayout();
            this.pan_join.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_class_delet)).BeginInit();
            this.panel_pupup_class.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send_msg_name)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_create_class
            // 
            this.pan_create_class.Controls.Add(this.tb_class_pw_class);
            this.pan_create_class.Controls.Add(this.btn_create);
            this.pan_create_class.Controls.Add(this.bunifuCustomLabel_err);
            this.pan_create_class.Controls.Add(this.alert_create);
            this.pan_create_class.Controls.Add(this.tb_class_pw);
            this.pan_create_class.Controls.Add(this.tb_class_name);
            this.pan_create_class.Location = new System.Drawing.Point(671, 277);
            this.pan_create_class.Name = "pan_create_class";
            this.pan_create_class.Size = new System.Drawing.Size(206, 259);
            this.pan_create_class.TabIndex = 2;
            // 
            // tb_class_pw_class
            // 
            this.tb_class_pw_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tb_class_pw_class.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_class_pw_class.BackgroundImage")));
            this.tb_class_pw_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_class_pw_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tb_class_pw_class.Icon = ((System.Drawing.Image)(resources.GetObject("tb_class_pw_class.Icon")));
            this.tb_class_pw_class.Location = new System.Drawing.Point(20, 141);
            this.tb_class_pw_class.Name = "tb_class_pw_class";
            this.tb_class_pw_class.Size = new System.Drawing.Size(179, 50);
            this.tb_class_pw_class.TabIndex = 49;
            this.tb_class_pw_class.text = "Teacher Password";
            this.tb_class_pw_class.Enter += new System.EventHandler(this.tb_class_pw_class_Enter);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Transparent;
            this.btn_create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_create.BackgroundImage")));
            this.btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create.ButtonText = "Create";
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btn_create.ForeColorHoverState = System.Drawing.Color.White;
            this.btn_create.Iconimage = null;
            this.btn_create.IconVisible = true;
            this.btn_create.IconZoom = 90D;
            this.btn_create.ImageIconOverlay = false;
            this.btn_create.Location = new System.Drawing.Point(40, 197);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(131, 36);
            this.btn_create.TabIndex = 48;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // bunifuCustomLabel_err
            // 
            this.bunifuCustomLabel_err.AutoSize = true;
            this.bunifuCustomLabel_err.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel_err.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.bunifuCustomLabel_err.Location = new System.Drawing.Point(16, 7);
            this.bunifuCustomLabel_err.Name = "bunifuCustomLabel_err";
            this.bunifuCustomLabel_err.Size = new System.Drawing.Size(117, 19);
            this.bunifuCustomLabel_err.TabIndex = 21;
            this.bunifuCustomLabel_err.Text = "Create a class";
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
            // tb_class_pw
            // 
            this.tb_class_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tb_class_pw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_class_pw.BackgroundImage")));
            this.tb_class_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_class_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tb_class_pw.Icon = ((System.Drawing.Image)(resources.GetObject("tb_class_pw.Icon")));
            this.tb_class_pw.Location = new System.Drawing.Point(20, 85);
            this.tb_class_pw.Name = "tb_class_pw";
            this.tb_class_pw.Size = new System.Drawing.Size(179, 50);
            this.tb_class_pw.TabIndex = 20;
            this.tb_class_pw.text = "Pupil Password";
            this.tb_class_pw.Enter += new System.EventHandler(this.tb_class_pw_Enter);
            // 
            // tb_class_name
            // 
            this.tb_class_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tb_class_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_class_name.BackgroundImage")));
            this.tb_class_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_class_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tb_class_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_class_name.Icon")));
            this.tb_class_name.Location = new System.Drawing.Point(20, 29);
            this.tb_class_name.Name = "tb_class_name";
            this.tb_class_name.Size = new System.Drawing.Size(179, 50);
            this.tb_class_name.TabIndex = 19;
            this.tb_class_name.text = "Class name";
            this.tb_class_name.Enter += new System.EventHandler(this.tb_class_name_Enter);
            // 
            // tv_classes
            // 
            this.tv_classes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.tv_classes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tv_classes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv_classes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tv_classes.FullRowSelect = true;
            this.tv_classes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.tv_classes.Location = new System.Drawing.Point(263, 87);
            this.tv_classes.MultiSelect = false;
            this.tv_classes.Name = "tv_classes";
            this.tv_classes.Size = new System.Drawing.Size(614, 184);
            this.tv_classes.TabIndex = 5;
            this.tv_classes.UseCompatibleStateImageBehavior = false;
            this.tv_classes.Click += new System.EventHandler(this.tv_classes_Click);
            this.tv_classes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tv_classes_MouseDoubleClick_1);
            // 
            // pan_join
            // 
            this.pan_join.Controls.Add(this.tb_join_pw_class);
            this.pan_join.Controls.Add(this.bunifuThinButton1);
            this.pan_join.Controls.Add(this.bunifuCustomLabel1);
            this.pan_join.Controls.Add(this.t_join_class_alert);
            this.pan_join.Controls.Add(this.tb_join_pw);
            this.pan_join.Controls.Add(this.tb_join_name);
            this.pan_join.Location = new System.Drawing.Point(457, 277);
            this.pan_join.Name = "pan_join";
            this.pan_join.Size = new System.Drawing.Size(208, 259);
            this.pan_join.TabIndex = 23;
            this.pan_join.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_join_Paint);
            // 
            // tb_join_pw_class
            // 
            this.tb_join_pw_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tb_join_pw_class.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_join_pw_class.BackgroundImage")));
            this.tb_join_pw_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_join_pw_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tb_join_pw_class.Icon = ((System.Drawing.Image)(resources.GetObject("tb_join_pw_class.Icon")));
            this.tb_join_pw_class.Location = new System.Drawing.Point(20, 141);
            this.tb_join_pw_class.Name = "tb_join_pw_class";
            this.tb_join_pw_class.Size = new System.Drawing.Size(179, 50);
            this.tb_join_pw_class.TabIndex = 48;
            this.tb_join_pw_class.text = "Teacher Password";
            this.tb_join_pw_class.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            this.tb_join_pw_class.Enter += new System.EventHandler(this.tb_join_pw_classEnter);
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "Join";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(38, 197);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(131, 36);
            this.bunifuThinButton1.TabIndex = 47;
            this.bunifuThinButton1.Click += new System.EventHandler(this.bunifuThinButton1_Click);
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
            // t_join_class_alert
            // 
            this.t_join_class_alert.AutoSize = true;
            this.t_join_class_alert.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_join_class_alert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_join_class_alert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.t_join_class_alert.Location = new System.Drawing.Point(16, 7);
            this.t_join_class_alert.Name = "t_join_class_alert";
            this.t_join_class_alert.Size = new System.Drawing.Size(101, 19);
            this.t_join_class_alert.TabIndex = 21;
            this.t_join_class_alert.Text = "Join a class!";
            // 
            // tb_join_pw
            // 
            this.tb_join_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tb_join_pw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_join_pw.BackgroundImage")));
            this.tb_join_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_join_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tb_join_pw.Icon = ((System.Drawing.Image)(resources.GetObject("tb_join_pw.Icon")));
            this.tb_join_pw.Location = new System.Drawing.Point(20, 85);
            this.tb_join_pw.Name = "tb_join_pw";
            this.tb_join_pw.Size = new System.Drawing.Size(179, 50);
            this.tb_join_pw.TabIndex = 20;
            this.tb_join_pw.text = "Pupil Password";
            this.tb_join_pw.OnTextChange += new System.EventHandler(this.tb_join_pw_OnTextChange);
            this.tb_join_pw.Enter += new System.EventHandler(this.tb_join_pw_Enter);
            // 
            // tb_join_name
            // 
            this.tb_join_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tb_join_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_join_name.BackgroundImage")));
            this.tb_join_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_join_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.tb_join_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_join_name.Icon")));
            this.tb_join_name.Location = new System.Drawing.Point(20, 29);
            this.tb_join_name.Name = "tb_join_name";
            this.tb_join_name.Size = new System.Drawing.Size(179, 50);
            this.tb_join_name.TabIndex = 19;
            this.tb_join_name.text = "Class name";
            this.tb_join_name.OnTextChange += new System.EventHandler(this.tb_join_name_OnTextChange);
            this.tb_join_name.Enter += new System.EventHandler(this.tb_join_name_Enter);
            // 
            // pb_class_delet
            // 
            this.pb_class_delet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_class_delet.BackgroundImage")));
            this.pb_class_delet.Location = new System.Drawing.Point(329, 47);
            this.pb_class_delet.Name = "pb_class_delet";
            this.pb_class_delet.Size = new System.Drawing.Size(24, 24);
            this.pb_class_delet.TabIndex = 24;
            this.pb_class_delet.TabStop = false;
            this.pb_class_delet.Click += new System.EventHandler(this.pb_class_delet_Click);
            // 
            // t_class_name
            // 
            this.t_class_name.AutoSize = true;
            this.t_class_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_class_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.t_class_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.t_class_name.Location = new System.Drawing.Point(18, 95);
            this.t_class_name.Name = "t_class_name";
            this.t_class_name.Size = new System.Drawing.Size(52, 19);
            this.t_class_name.TabIndex = 23;
            this.t_class_name.Text = "Class:";
            this.t_class_name.Click += new System.EventHandler(this.t_selected_class_Click);
            // 
            // panel_pupup_class
            // 
            this.panel_pupup_class.BackColor = System.Drawing.Color.Transparent;
            this.panel_pupup_class.Controls.Add(this.btn_dash_update);
            this.panel_pupup_class.Controls.Add(this.btn_create_class);
            this.panel_pupup_class.Controls.Add(this.btn_join_class);
            this.panel_pupup_class.Controls.Add(this.bunifuSeparator1);
            this.panel_pupup_class.Controls.Add(this.btn_send_msg_name);
            this.panel_pupup_class.Controls.Add(this.pb_class_delet);
            this.panel_pupup_class.Controls.Add(this.t_class_name);
            this.panel_pupup_class.Controls.Add(this.bunifuSeparator6);
            this.panel_pupup_class.Controls.Add(this.t_info_school);
            this.panel_pupup_class.Controls.Add(this.t_info_email);
            this.panel_pupup_class.Controls.Add(this.tb_msg);
            this.panel_pupup_class.Location = new System.Drawing.Point(883, 3);
            this.panel_pupup_class.Name = "panel_pupup_class";
            this.panel_pupup_class.Size = new System.Drawing.Size(357, 516);
            this.panel_pupup_class.TabIndex = 36;
            // 
            // btn_dash_update
            // 
            this.btn_dash_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_dash_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dash_update.BackgroundImage")));
            this.btn_dash_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dash_update.ButtonText = "Refresh";
            this.btn_dash_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dash_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btn_dash_update.ForeColorHoverState = System.Drawing.Color.White;
            this.btn_dash_update.Iconimage = null;
            this.btn_dash_update.IconVisible = true;
            this.btn_dash_update.IconZoom = 90D;
            this.btn_dash_update.ImageIconOverlay = false;
            this.btn_dash_update.Location = new System.Drawing.Point(22, 232);
            this.btn_dash_update.Name = "btn_dash_update";
            this.btn_dash_update.Size = new System.Drawing.Size(129, 36);
            this.btn_dash_update.TabIndex = 48;
            this.btn_dash_update.Click += new System.EventHandler(this.btn_dash_update_Click);
            // 
            // btn_create_class
            // 
            this.btn_create_class.BackColor = System.Drawing.Color.Transparent;
            this.btn_create_class.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_create_class.BackgroundImage")));
            this.btn_create_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create_class.ButtonText = "Create";
            this.btn_create_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btn_create_class.ForeColorHoverState = System.Drawing.Color.White;
            this.btn_create_class.Iconimage = null;
            this.btn_create_class.IconVisible = true;
            this.btn_create_class.IconZoom = 90D;
            this.btn_create_class.ImageIconOverlay = false;
            this.btn_create_class.Location = new System.Drawing.Point(22, 274);
            this.btn_create_class.Name = "btn_create_class";
            this.btn_create_class.Size = new System.Drawing.Size(129, 36);
            this.btn_create_class.TabIndex = 47;
            this.btn_create_class.Click += new System.EventHandler(this.btn_create_class_Click);
            // 
            // btn_join_class
            // 
            this.btn_join_class.BackColor = System.Drawing.Color.Transparent;
            this.btn_join_class.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_join_class.BackgroundImage")));
            this.btn_join_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_join_class.ButtonText = "Join";
            this.btn_join_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_join_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btn_join_class.ForeColorHoverState = System.Drawing.Color.White;
            this.btn_join_class.Iconimage = null;
            this.btn_join_class.IconVisible = true;
            this.btn_join_class.IconZoom = 90D;
            this.btn_join_class.ImageIconOverlay = false;
            this.btn_join_class.Location = new System.Drawing.Point(156, 232);
            this.btn_join_class.Name = "btn_join_class";
            this.btn_join_class.Size = new System.Drawing.Size(127, 36);
            this.btn_join_class.TabIndex = 46;
            this.btn_join_class.Click += new System.EventHandler(this.btn_join_class_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 91);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(15, 399);
            this.bunifuSeparator1.TabIndex = 44;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // btn_send_msg_name
            // 
            this.btn_send_msg_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_send_msg_name.BackgroundImage")));
            this.btn_send_msg_name.Location = new System.Drawing.Point(289, 196);
            this.btn_send_msg_name.Name = "btn_send_msg_name";
            this.btn_send_msg_name.Size = new System.Drawing.Size(24, 24);
            this.btn_send_msg_name.TabIndex = 43;
            this.btn_send_msg_name.TabStop = false;
            this.btn_send_msg_name.Click += new System.EventHandler(this.btn_send_msg_name_Click);
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(15, 78);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(342, 10);
            this.bunifuSeparator6.TabIndex = 42;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // t_info_school
            // 
            this.t_info_school.AutoSize = true;
            this.t_info_school.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_info_school.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_info_school.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.t_info_school.Location = new System.Drawing.Point(18, 125);
            this.t_info_school.Name = "t_info_school";
            this.t_info_school.Size = new System.Drawing.Size(69, 19);
            this.t_info_school.TabIndex = 41;
            this.t_info_school.Text = "School: ";
            this.t_info_school.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.t_info_school.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // t_info_email
            // 
            this.t_info_email.AutoSize = true;
            this.t_info_email.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_info_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_info_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.t_info_email.Location = new System.Drawing.Point(18, 157);
            this.t_info_email.Name = "t_info_email";
            this.t_info_email.Size = new System.Drawing.Size(54, 19);
            this.t_info_email.TabIndex = 40;
            this.t_info_email.Text = "EMail:";
            this.t_info_email.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.t_info_email.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // tb_msg
            // 
            this.tb_msg.Location = new System.Drawing.Point(22, 200);
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(261, 20);
            this.tb_msg.TabIndex = 39;
            this.tb_msg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dashboard_mod_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_pupup_class);
            this.Controls.Add(this.tv_classes);
            this.Controls.Add(this.pan_join);
            this.Controls.Add(this.pan_create_class);
            this.Name = "dashboard_mod_teacher";
            this.Size = new System.Drawing.Size(1932, 1074);
            this.Load += new System.EventHandler(this.dashboard_mod_Load);
            this.pan_create_class.ResumeLayout(false);
            this.pan_create_class.PerformLayout();
            this.pan_join.ResumeLayout(false);
            this.pan_join.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_class_delet)).EndInit();
            this.panel_pupup_class.ResumeLayout(false);
            this.panel_pupup_class.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send_msg_name)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pan_create_class;
        private Bunifu.Framework.UI.BunifuTextbox tb_class_name;
        private Bunifu.Framework.UI.BunifuTextbox tb_class_pw;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel_err;
        private Bunifu.Framework.UI.BunifuCustomLabel alert_create;
        private System.Windows.Forms.ListView tv_classes;
        private System.Windows.Forms.Panel pan_join;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel t_join_class_alert;
        private Bunifu.Framework.UI.BunifuTextbox tb_join_pw;
        private Bunifu.Framework.UI.BunifuTextbox tb_join_name;
        private Bunifu.Framework.UI.BunifuCustomLabel t_class_name;
        private System.Windows.Forms.PictureBox pb_class_delet;
        private System.Windows.Forms.Panel panel_pupup_class;
        private System.Windows.Forms.TextBox tb_msg;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_school;
        private Bunifu.Framework.UI.BunifuCustomLabel t_info_email;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private System.Windows.Forms.PictureBox btn_send_msg_name;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private WindowsFormsControlLibrary1.BunifuThinButton btn_dash_update;
        private WindowsFormsControlLibrary1.BunifuThinButton btn_create_class;
        private WindowsFormsControlLibrary1.BunifuThinButton btn_join_class;
        private WindowsFormsControlLibrary1.BunifuThinButton btn_create;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
        private Bunifu.Framework.UI.BunifuTextbox tb_join_pw_class;
        private Bunifu.Framework.UI.BunifuTextbox tb_class_pw_class;
    }
}
