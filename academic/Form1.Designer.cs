namespace academic
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MENU2 = new System.Windows.Forms.Panel();
            this.btn_mail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.t_alert_count = new System.Windows.Forms.Label();
            this.pb_alert = new System.Windows.Forms.PictureBox();
            this.t_user_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_homework = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_chat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_class = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_alert = new System.Windows.Forms.Panel();
            this.lb_msgs_alert = new System.Windows.Forms.ListBox();
            this.btn_sendMSG_alert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CONTENT = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.top_bar = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MENU2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_alert)).BeginInit();
            this.panel_alert.SuspendLayout();
            this.CONTENT.SuspendLayout();
            this.top_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MENU2
            // 
            this.MENU2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.MENU2.Controls.Add(this.panel_alert);
            this.MENU2.Controls.Add(this.btn_mail);
            this.MENU2.Controls.Add(this.pictureBox4);
            this.MENU2.Controls.Add(this.panel2);
            this.MENU2.Controls.Add(this.panel1);
            this.MENU2.Controls.Add(this.btn_dashboard);
            this.MENU2.Controls.Add(this.btn_settings);
            this.MENU2.Controls.Add(this.bunifuCustomLabel3);
            this.MENU2.Controls.Add(this.btn_homework);
            this.MENU2.Controls.Add(this.btn_chat);
            this.MENU2.Controls.Add(this.btn_class);
            this.MENU2.Controls.Add(this.bunifuCustomLabel1);
            this.MENU2.Dock = System.Windows.Forms.DockStyle.Left;
            this.MENU2.Location = new System.Drawing.Point(0, 0);
            this.MENU2.Name = "MENU2";
            this.MENU2.Size = new System.Drawing.Size(301, 602);
            this.MENU2.TabIndex = 2;
            // 
            // btn_mail
            // 
            this.btn_mail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_mail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mail.BorderRadius = 5;
            this.btn_mail.ButtonText = "                      MAILS";
            this.btn_mail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mail.Iconcolor = System.Drawing.Color.Turquoise;
            this.btn_mail.Iconimage = null;
            this.btn_mail.Iconimage_right = null;
            this.btn_mail.Iconimage_right_Selected = null;
            this.btn_mail.Iconimage_Selected = null;
            this.btn_mail.IconZoom = 90D;
            this.btn_mail.IsTab = false;
            this.btn_mail.Location = new System.Drawing.Point(29, 273);
            this.btn_mail.Name = "btn_mail";
            this.btn_mail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_mail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_mail.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_mail.selected = false;
            this.btn_mail.Size = new System.Drawing.Size(221, 39);
            this.btn_mail.TabIndex = 28;
            this.btn_mail.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_mail.TextFont = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mail.Click += new System.EventHandler(this.btn_mail_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 574);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 28);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(296, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 2000);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.t_alert_count);
            this.panel1.Controls.Add(this.pb_alert);
            this.panel1.Controls.Add(this.t_user_name);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 36);
            this.panel1.TabIndex = 1;
            // 
            // t_alert_count
            // 
            this.t_alert_count.AutoSize = true;
            this.t_alert_count.BackColor = System.Drawing.Color.Transparent;
            this.t_alert_count.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_alert_count.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.t_alert_count.Location = new System.Drawing.Point(200, 20);
            this.t_alert_count.Name = "t_alert_count";
            this.t_alert_count.Size = new System.Drawing.Size(15, 16);
            this.t_alert_count.TabIndex = 0;
            this.t_alert_count.Text = "0";
            // 
            // pb_alert
            // 
            this.pb_alert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_alert.BackgroundImage")));
            this.pb_alert.Location = new System.Drawing.Point(175, 3);
            this.pb_alert.Name = "pb_alert";
            this.pb_alert.Size = new System.Drawing.Size(29, 34);
            this.pb_alert.TabIndex = 11;
            this.pb_alert.TabStop = false;
            this.pb_alert.Click += new System.EventHandler(this.pb_alert_Click);
            // 
            // t_user_name
            // 
            this.t_user_name.AutoSize = true;
            this.t_user_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_user_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_user_name.ForeColor = System.Drawing.Color.White;
            this.t_user_name.Location = new System.Drawing.Point(3, 9);
            this.t_user_name.Name = "t_user_name";
            this.t_user_name.Size = new System.Drawing.Size(166, 19);
            this.t_user_name.TabIndex = 10;
            this.t_user_name.Text = "FirstName,LastName";
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dashboard.BorderRadius = 5;
            this.btn_dashboard.ButtonText = "                       DASHBOARD";
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dashboard.Iconcolor = System.Drawing.Color.Turquoise;
            this.btn_dashboard.Iconimage = null;
            this.btn_dashboard.Iconimage_right = null;
            this.btn_dashboard.Iconimage_right_Selected = null;
            this.btn_dashboard.Iconimage_Selected = null;
            this.btn_dashboard.IconZoom = 90D;
            this.btn_dashboard.IsTab = false;
            this.btn_dashboard.Location = new System.Drawing.Point(29, 93);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_dashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_dashboard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_dashboard.selected = true;
            this.btn_dashboard.Size = new System.Drawing.Size(221, 39);
            this.btn_dashboard.TabIndex = 13;
            this.btn_dashboard.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_dashboard.TextFont = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // btn_settings
            // 
            this.btn_settings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.BorderRadius = 5;
            this.btn_settings.ButtonText = "                        SETTINGS";
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.Iconcolor = System.Drawing.Color.Turquoise;
            this.btn_settings.Iconimage = null;
            this.btn_settings.Iconimage_right = null;
            this.btn_settings.Iconimage_right_Selected = null;
            this.btn_settings.Iconimage_Selected = null;
            this.btn_settings.IconZoom = 90D;
            this.btn_settings.IsTab = false;
            this.btn_settings.Location = new System.Drawing.Point(29, 339);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_settings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_settings.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_settings.selected = false;
            this.btn_settings.Size = new System.Drawing.Size(212, 39);
            this.btn_settings.TabIndex = 8;
            this.btn_settings.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_settings.TextFont = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(25, 317);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(75, 19);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Account";
            // 
            // btn_homework
            // 
            this.btn_homework.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_homework.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_homework.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_homework.BorderRadius = 5;
            this.btn_homework.ButtonText = "                      HOMEWORK";
            this.btn_homework.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_homework.Iconcolor = System.Drawing.Color.Turquoise;
            this.btn_homework.Iconimage = null;
            this.btn_homework.Iconimage_right = null;
            this.btn_homework.Iconimage_right_Selected = null;
            this.btn_homework.Iconimage_Selected = null;
            this.btn_homework.IconZoom = 90D;
            this.btn_homework.IsTab = false;
            this.btn_homework.Location = new System.Drawing.Point(29, 228);
            this.btn_homework.Name = "btn_homework";
            this.btn_homework.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_homework.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_homework.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_homework.selected = false;
            this.btn_homework.Size = new System.Drawing.Size(221, 39);
            this.btn_homework.TabIndex = 6;
            this.btn_homework.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_homework.TextFont = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homework.Click += new System.EventHandler(this.btn_homework_Click);
            // 
            // btn_chat
            // 
            this.btn_chat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_chat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chat.BorderRadius = 5;
            this.btn_chat.ButtonText = "                       CHAT";
            this.btn_chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chat.Iconcolor = System.Drawing.Color.Turquoise;
            this.btn_chat.Iconimage = null;
            this.btn_chat.Iconimage_right = null;
            this.btn_chat.Iconimage_right_Selected = null;
            this.btn_chat.Iconimage_Selected = null;
            this.btn_chat.IconZoom = 90D;
            this.btn_chat.IsTab = false;
            this.btn_chat.Location = new System.Drawing.Point(29, 183);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_chat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_chat.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_chat.selected = false;
            this.btn_chat.Size = new System.Drawing.Size(221, 39);
            this.btn_chat.TabIndex = 5;
            this.btn_chat.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_chat.TextFont = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chat.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_class
            // 
            this.btn_class.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_class.BorderRadius = 5;
            this.btn_class.ButtonText = "                       CLASS";
            this.btn_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_class.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_class.Iconcolor = System.Drawing.Color.Turquoise;
            this.btn_class.Iconimage = null;
            this.btn_class.Iconimage_right = null;
            this.btn_class.Iconimage_right_Selected = null;
            this.btn_class.Iconimage_Selected = null;
            this.btn_class.IconZoom = 90D;
            this.btn_class.IsTab = false;
            this.btn_class.Location = new System.Drawing.Point(29, 138);
            this.btn_class.Name = "btn_class";
            this.btn_class.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_class.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btn_class.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_class.selected = true;
            this.btn_class.Size = new System.Drawing.Size(221, 39);
            this.btn_class.TabIndex = 4;
            this.btn_class.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_class.TextFont = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_class.Click += new System.EventHandler(this.dash_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 53);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(48, 19);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Main";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // panel_alert
            // 
            this.panel_alert.BackColor = System.Drawing.Color.White;
            this.panel_alert.Controls.Add(this.lb_msgs_alert);
            this.panel_alert.Controls.Add(this.btn_sendMSG_alert);
            this.panel_alert.Location = new System.Drawing.Point(7, 43);
            this.panel_alert.Name = "panel_alert";
            this.panel_alert.Size = new System.Drawing.Size(287, 270);
            this.panel_alert.TabIndex = 1;
            this.panel_alert.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel_alert_MouseDoubleClick);
            // 
            // lb_msgs_alert
            // 
            this.lb_msgs_alert.BackColor = System.Drawing.Color.White;
            this.lb_msgs_alert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_msgs_alert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_msgs_alert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lb_msgs_alert.FormattingEnabled = true;
            this.lb_msgs_alert.ItemHeight = 19;
            this.lb_msgs_alert.Location = new System.Drawing.Point(17, 10);
            this.lb_msgs_alert.Name = "lb_msgs_alert";
            this.lb_msgs_alert.Size = new System.Drawing.Size(241, 171);
            this.lb_msgs_alert.TabIndex = 3;
            this.lb_msgs_alert.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_msgs_alert_MouseDoubleClick);
            // 
            // btn_sendMSG_alert
            // 
            this.btn_sendMSG_alert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_sendMSG_alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_sendMSG_alert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sendMSG_alert.BorderRadius = 0;
            this.btn_sendMSG_alert.ButtonText = "SendMessage";
            this.btn_sendMSG_alert.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_sendMSG_alert.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_sendMSG_alert.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_sendMSG_alert.Iconimage")));
            this.btn_sendMSG_alert.Iconimage_right = null;
            this.btn_sendMSG_alert.Iconimage_right_Selected = null;
            this.btn_sendMSG_alert.Iconimage_Selected = null;
            this.btn_sendMSG_alert.IconZoom = 90D;
            this.btn_sendMSG_alert.IsTab = false;
            this.btn_sendMSG_alert.Location = new System.Drawing.Point(17, 195);
            this.btn_sendMSG_alert.Name = "btn_sendMSG_alert";
            this.btn_sendMSG_alert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_sendMSG_alert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btn_sendMSG_alert.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_sendMSG_alert.selected = false;
            this.btn_sendMSG_alert.Size = new System.Drawing.Size(241, 48);
            this.btn_sendMSG_alert.TabIndex = 0;
            this.btn_sendMSG_alert.Textcolor = System.Drawing.Color.White;
            this.btn_sendMSG_alert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CONTENT
            // 
            this.CONTENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.CONTENT.Controls.Add(this.panel3);
            this.CONTENT.Controls.Add(this.top_bar);
            this.CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CONTENT.Location = new System.Drawing.Point(0, 0);
            this.CONTENT.Name = "CONTENT";
            this.CONTENT.Size = new System.Drawing.Size(1271, 602);
            this.CONTENT.TabIndex = 4;
            this.CONTENT.Paint += new System.Windows.Forms.PaintEventHandler(this.CONTENT_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(-15, -15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 1;
            // 
            // top_bar
            // 
            this.top_bar.BackColor = System.Drawing.Color.White;
            this.top_bar.Controls.Add(this.pictureBox3);
            this.top_bar.Controls.Add(this.pictureBox2);
            this.top_bar.Controls.Add(this.pictureBox1);
            this.top_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.top_bar.Location = new System.Drawing.Point(0, 0);
            this.top_bar.Name = "top_bar";
            this.top_bar.Size = new System.Drawing.Size(1271, 36);
            this.top_bar.TabIndex = 0;
            this.top_bar.Paint += new System.Windows.Forms.PaintEventHandler(this.top_bar_Paint);
            this.top_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_bar_MouseDown);
            this.top_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_bar_MouseMove);
            this.top_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_bar_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Location = new System.Drawing.Point(1182, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 36);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(1211, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 36);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(1241, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 36);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 602);
            this.Controls.Add(this.MENU2);
            this.Controls.Add(this.CONTENT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MENU2.ResumeLayout(false);
            this.MENU2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_alert)).EndInit();
            this.panel_alert.ResumeLayout(false);
            this.CONTENT.ResumeLayout(false);
            this.top_bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MENU2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_class;
        private Bunifu.Framework.UI.BunifuFlatButton btn_chat;
        private Bunifu.Framework.UI.BunifuFlatButton btn_homework;
        private Bunifu.Framework.UI.BunifuFlatButton btn_settings;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Panel CONTENT;
        private System.Windows.Forms.Panel top_bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel t_user_name;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_alert;
        private System.Windows.Forms.Panel panel_alert;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label t_alert_count;
        private Bunifu.Framework.UI.BunifuFlatButton btn_sendMSG_alert;
        private System.Windows.Forms.ListBox lb_msgs_alert;
        private Bunifu.Framework.UI.BunifuFlatButton btn_mail;
        private System.Windows.Forms.Panel panel3;
    }
}

