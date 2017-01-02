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

        string ExportDirectory2 = Properties.Settings.Default.ExportDirectory;
        string LiveScoreFileBase = "c://StreamTools/LiveScore";
        string LiveScoreFileHome = "c://StreamTools/LiveScore/Home";
        string LiveScoreFileAway = "c://StreamTools/LiveScore/Away";
        string StartingCountdownFile = "c://StreamTools/StartingCountdown";
        string HalftimeCountdownFile = "c://StreamTools/HalftimeCountdown";
        string livescoreXMLDOC = "c://StreamTools/livescore.xml";
        string exportDirectory = "c://StreamTools";

        // Initializing the Form and Create Directories
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory("c://StreamTools/");
            Directory.CreateDirectory("c://StreamTools/StartingCountdown");
            Directory.CreateDirectory("c://StreamTools/HalftimeCountdown");
            Directory.CreateDirectory("c://StreamTools/LiveScore/");
            Directory.CreateDirectory("c://StreamTools/LiveScore/Home");
            Directory.CreateDirectory("c://StreamTools/LiveScore/Away");
        }

        //  Starting/Pausing/Stopping - Starting Soon Countdown
        int hStart;
        int mStart;
        int sStart;
        string hhStart;
        string mmStart;
        string ssStart;
        int StartingPause = 1;

        private void StartStartButton_Click(object sender, EventArgs e)
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

            if (hStart == 0 & mStart == 0 & sStart == 0)
            {
                startingSoonTimer.Stop();
                StartLiveOutputTextBox.Text = StartMsgTextBox.Text;
                File.WriteAllText(@StartingCountdownFile + "/starting-countdown.txt", StartMsgTextBox.Text);
            }

            // StartLiveOutputTextBox.Text = hhStart + ":" + mmStart + ":" + ssStart;
        }

        //  Starting/Pausing/Stopping - Halftime Countdown
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
            mHalftime = 12;
            sHalftime = 1;

            HalfTimeH.Value = Convert.ToDecimal(hHalftime);
            HalfTimeM.Value = Convert.ToDecimal(mHalftime);
            HalfTimeS.Value = Convert.ToDecimal(sHalftime);

            HalftimeLiveOutputTextBox.Text = "";

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

            string hhHalftime = Convert.ToString(hHalftime);
            string mmHalftime = Convert.ToString(mHalftime);
            string ssHalftime = Convert.ToString(sHalftime);

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

            string desiredOutput = StartOutputFormatTextBox.Text;

            string correctString1 = desiredOutput.Replace("$h", Convert.ToString(hHalftime));
            string correctString2 = correctString1.Replace("$m", Convert.ToString(mHalftime));
            string correctString3 = correctString2.Replace("$s", Convert.ToString(sHalftime));

            HalftimeLiveOutputTextBox.Text = correctString3;

            File.WriteAllText(@HalftimeCountdownFile + "/halftime-countdown.txt", correctString3);

            // HalftimeLiveOutputTextBox.Text = hhHalftime + ":" + mmHalftime + ":" + ssHalftime;

            if (hHalftime == 0 & mHalftime == 0 & sHalftime == 0)
            {
                halftimeTimer.Stop();
                HalftimeLiveOutputTextBox.Text = HalftimeMsgTextBox.Text;
                File.WriteAllText(@HalftimeCountdownFile + "/halftime-countdown.txt", HalftimeMsgTextBox.Text);
            }
        }

        // Interprets XML File
        public string GetLiveScoreInformation(string info)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            string str = null;
            try
            {
                FileStream fs = new FileStream(@LiveScoreFileBase + "/livescore.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);

                xmlnode = xmldoc.GetElementsByTagName(info);

                str = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                fs.Close();
                return str;
            }
            catch (Exception e)
            {
                return null;
            }


        }
        // Runs constantly to Update TXT files
        private void livescoreupdate_Tick(object sender, EventArgs e)
        {
            AwayName.Text = GetLiveScoreInformation("team_away");
            AwayScore.Text = GetLiveScoreInformation("score_away");
            AwayTimeouts.Text = GetLiveScoreInformation("timeouts_away");
            string StringAwayBonus = GetLiveScoreInformation("bonus_away");

            if (Convert.ToInt32(StringAwayBonus) == 1)
            {
                AwayBonus.Text = "BONUS";
            }

            if (Convert.ToInt32(StringAwayBonus) == 0)
            {
                AwayBonus.Text = "";
            }

            AwayFouls.Text = GetLiveScoreInformation("fouls_away");

            HomeName.Text = GetLiveScoreInformation("team_home");
            HomeScore.Text = GetLiveScoreInformation("score_home");
            HomeTimeouts.Text = GetLiveScoreInformation("timeouts_home");
            string StringHomeBonus = GetLiveScoreInformation("bonus_home");

            if (Convert.ToInt32(StringHomeBonus) == 1)
            {
                HomeBonus.Text = "BONUS";
            }

            if (Convert.ToInt32(StringHomeBonus) == 0)
            {
                HomeBonus.Text = "";
            }

            HomeFouls.Text = GetLiveScoreInformation("fouls_home");

            string StringGamePeriod = GetLiveScoreInformation("period");
            if (Convert.ToInt32(StringGamePeriod) == 1)
            {
                GamePeriod.Text = "1st";
            }

            if (Convert.ToInt32(StringGamePeriod) == 2)
            {
                GamePeriod.Text = "2nd";
            }

            if (Convert.ToInt32(StringGamePeriod) == 3)
            {
                GamePeriod.Text = "3rd";
            }

            if (Convert.ToInt32(StringGamePeriod) == 4)
            {
                GamePeriod.Text = "4th";
            }

            if (Convert.ToInt32(StringGamePeriod) == 5)
            {
                GamePeriod.Text = "OT";
            }

            GameTime.Text = GetLiveScoreInformation("time");
            GameShotClock.Text = GetLiveScoreInformation("shotclock");

            File.WriteAllText(@LiveScoreFileAway + "/livescore_away_name.txt", AwayName.Text);
            File.WriteAllText(@LiveScoreFileAway + "/livescore_away_score.txt", AwayScore.Text);
            File.WriteAllText(@LiveScoreFileAway + "/livescore_away_timeouts.txt", AwayTimeouts.Text);
            File.WriteAllText(@LiveScoreFileAway + "/livescore_away_bonus.txt", AwayBonus.Text);
            File.WriteAllText(@LiveScoreFileAway + "/livescore_away_fouls.txt", AwayFouls.Text);

            File.WriteAllText(@LiveScoreFileHome + "/livescore_home_name.txt", HomeName.Text);
            File.WriteAllText(@LiveScoreFileHome + "/livescore_home_score.txt", HomeScore.Text);
            File.WriteAllText(@LiveScoreFileHome + "/livescore_home_timeouts.txt", HomeTimeouts.Text);
            File.WriteAllText(@LiveScoreFileHome + "/livescore_home_bonus.txt", HomeBonus.Text);
            File.WriteAllText(@LiveScoreFileHome + "/livescore_home_fouls.txt", HomeFouls.Text);

            File.WriteAllText(@LiveScoreFileBase + "/livescore_game_period.txt", GamePeriod.Text);
            File.WriteAllText(@LiveScoreFileBase + "/livescore_game_time.txt", GameTime.Text);
            File.WriteAllText(@LiveScoreFileBase + "/livescore_game_shotclock.txt", GameShotClock.Text);
        }

        private void startingSoonCountdown1_Load(object sender, EventArgs e)
        {

        }
    }
}