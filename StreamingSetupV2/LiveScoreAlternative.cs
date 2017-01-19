using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamingSetupV2
{
    public partial class LiveScoreAlternative : UserControl
    {
        public LiveScoreAlternative()
        {
            InitializeComponent();

            Directory.CreateDirectory(Properties.Settings.Default.ExportDirectory + "/ScoreboardExport");

            //rightScoreText.Controls[0].Visible = false;
            //leftScoreText.Controls[0].Visible = false;

            leftScoreText.Value = Properties.Settings.Default.LeftScore;
            rightScoreText.Value = Properties.Settings.Default.RightScore;

            leftName.Text = Properties.Settings.Default.LeftName;
            rightName.Text = Properties.Settings.Default.RightName;

            if (Properties.Settings.Default.KeyboardStatus == 0)
            {
                KeyboardStatus.Text = "Off";
            } else
            {
                KeyboardStatus.Text = "On";
            }

        }
        
        // Variables
        string ScoreboardExport = Properties.Settings.Default.ExportDirectory + "/ScoreboardExport";
        internal int mTimeClock;
        internal int sTimeClock;
        internal string mmTimeClock;
        internal string ssTimeClock;

        int ClockPause = 1;

        internal int periodState = 1;
        
        // TimeClock Timer
        private void timeClock_Tick(object sender, EventArgs e)
        {
            sTimeClock = sTimeClock - 1;

            if (sTimeClock == -1)
            {
                mTimeClock = mTimeClock - 1;
                sTimeClock = 59;
            }

            writeFile();

            if (mTimeClock == 0 & sTimeClock == 0)
            {
                timeClock.Stop();
            }

        }

        // Write TimeClock File
        internal void writeFile()
        {
            mmTimeClock = Convert.ToString(mTimeClock);
            ssTimeClock = Convert.ToString(sTimeClock);

            if (mTimeClock < 10)
            {
                mmTimeClock = "0" + Convert.ToString(mTimeClock);
            }

            if (sTimeClock < 10)
            {
                ssTimeClock = "0" + Convert.ToString(sTimeClock);
            }

            string desiredOutput = "$m:$s";

            string correctString1 = desiredOutput.Replace("$m", mmTimeClock);
            string correctString2 = correctString1.Replace("$s", ssTimeClock);

            GameTime.Text = correctString2;

            TimeClockM.Value = mTimeClock;
            TimeClockS.Value = sTimeClock;

            File.WriteAllText(@ScoreboardExport + "/GameTime.txt", GameTime.Text);
        }

        // TimeClock Start/Stop
        private void button13_Click(object sender, EventArgs e)
        {
            if (ClockPause == 3)
            {
                timeClock.Start();
                mTimeClock = Convert.ToInt32(TimeClockM.Value);
                sTimeClock = Convert.ToInt32(TimeClockS.Value);

                writeFile();

                ClockPause = 4;
            }

            if (ClockPause == 2)
            {
                timeClock.Stop();
                TimeClockM.Value = Convert.ToDecimal(mTimeClock);
                TimeClockS.Value = Convert.ToDecimal(sTimeClock);

                ClockPause = 3;
            }

            if (ClockPause == 1)
            {
                timeClock.Start();
                mTimeClock = Convert.ToInt32(TimeClockM.Value);
                sTimeClock = Convert.ToInt32(TimeClockS.Value);

                writeFile();

                ClockPause = 2;
            }

            if (ClockPause == 4)
            {
                ClockPause = 2;
            }
        }

        // Reset Time Clock
        private void button14_Click(object sender, EventArgs e)
        {
            timeClock.Stop();
            mTimeClock = 8;
            sTimeClock = 0;

            TimeClockM.Value = Convert.ToDecimal(mTimeClock);
            TimeClockS.Value = Convert.ToDecimal(sTimeClock);

            ClockPause = 1;

            writeFile();

            //File.WriteAllText(@ScoreboardExport + "/GameTime.txt", GameTime.Text);

        }

        // Period Up (2)
        private void period1_Click(object sender, EventArgs e)
        {
            periodState = periodState + 1;

            if (periodState == 5)
            {
                periodState = 0;
            }

            updatePeriod();
        }

        // Period Down (1)
        private void period2_Click(object sender, EventArgs e)
        {
            periodState = periodState - 1;

            if (periodState == -1)
            {
                periodState = 4;
            }

            updatePeriod();
        }

        // Period Update
        internal void updatePeriod()
        {
            if (periodState == 1)
            {
                GamePeriod.Text = "1st";
            }

            if (periodState == 2)
            {
                GamePeriod.Text = "2nd";
            }

            if (periodState == 3)
            {
                GamePeriod.Text = "3rd";
            }

            if (periodState == 4)
            {
                GamePeriod.Text = "4th";
            }

            if (periodState == 0)
            {
                GamePeriod.Text = "OT";
            }

            File.WriteAllText(@ScoreboardExport + "/GamePeriod.txt", GamePeriod.Text);

        }

        // Away Name Changed (Left)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(@ScoreboardExport + "/LeftName.txt", leftName.Text);

            Properties.Settings.Default.LeftName = leftName.Text;
            Properties.Settings.Default.Save();
        }

        // Home Name Changed (Right)
        private void HomeName_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(@ScoreboardExport + "/RightName.txt", rightName.Text);

            Properties.Settings.Default.RightName = rightName.Text;
            Properties.Settings.Default.Save();
        }

        // Keyboard Status Change
        private void button19_Click(object sender, EventArgs e)
        {
            int status = Properties.Settings.Default.KeyboardStatus;

            if (status == 0)
            {
                Properties.Settings.Default.KeyboardStatus = 1;
                Properties.Settings.Default.Save();
            }

            if (status == 1)
            {
                Properties.Settings.Default.KeyboardStatus = 0;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.KeyboardStatus == 0)
            {
                KeyboardStatus.Text = "Off";
            }

            if (Properties.Settings.Default.KeyboardStatus == 1)
            {
                KeyboardStatus.Text = "On";
            }
        }

        // Score Adjustments
        private void scoreUpdate()
        {
            File.WriteAllText(@ScoreboardExport + "/LeftScore.txt", leftScoreText.Value.ToString());

            File.WriteAllText(@ScoreboardExport + "/RightScore.txt", rightScoreText.Value.ToString());

            Properties.Settings.Default.LeftScore = leftScoreText.Value;
            Properties.Settings.Default.RightScore = rightScoreText.Value;

            Properties.Settings.Default.Save();
        }

        // Left Score +2
        private void button1_Click(object sender, EventArgs e)
        {
            leftScoreText.Value = leftScoreText.Value + 2;

            scoreUpdate();
        }

        // Left Score +3
        private void button2_Click(object sender, EventArgs e)
        {
            leftScoreText.Value = leftScoreText.Value + 3;

            scoreUpdate();
        }

        // Left Score +1
        private void button3_Click(object sender, EventArgs e)
        {
            leftScoreText.Value = leftScoreText.Value + 1;

            scoreUpdate();
        }

        // Left Score -2
        private void button4_Click(object sender, EventArgs e)
        {
            if (leftScoreText.Value == 1)
            {
                leftScoreText.Value = leftScoreText.Value - 1;

                scoreUpdate();
                return;
            }

            if (leftScoreText.Value == 0)
            {
                scoreUpdate();
                return;
            }
            
            leftScoreText.Value = leftScoreText.Value - 2;

            scoreUpdate();
        }

        // Left Score -3
        private void button5_Click(object sender, EventArgs e)
        {
            if (leftScoreText.Value == 2)
            {
                leftScoreText.Value = leftScoreText.Value - 2;

                scoreUpdate();
                return;
            }

            if (leftScoreText.Value == 1)
            {
                leftScoreText.Value = leftScoreText.Value - 1;

                scoreUpdate();
                return;
            }

            if (leftScoreText.Value == 0)
            {
                scoreUpdate();
                return;
            }

            leftScoreText.Value = leftScoreText.Value - 3;

            scoreUpdate();
        }

        // Left Score -1
        private void button6_Click(object sender, EventArgs e)
        {
            if (leftScoreText.Value == 0)
            {
                scoreUpdate();
                return;
            }

            leftScoreText.Value = leftScoreText.Value - 1;

            scoreUpdate();
        }

        // Right Score +2
        private void button10_Click(object sender, EventArgs e)
        {
            rightScoreText.Value = rightScoreText.Value + 2;

            scoreUpdate();
        }

        // Right Score +3
        private void button11_Click(object sender, EventArgs e)
        {
            rightScoreText.Value = rightScoreText.Value + 3;

            scoreUpdate();
        }

        // Right Score +1
        private void button12_Click(object sender, EventArgs e)
        {
            rightScoreText.Value = rightScoreText.Value + 1;

            scoreUpdate();
        }

        // Right Score -2
        private void button7_Click(object sender, EventArgs e)
        {
            if (rightScoreText.Value == 1)
            {
                rightScoreText.Value = rightScoreText.Value - 1;

                scoreUpdate();
                return;
            }

            if (rightScoreText.Value == 0)
            {
                scoreUpdate();
                return;
            }

            rightScoreText.Value = rightScoreText.Value -2;

            scoreUpdate();
        }

        // Right Score -3
        private void button8_Click(object sender, EventArgs e)
        {
            if (rightScoreText.Value == 2)
            {
                rightScoreText.Value = rightScoreText.Value - 2;

                scoreUpdate();
                return;
            }

            if (rightScoreText.Value == 1)
            {
                rightScoreText.Value = rightScoreText.Value - 1;

                scoreUpdate();
                return;
            }

            if (rightScoreText.Value == 0)
            {
                scoreUpdate();
                return;
            }

            rightScoreText.Value = rightScoreText.Value - 3;

            scoreUpdate();

        }

        // Right Score -1
        private void button9_Click(object sender, EventArgs e)
        {
            if (rightScoreText.Value == 0)
            {
                scoreUpdate();
                return;
            }

            rightScoreText.Value = rightScoreText.Value - 1;

            scoreUpdate();
        }

        // Reset Game
        private void resetGame_Click(object sender, EventArgs e)
        {
            rightScoreText.Value = rightScoreText.Value - rightScoreText.Value;

            leftScoreText.Value = leftScoreText.Value - leftScoreText.Value;

            timeClock.Stop();

            sTimeClock = 0;
            mTimeClock = 8;

            TimeClockM.Value = 8;
            TimeClockS.Value = 0;

            periodState = 1;

            updatePeriod();
            scoreUpdate();
            writeFile();
        }

    }
}
