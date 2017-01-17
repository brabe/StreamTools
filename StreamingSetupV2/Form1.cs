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

            if (e.Control && e.KeyCode.ToString() == "Space")
            {
                liveScoreAlternative1.button19.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (Properties.Settings.Default.KeyboardStatus == 1)
            {
                if (e.KeyCode.ToString() == "D2")
                {
                    liveScoreAlternative1.period1.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "D1")
                {
                    liveScoreAlternative1.period2.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "I")
                {
                    liveScoreAlternative1.button17.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "K")
                {
                    liveScoreAlternative1.button18.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "U")
                {
                    liveScoreAlternative1.button15.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "J")
                {
                    liveScoreAlternative1.button16.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "M")
                {
                    liveScoreAlternative1.button14.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "Space")
                {
                    liveScoreAlternative1.button13.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "E")
                {
                    liveScoreAlternative1.button1.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "D")
                {
                    liveScoreAlternative1.button2.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "C")
                {
                    liveScoreAlternative1.button3.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "W")
                {
                    liveScoreAlternative1.button4.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "S")
                {
                    liveScoreAlternative1.button5.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "X")
                {
                    liveScoreAlternative1.button6.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "T")
                {
                    liveScoreAlternative1.button10.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "G")
                {
                    liveScoreAlternative1.button11.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "B")
                {
                    liveScoreAlternative1.button12.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "R")
                {
                    liveScoreAlternative1.button7.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "F")
                {
                    liveScoreAlternative1.button8.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }

                if (e.KeyCode.ToString() == "V")
                {
                    liveScoreAlternative1.button9.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }
            }
            //Console.Write(e.KeyCode.ToString());
        }
    }
}