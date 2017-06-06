using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLogGenerator
{
    public partial class frmTextLogGenerator : Form
    {

        string _text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        List<string> _wordList;
        public frmTextLogGenerator()
        {
            InitializeComponent();
            _wordList = _text.Split(' ').ToList();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text == "Start")
            {
                btnToggle.Text = "Stop";
                tmrTemp.Start();
            }
            else
            {
                btnToggle.Text = "Start";
                tmrTemp.Stop();
            }
        }

        private void tmrTemp_Tick(object sender, EventArgs e)
        {

        }

        private void test()
        {
            String s = "Test" ;
            StringBuilder sb = new StringBuilder("test2");
            sb.Append(s);
            Console.WriteLine(sb);
        }

    }
}
