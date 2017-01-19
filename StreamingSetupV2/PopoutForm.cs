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
    public partial class PopoutForm : Form
    {

        string formType;

        public PopoutForm(string popup)
        {
            InitializeComponent();

            if (popup == "scoreboard")
            {
                this.Controls.Add(scoreboard);

                formType = "scoreboard";
            }
        }

        private LiveScoreAlternative scoreboard = new LiveScoreAlternative();

        private void PopoutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (formType == "scoreboard")
            {
                if (Properties.Settings.Default.KeyboardStatus == 1)
                {
                    if (e.Control && e.KeyCode.ToString() == "Space")
                    {
                        scoreboard.button19.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "D2")
                    {
                        scoreboard.period1.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "D1")
                    {
                        scoreboard.period2.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "M")
                    {
                        scoreboard.button14.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "Space")
                    {
                        scoreboard.button13.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "E")
                    {
                        scoreboard.button1.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "D")
                    {
                        scoreboard.button2.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "C")
                    {
                        scoreboard.button3.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "W")
                    {
                        scoreboard.button4.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "S")
                    {
                        scoreboard.button5.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "X")
                    {
                        scoreboard.button6.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "T")
                    {
                        scoreboard.button10.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "G")
                    {
                        scoreboard.button11.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "B")
                    {
                        scoreboard.button12.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "R")
                    {
                        scoreboard.button7.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "F")
                    {
                        scoreboard.button8.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }

                    if (e.KeyCode.ToString() == "V")
                    {
                        scoreboard.button9.PerformClick();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }
                }
            }
        }

        private void PopoutForm_Load(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;

            scoreboard.leftName.Text = settings.LeftName;
            scoreboard.rightName.Text = settings.RightName;

            scoreboard.leftScoreText.Value = settings.LeftScore;
            scoreboard.rightScoreText.Value = settings.RightScore;

            scoreboard.TimeClockM.Value = settings.scoreTimeM;
            scoreboard.TimeClockS.Value = settings.scoreTimeS;

            scoreboard.periodState = settings.scorePeriodState;

            string desiredOutput = "$m:$s";

            string correctString1 = desiredOutput.Replace("$m", settings.scoreTimeM.ToString());
            string correctString2 = correctString1.Replace("$s", settings.scoreTimeS.ToString());

            scoreboard.GameTime.Text = correctString2;

            scoreboard.updatePeriod();
        }
        private void PopoutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var settings = Properties.Settings.Default;

            settings.scorePeriodState = scoreboard.periodState;

            settings.scoreTimeM = scoreboard.TimeClockM.Value;
            settings.scoreTimeS = scoreboard.TimeClockS.Value;
        }
    }
}
