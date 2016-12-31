namespace academic
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.top_bar = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_login = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.tb_pw = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.alert_login = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_login = new Bunifu.Framework.UI.BunifuDropdown();
            this.tb_login_last_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.t_login = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_login_first_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_login_sel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.btn_reg_sel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_reg = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_age = new Bunifu.Framework.UI.BunifuTextbox();
            this.dd_te_or_pup = new Bunifu.Framework.UI.BunifuDropdown();
            this.reg_alert = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_school = new Bunifu.Framework.UI.BunifuTextbox();
            this.tb_class_pw = new Bunifu.Framework.UI.BunifuTextbox();
            this.tb_class = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_reg = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.tb_pw2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.tb_ln = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_fn = new Bunifu.Framework.UI.BunifuTextbox();
            this.tb_pw1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.tb_tel = new Bunifu.Framework.UI.BunifuTextbox();
            this.tb_email = new Bunifu.Framework.UI.BunifuTextbox();
            this.top_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_login.SuspendLayout();
            this.panel_reg.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_bar
            // 
            this.top_bar.BackColor = System.Drawing.Color.White;
            this.top_bar.Controls.Add(this.pictureBox3);
            this.top_bar.Controls.Add(this.pictureBox1);
            this.top_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.top_bar.Location = new System.Drawing.Point(0, 0);
            this.top_bar.Name = "top_bar";
            this.top_bar.Size = new System.Drawing.Size(532, 36);
            this.top_bar.TabIndex = 1;
            this.top_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_bar_MouseDown);
            this.top_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_bar_MouseMove);
            this.top_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_bar_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(458, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 29);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(493, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_login.ForeColorHoverState = System.Drawing.Color.White;
            this.btn_login.Iconimage = null;
            this.btn_login.IconVisible = true;
            this.btn_login.IconZoom = 90D;
            this.btn_login.ImageIconOverlay = false;
            this.btn_login.Location = new System.Drawing.Point(69, 428);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(272, 46);
            this.btn_login.TabIndex = 3;
            this.btn_login.Click += new System.EventHandler(this.bunifuThinButton1_Click);
            // 
            // tb_pw
            // 
            this.tb_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_pw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_pw.BackgroundImage")));
            this.tb_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_pw.Icon = ((System.Drawing.Image)(resources.GetObject("tb_pw.Icon")));
            this.tb_pw.Location = new System.Drawing.Point(69, 203);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(272, 48);
            this.tb_pw.TabIndex = 6;
            this.tb_pw.text = "User Password";
            this.tb_pw.OnTextChange += new System.EventHandler(this.tb_pw_OnTextChange);
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.Transparent;
            this.panel_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_login.Controls.Add(this.alert_login);
            this.panel_login.Controls.Add(this.dd_login);
            this.panel_login.Controls.Add(this.tb_login_last_name);
            this.panel_login.Controls.Add(this.t_login);
            this.panel_login.Controls.Add(this.tb_login_first_name);
            this.panel_login.Controls.Add(this.tb_pw);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Location = new System.Drawing.Point(53, 116);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(407, 496);
            this.panel_login.TabIndex = 7;
            // 
            // alert_login
            // 
            this.alert_login.AutoSize = true;
            this.alert_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.alert_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.alert_login.Location = new System.Drawing.Point(65, 301);
            this.alert_login.Name = "alert_login";
            this.alert_login.Size = new System.Drawing.Size(0, 19);
            this.alert_login.TabIndex = 19;
            // 
            // dd_login
            // 
            this.dd_login.BackColor = System.Drawing.Color.Transparent;
            this.dd_login.ForeColor = System.Drawing.Color.White;
            this.dd_login.Items = new string[] {
        "Teacher",
        "Pupil"};
            this.dd_login.Location = new System.Drawing.Point(69, 256);
            this.dd_login.Name = "dd_login";
            this.dd_login.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.dd_login.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.dd_login.selectedIndex = -1;
            this.dd_login.Size = new System.Drawing.Size(272, 35);
            this.dd_login.TabIndex = 20;
            this.dd_login.onItemSelected += new System.EventHandler(this.dd_login_onItemSelected);
            // 
            // tb_login_last_name
            // 
            this.tb_login_last_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_login_last_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_login_last_name.BackgroundImage")));
            this.tb_login_last_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_login_last_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_login_last_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_login_last_name.Icon")));
            this.tb_login_last_name.Location = new System.Drawing.Point(69, 140);
            this.tb_login_last_name.Name = "tb_login_last_name";
            this.tb_login_last_name.Size = new System.Drawing.Size(272, 65);
            this.tb_login_last_name.TabIndex = 19;
            this.tb_login_last_name.text = "Last Name";
            // 
            // t_login
            // 
            this.t_login.AutoSize = true;
            this.t_login.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.t_login.Location = new System.Drawing.Point(83, 26);
            this.t_login.Name = "t_login";
            this.t_login.Size = new System.Drawing.Size(191, 33);
            this.t_login.TabIndex = 7;
            this.t_login.Text = "Login as pupil";
            this.t_login.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // tb_login_first_name
            // 
            this.tb_login_first_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_login_first_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_login_first_name.BackgroundImage")));
            this.tb_login_first_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_login_first_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_login_first_name.Icon = ((System.Drawing.Image)(resources.GetObject("tb_login_first_name.Icon")));
            this.tb_login_first_name.Location = new System.Drawing.Point(69, 78);
            this.tb_login_first_name.Name = "tb_login_first_name";
            this.tb_login_first_name.Size = new System.Drawing.Size(272, 65);
            this.tb_login_first_name.TabIndex = 18;
            this.tb_login_first_name.text = "First Name";
            this.tb_login_first_name.OnTextChange += new System.EventHandler(this.tb_login_first_name_OnTextChange);
            this.tb_login_first_name.Click += new System.EventHandler(this.tb_login_first_name_Click);
            this.tb_login_first_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_login_first_name_MouseDown);
            this.tb_login_first_name.MouseEnter += new System.EventHandler(this.tb_login_first_name_MouseEnter);
            // 
            // btn_login_sel
            // 
            this.btn_login_sel.Activecolor = System.Drawing.Color.Transparent;
            this.btn_login_sel.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_sel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login_sel.BorderRadius = 0;
            this.btn_login_sel.ButtonText = "                   Login";
            this.btn_login_sel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_sel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login_sel.Iconimage = null;
            this.btn_login_sel.Iconimage_right = null;
            this.btn_login_sel.Iconimage_right_Selected = null;
            this.btn_login_sel.Iconimage_Selected = null;
            this.btn_login_sel.IconZoom = 90D;
            this.btn_login_sel.IsTab = false;
            this.btn_login_sel.Location = new System.Drawing.Point(68, 62);
            this.btn_login_sel.Name = "btn_login_sel";
            this.btn_login_sel.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_login_sel.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_login_sel.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_login_sel.selected = false;
            this.btn_login_sel.Size = new System.Drawing.Size(194, 39);
            this.btn_login_sel.TabIndex = 8;
            this.btn_login_sel.Textcolor = System.Drawing.Color.White;
            this.btn_login_sel.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_sel.Click += new System.EventHandler(this.btn_login_sel_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.line.LineThickness = 1;
            this.line.Location = new System.Drawing.Point(123, 100);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(87, 10);
            this.line.TabIndex = 9;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // btn_reg_sel
            // 
            this.btn_reg_sel.Activecolor = System.Drawing.Color.Transparent;
            this.btn_reg_sel.BackColor = System.Drawing.Color.Transparent;
            this.btn_reg_sel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reg_sel.BorderRadius = 0;
            this.btn_reg_sel.ButtonText = "               Register";
            this.btn_reg_sel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reg_sel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_reg_sel.Iconimage = null;
            this.btn_reg_sel.Iconimage_right = null;
            this.btn_reg_sel.Iconimage_right_Selected = null;
            this.btn_reg_sel.Iconimage_Selected = null;
            this.btn_reg_sel.IconZoom = 90D;
            this.btn_reg_sel.IsTab = false;
            this.btn_reg_sel.Location = new System.Drawing.Point(248, 62);
            this.btn_reg_sel.Name = "btn_reg_sel";
            this.btn_reg_sel.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_reg_sel.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_reg_sel.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_reg_sel.selected = false;
            this.btn_reg_sel.Size = new System.Drawing.Size(194, 39);
            this.btn_reg_sel.TabIndex = 10;
            this.btn_reg_sel.Textcolor = System.Drawing.Color.White;
            this.btn_reg_sel.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg_sel.Click += new System.EventHandler(this.btn_reg_sel_Click);
            // 
            // panel_reg
            // 
            this.panel_reg.BackColor = System.Drawing.Color.Transparent;
            this.panel_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_reg.Controls.Add(this.tb_tel);
            this.panel_reg.Controls.Add(this.tb_email);
            this.panel_reg.Controls.Add(this.bunifuCustomLabel3);
            this.panel_reg.Controls.Add(this.tb_age);
            this.panel_reg.Controls.Add(this.dd_te_or_pup);
            this.panel_reg.Controls.Add(this.reg_alert);
            this.panel_reg.Controls.Add(this.tb_school);
            this.panel_reg.Controls.Add(this.tb_class_pw);
            this.panel_reg.Controls.Add(this.tb_class);
            this.panel_reg.Controls.Add(this.btn_reg);
            this.panel_reg.Controls.Add(this.tb_pw2);
            this.panel_reg.Controls.Add(this.tb_ln);
            this.panel_reg.Controls.Add(this.bunifuCustomLabel2);
            this.panel_reg.Controls.Add(this.tb_fn);
            this.panel_reg.Controls.Add(this.tb_pw1);
            this.panel_reg.Location = new System.Drawing.Point(560, 116);
            this.panel_reg.Name = "panel_reg";
            this.panel_reg.Size = new System.Drawing.Size(487, 496);
            this.panel_reg.TabIndex = 8;
            this.panel_reg.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_reg_Paint);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(242, 201);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(0, 19);
            this.bunifuCustomLabel3.TabIndex = 18;
            // 
            // tb_age
            // 
            this.tb_age.AccessibleName = "tb_class";
            this.tb_age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_age.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_age.BackgroundImage")));
            this.tb_age.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_age.Icon = ((System.Drawing.Image)(resources.GetObject("tb_age.Icon")));
            this.tb_age.Location = new System.Drawing.Point(44, 281);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(194, 57);
            this.tb_age.TabIndex = 17;
            this.tb_age.Tag = "tb_age";
            this.tb_age.text = "Age";
            // 
            // dd_te_or_pup
            // 
            this.dd_te_or_pup.BackColor = System.Drawing.Color.Transparent;
            this.dd_te_or_pup.ForeColor = System.Drawing.Color.White;
            this.dd_te_or_pup.Items = new string[] {
        "Teacher",
        "Pupil"};
            this.dd_te_or_pup.Location = new System.Drawing.Point(262, 78);
            this.dd_te_or_pup.Name = "dd_te_or_pup";
            this.dd_te_or_pup.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.dd_te_or_pup.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.dd_te_or_pup.selectedIndex = -1;
            this.dd_te_or_pup.Size = new System.Drawing.Size(194, 35);
            this.dd_te_or_pup.TabIndex = 16;
            this.dd_te_or_pup.onItemSelected += new System.EventHandler(this.dd_te_or_pup_onItemSelected);
            // 
            // reg_alert
            // 
            this.reg_alert.AutoSize = true;
            this.reg_alert.Cursor = System.Windows.Forms.Cursors.Default;
            this.reg_alert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_alert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.reg_alert.Location = new System.Drawing.Point(258, 301);
            this.reg_alert.Name = "reg_alert";
            this.reg_alert.Size = new System.Drawing.Size(0, 19);
            this.reg_alert.TabIndex = 15;
            // 
            // tb_school
            // 
            this.tb_school.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_school.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_school.BackgroundImage")));
            this.tb_school.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_school.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_school.Icon = ((System.Drawing.Image)(resources.GetObject("tb_school.Icon")));
            this.tb_school.Location = new System.Drawing.Point(44, 69);
            this.tb_school.Name = "tb_school";
            this.tb_school.Size = new System.Drawing.Size(194, 57);
            this.tb_school.TabIndex = 14;
            this.tb_school.text = "School name";
            // 
            // tb_class_pw
            // 
            this.tb_class_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_class_pw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_class_pw.BackgroundImage")));
            this.tb_class_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_class_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_class_pw.Icon = ((System.Drawing.Image)(resources.GetObject("tb_class_pw.Icon")));
            this.tb_class_pw.Location = new System.Drawing.Point(262, 234);
            this.tb_class_pw.Name = "tb_class_pw";
            this.tb_class_pw.Size = new System.Drawing.Size(194, 57);
            this.tb_class_pw.TabIndex = 13;
            this.tb_class_pw.text = "Class Password";
            this.tb_class_pw.OnTextChange += new System.EventHandler(this.tb_class_pw_OnTextChange);
            // 
            // tb_class
            // 
            this.tb_class.AccessibleName = "tb_class";
            this.tb_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_class.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_class.BackgroundImage")));
            this.tb_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_class.Icon = ((System.Drawing.Image)(resources.GetObject("tb_class.Icon")));
            this.tb_class.Location = new System.Drawing.Point(44, 234);
            this.tb_class.Name = "tb_class";
            this.tb_class.Size = new System.Drawing.Size(194, 57);
            this.tb_class.TabIndex = 12;
            this.tb_class.Tag = "tb_class";
            this.tb_class.text = "Class name";
            // 
            // btn_reg
            // 
            this.btn_reg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reg.BackgroundImage")));
            this.btn_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reg.ButtonText = "Sign Up";
            this.btn_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_reg.ForeColorHoverState = System.Drawing.Color.White;
            this.btn_reg.Iconimage = null;
            this.btn_reg.IconVisible = true;
            this.btn_reg.IconZoom = 90D;
            this.btn_reg.ImageIconOverlay = false;
            this.btn_reg.Location = new System.Drawing.Point(115, 428);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(272, 46);
            this.btn_reg.TabIndex = 8;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // tb_pw2
            // 
            this.tb_pw2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_pw2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_pw2.BackgroundImage")));
            this.tb_pw2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_pw2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_pw2.Icon = ((System.Drawing.Image)(resources.GetObject("tb_pw2.Icon")));
            this.tb_pw2.Location = new System.Drawing.Point(264, 180);
            this.tb_pw2.Name = "tb_pw2";
            this.tb_pw2.Size = new System.Drawing.Size(194, 57);
            this.tb_pw2.TabIndex = 10;
            this.tb_pw2.text = "Password Confirm";
            // 
            // tb_ln
            // 
            this.tb_ln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_ln.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_ln.BackgroundImage")));
            this.tb_ln.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_ln.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_ln.Icon = ((System.Drawing.Image)(resources.GetObject("tb_ln.Icon")));
            this.tb_ln.Location = new System.Drawing.Point(264, 126);
            this.tb_ln.Name = "tb_ln";
            this.tb_ln.Size = new System.Drawing.Size(192, 48);
            this.tb_ln.TabIndex = 9;
            this.tb_ln.text = "Last Name";
            this.tb_ln.OnTextChange += new System.EventHandler(this.bunifuTextbox4_OnTextChange);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(181, 26);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(119, 33);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Sign Up!";
            // 
            // tb_fn
            // 
            this.tb_fn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_fn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_fn.BackgroundImage")));
            this.tb_fn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_fn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_fn.Icon = ((System.Drawing.Image)(resources.GetObject("tb_fn.Icon")));
            this.tb_fn.Location = new System.Drawing.Point(46, 126);
            this.tb_fn.Name = "tb_fn";
            this.tb_fn.Size = new System.Drawing.Size(192, 48);
            this.tb_fn.TabIndex = 5;
            this.tb_fn.text = "First Name";
            this.tb_fn.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange_1);
            // 
            // tb_pw1
            // 
            this.tb_pw1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_pw1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_pw1.BackgroundImage")));
            this.tb_pw1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_pw1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_pw1.Icon = ((System.Drawing.Image)(resources.GetObject("tb_pw1.Icon")));
            this.tb_pw1.Location = new System.Drawing.Point(46, 180);
            this.tb_pw1.Name = "tb_pw1";
            this.tb_pw1.Size = new System.Drawing.Size(194, 57);
            this.tb_pw1.TabIndex = 6;
            this.tb_pw1.text = "Password";
            // 
            // tb_tel
            // 
            this.tb_tel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_tel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_tel.BackgroundImage")));
            this.tb_tel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_tel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_tel.Icon = ((System.Drawing.Image)(resources.GetObject("tb_tel.Icon")));
            this.tb_tel.Location = new System.Drawing.Point(262, 344);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(192, 48);
            this.tb_tel.TabIndex = 20;
            this.tb_tel.text = "Telephone number";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tb_email.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_email.BackgroundImage")));
            this.tb_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.tb_email.Icon = ((System.Drawing.Image)(resources.GetObject("tb_email.Icon")));
            this.tb_email.Location = new System.Drawing.Point(44, 344);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(192, 48);
            this.tb_email.TabIndex = 19;
            this.tb_email.text = "Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(532, 624);
            this.Controls.Add(this.panel_reg);
            this.Controls.Add(this.btn_reg_sel);
            this.Controls.Add(this.line);
            this.Controls.Add(this.btn_login_sel);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.top_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.top_bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_reg.ResumeLayout(false);
            this.panel_reg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_bar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuThinButton btn_login;
        private Bunifu.Framework.UI.BunifuTextbox tb_pw;
        private System.Windows.Forms.Panel panel_login;
        private Bunifu.Framework.UI.BunifuCustomLabel t_login;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login_sel;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private Bunifu.Framework.UI.BunifuFlatButton btn_reg_sel;
        private System.Windows.Forms.Panel panel_reg;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuTextbox tb_fn;
        private Bunifu.Framework.UI.BunifuTextbox tb_pw1;
        private Bunifu.Framework.UI.BunifuTextbox tb_ln;
        private WindowsFormsControlLibrary1.BunifuThinButton btn_reg;
        private Bunifu.Framework.UI.BunifuTextbox tb_pw2;
        private Bunifu.Framework.UI.BunifuTextbox tb_school;
        private Bunifu.Framework.UI.BunifuTextbox tb_class_pw;
        private Bunifu.Framework.UI.BunifuTextbox tb_class;
        private Bunifu.Framework.UI.BunifuCustomLabel reg_alert;
        private Bunifu.Framework.UI.BunifuDropdown dd_te_or_pup;
        private Bunifu.Framework.UI.BunifuTextbox tb_age;
        private Bunifu.Framework.UI.BunifuTextbox tb_login_last_name;
        private Bunifu.Framework.UI.BunifuTextbox tb_login_first_name;
        private Bunifu.Framework.UI.BunifuDropdown dd_login;
        private Bunifu.Framework.UI.BunifuCustomLabel alert_login;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuTextbox tb_tel;
        private Bunifu.Framework.UI.BunifuTextbox tb_email;
    }
}