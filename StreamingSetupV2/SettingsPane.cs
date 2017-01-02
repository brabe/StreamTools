using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingSetupV2
{
    public partial class SettingsPane : Form
    {
        public SettingsPane()
        {
            InitializeComponent();

            outputDirTextBox.Text = Properties.Settings.Default.ExportDirectory;

            livescoreXMLDir.Text = Properties.Settings.Default.LiveScoreXML;

        }

        private void outputBrowseButton_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = outputDirectoryBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                outputDirTextBox.Text = outputDirectoryBrowserDialog.SelectedPath;
            }
        }

        private void livescoreXMLBrowse_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                livescoreXMLDir.Text = openFileDialog1.FileName;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LiveScoreXML = livescoreXMLDir.Text;
            Properties.Settings.Default.ExportDirectory = outputDirTextBox.Text;

            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LiveScoreXML = "C:/StreamTools/livescore.xml";
            Properties.Settings.Default.ExportDirectory = "C:/StreamTools";

            livescoreXMLDir.Text = Properties.Settings.Default.LiveScoreXML;
            outputDirTextBox.Text = Properties.Settings.Default.ExportDirectory;
        }
    }
}
