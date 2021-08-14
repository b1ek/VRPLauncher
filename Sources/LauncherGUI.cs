using System;
using System.Drawing;
using System.Windows.Forms;

namespace VRPLancher.Sources
{
    public partial class LauncherGUI : Form
    {
        private bool userTypedPassword = false;
        public LauncherGUI()
        {
            InitializeComponent();
            nickInput.Text = RegistryConfig.getNickName();
            mojangEmail.Text = RegistryConfig.mojangEmail;
            //global::VRPLancher.Properties.Resources.uac
            //this.helpButton.BackgroundImage = SystemIcons.Question.ToBitmap();
            if (!(RegistryConfig.mojangPassword == "" || RegistryConfig.mojangPassword == "not saved")) {
                userTypedPassword = true;
                mojangPassword.Text = RegistryConfig.mojangPassword;
                userTypedPassword = false;
            }

            ramInput.Maximum = Central.maxram;
            ramInput.Value   = Central.maxram / 2;
            valueChanged += new System.EventHandler(onValueChanged);
        }

        public event System.EventHandler valueChanged;

        public virtual void onValueChanged(object sender, System.EventArgs e) {
            percentProgress.Text = progress + "%";
        }

        public int progress
        {
            get
            {
                return launcherProgress.Value;
            }
            set
            {
                valueChanged.Invoke(this, new EventArgs());
                launcherProgress.Value = value;
            }
        }

        private void nickInput_TextChanged(object sender, EventArgs e)
        {
            RegistryConfig.setNickName(nickInput.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Central.verifyFileIntegrity();
        }
        public void setGrayShield(bool value)
        {
            if (value == false)
            {
                shield.Image = global::VRPLancher.Properties.Resources.uac;
            }
            if (value)
            {
                Bitmap img = (Bitmap)shield.Image;
                int x, y;
                for (x = 0; x < img.Width; x++)
                {
                    for (y = 0; y < img.Height; y++)
                    {
                        Color pixelColor = img.GetPixel(x, y);
                        Color newColor = Color.FromArgb(pixelColor.A, pixelColor.R, pixelColor.R, pixelColor.R);
                        img.SetPixel(x, y, newColor);
                        shield.Image = img;

                        System.GC.Collect();
                    }
                }
            }
            isShieldGray = value;
            System.GC.Collect();
        }
        private bool isShieldGray = true;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setGrayShield(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new HelpMenu().Show();
        }

        private void mojangEmail_TextChanged(object sender, EventArgs e)
        {
            RegistryConfig.mojangEmail = mojangEmail.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new HelpMenu().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                MessageBox.Show("Хранить пароли в лаунчере НЕБЕЗОПАСНО.\nВаш пароль НЕ ШИФРУЕТСЯ.\n\nЗнайте об этом.\nЕсли вы хотите удалить ваш пароль из программы, введите в поле пустое значение.", "Предупреждение!!!! обратите внимание");
            if (userTypedPassword)
                RegistryConfig.mojangPassword = mojangPassword.Text;
        }

        private void launch_Click(object sender, EventArgs e)
        {
            #region Config assembler
            // (mojang auth) (nick or email) (password) (close launcher) (RAM)
            bool mAuth = useMojangAuth.Checked;
            string[] config = { };
            if (mAuth)
            {
                string email = mojangEmail.Text                               ;
                string pswd  = mojangPassword.Text                            ;
                string close = closeLauncher.Checked.ToString().ToLower()     ;
                string ram   = ramInput.Value.ToString()                      ;
                config = new string[] { "true", email, pswd, close, ram }     ;
            }
            else
            {
                string nick  = nickInput.Text                                 ;
                string close = closeLauncher.Checked.ToString().ToLower()     ;
                string ram   = ramInput.Value.ToString()                      ;
                config       = new string[] { "false", nick, "", close, ram } ;
            }
            #endregion
            #region Launcher
            Central.launcher.launchNow(config);
            #endregion
        }

        private void mojangPassword_TextChanged(object sender, EventArgs e)
        {
            if (!userTypedPassword) {
                mojangPassword.Text = "";
                userTypedPassword = true;
            }
            if (checkBox1.Checked == false) return;
                RegistryConfig.mojangPassword = mojangPassword.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ramInput.Value += 1024;
            } catch (Exception) { ramInput.Value = Central.maxram; }
        }

        private void showMojangPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!showMojangPassword.Checked) {
                mojangPassword.PasswordChar = '*';
            }
            if (showMojangPassword.Checked) {
                if (!userTypedPassword) {
                    mojangPassword.Text = "";
                }
                mojangPassword.PasswordChar = char.MinValue;
            }
        }
    }
}
