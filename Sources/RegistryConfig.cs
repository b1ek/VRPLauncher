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
        #region vrpkey
        public static RegistryKey vrpKey
        {
            get
            {
                RegistryKey a = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\blek\VRP");
                if (a == null)
                {
                    Registry.CurrentUser.CreateSubKey(@"SOFTWARE\blek\VRP");
                }
                return Registry.CurrentUser.OpenSubKey(@"SOFTWARE\blek\VRP");
            }
            set
            {
                return;
            }
        }
        #endregion
        #region NickName
        public const string vrpNickValue = "NickName";
        public static string nickname
        {
            get
            {
                var a = Registry.GetValue(Central.vrpRegKey.Name, RegistryConfig.vrpNickValue, "84a3572b-60fa-4fbc-8251-8f6fe412d01b");
                if (a == null || a.Equals("84a3572b-60fa-4fbc-8251-8f6fe412d01b"))
                {
                    nickname = "BlackLightHack";
                }
                return Registry.GetValue(Central.vrpRegKey.Name, RegistryConfig.vrpNickValue, "BlackLightHack").ToString();
            }
            set
            {
                Registry.SetValue(Central.vrpRegKey.Name, RegistryConfig.vrpNickValue, value, RegistryValueKind.String);
            }
        }
        #endregion
        #region lastLaunchedVersion
        public static readonly string lastLaunchedVersionKey = "lastLaunchedVersion";

        public static string lastVersion
        {
            get
            {
                var a = Registry.GetValue(Central.vrpRegKey.Name, lastLaunchedVersionKey, "-1");
                if (a == null || a.Equals("-1"))
                {
                    return "-1";
                }
                return Registry.GetValue(Central.vrpRegKey.Name, lastLaunchedVersionKey, "-1").ToString();
            }
            set
            {
                Registry.SetValue(Central.vrpRegKey.Name, lastLaunchedVersionKey, Central.version, RegistryValueKind.String);
            }
        }
        #endregion
        #region Mojang auth

        #region email
        public static string mojangEmailKey = "mojangEmail"; // key in registry
        public static string mojangEmail
        {
            get {
                // get as object
                object email = Registry.GetValue(Central.vrpRegKey.Name, mojangEmailKey, "84a3572b-60fa-4fbc-8251-8f6fe412d01b");

                // if not exists, return empty string.
                if (email == null || email.Equals("84a3572b-60fa-4fbc-8251-8f6fe412d01b"))
                    return "";

                // if exists, return its value.
                return Registry.GetValue(Central.vrpRegKey.Name, mojangEmailKey, "84a3572b-60fa-4fbc-8251-8f6fe412d01b").ToString();
            }
            set {
                Registry.SetValue(Central.vrpRegKey.Name, mojangEmailKey, value, RegistryValueKind.String);
            }
        }
        #endregion
        #region password

        public static string mojangPasswordKey = "mojangPassword"; // key in registry
        public static string mojangPassword
        {
            get
            {
                //get as object
                object password = Registry.GetValue(Central.vrpRegKey.Name, mojangPasswordKey, "84a3572b-60fa-4fbc-8251-8f6fe412d01b");
                // if not exists, return "not set"
                if (password == null || password.Equals("84a3572b-60fa-4fbc-8251-8f6fe412d01b") || password.Equals("not set"))
                    mojangPassword = "not set";
                // return the value
                return Registry.GetValue(Central.vrpRegKey.Name, mojangPasswordKey, "84a3572b-60fa-4fbc-8251-8f6fe412d01b").ToString();
            }
            set
            {
                // if you are trying to set an empty password
                if (value == "")
                    Registry.SetValue(Central.vrpRegKey.Name, mojangPasswordKey, "not set", RegistryValueKind.String);
                // if ur not
                Registry.SetValue(Central.vrpRegKey.Name, mojangPasswordKey, value, RegistryValueKind.String);
            }
        }
        #endregion

        #endregion
    }
}
