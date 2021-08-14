using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace VRPLancher.Sources
{
    public static class Browser
    {
        public static void open(string link) {
            if (link.StartsWith("https://") || link.StartsWith("http://") || link.StartsWith("www.")) { } else return;

            Process p = new Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = link;
            p.Start();
            System.GC.Collect();
        }
    }
}
