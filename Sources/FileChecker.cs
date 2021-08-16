using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRPLancher.Sources
{
    public static class FileChecker {

        private const string modHash = "5878a0f76e069b958218ac330a01b526520e69dd";
        private const string verHash = "6680ff5ebef5c115e412573b3a0db6df39c748ed";
        private const string hash3TR = "5c40561892484ac72693527bac7b0674a1d23a690cf731417de4b6fad11231be";

        public static bool checkByDefault()
        {
            CheckProgress checkProgress = new();
            checkProgress.Show();
            checkProgress.progress = 60;
            string hash1 = "";
            string hash2 = "";
            try
            {
                hash1 = Cryptography.getFolderHashSHA1(MCLauncher.pathToMCFolder + @"\versions", "*.jar", System.IO.SearchOption.AllDirectories);
            }
            catch (Exception)
            {
                MessageBox.Show("Папка с версиями отсутствует.");
            }

            checkProgress.text = "Проверка файлов (2/2)";
            checkProgress.progress = 72;
            try
            {
                hash2 = Cryptography.getFolderHashSHA1(MCLauncher.pathToMCFolder + @"\mods", "*.jar", System.IO.SearchOption.AllDirectories);
            }
            catch (Exception)
            {
                MessageBox.Show("Папка с модами отсутствует.");
            }

            checkProgress.progress = 80;
            // 5c40561892484ac72693527bac7b0674a1d23a690cf731417de4b6fad11231be
            string hash3 = Cryptography.getStringHash(System.Security.Cryptography.SHA256.Create(), hash1 + hash2).Replace("-", "").ToLowerInvariant();
            checkProgress.progress = 98;
            bool hash3valid = hash3.Equals(hash3TR);

            checkProgress.progress = 100;
            checkProgress.Close();
            AdvancedRegistryConfig.lastVersionHash  = hash1;
            AdvancedRegistryConfig.lastModHash      = hash2;
            return hash3valid;
        }
    }
}
