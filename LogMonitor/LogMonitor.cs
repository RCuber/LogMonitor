using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogMonitor.IO;
using System.Configuration;

namespace LogMonitor
{
    public partial class LogMonitor : Form
    {

        NotifyIcon _notify;
        LogReader _reader;

        string _path;
        string _extension;
        string _file = @"\2017-06-03 03-08-26.txt";

        public LogMonitor()
        {
            InitializeComponent();
            _notify = new NotifyIcon();
            _notify.Icon = global::LogMonitor.Properties.Resources.passive;
            _notify.Visible = true;
        }

        private void LogStatus_Load(object sender, EventArgs e)
        {
            _path = Shared.Common.FolderPath;
            if (string.IsNullOrEmpty(_path))
            {
                MessageBox.Show("Please Configure Folder To Monitor");
                btnMonitor.Visible = false;
                return;
            }
            _extension = Shared.Common.SelectedExtension;
           txtFile.Text =  LogReader.GetLatestFile(_path);
            btnMonitor.Visible = true;
        }

        private void Notify(string message, string title, int timeOut = 1000, ToolTipIcon icon = ToolTipIcon.Info)
        {
            _notify.ShowBalloonTip(timeOut, title, message, icon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LogReader.GetLatestFile(_path));
        }

        private void LogStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            _notify.Visible = false;
            _notify.Dispose();
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            var config = new Configuration();
            config.ShowDialog();
            LogStatus_Load(null, null);
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            var lines = _reader.GetAddedLines();
            if (lines?.Length > 0)
            {
                txtLog.AppendText(lines);
                var key = DetectKeyword(lines, OBSDictionary.GetDictionary());
                if (!string.IsNullOrEmpty(key))
                {
                    Notify(key, key);
                }
            }
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (btnMonitor.Text == "Start")
            {
                InitReader();
                tmrRefresh.Start();
                btnMonitor.Text = "Stop";
            }
            else
            {
                tmrRefresh.Stop();
                btnMonitor.Text = "Start";
            }
        }

        private void InitReader()
        {
            _reader = new LogReader(txtFile.Text);
            txtLog.AppendText(_reader.GetAddedLines());
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
           
        }

        private string DetectKeyword(string logText, Dictionary<string,string> dictionary)
        {
            var key = dictionary.Where(x => logText.Contains(x.Key)).Select(y=>y.Value).FirstOrDefault();
            return key; 
            
        }
    }
}
