using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Web;

namespace EmailAccountCheck
{
    class RedirectToWebBrowser
    {
        public void OpenBrowser(string URL)
        {
            string URLtemp = "http://www." + URL;   
            Process proc = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo(URLtemp);
            proc.StartInfo = startInfo;
            proc.Refresh();
            proc.Start();
        }
    }
}
