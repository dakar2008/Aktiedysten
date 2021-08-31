using Aktiedysten.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Aktiedysten.Models;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aktiedysten
{
    public partial class Form1 : Form
    {
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public Form1()
        {
            InitializeComponent();
            if (rkApp.GetValue("AktieDystenApp") != null)
            {
                StartWithWindowsMenuItem.Text = "Fjern Start Med Windows";
                StartWithWindowsMenuItem.Image = Resources.Alarm_Error_icon;
            }
            if (Settings.Default.ShowLiveCurrency)
            {

                ShowLiveCurrencyRatesBtn.Visible = false;
                CurrencyRatesGroupBox.Visible = true;
                HideLiveCurrencyRatesBtn.Visible = true;
            }
            else
            {
                ShowLiveCurrencyRatesBtn.Visible = true;
                CurrencyRatesGroupBox.Visible = false;
                HideLiveCurrencyRatesBtn.Visible = false;
            }
            if (Settings.Default.AlwaysOnTop)
            {
                this.TopMost = true;
                AlwaysOnTopMenuItem.Text = "Fjern Altid Øverst";
                AlwaysOnTopMenuItem.Image = Resources.Action_window_fullscreen_icon;
            }
            else
            {
                this.TopMost = false;
                AlwaysOnTopMenuItem.Text = "Altid Øverst";
                AlwaysOnTopMenuItem.Image = Resources.Action_window_new_icon;
            }
            if (Settings.Default.LastWindowPositionY != 0 && Settings.Default.LastWindowPositonX != 0)
            {
                StartPosition = FormStartPosition.Manual;
                Point lastposition = new Point(Settings.Default.LastWindowPositonX, Settings.Default.LastWindowPositionY);
                this.Location = lastposition;
            }
            if (Settings.Default.StartMinimized)
            {
                this.WindowState = FormWindowState.Minimized;
                Hide();
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Aktiedysten - Markeder";
                notifyIcon1.BalloonTipText = "Notifikationer aktiveret!";
                notifyIcon1.ShowBalloonTip(15000, "Aktiedysten - Markeder", "Notifikationer aktiveret!", ToolTipIcon.Info);
                StartMinimizedMenuItem.Text = "Start Normal";
                StartMinimizedMenuItem.Image = Resources.Programming_Maximize_Window_icon;
            }
            else
            {
                StartMinimizedMenuItem.Text = "Start Minimered";
                StartMinimizedMenuItem.Image = Resources.Programming_Minimize_Window_icon;
            }
        }

        private void GlobalTimer_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            if (Helper.IsWorkingDay(Now))
            {
                #region Denmark

                TimerAction(Now, "DK", DK_Market_Status, DK_Market_Status2, DK_Timer_DateTime, DK_Market_Timer);
                ShowLabel(DK_Market_Timer);

                #endregion

                #region United States

                TimerAction(Now, "US", US_Market_Status, US_Market_Status2, US_Timer_DateTime, US_Market_Timer);
                ShowLabel(US_Market_Timer);

                #endregion

                #region Germany

                TimerAction(Now, "DE", DE_Market_Status, DE_Market_Status2, DE_Timer_DateTime, DE_Market_Timer);
                ShowLabel(DE_Market_Timer);
                #endregion

                #region Sweden

                TimerAction(Now, "SE", SE_Market_Status, SE_Market_Status2, SE_Timer_DateTime, SE_Market_Timer);
                ShowLabel(SE_Market_Timer);
                #endregion

                #region Finland

                TimerAction(Now, "FI", FI_Market_Status, FI_Market_Status2, FI_Timer_DateTime, FI_Market_Timer);
                ShowLabel(FI_Market_Timer);

                #endregion

                #region Austria

                TimerAction(Now, "A", A_Market_Status, A_Market_Status2, A_Timer_DateTime, A_Market_Timer);
                ShowLabel(A_Market_Timer);
                #endregion

                #region Island

                TimerAction(Now, "IS", IS_Market_Status, IS_Market_Status2, IS_Timer_DateTime, IS_Market_Timer);
                ShowLabel(IS_Market_Timer);

                #endregion
            }
            else
            {
                #region Denmark
                CloseStatusText(DK_Market_Status);
                HideLabel(DK_Market_Status2);
                HideLabel(DK_Market_Timer);
                HideLabel(DK_Timer_DateTime);
                ShowLabel(DK_WeekendClosed);
                #endregion

                #region United States
                CloseStatusText(US_Market_Status);
                HideLabel(US_Market_Status2);
                HideLabel(US_Market_Timer);
                HideLabel(US_Timer_DateTime);
                ShowLabel(US_WeekendClosed);
                #endregion

                #region Germany
                CloseStatusText(DE_Market_Status);
                HideLabel(DE_Market_Status2);
                HideLabel(DE_Market_Timer);
                HideLabel(DE_Timer_DateTime);
                ShowLabel(DE_WeekendClosed);
                #endregion

                #region Sweden
                CloseStatusText(SE_Market_Status);
                HideLabel(SE_Market_Status2);
                HideLabel(SE_Market_Timer);
                HideLabel(SE_Timer_DateTime);
                ShowLabel(SE_WeekendClosed);
                #endregion

                #region Finland
                CloseStatusText(FI_Market_Status);
                HideLabel(FI_Market_Status2);
                HideLabel(FI_Market_Timer);
                HideLabel(FI_Timer_DateTime);
                ShowLabel(FI_WeekendClosed);
                #endregion

                #region Austria
                CloseStatusText(A_Market_Status);
                HideLabel(A_Market_Status2);
                HideLabel(A_Market_Timer);
                HideLabel(A_Timer_DateTime);
                ShowLabel(A_WeekendClosed);
                #endregion

                #region Island
                CloseStatusText(IS_Market_Status);
                HideLabel(IS_Market_Status2);
                HideLabel(IS_Market_Timer);
                HideLabel(IS_Timer_DateTime);
                ShowLabel(IS_WeekendClosed);
                #endregion
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = true;
        }

        private void afslutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("http://www.aktiedysten.dk");
        }

        private void OpenAktiedystenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.aktiedysten.dk");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Settings.Default.LastWindowPositionY = this.Location.Y;
                Settings.Default.LastWindowPositonX = this.Location.X;
                Settings.Default.Save();
                notifyIcon1.Visible = true;
                this.Hide();
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GlobalTimer.Start();
            CurrencyRateTimer.Start();
            CurrencyRateTimer.Interval = 100;
        }

        private void StartWithWindowsMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.StartWithWindows)
            {
                rkApp.DeleteValue("AktieDystenApp", false);
                Settings.Default.StartWithWindows = false;
                Settings.Default.Save();
                StartWithWindowsMenuItem.Text = "Start Med Windows";
                StartWithWindowsMenuItem.Image = Resources.Alarm_Arrow_Right_icon;
            }
            else
            {
                rkApp.SetValue("AktieDystenApp", Application.ExecutablePath);
                Settings.Default.StartWithWindows = true;
                Settings.Default.Save();
                StartWithWindowsMenuItem.Text = "Fjern Start Med Windows";
                StartWithWindowsMenuItem.Image = Resources.Alarm_Error_icon;
            }
        }

        private void StartMinimizedMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.StartMinimized)
            {
                Settings.Default.StartMinimized = false;
                Settings.Default.Save();
                StartMinimizedMenuItem.Text = "Start Minimered";
                StartMinimizedMenuItem.Image = Resources.Programming_Minimize_Window_icon;
            }
            else
            {
                Settings.Default.StartMinimized = true;
                Settings.Default.Save();
                StartMinimizedMenuItem.Text = "Start Normal";
                StartMinimizedMenuItem.Image = Resources.Programming_Maximize_Window_icon;
            }
        }

        private void CurrencyRateTimer_Tick(object sender, EventArgs e)
        {
            if(CurrencyRateTimer.Interval == 100)
            {
                CurrencyRateTimer.Interval = 180000;
            }
            DateTime current = DateTime.Now;
            CurrencyRates rates = Helper.GetRates();
            CurrencyRateLastUpdatedLabel.Text = current.ToString("dd-MM-yyyy HH:mm:ss");
            double dollarcalc = rates.rates.USD * 100;
            double eurocalc = rates.rates.EUR * 100;
            double swecalc = rates.rates.SEK * 100;
            double iskcalc = rates.rates.ISK * 100;
            DollarCurrencyRateLabel.Text = string.Format("${0}", dollarcalc.ToString("N2"));
            EuroCurrencyRateLabel.Text = string.Format("€{0}", eurocalc.ToString("N2"));
            SwedishKronerCurrencyRateLabel.Text = string.Format("SEK {0}", swecalc.ToString("N2"));
            IslandishKronerCurrencyRateLabel.Text = string.Format("ISK {0}", iskcalc.ToString("N2"));
        }

        private void ShowLiveCurrencyRatesBtn_Click(object sender, EventArgs e)
        {
            CurrencyRatesGroupBox.Visible = true;
            ShowLiveCurrencyRatesBtn.Visible = false;
            HideLiveCurrencyRatesBtn.Visible = true;
            Settings.Default.ShowLiveCurrency = true;
            Settings.Default.Save();
        }

        private void HideLiveCurrencyRatesBtn_Click(object sender, EventArgs e)
        {
            CurrencyRatesGroupBox.Visible = false;
            ShowLiveCurrencyRatesBtn.Visible = true;
            HideLiveCurrencyRatesBtn.Visible = false;
            Settings.Default.ShowLiveCurrency = false;
            Settings.Default.Save();
        }

        #region Functions
        public void OpenStatusText(Label thistextbox)
        {
            thistextbox.Text = "Åben";
            thistextbox.ForeColor = Color.LightGreen;
        }
        public void OpenSmallStatusText(Label thistextbox)
        {
            thistextbox.Text = "Lukker Om:";
        }
        public void CloseStatusText(Label thistextbox)
        {
            thistextbox.Text = "Lukket";
            thistextbox.ForeColor = Color.Red;
        }
        public void CloseSmallStatusText(Label thistextbox)
        {
            thistextbox.Text = "Åbner Om:";
        }
        public void CloseSmallWeekendStatusText(Label thistextbox)
        {
            thistextbox.Text = "Lukket";
        }
        public void CloseSmallWeekendTimerText(Label thistextbox)
        {
            thistextbox.Text = "Weekend Lukket";
        }
        public void TimeBeforeClose(Label thislabel, DateTime Current, DateTime ClosingHour, NotifyIcon thisnotify, string Country)
        {
            TimeSpan ts;
            if(ClosingHour > Current)
            {
                ts = ClosingHour.Subtract(Current);
            }
            else
            {
                ts = Current.Subtract(ClosingHour);
            }
            thislabel.Text = Helper.TimeLeft(ts);
            if (ts.Hours == 0 && ts.Minutes > 20 && ts.Minutes <= 59)
            {
                thislabel.ForeColor = Color.Yellow;
            }
            else if (ts.Hours == 0 && ts.Minutes == 20 && ts.Seconds == 0)
            {
                if (thisnotify.Visible)
                {
                    int timeout = 15000;
                    string closedtitle = "Marked Lukker Snart!";
                    string closedtext;
                    notifyIcon1.BalloonTipTitle = closedtitle;
                    if (Country == "DK")
                    {
                        closedtext = string.Format("Det {0} aktiemarked lukker snart...", "danske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else if (Country == "US")
                    {
                        closedtext = string.Format("Det {0} aktiemarked lukker snart...", "amerikanske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else if (Country == "DE")
                    {
                        closedtext = string.Format("Det {0} aktiemarked lukker snart...", "tyske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else if (Country == "SE")
                    {
                        closedtext = string.Format("Det {0} aktiemarked lukker snart...", "svenske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else if (Country == "FI")
                    {
                        closedtext = string.Format("Det {0} aktiemarked lukker snart...", "finske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else if (Country == "A")
                    {
                        closedtext = string.Format("Det {0} aktiemarked lukker snart...", "østriske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else
                    {
                        closedtext = string.Format("Det {0} aktiemarked lukker snart...", "islandske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    notifyIcon1.BalloonTipText = closedtext;
                }
            }
            else if (ts.Hours == 0 && ts.Minutes == 0 && ts.Seconds == 5)
            {
                if (thisnotify.Visible)
                {
                    int timeout = 15000;
                    string closedtitle = "Marked Er Lukket!";
                    string closedtext;
                    if (Country == "DK")
                    {
                        closedtext = string.Format("Det {0} aktiemarked er nu lukket...", "danske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else if (Country == "US")
                    {
                        closedtext = string.Format("Det {0} aktiemarked er nu lukket...", "amerikanske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else if (Country == "DE")
                    {
                        closedtext = string.Format("Det {0} aktiemarked er nu lukket...", "tyske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else if (Country == "SE")
                    {
                        closedtext = string.Format("Det {0} aktiemarked er nu lukket...", "svenske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else if (Country == "FI")
                    {
                        closedtext = string.Format("Det {0} aktiemarked er nu lukket...", "finske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else if (Country == "A")
                    {
                        closedtext = string.Format("Det {0} aktiemarked er nu lukket...", "østriske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    else
                    {
                        closedtext = string.Format("Det {0} aktiemarked er nu lukket...", "islandske");
                        thisnotify.ShowBalloonTip(timeout, closedtitle, closedtext, ToolTipIcon.Info);
                    }
                    notifyIcon1.BalloonTipText = closedtext;
                }
            }
            else if (ts.Hours == 0 && ts.Minutes <= 20)
            {
                thislabel.ForeColor = Color.Red;
            }
            else
            {
                thislabel.ForeColor = Color.White;
            }
        }
        public void TimeBeforeOpen(Label thislabel, DateTime Current, DateTime OpenHour, NotifyIcon thisnotify, string Country)
        {
            TimeSpan ts;
            if (OpenHour > Current)
            {
                ts = OpenHour.Subtract(Current);
            }
            else
            {
                ts = Current.Subtract(OpenHour);
            }
            thislabel.Text = Helper.TimeLeft(ts);
            if (ts.Hours == 0 && ts.Minutes > 20 && ts.Minutes <= 59)
            {
                thislabel.ForeColor = Color.Yellow;
            }
            else if (ts.Hours == 0 && ts.Minutes == 20 && ts.Seconds == 0)
            {
                if (thisnotify.Visible)
                {
                    int timeout = 15000;
                    string opentitle = "Marked Åbner Snart!";
                    string opentext;
                    notifyIcon1.BalloonTipTitle = opentitle;
                    if (Country == "DK")
                    {
                        opentext = string.Format("Det {0} aktiemarked åbner snart...", "danske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else if (Country == "US")
                    {
                        opentext = string.Format("Det {0} aktiemarked åbner snart...", "amerikanske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else if (Country == "DE")
                    {
                        opentext = string.Format("Det {0} aktiemarked åbner snart...", "tyske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else if (Country == "SE")
                    {
                        opentext = string.Format("Det {0} aktiemarked åbner snart...", "svenske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else if (Country == "FI")
                    {
                        opentext = string.Format("Det {0} aktiemarked åbner snart...", "finske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else if (Country == "A")
                    {
                        opentext = string.Format("Det {0} aktiemarked åbner snart...", "østriske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else
                    {
                        opentext = string.Format("Det {0} aktiemarked åbner snart...", "islandske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    notifyIcon1.BalloonTipText = opentext;
                }
            }
            else if (ts.Hours == 0 && ts.Minutes == 0 && ts.Seconds == 5)
            {
                if (thisnotify.Visible)
                {
                    int timeout = 15000;
                    string opentitle = "Marked Er Nu Åbent!";
                    notifyIcon1.BalloonTipTitle = opentitle;
                    string opentext;
                    if (Country == "DK")
                    {
                        opentext = string.Format("Det {0} aktiemarked er nu åbent...", "danske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else if (Country == "US")
                    {
                        opentext = string.Format("Det {0} aktiemarked er nu åbent...", "amerikanske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else if (Country == "DE")
                    {
                        opentext = string.Format("Det {0} aktiemarked er nu åbent...", "tyske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else if (Country == "SE")
                    {
                        opentext = string.Format("Det {0} aktiemarked er nu åbent...", "svenske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else if (Country == "FI")
                    {
                        opentext = string.Format("Det {0} aktiemarked er nu åbent...", "finske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else if (Country == "A")
                    {
                        opentext = string.Format("Det {0} aktiemarked er nu åbent...", "østriske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    else
                    {
                        opentext = string.Format("Det {0} aktiemarked er nu åbent...", "islandske");
                        thisnotify.ShowBalloonTip(timeout, opentitle, opentext, ToolTipIcon.Info);
                    }
                    notifyIcon1.BalloonTipText = opentext;
                }
            }
            else if (ts.Hours == 0 && ts.Minutes <= 20)
            {
                thislabel.ForeColor = Color.LimeGreen;
            }
            else
            {
                thislabel.ForeColor = Color.White;
            }
        }
        public void TimerAction(DateTime Now, string Country, Label StatusLabel, Label StatusLabel2, Label TimerLabel, Label ShowTimeDate)
        {
            if (Helper.IsMarketOpen(Now, Helper.GetTime(Country), Helper.GetTime(Country, false)))
            {
                OpenStatusText(StatusLabel);
                OpenSmallStatusText(StatusLabel2);
                TimeBeforeClose(TimerLabel, Now, Helper.GetTime(Country, false), notifyIcon1, Country);
                ShowMarketDateTime(ShowTimeDate, Country);
            }
            else
            {
                CloseStatusText(StatusLabel);
                CloseSmallStatusText(StatusLabel2);
                TimeBeforeOpen(TimerLabel, Now, Helper.GetTime(Country), notifyIcon1, Country);
                ShowMarketDateTime(ShowTimeDate, Country, false);
            }
        }
        public void ShowMarketDateTime(Label thislabel, string Country, bool MarketOpen = true)
        {
            if (MarketOpen)
            {
                DateTime ThisTime = Helper.GetTime(Country, false);
                thislabel.Text = ThisTime.ToString("HH:mm:ss");
                thislabel.ForeColor = Color.Orange;
            }
            else
            {
                DateTime ThisTime = Helper.GetTime(Country);
                thislabel.Text = ThisTime.ToString("HH:mm:ss");
                thislabel.ForeColor = Color.Orange;
            }
        }
        public void HideLabel(Label thislabel)
        {
            thislabel.Visible = false;
        }
        public void ShowLabel(Label thislabel)
        {
            thislabel.Visible = true;
        }
        #endregion

        private void AlwaysOnTopMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AlwaysOnTop)
            {
                Settings.Default.AlwaysOnTop = false;
                Settings.Default.Save();
                AlwaysOnTopMenuItem.Text = "Altid Øverst";
                AlwaysOnTopMenuItem.Image = Resources.Action_window_new_icon;
                this.TopMost = false;
            }
            else
            {
                Settings.Default.AlwaysOnTop = true;
                Settings.Default.Save();
                AlwaysOnTopMenuItem.Text = "Fjern Altid Øverst";
                AlwaysOnTopMenuItem.Image = Resources.Action_window_fullscreen_icon;
                this.TopMost = true;
            }
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if(notifyIcon1.BalloonTipText == "Notifikationer aktiveret!" && notifyIcon1.BalloonTipTitle == "Aktiedysten - Markeder")
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = true;
            }
            else
            {
                Process.Start("http://www.aktiedysten.dk");
            }
        }
    }
}