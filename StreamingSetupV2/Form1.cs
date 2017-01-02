using System;
using System.IO;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using SpotifyAPI.Local;
using SpotifyAPI.Local.Enums;
using SpotifyAPI.Local.Models;
using System.Drawing.Imaging;

namespace StreamingSetupV2
{
    public partial class Form1 : Form
    {
        // Initializing the Form and Create Directories
        public Form1()
        {
            InitializeComponent();

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
            this.Close();
        }
    }
}