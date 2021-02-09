using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscilloscope
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = HelpSelect.SelectedNode;
            switch (tn.Tag)
            {
                default:
                    HelpText.Text = "ERR: OPTION NOT FOUND OR IS NULL";
                    break;
                case "Help":
                    HelpText.Text = "What section do you think you are in?";
                    break;
                case "Load":
                    HelpText.Text = "This option allows for the loading of waveforms. Waveforms must be Wave files (.wav).";
                    break;
                case "Export":
                    HelpText.Text = "This option allows for the user to create a sound file from the waveform. These files can be found in a folder called SOUNDS";
                    break;
                case "View":
                    HelpText.Text = "What section do you think you are in?";
                    break;
                case "Edit":
                    HelpText.Text = "What section do you think you are in?";
                    break;
            }
        }
    }
}
