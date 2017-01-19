using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;


namespace StreamingSetupV2
{
    public partial class Form1 : Form
    {
        
        // Initializing the Form and Create Directories
        public Form1()
        {
            InitializeComponent();

            this.ActiveControl = menuStrip1;

            //Create the main export directory
            Directory.CreateDirectory(Properties.Settings.Default.ExportDirectory);
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SettingsPane frm = new SettingsPane();
            frm.Show();
        }

        private void openOutputDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.ExportDirectory);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "-")
            {
                startingSoonCountdown1.StartStartButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.Control && e.KeyCode.ToString() == "=")
            {
                startingSoonCountdown1.StartResetButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.Control && e.KeyCode.ToString() == "[")
            {
                halftimeCountdown1.HalfTimeStartButton2.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.Control && e.KeyCode.ToString() == "]")
            {
                halftimeCountdown1.HalftimeResetButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
            //Console.Write(e.KeyCode.ToString());
        }

        private void openScoreboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopoutForm scoreFrm = new PopoutForm("scoreboard");

            scoreFrm.Text = "";
            scoreFrm.Show();
        }
    }
}