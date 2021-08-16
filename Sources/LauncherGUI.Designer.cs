
namespace VRPLancher.Sources
{
    partial class LauncherGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherGUI));
            this.shield = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.showMojangPassword = new System.Windows.Forms.CheckBox();
            this.mojangPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mojangEmail = new System.Windows.Forms.TextBox();
            this.nickInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closeLauncher = new System.Windows.Forms.CheckBox();
            this.autoJoinServer = new System.Windows.Forms.CheckBox();
            this.launcherProgress = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.launch = new System.Windows.Forms.Button();
            this.useMojangAuth = new System.Windows.Forms.CheckBox();
            this.percentProgress = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ramInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shield)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramInput)).BeginInit();
            this.SuspendLayout();
            // 
            // shield
            // 
            this.shield.BackColor = System.Drawing.Color.Transparent;
            this.shield.Image = global::VRPLancher.Properties.Resources.uac;
            this.shield.Location = new System.Drawing.Point(26, 15);
            this.shield.Name = "shield";
            this.shield.Size = new System.Drawing.Size(199, 282);
            this.shield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shield.TabIndex = 0;
            this.shield.TabStop = false;
            this.shield.Tag = "Все файлы лаунчера не менялись! Администрация доверяет вам =)";
            this.shield.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "VRP Launcher";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.showMojangPassword);
            this.groupBox1.Controls.Add(this.mojangPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(367, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mojang";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(7, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Сохранить пароль";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // showMojangPassword
            // 
            this.showMojangPassword.AutoSize = true;
            this.showMojangPassword.BackColor = System.Drawing.Color.Transparent;
            this.showMojangPassword.Location = new System.Drawing.Point(6, 110);
            this.showMojangPassword.Name = "showMojangPassword";
            this.showMojangPassword.Size = new System.Drawing.Size(134, 19);
            this.showMojangPassword.TabIndex = 2;
            this.showMojangPassword.Text = "Показывать пароль";
            this.showMojangPassword.UseVisualStyleBackColor = false;
            this.showMojangPassword.CheckedChanged += new System.EventHandler(this.showMojangPassword_CheckedChanged);
            // 
            // mojangPassword
            // 
            this.mojangPassword.Location = new System.Drawing.Point(6, 81);
            this.mojangPassword.Name = "mojangPassword";
            this.mojangPassword.PasswordChar = '*';
            this.mojangPassword.Size = new System.Drawing.Size(139, 23);
            this.mojangPassword.TabIndex = 1;
            this.mojangPassword.TextChanged += new System.EventHandler(this.mojangPassword_TextChanged);
            this.mojangPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mojangPassword_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Пароль";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mojangEmail);
            this.panel1.Location = new System.Drawing.Point(0, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 140);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-Mail";
            // 
            // mojangEmail
            // 
            this.mojangEmail.Location = new System.Drawing.Point(6, 24);
            this.mojangEmail.Name = "mojangEmail";
            this.mojangEmail.Size = new System.Drawing.Size(139, 23);
            this.mojangEmail.TabIndex = 1;
            this.mojangEmail.Tag = "Файлы лаунчера не повреждены, и поэтому администрация доверяет вам! =)";
            this.mojangEmail.TextChanged += new System.EventHandler(this.mojangEmail_TextChanged);
            // 
            // nickInput
            // 
            this.nickInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nickInput.Location = new System.Drawing.Point(204, 102);
            this.nickInput.MaxLength = 32;
            this.nickInput.Name = "nickInput";
            this.nickInput.Size = new System.Drawing.Size(147, 23);
            this.nickInput.TabIndex = 3;
            this.nickInput.Tag = "Ник в игре";
            this.nickInput.Text = "BlackLightHack";
            this.nickInput.TextChanged += new System.EventHandler(this.nickInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(204, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ник:";
            // 
            // closeLauncher
            // 
            this.closeLauncher.AutoSize = true;
            this.closeLauncher.BackColor = System.Drawing.Color.Transparent;
            this.closeLauncher.Location = new System.Drawing.Point(204, 131);
            this.closeLauncher.Name = "closeLauncher";
            this.closeLauncher.Size = new System.Drawing.Size(121, 19);
            this.closeLauncher.TabIndex = 5;
            this.closeLauncher.Text = "Закрыть лаунчер";
            this.closeLauncher.UseVisualStyleBackColor = false;
            // 
            // autoJoinServer
            // 
            this.autoJoinServer.AutoSize = true;
            this.autoJoinServer.BackColor = System.Drawing.Color.Transparent;
            this.autoJoinServer.Location = new System.Drawing.Point(204, 157);
            this.autoJoinServer.Name = "autoJoinServer";
            this.autoJoinServer.Size = new System.Drawing.Size(144, 34);
            this.autoJoinServer.TabIndex = 6;
            this.autoJoinServer.Text = "Автоматически зайти\nна сервер";
            this.autoJoinServer.UseVisualStyleBackColor = false;
            // 
            // launcherProgress
            // 
            this.launcherProgress.Location = new System.Drawing.Point(13, 322);
            this.launcherProgress.MarqueeAnimationSpeed = 10;
            this.launcherProgress.Name = "launcherProgress";
            this.launcherProgress.Size = new System.Drawing.Size(499, 23);
            this.launcherProgress.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(26, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Перепроверить целостность файлов";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // launch
            // 
            this.launch.BackColor = System.Drawing.Color.Lavender;
            this.launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.launch.Location = new System.Drawing.Point(367, 259);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(151, 38);
            this.launch.TabIndex = 10;
            this.launch.Text = "Запуск!";
            this.launch.UseVisualStyleBackColor = false;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // useMojangAuth
            // 
            this.useMojangAuth.AutoSize = true;
            this.useMojangAuth.BackColor = System.Drawing.Color.Transparent;
            this.useMojangAuth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.useMojangAuth.Location = new System.Drawing.Point(203, 193);
            this.useMojangAuth.Name = "useMojangAuth";
            this.useMojangAuth.Size = new System.Drawing.Size(143, 34);
            this.useMojangAuth.TabIndex = 11;
            this.useMojangAuth.Text = "Использовать\nавторизацию Mojang";
            this.useMojangAuth.UseVisualStyleBackColor = false;
            // 
            // percentProgress
            // 
            this.percentProgress.AutoSize = true;
            this.percentProgress.BackColor = System.Drawing.Color.Transparent;
            this.percentProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.percentProgress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.percentProgress.Location = new System.Drawing.Point(514, 323);
            this.percentProgress.Name = "percentProgress";
            this.percentProgress.Size = new System.Drawing.Size(24, 15);
            this.percentProgress.TabIndex = 12;
            this.percentProgress.Text = "0%";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(471, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 15);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Помощь";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ramInput
            // 
            this.ramInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramInput.Location = new System.Drawing.Point(243, 233);
            this.ramInput.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ramInput.Name = "ramInput";
            this.ramInput.Size = new System.Drawing.Size(53, 23);
            this.ramInput.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(204, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "RAM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "+1GB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Location = new System.Drawing.Point(12, 304);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(219, 15);
            this.statusLabel.TabIndex = 17;
            this.statusLabel.Text = "Ожидание команды от пользователя...";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.versionLabel.Location = new System.Drawing.Point(463, 58);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(31, 15);
            this.versionLabel.TabIndex = 18;
            this.versionLabel.Text = "1.0.1";
            // 
            // LauncherGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 351);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ramInput);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.percentProgress);
            this.Controls.Add(this.useMojangAuth);
            this.Controls.Add(this.launch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.launcherProgress);
            this.Controls.Add(this.autoJoinServer);
            this.Controls.Add(this.closeLauncher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nickInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shield);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LauncherGUI";
            this.Text = "LauncherGUI";
            ((System.ComponentModel.ISupportInitialize)(this.shield)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox shield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mojangPassword;
        private System.Windows.Forms.TextBox mojangEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nickInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox showMojangPassword;
        private System.Windows.Forms.CheckBox closeLauncher;
        private System.Windows.Forms.CheckBox autoJoinServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox useMojangAuth;
        private System.Windows.Forms.Label percentProgress;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar launcherProgress;
        private System.Windows.Forms.NumericUpDown ramInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button launch;
        public System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}
