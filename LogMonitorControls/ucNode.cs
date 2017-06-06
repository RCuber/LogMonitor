using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogMonitor.Controls
{
    public partial class ucNode: UserControl
    {
        public ucNode()
        {
            InitializeComponent();
        }

        public string ElementText
        {
            get { return this.lblElement.Text; }
            set { this.lblElement.Text = value; }
        }

        public string Status
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }


    }
}
