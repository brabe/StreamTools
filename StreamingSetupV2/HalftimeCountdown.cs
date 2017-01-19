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
    public partial class HalftimeCountdown : UserControl
    {
        public HalftimeCountdown()
        {
            InitializeComponent();

            //Create HalftimeCountdown Directory
            Directory.CreateDirectory(Properties.Settings.Default.ExportDirectory + "/HalftimeCountdown");
        }

        //  Starting/Pausing/Stopping - Halftime Countdown

        string HalftimeCountdownFile = Properties.Settings.Default.ExportDirectory + "/HalftimeCountdown";

        int hHalftime;
        int mHalftime;
        int sHalftime;
        string hhHalftime;
        string mmHalftime;
        string ssHalftime;
        int HalftimePause = 1;

        private void HalfTimeStartButton2_Click(object sender, EventArgs e)
        {
            if (HalftimePause == 3)
            {
                halftimeTimer.Start();
                hHalftime = Convert.ToInt32(HalfTimeH.Value);
                mHalftime = Convert.ToInt32(HalfTimeM.Value);
                sHalftime = Convert.ToInt32(HalfTimeS.Value);

                HalfTimeStartButton2.Text = "Pause";

                writeFile();

                HalftimePause = 4;
            }

            if (HalftimePause == 2)
            {
                halftimeTimer.Stop();
                HalfTimeH.Value = Convert.ToDecimal(hHalftime);
                HalfTimeM.Value = Convert.ToDecimal(mHalftime);
                HalfTimeS.Value = Convert.ToDecimal(sHalftime);

                HalfTimeStartButton2.Text = "Resume";
                HalftimePause = 3;

            }

            if (HalftimePause == 1)
            {
                halftimeTimer.Start();
                hHalftime = Convert.ToInt32(HalfTimeH.Value);
                mHalftime = Convert.ToInt32(HalfTimeM.Value);
                sHalftime = Convert.ToInt32(HalfTimeS.Value);

                HalfTimeStartButton2.Text = "Pause";

                writeFile();

                HalftimePause = 2;
            }

            if (HalftimePause == 4)
            {
                HalftimePause = 2;
            }
        }
        // Resetting - Hafltime Countdown
        private void HalftimeResetButton_Click(object sender, EventArgs e)
        {
            halftimeTimer.Stop();
            hHalftime = 0;
            mHalftime = 10;
            sHalftime = 0;

            HalfTimeH.Value = Convert.ToDecimal(hHalftime);
            HalfTimeM.Value = Convert.ToDecimal(mHalftime);
            HalfTimeS.Value = Convert.ToDecimal(sHalftime);

            HalftimeLiveOutputTextBox.Text = " ";

            File.WriteAllText(@HalftimeCountdownFile + "/halftime-countdown.txt", HalftimeLiveOutputTextBox.Text);

            HalfTimeStartButton2.Text = "Start";
            HalftimePause = 1;
        }

        // Workings of Countdown Clock and Text Export
        private void halftimeTimer_Tick(object sender, EventArgs e)
        {

            sHalftime = sHalftime - 1;

            if (sHalftime == -1)
            {
                mHalftime = mHalftime - 1;
                sHalftime = 59;
            }

            if (mHalftime == -1)
            {
                hHalftime = hHalftime - 1;
                mHalftime = 59;
            }

            writeFile();

            if (hHalftime == 0 & mHalftime == 0 & sHalftime == 0)
            {
                halftimeTimer.Stop();
                HalftimeLiveOutputTextBox.Text = HalftimeMsgTextBox.Text;
                File.WriteAllText(@HalftimeCountdownFile + "/halftime-countdown.txt", HalftimeMsgTextBox.Text);
            }
        }

        private void writeFile()
        {
            hhHalftime = Convert.ToString(hHalftime);
            mmHalftime = Convert.ToString(mHalftime);
            ssHalftime = Convert.ToString(sHalftime);

            if (hHalftime < 10)
            {
                hhHalftime = "0" + Convert.ToString(hHalftime);
            }

            if (mHalftime < 10)
            {
                mmHalftime = "0" + Convert.ToString(mHalftime);
            }

            if (sHalftime < 10)
            {
                ssHalftime = "0" + Convert.ToString(sHalftime);

            }

            string desiredOutput = textBox1.Text;

            string correctString1 = desiredOutput.Replace("$h", Convert.ToString(hHalftime));
            string correctString2 = correctString1.Replace("$m", Convert.ToString(mHalftime));
            string correctString3 = correctString2.Replace("$s", Convert.ToString(sHalftime));

            HalftimeLiveOutputTextBox.Text = correctString3;

            File.WriteAllText(@HalftimeCountdownFile + "/halftime-countdown.txt", correctString3);

            // HalftimeLiveOutputTextBox.Text = hhHalftime + ":" + mmHalftime + ":" + ssHalftime;

            HalfTimeH.Value = hHalftime;
            HalfTimeM.Value = mHalftime;
            HalfTimeS.Value = sHalftime;
        }
    }
}
