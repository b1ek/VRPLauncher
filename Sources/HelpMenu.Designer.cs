
namespace VRPLancher
{
    partial class HelpMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.github = new System.Windows.Forms.Button();
            this.discord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 120);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Лицензионное соглашение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // github
            // 
            this.github.BackColor = System.Drawing.SystemColors.ControlLight;
            this.github.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.github.Location = new System.Drawing.Point(12, 162);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(143, 23);
            this.github.TabIndex = 4;
            this.github.Text = "GitHub";
            this.github.UseVisualStyleBackColor = false;
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // discord
            // 
            this.discord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discord.Location = new System.Drawing.Point(169, 162);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(143, 23);
            this.discord.TabIndex = 5;
            this.discord.Text = "Discord";
            this.discord.UseVisualStyleBackColor = true;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // HelpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 196);
            this.Controls.Add(this.discord);
            this.Controls.Add(this.github);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HelpMenu";
            this.Text = "HelpMenu";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button github;
        private System.Windows.Forms.Button discord;
    }
}