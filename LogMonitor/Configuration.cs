using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogMonitor
{
    public partial class Configuration : Form
    {
        string _path;
        string _extension;
        const string _logFolderPath = "logFolderPath";
        const string _selectedExtension = "selectedExtension";

        public Configuration()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                _path = fbd.SelectedPath;
                txtPath.Text = _path;
            }
        }

        private void txtPath_Leave(object sender, EventArgs e)
        {
            //TODO: Validate path on exit. or have a validation method.
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
            this.Close();

        }

        private void SaveConfiguration()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (CheckPathExists(txtPath.Text))
            {
                config.AppSettings.Settings[_logFolderPath].Value = txtPath.Text;
                _path = txtPath.Text;
            }
            else
            {
                MessageBox.Show("Cannot access the path provided, please try running the application with Admin Privilege");
            }
            try
            {
                config.AppSettings.Settings[_selectedExtension].Value = cmbExtensions.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Could Not Save Changes, Please try running the application with Admin Privilege {Environment.NewLine} {ex.Message}","Error");
            }
        }

        private List<string> ReadConfiguration(string path)
        {
            try
            {
                //TODO: Get file extensions from the currently selected directory and show in combo box as available extensions. Or allow user to enter any? 
                //_path = ConfigurationManager.AppSettings["logFolderPath"];
                //if (CheckPathExists(_path))
                //{
                //    List<string> extensions = EnumerateExtensions(Directory.EnumerateFiles(_path));
                //    return extensions;
                //}
                //else
                return new List<string> { "*.txt", "*.log" };
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<string> EnumerateExtensions(IEnumerable<string> files)
        {
            var extensions = files.Select(x => x.Substring(x.Length - 4)).ToList();
            return extensions;
        }

        private bool CheckPathExists(string text)
        {
            try
            {
                return Directory.Exists(text);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Cannot access the path provided- {ex.Message}");
                return false;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            try
            {
                _path = ConfigurationManager.AppSettings[_logFolderPath];
                _extension = ConfigurationManager.AppSettings[_selectedExtension];
                if (!CheckPathExists(_path))
                {
                    _path = CurrentAssemblyDirectory();
                }
                cmbExtensions.DataSource = ReadConfiguration(_path);
                cmbExtensions.SelectedIndex = cmbExtensions.Items.IndexOf(_extension);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            txtPath.Text = _path;
        }

        private string CurrentAssemblyDirectory()
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }

        private void cmbExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
