
namespace VRPLancher
{
    partial class Legal
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
            this.agree = new System.Windows.Forms.Button();
            this.disagree = new System.Windows.Forms.Button();
            this.licenseText = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // agree
            // 
            this.agree.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.agree.Location = new System.Drawing.Point(0, 0);
            this.agree.Margin = new System.Windows.Forms.Padding(0);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(268, 32);
            this.agree.TabIndex = 4;
            this.agree.Text = "Я согласен с данным соглашением";
            this.agree.UseVisualStyleBackColor = true;
            this.agree.Click += new System.EventHandler(this.button1_Click);
            // 
            // disagree
            // 
            this.disagree.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.disagree.Location = new System.Drawing.Point(0, 32);
            this.disagree.Name = "disagree";
            this.disagree.Size = new System.Drawing.Size(268, 32);
            this.disagree.TabIndex = 5;
            this.disagree.Text = "Я не согласен с данным соглашением";
            this.disagree.UseVisualStyleBackColor = true;
            this.disagree.Click += new System.EventHandler(this.button2_Click);
            // 
            // licenseText
            // 
            this.licenseText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.licenseText.Location = new System.Drawing.Point(12, 12);
            this.licenseText.Name = "licenseText";
            this.licenseText.ReadOnly = true;
            this.licenseText.Size = new System.Drawing.Size(422, 216);
            this.licenseText.TabIndex = 6;
            this.licenseText.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.agree);
            this.panel1.Controls.Add(this.disagree);
            this.panel1.Location = new System.Drawing.Point(94, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 64);
            this.panel1.TabIndex = 7;
            // 
            // Legal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 332);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.licenseText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Legal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Лицензионное соглашение";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button agree;
        public System.Windows.Forms.Button disagree;
        private System.Windows.Forms.RichTextBox licenseText;
        private System.Windows.Forms.Panel panel1;
    }
}