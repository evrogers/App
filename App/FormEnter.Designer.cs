namespace App
{
    partial class FormEnter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnter));
            this.guestLabel = new System.Windows.Forms.Button();
            this.guestEnterButton = new System.Windows.Forms.Button();
            this.adminModeButton = new System.Windows.Forms.Button();
            this.panelGuest = new System.Windows.Forms.Panel();
            this.guestPic = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Button();
            this.showPic = new System.Windows.Forms.PictureBox();
            this.hidePic = new System.Windows.Forms.PictureBox();
            this.adminPassword = new System.Windows.Forms.TextBox();
            this.guestModeButton = new System.Windows.Forms.Button();
            this.adminEnterButton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Button();
            this.adminPic = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelGuest.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePic)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // guestLabel
            // 
            this.guestLabel.BackColor = System.Drawing.Color.Transparent;
            this.guestLabel.FlatAppearance.BorderSize = 0;
            this.guestLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.guestLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.guestLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestLabel.Location = new System.Drawing.Point(365, 198);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(150, 50);
            this.guestLabel.TabIndex = 1;
            this.guestLabel.Text = "Гость";
            this.guestLabel.UseVisualStyleBackColor = false;
            // 
            // guestEnterButton
            // 
            this.guestEnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestEnterButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.guestEnterButton.FlatAppearance.BorderSize = 2;
            this.guestEnterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.guestEnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.guestEnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestEnterButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestEnterButton.Location = new System.Drawing.Point(365, 325);
            this.guestEnterButton.Name = "guestEnterButton";
            this.guestEnterButton.Size = new System.Drawing.Size(150, 37);
            this.guestEnterButton.TabIndex = 2;
            this.guestEnterButton.Text = "Войти";
            this.guestEnterButton.UseVisualStyleBackColor = true;
            this.guestEnterButton.Click += new System.EventHandler(this.guestEnterButton_Click);
            // 
            // adminModeButton
            // 
            this.adminModeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminModeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.adminModeButton.FlatAppearance.BorderSize = 2;
            this.adminModeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.adminModeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.adminModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminModeButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminModeButton.Location = new System.Drawing.Point(300, 380);
            this.adminModeButton.Name = "adminModeButton";
            this.adminModeButton.Size = new System.Drawing.Size(280, 37);
            this.adminModeButton.TabIndex = 3;
            this.adminModeButton.Text = "Режим администратора";
            this.adminModeButton.UseVisualStyleBackColor = true;
            this.adminModeButton.Click += new System.EventHandler(this.adminModeButton_Click);
            // 
            // panelGuest
            // 
            this.panelGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panelGuest.Controls.Add(this.adminModeButton);
            this.panelGuest.Controls.Add(this.guestEnterButton);
            this.panelGuest.Controls.Add(this.guestLabel);
            this.panelGuest.Controls.Add(this.guestPic);
            this.panelGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGuest.Location = new System.Drawing.Point(0, 0);
            this.panelGuest.Name = "panelGuest";
            this.panelGuest.Size = new System.Drawing.Size(858, 454);
            this.panelGuest.TabIndex = 4;
            // 
            // guestPic
            // 
            this.guestPic.BackColor = System.Drawing.Color.Transparent;
            this.guestPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guestPic.BackgroundImage")));
            this.guestPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guestPic.FlatAppearance.BorderSize = 0;
            this.guestPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.guestPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.guestPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestPic.Location = new System.Drawing.Point(365, 42);
            this.guestPic.Name = "guestPic";
            this.guestPic.Size = new System.Drawing.Size(150, 150);
            this.guestPic.TabIndex = 0;
            this.guestPic.UseVisualStyleBackColor = false;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panelAdmin.Controls.Add(this.label1);
            this.panelAdmin.Controls.Add(this.line);
            this.panelAdmin.Controls.Add(this.showPic);
            this.panelAdmin.Controls.Add(this.hidePic);
            this.panelAdmin.Controls.Add(this.adminPassword);
            this.panelAdmin.Controls.Add(this.guestModeButton);
            this.panelAdmin.Controls.Add(this.adminEnterButton);
            this.panelAdmin.Controls.Add(this.adminLabel);
            this.panelAdmin.Controls.Add(this.adminPic);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(858, 454);
            this.panelAdmin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(296, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Пароль";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.line.FlatAppearance.BorderSize = 2;
            this.line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.Location = new System.Drawing.Point(300, 279);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(280, 3);
            this.line.TabIndex = 7;
            this.line.UseVisualStyleBackColor = false;
            // 
            // showPic
            // 
            this.showPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPic.BackgroundImage")));
            this.showPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPic.Location = new System.Drawing.Point(555, 254);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(25, 25);
            this.showPic.TabIndex = 6;
            this.showPic.TabStop = false;
            this.showPic.Visible = false;
            this.showPic.Click += new System.EventHandler(this.showPic_Click);
            // 
            // hidePic
            // 
            this.hidePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidePic.BackgroundImage")));
            this.hidePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePic.Location = new System.Drawing.Point(555, 254);
            this.hidePic.Name = "hidePic";
            this.hidePic.Size = new System.Drawing.Size(25, 25);
            this.hidePic.TabIndex = 5;
            this.hidePic.TabStop = false;
            this.hidePic.Click += new System.EventHandler(this.hidePic_Click);
            // 
            // adminPassword
            // 
            this.adminPassword.AllowDrop = true;
            this.adminPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.adminPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminPassword.ForeColor = System.Drawing.Color.White;
            this.adminPassword.Location = new System.Drawing.Point(296, 254);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.Size = new System.Drawing.Size(286, 25);
            this.adminPassword.TabIndex = 4;
            this.adminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adminPassword.UseSystemPasswordChar = true;
            this.adminPassword.Enter += new System.EventHandler(this.adminPassword_Enter);
            this.adminPassword.Leave += new System.EventHandler(this.adminPassword_Leave);
            // 
            // guestModeButton
            // 
            this.guestModeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestModeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.guestModeButton.FlatAppearance.BorderSize = 2;
            this.guestModeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.guestModeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.guestModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestModeButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.guestModeButton.Location = new System.Drawing.Point(300, 380);
            this.guestModeButton.Name = "guestModeButton";
            this.guestModeButton.Size = new System.Drawing.Size(280, 37);
            this.guestModeButton.TabIndex = 3;
            this.guestModeButton.Text = "Режим гостя";
            this.guestModeButton.UseVisualStyleBackColor = true;
            this.guestModeButton.Click += new System.EventHandler(this.guestModeButton_Click);
            // 
            // adminEnterButton
            // 
            this.adminEnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminEnterButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.adminEnterButton.FlatAppearance.BorderSize = 2;
            this.adminEnterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.adminEnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.adminEnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminEnterButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.adminEnterButton.Location = new System.Drawing.Point(365, 325);
            this.adminEnterButton.Name = "adminEnterButton";
            this.adminEnterButton.Size = new System.Drawing.Size(150, 37);
            this.adminEnterButton.TabIndex = 2;
            this.adminEnterButton.Text = "Войти";
            this.adminEnterButton.UseVisualStyleBackColor = true;
            this.adminEnterButton.Click += new System.EventHandler(this.adminEnterButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminLabel.FlatAppearance.BorderSize = 0;
            this.adminLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.adminLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.adminLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.adminLabel.Location = new System.Drawing.Point(300, 198);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(280, 50);
            this.adminLabel.TabIndex = 1;
            this.adminLabel.Text = "Администратор";
            this.adminLabel.UseVisualStyleBackColor = false;
            // 
            // adminPic
            // 
            this.adminPic.BackColor = System.Drawing.Color.Transparent;
            this.adminPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminPic.BackgroundImage")));
            this.adminPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminPic.FlatAppearance.BorderSize = 0;
            this.adminPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.adminPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.adminPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminPic.Location = new System.Drawing.Point(365, 42);
            this.adminPic.Name = "adminPic";
            this.adminPic.Size = new System.Drawing.Size(150, 150);
            this.adminPic.TabIndex = 0;
            this.adminPic.UseVisualStyleBackColor = false;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panelInfo.Controls.Add(this.button3);
            this.panelInfo.Controls.Add(this.button5);
            this.panelInfo.Controls.Add(this.button4);
            this.panelInfo.Controls.Add(this.button2);
            this.panelInfo.Controls.Add(this.button1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(858, 454);
            this.panelInfo.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button3.Location = new System.Drawing.Point(484, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(374, 159);
            this.button3.TabIndex = 2;
            this.button3.Text = "Авторы: \r\nпреподаватель О.Л. Иткина\r\nучащаяся 4 курса Е.М. Сиволоб\r\n";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(0, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(858, 79);
            this.button5.TabIndex = 4;
            this.button5.Text = "Гомель 2022";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(858, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "  Дальше";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(0, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(858, 83);
            this.button2.TabIndex = 1;
            this.button2.Text = "Электронное учебное пособие по программированию";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(858, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "УО  \"Гомельский торгово-экономический колледж\"  Белкоопсоюза";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(858, 454);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelGuest);
            this.Controls.Add(this.panelAdmin);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormEnter";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEnter_FormClosed);
            this.Load += new System.EventHandler(this.FormEnter_Load);
            this.panelGuest.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePic)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button guestPic;
        private System.Windows.Forms.Button guestLabel;
        private System.Windows.Forms.Button guestEnterButton;
        private System.Windows.Forms.Button adminModeButton;
        private System.Windows.Forms.Panel panelGuest;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button guestModeButton;
        private System.Windows.Forms.Button adminEnterButton;
        private System.Windows.Forms.Button adminLabel;
        private System.Windows.Forms.Button adminPic;
        private System.Windows.Forms.TextBox adminPassword;
        private System.Windows.Forms.PictureBox hidePic;
        private System.Windows.Forms.PictureBox showPic;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}