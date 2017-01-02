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
        string livescoreXMLDOC = "c://StreamTools/livescore.xml";
        string exportDirectory = "c://StreamTools";

        // Initializing the Form and Create Directories
        public Form1()
        {
            InitializeComponent();

            //Create the main export directory
            Directory.CreateDirectory(Properties.Settings.Default.ExportDirectory);
            
            //Directory.CreateDirectory("c://StreamTools/StartingCountdown");
            //Directory.CreateDirectory("c://StreamTools/HalftimeCountdown");
            //Directory.CreateDirectory("c://StreamTools/LiveScore/");
            //Directory.CreateDirectory("c://StreamTools/LiveScore/Home");
            //Directory.CreateDirectory("c://StreamTools/LiveScore/Away");
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