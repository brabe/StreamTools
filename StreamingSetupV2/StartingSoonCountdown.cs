using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingSetupV2
{
    public partial class StartingSoonCountdown : UserControl
    {
        public StartingSoonCountdown()
        {
            InitializeComponent();
            
            // Creating the StartingCountdown Directory
            Directory.CreateDirectory(Properties.Settings.Default.ExportDirectory + "/StartingCountdown");

        }

        //  Starting/Pausing/Stopping - Starting Soon Countdown

        string StartingCountdownFile = Properties.Settings.Default.ExportDirectory + "/StartingCountdown";

        int hStart;
        int mStart;
        int sStart;
        string hhStart;
        string mmStart;
        string ssStart;
        int StartingPause = 1;

        public void StartStartButton_Click(object sender, EventArgs e)
        {
            if (StartingPause == 3)
            {
                startingSoonTimer.Start();
                hStart = Convert.ToInt32(StartTimeH.Value);
                mStart = Convert.ToInt32(StartTimeM.Value);
                sStart = Convert.ToInt32(StartTimeS.Value);

                StartStartButton.Text = "Pause";
                StartingPause = 4;
            }

            if (StartingPause == 2)
            {
                startingSoonTimer.Stop();
                StartTimeH.Value = Convert.ToDecimal(hStart);
                StartTimeM.Value = Convert.ToDecimal(mStart);
                StartTimeS.Value = Convert.ToDecimal(sStart);

                StartStartButton.Text = "Resume";
                StartingPause = 3;

            }

            if (StartingPause == 1)
            {
                startingSoonTimer.Start();
                hStart = Convert.ToInt32(StartTimeH.Value);
                mStart = Convert.ToInt32(StartTimeM.Value);
                sStart = Convert.ToInt32(StartTimeS.Value);

                StartStartButton.Text = "Pause";
                StartingPause = 2;
            }

            if (StartingPause == 4)
            {
                StartingPause = 2;
            }
        }
        
        // Resetting - Starting Soon Countdown
        private void StartResetButton_Click(object sender, EventArgs e)
        {
            startingSoonTimer.Stop();
            hStart = 0;
            mStart = 15;
            sStart = 1;

            StartTimeH.Value = Convert.ToDecimal(hStart);
            StartTimeM.Value = Convert.ToDecimal(mStart);
            StartTimeS.Value = Convert.ToDecimal(sStart);

            StartLiveOutputTextBox.Text = "";

            StartStartButton.Text = "Start";
            StartingPause = 1;
        }
        
        // Workings of Starting Soon Countdown Clock and Text Export
        private void startingSoonTimer_Tick(object sender, EventArgs e)
        {
            sStart = sStart - 1;

            if (sStart == -1)
            {
                mStart = mStart - 1;
                sStart = 59;
            }

            if (mStart == -1)
            {
                hStart = hStart - 1;
                mStart = 59;
            }

            string hhStart = Convert.ToString(hStart);
            string mmStart = Convert.ToString(mStart);
            string ssStart = Convert.ToString(sStart);

            if (hStart < 10)
            {
                hhStart = "0" + Convert.ToString(hStart);
            }

            if (mStart < 10)
            {
                mmStart = "0" + Convert.ToString(mStart);
            }

            if (sStart < 10)
            {
                ssStart = "0" + Convert.ToString(sStart);

            }

            string desiredOutput = StartOutputFormatTextBox.Text;

            string correctString1 = desiredOutput.Replace("$h", Convert.ToString(hStart));
            string correctString2 = correctString1.Replace("$m", Convert.ToString(mStart));
            string correctString3 = correctString2.Replace("$s", Convert.ToString(sStart));

            StartLiveOutputTextBox.Text = correctString3;
            File.WriteAllText(@StartingCountdownFile + "/starting-countdown.txt", correctString3);

            StartTimeH.Value = hStart;
            StartTimeM.Value = mStart;
            StartTimeS.Value = sStart;

            if (hStart == 0 & mStart == 0 & sStart == 0)
            {
                startingSoonTimer.Stop();
                StartLiveOutputTextBox.Text = StartMsgTextBox.Text;
                File.WriteAllText(@StartingCountdownFile + "/starting-countdown.txt", StartMsgTextBox.Text);
            }
        }

    }
}
