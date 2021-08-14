using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using Microsoft.Win32;
using VRPLancher.Sources;
using System.Security.Cryptography;
using System.Text;

namespace VRPLancher
{
    static class Central
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        #region public const string README_minecraft
        public const string README_minecraft =
            "Не редактируйте или изменяйте файлы в этой папке. НИКОГДА.\n" +
            "Если вы всё же это делаете, понимайте что вы действуете на свой личный риск\n" +
            "и администрация сервера не несёт ответственности за ваши действия или любые\n" +
            "ихние последстствия.\n" +
            "\n" +
            "Чтобы вернуть всё как было, просто удалите и скачайте снова лаунчер.\n" +
            "\n" +
            "\n" +
            "=======================\n" +
            "[Контактная информация]\n" +
            "=======================\n" +
            "Discord: https://discord.gg/SknQerfZha\n" +
            "E-Mail разработчика: creeperywime@gmail.com\n" +
            "GitHub: [отсутствует]\n";
        #endregion
        //public const string README = "";
        public static LauncherGUI launcherGUI;
        public static readonly RegistryKey vrpRegKey = getVrpRegKey();
        public const string version = "1.0.1";
        public static readonly int maxram = Convert.ToInt32(new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024));
        public static bool filesValid;
        public static MCLauncher launcher = new MCLauncher();

        public static RegistryKey getVrpRegKey() {
            RegistryKey a = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\blek\VRP");
            if (a == null) {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\blek\VRP");
            }
            return Registry.CurrentUser.OpenSubKey(@"SOFTWARE\blek\VRP");
        }

        private static void WriteReadme() {
            try {
                using StreamWriter file = new(MCLauncher.pathToMCFolder + "\\README.txt");
                file.Close();
            } catch (Exception) {
                Directory.CreateDirectory(MCLauncher.pathToMCFolder);
            }
            File.WriteAllTextAsync(MCLauncher.pathToMCFolder + "\\README.txt", README_minecraft);
        }

        [STAThread]
        //[SecurityPermission(SecurityAction.Demand, Flags=SecurityPermissionFlag.ControlAppDomain)]
        static void Main()
        {
            //Clipboard.SetText(Cryptography.getPasswordHash("пароль)"));
            try
            {
                Directory.GetFiles(MCLauncher.pathToMCFolder, "*.*", SearchOption.AllDirectories).OrderBy(p => p).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы удалили папку с игрой. Верните.\nЛаунчер без неё работать не будет.");
            }
            if (Directory.Exists(MCLauncher.pathToMCFolder + @"\versions\1.16.4")) {
                try
                {
                    Directory.Delete(MCLauncher.pathToMCFolder + @"\versions\1.16.4");
                }
                catch (Exception) { /*ignored*/ }
            }
            WriteReadme();
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(ExceptionHandler);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (RegistryConfig.lastVersion == "-1")
            {
                Legal legal_agreement = new Legal();
                Application.Run(legal_agreement);
            }
            if (RegistryConfig.lastVersion != "-1")
            {
                openForm11();
            }
            
        }
        public static void checkFiles()
        {
            bool trusted = FileChecker.checkByDefault();
            if (!trusted)
            {
                MessageBox.Show(
                "Файлы вашего лаунчера были изменены вручную или какой-то программой\n" +
                "поэтому если вас будут подозревать в читерстве и попросят показать лаунчер\n" +
                "вас скорее всего накажут.\n" +
                "\n" +
                "Чтобы восстановить свой статус доверенности, поставьте оригинальные моды и версию игры.");
            }
            filesValid = trusted;
        }
        public static void reCheckFiles()
        {
            bool trusted = FileChecker.checkByDefault();
            filesValid = trusted;
            if (filesValid)
            {
                MessageBox.Show("Результат перепроверки показал что файлы оригиальные.");
            }
            else
            {
                MessageBox.Show("Результат перепроверки показал что файлы не оригиальные.");
            }
            launcherGUI.updateShield();
        }

        public static void openForm11()
        {
            checkFiles();
            launcherGUI = new LauncherGUI();
            Application.Run(launcherGUI);
        }


        public static void openForm1()
        {
            checkFiles();
            launcherGUI = new LauncherGUI();
            launcherGUI.Show();
        }

        public static void ExceptionHandler(object sender, UnhandledExceptionEventArgs args) {
            Exception e = (Exception) args.ExceptionObject;
            MessageBox.Show("При выполнении программы вылезла ошибка:\n\n" + e.StackTrace, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            return;
        }
    }
}
