using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPLancher
{
    static class RegistryConfig
    {
        #region NickName
        public static void setNickName(string nickName)
        {
            Registry.SetValue(Central.vrpRegKey.Name, Central.vrpNickValue, nickName, RegistryValueKind.String);
        }
        public static string getNickName()
        {
            var a = Registry.GetValue(Central.vrpRegKey.Name, Central.vrpNickValue, "84a3572b-60fa-4fbc-8251-8f6fe412d01b");
            if (a == null || a.Equals("84a3572b-60fa-4fbc-8251-8f6fe412d01b"))
            {
                setNickName("BlackLightHack");
            }
            return Registry.GetValue(Central.vrpRegKey.Name, Central.vrpNickValue, "BlackLightHack").ToString();
        }
        #endregion
        #region lastLaunchedVersion
        public static readonly string lastLaunchedVersionKey = "lastLaunchedVersion";
        public static void setLastLaunchedVersion()
        {
            Registry.SetValue(Central.vrpRegKey.Name, lastLaunchedVersionKey, Central.version, RegistryValueKind.DWord);
        }
        public static int lastLaunchedVersion()
        {
            var a = Registry.GetValue(Central.vrpRegKey.Name, lastLaunchedVersionKey, "-1");
            if (a == null || a.Equals("-1"))
            {
                return -1;
            }
            return (int)Registry.GetValue(Central.vrpRegKey.Name, lastLaunchedVersionKey, "-1");
        }
        #endregion
        #region Mojang auth data
        public static string mojangEmailKey     = "mojangEmail";
        public static string mojangPasswordKey  = "mojangPassword";
        public static string mojangEmail
        {
            get {
                object email = Registry.GetValue(Central.vrpRegKey.Name, mojangEmailKey, "84a3572b-60fa-4fbc-8251-8f6fe412d01b");
                if (email == null || email.Equals("84a3572b-60fa-4fbc-8251-8f6fe412d01b"))
                    return "";
                return Registry.GetValue(Central.vrpRegKey.Name, mojangEmailKey, "84a3572b-60fa-4fbc-8251-8f6fe412d01b").ToString();
            }
            set {
                Registry.SetValue(Central.vrpRegKey.Name, mojangEmailKey, value, RegistryValueKind.String);
            }
        }
        public static string mojangPassword
        {
            get
            {
                object password = Registry.GetValue(Central.vrpRegKey.Name, mojangPasswordKey, "84a3572b-60fa-4fbc-8251-8f6fe412d01b");
                if (password == null || password.Equals("84a3572b-60fa-4fbc-8251-8f6fe412d01b") || password.Equals("not set"))
                    mojangPassword = "not set";
                return Registry.GetValue(Central.vrpRegKey.Name, mojangPasswordKey, "84a3572b-60fa-4fbc-8251-8f6fe412d01b").ToString();
            }
            set
            {
                if (value == "")
                    Registry.SetValue(Central.vrpRegKey.Name, mojangPasswordKey, "not set", RegistryValueKind.String);

                Registry.SetValue(Central.vrpRegKey.Name, mojangPasswordKey, value, RegistryValueKind.String);
            }
        }
        #endregion
    }
}
