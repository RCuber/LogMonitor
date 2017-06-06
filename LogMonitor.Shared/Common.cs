using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogMonitor.Shared
{
    public class Common
    {
        const string _logFolderPath = "logFolderPath";
        const string _extensions = "selectedExtension";

        public static string  FolderPath
        {
            get { return ConfigurationManager.AppSettings[_logFolderPath]; }
        }

        public static string SelectedExtension
        {
            get { return ConfigurationManager.AppSettings[_extensions]; }
        }
    }
}
