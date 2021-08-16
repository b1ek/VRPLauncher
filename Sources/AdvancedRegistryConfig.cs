using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPLancher.Sources
{
    static class AdvancedRegistryConfig
    {
        private static readonly RegistryKey root = makeorgetroot();
        private static readonly bool enabled = RegistryConfig.launcherUnlocked;
        private static RegistryKey makeorgetroot() {
            var a = Central.vrpRegKey.OpenSubKey(@"advancedConfig");
            if (a==null)
            {
                var b = Central.vrpRegKey.CreateSubKey(@"advancedConfig");
                return b;
            }
            return a;
        }
        #region Version Name
        private const string minecraftVersionKeyName = "minecraftVersion";
        public static string minecraftVerion
        {
            get
            {
                if (!enabled) return "fabric-loader-0.11.6-1.16.4";
                string value = (string) root.GetValue(minecraftVersionKeyName, "fabric-loader-0.11.6-1.16.4");
                if (value == null)
                {
                    minecraftVerion = "fabric-loader-0.11.6-1.16.4";
                }
                return value;
            }
            set
            {
                if (enabled) Registry.SetValue(root.Name, minecraftVersionKeyName, value);
            }
        }
        #endregion
        #region LastVersionHash
        private const string lVerHashKeyName = "lastVersionHash";
        public static string lastVersionHash
        {
            set
            {
                if (enabled)
                    Registry.SetValue(root.Name, lVerHashKeyName, value.ToString());
            }
        }
        #endregion
        #region LastModHash
        private const string lModHashKeyName = "lastModHash";
        public static string lastModHash
        {
            set
            {
                if (enabled)
                    Registry.SetValue(root.Name, lModHashKeyName, value.ToString());
            }
        }

        #endregion
    }
}
