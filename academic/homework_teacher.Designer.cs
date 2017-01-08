namespace academic
{
    partial class homework_teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homework_teacher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.rtb_hw = new System.Windows.Forms.RichTextBox();
            this.panel_pop = new System.Windows.Forms.Panel();
            this.t_pop_msg = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.t_head_line = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_pop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bunifuThinButton1);
            this.panel1.Controls.Add(this.rtb_hw);
            this.panel1.Location = new System.Drawing.Point(467, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 603);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(20, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 44);
            this.panel2.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 28);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "Set";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(20, 545);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(223, 46);
            this.bunifuThinButton1.TabIndex = 2;
            this.bunifuThinButton1.Click += new System.EventHandler(this.bunifuThinButton1_Click);
            // 
            // rtb_hw
            // 
            this.rtb_hw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_hw.Location = new System.Drawing.Point(20, 84);
            this.rtb_hw.Name = "rtb_hw";
            this.rtb_hw.Size = new System.Drawing.Size(755, 455);
            this.rtb_hw.TabIndex = 1;
            this.rtb_hw.Text = "";
            // 
            // panel_pop
            // 
            this.panel_pop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.panel_pop.Controls.Add(this.t_pop_msg);
            this.panel_pop.Controls.Add(this.t_head_line);
            this.panel_pop.Location = new System.Drawing.Point(982, 0);
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
            // homework_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_pop);
            this.Controls.Add(this.panel1);
            this.Name = "homework_teacher";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_pop.ResumeLayout(false);
            this.panel_pop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
        private System.Windows.Forms.RichTextBox rtb_hw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_pop;
        private Bunifu.Framework.UI.BunifuCustomLabel t_pop_msg;
        private Bunifu.Framework.UI.BunifuCustomLabel t_head_line;
    }
}
