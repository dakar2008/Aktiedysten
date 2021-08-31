namespace Aktiedysten
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifymenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenAktiedystenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlwaysOnTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartWithWindowsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartMinimizedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afslutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DK_Market_Status = new System.Windows.Forms.Label();
            this.DK_Market_Status2 = new System.Windows.Forms.Label();
            this.DK_Market_Timer = new System.Windows.Forms.Label();
            this.US_Market_Timer = new System.Windows.Forms.Label();
            this.US_Market_Status2 = new System.Windows.Forms.Label();
            this.US_Market_Status = new System.Windows.Forms.Label();
            this.DE_Market_Timer = new System.Windows.Forms.Label();
            this.DE_Market_Status2 = new System.Windows.Forms.Label();
            this.DE_Market_Status = new System.Windows.Forms.Label();
            this.SE_Market_Timer = new System.Windows.Forms.Label();
            this.SE_Market_Status2 = new System.Windows.Forms.Label();
            this.SE_Market_Status = new System.Windows.Forms.Label();
            this.FI_Market_Timer = new System.Windows.Forms.Label();
            this.FI_Market_Status2 = new System.Windows.Forms.Label();
            this.FI_Market_Status = new System.Windows.Forms.Label();
            this.A_Market_Timer = new System.Windows.Forms.Label();
            this.A_Market_Status2 = new System.Windows.Forms.Label();
            this.A_Market_Status = new System.Windows.Forms.Label();
            this.IS_Market_Timer = new System.Windows.Forms.Label();
            this.IS_Market_Status2 = new System.Windows.Forms.Label();
            this.IS_Market_Status = new System.Windows.Forms.Label();
            this.GlobalTimer = new System.Windows.Forms.Timer(this.components);
            this.DK_Timer_DateTime = new System.Windows.Forms.Label();
            this.US_Timer_DateTime = new System.Windows.Forms.Label();
            this.DE_Timer_DateTime = new System.Windows.Forms.Label();
            this.SE_Timer_DateTime = new System.Windows.Forms.Label();
            this.FI_Timer_DateTime = new System.Windows.Forms.Label();
            this.A_Timer_DateTime = new System.Windows.Forms.Label();
            this.IS_Timer_DateTime = new System.Windows.Forms.Label();
            this.DK_WeekendClosed = new System.Windows.Forms.Label();
            this.US_WeekendClosed = new System.Windows.Forms.Label();
            this.DE_WeekendClosed = new System.Windows.Forms.Label();
            this.SE_WeekendClosed = new System.Windows.Forms.Label();
            this.FI_WeekendClosed = new System.Windows.Forms.Label();
            this.A_WeekendClosed = new System.Windows.Forms.Label();
            this.IS_WeekendClosed = new System.Windows.Forms.Label();
            this.aktiedystenLogo_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CurrencyRatesGroupBox = new System.Windows.Forms.GroupBox();
            this.IslandishKronerCurrencyRateLabel = new System.Windows.Forms.Label();
            this.IslandishKronerTextLabel = new System.Windows.Forms.Label();
            this.SwedishKronerCurrencyRateLabel = new System.Windows.Forms.Label();
            this.SwedishKronerTextLabel = new System.Windows.Forms.Label();
            this.EuroCurrencyRateLabel = new System.Windows.Forms.Label();
            this.EuroTextLabel = new System.Windows.Forms.Label();
            this.DollarCurrencyRateLabel = new System.Windows.Forms.Label();
            this.DollarTextLabel = new System.Windows.Forms.Label();
            this.CurrencyRateLastUpdateTextLabel = new System.Windows.Forms.Label();
            this.CurrencyRateLastUpdatedLabel = new System.Windows.Forms.Label();
            this.BaseCurrencyLabel = new System.Windows.Forms.Label();
            this.CurrencyRateTimer = new System.Windows.Forms.Timer(this.components);
            this.HideLiveCurrencyRatesBtn = new System.Windows.Forms.Button();
            this.ShowLiveCurrencyRatesBtn = new System.Windows.Forms.Button();
            this.notifymenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CurrencyRatesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notifymenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Aktiedysten - Markeder";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // notifymenu
            // 
            this.notifymenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenAktiedystenToolStripMenuItem,
            this.AlwaysOnTopMenuItem,
            this.StartWithWindowsMenuItem,
            this.StartMinimizedMenuItem,
            this.afslutToolStripMenuItem});
            this.notifymenu.Name = "notifymenu";
            this.notifymenu.Size = new System.Drawing.Size(213, 114);
            // 
            // OpenAktiedystenToolStripMenuItem
            // 
            this.OpenAktiedystenToolStripMenuItem.Image = global::Aktiedysten.Properties.Resources.aktiedysten_minilogo;
            this.OpenAktiedystenToolStripMenuItem.Name = "OpenAktiedystenToolStripMenuItem";
            this.OpenAktiedystenToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.OpenAktiedystenToolStripMenuItem.Text = "Åben Aktiedysten Website";
            this.OpenAktiedystenToolStripMenuItem.Click += new System.EventHandler(this.OpenAktiedystenToolStripMenuItem_Click);
            // 
            // AlwaysOnTopMenuItem
            // 
            this.AlwaysOnTopMenuItem.Image = global::Aktiedysten.Properties.Resources.Action_window_new_icon;
            this.AlwaysOnTopMenuItem.Name = "AlwaysOnTopMenuItem";
            this.AlwaysOnTopMenuItem.Size = new System.Drawing.Size(212, 22);
            this.AlwaysOnTopMenuItem.Text = "Altid Øverst";
            this.AlwaysOnTopMenuItem.Click += new System.EventHandler(this.AlwaysOnTopMenuItem_Click);
            // 
            // StartWithWindowsMenuItem
            // 
            this.StartWithWindowsMenuItem.Image = global::Aktiedysten.Properties.Resources.Alarm_Arrow_Right_icon;
            this.StartWithWindowsMenuItem.Name = "StartWithWindowsMenuItem";
            this.StartWithWindowsMenuItem.Size = new System.Drawing.Size(212, 22);
            this.StartWithWindowsMenuItem.Text = "Start Med Windows";
            this.StartWithWindowsMenuItem.Click += new System.EventHandler(this.StartWithWindowsMenuItem_Click);
            // 
            // StartMinimizedMenuItem
            // 
            this.StartMinimizedMenuItem.Image = global::Aktiedysten.Properties.Resources.Programming_Minimize_Window_icon;
            this.StartMinimizedMenuItem.Name = "StartMinimizedMenuItem";
            this.StartMinimizedMenuItem.Size = new System.Drawing.Size(212, 22);
            this.StartMinimizedMenuItem.Text = "Start Minimered";
            this.StartMinimizedMenuItem.Click += new System.EventHandler(this.StartMinimizedMenuItem_Click);
            // 
            // afslutToolStripMenuItem
            // 
            this.afslutToolStripMenuItem.Image = global::Aktiedysten.Properties.Resources.Actions_application_exit_icon;
            this.afslutToolStripMenuItem.Name = "afslutToolStripMenuItem";
            this.afslutToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.afslutToolStripMenuItem.Text = "Afslut";
            this.afslutToolStripMenuItem.Click += new System.EventHandler(this.afslutToolStripMenuItem_Click);
            // 
            // DK_Market_Status
            // 
            this.DK_Market_Status.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DK_Market_Status.ForeColor = System.Drawing.Color.Red;
            this.DK_Market_Status.Location = new System.Drawing.Point(78, 74);
            this.DK_Market_Status.Name = "DK_Market_Status";
            this.DK_Market_Status.Size = new System.Drawing.Size(202, 63);
            this.DK_Market_Status.TabIndex = 3;
            this.DK_Market_Status.Text = "Åbent";
            this.DK_Market_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DK_Market_Status2
            // 
            this.DK_Market_Status2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DK_Market_Status2.ForeColor = System.Drawing.Color.DarkGray;
            this.DK_Market_Status2.Location = new System.Drawing.Point(286, 74);
            this.DK_Market_Status2.Name = "DK_Market_Status2";
            this.DK_Market_Status2.Size = new System.Drawing.Size(202, 21);
            this.DK_Market_Status2.TabIndex = 4;
            this.DK_Market_Status2.Text = "Åbner Om:";
            this.DK_Market_Status2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DK_Market_Timer
            // 
            this.DK_Market_Timer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DK_Market_Timer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DK_Market_Timer.Location = new System.Drawing.Point(286, 95);
            this.DK_Market_Timer.Name = "DK_Market_Timer";
            this.DK_Market_Timer.Size = new System.Drawing.Size(202, 21);
            this.DK_Market_Timer.TabIndex = 5;
            this.DK_Market_Timer.Text = "23:33:00";
            this.DK_Market_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // US_Market_Timer
            // 
            this.US_Market_Timer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.US_Market_Timer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.US_Market_Timer.Location = new System.Drawing.Point(286, 164);
            this.US_Market_Timer.Name = "US_Market_Timer";
            this.US_Market_Timer.Size = new System.Drawing.Size(202, 21);
            this.US_Market_Timer.TabIndex = 9;
            this.US_Market_Timer.Text = "23:33:00";
            this.US_Market_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // US_Market_Status2
            // 
            this.US_Market_Status2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.US_Market_Status2.ForeColor = System.Drawing.Color.DarkGray;
            this.US_Market_Status2.Location = new System.Drawing.Point(286, 143);
            this.US_Market_Status2.Name = "US_Market_Status2";
            this.US_Market_Status2.Size = new System.Drawing.Size(202, 21);
            this.US_Market_Status2.TabIndex = 8;
            this.US_Market_Status2.Text = "Åbner Om:";
            this.US_Market_Status2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // US_Market_Status
            // 
            this.US_Market_Status.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.US_Market_Status.ForeColor = System.Drawing.Color.Red;
            this.US_Market_Status.Location = new System.Drawing.Point(78, 143);
            this.US_Market_Status.Name = "US_Market_Status";
            this.US_Market_Status.Size = new System.Drawing.Size(202, 63);
            this.US_Market_Status.TabIndex = 7;
            this.US_Market_Status.Text = "Åbent";
            this.US_Market_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DE_Market_Timer
            // 
            this.DE_Market_Timer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DE_Market_Timer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DE_Market_Timer.Location = new System.Drawing.Point(286, 233);
            this.DE_Market_Timer.Name = "DE_Market_Timer";
            this.DE_Market_Timer.Size = new System.Drawing.Size(202, 21);
            this.DE_Market_Timer.TabIndex = 13;
            this.DE_Market_Timer.Text = "23:33:00";
            this.DE_Market_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DE_Market_Status2
            // 
            this.DE_Market_Status2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DE_Market_Status2.ForeColor = System.Drawing.Color.DarkGray;
            this.DE_Market_Status2.Location = new System.Drawing.Point(286, 212);
            this.DE_Market_Status2.Name = "DE_Market_Status2";
            this.DE_Market_Status2.Size = new System.Drawing.Size(202, 21);
            this.DE_Market_Status2.TabIndex = 12;
            this.DE_Market_Status2.Text = "Åbner Om:";
            this.DE_Market_Status2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DE_Market_Status
            // 
            this.DE_Market_Status.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DE_Market_Status.ForeColor = System.Drawing.Color.Red;
            this.DE_Market_Status.Location = new System.Drawing.Point(78, 212);
            this.DE_Market_Status.Name = "DE_Market_Status";
            this.DE_Market_Status.Size = new System.Drawing.Size(202, 63);
            this.DE_Market_Status.TabIndex = 11;
            this.DE_Market_Status.Text = "Åbent";
            this.DE_Market_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SE_Market_Timer
            // 
            this.SE_Market_Timer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SE_Market_Timer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SE_Market_Timer.Location = new System.Drawing.Point(286, 302);
            this.SE_Market_Timer.Name = "SE_Market_Timer";
            this.SE_Market_Timer.Size = new System.Drawing.Size(202, 21);
            this.SE_Market_Timer.TabIndex = 17;
            this.SE_Market_Timer.Text = "23:33:00";
            this.SE_Market_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SE_Market_Status2
            // 
            this.SE_Market_Status2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SE_Market_Status2.ForeColor = System.Drawing.Color.DarkGray;
            this.SE_Market_Status2.Location = new System.Drawing.Point(286, 281);
            this.SE_Market_Status2.Name = "SE_Market_Status2";
            this.SE_Market_Status2.Size = new System.Drawing.Size(202, 21);
            this.SE_Market_Status2.TabIndex = 16;
            this.SE_Market_Status2.Text = "Åbner Om:";
            this.SE_Market_Status2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SE_Market_Status
            // 
            this.SE_Market_Status.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SE_Market_Status.ForeColor = System.Drawing.Color.Red;
            this.SE_Market_Status.Location = new System.Drawing.Point(78, 281);
            this.SE_Market_Status.Name = "SE_Market_Status";
            this.SE_Market_Status.Size = new System.Drawing.Size(202, 63);
            this.SE_Market_Status.TabIndex = 15;
            this.SE_Market_Status.Text = "Åbent";
            this.SE_Market_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FI_Market_Timer
            // 
            this.FI_Market_Timer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FI_Market_Timer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FI_Market_Timer.Location = new System.Drawing.Point(286, 371);
            this.FI_Market_Timer.Name = "FI_Market_Timer";
            this.FI_Market_Timer.Size = new System.Drawing.Size(202, 21);
            this.FI_Market_Timer.TabIndex = 21;
            this.FI_Market_Timer.Text = "23:33:00";
            this.FI_Market_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FI_Market_Status2
            // 
            this.FI_Market_Status2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FI_Market_Status2.ForeColor = System.Drawing.Color.DarkGray;
            this.FI_Market_Status2.Location = new System.Drawing.Point(286, 350);
            this.FI_Market_Status2.Name = "FI_Market_Status2";
            this.FI_Market_Status2.Size = new System.Drawing.Size(202, 21);
            this.FI_Market_Status2.TabIndex = 20;
            this.FI_Market_Status2.Text = "Åbner Om:";
            this.FI_Market_Status2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FI_Market_Status
            // 
            this.FI_Market_Status.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FI_Market_Status.ForeColor = System.Drawing.Color.Red;
            this.FI_Market_Status.Location = new System.Drawing.Point(78, 350);
            this.FI_Market_Status.Name = "FI_Market_Status";
            this.FI_Market_Status.Size = new System.Drawing.Size(202, 63);
            this.FI_Market_Status.TabIndex = 19;
            this.FI_Market_Status.Text = "Åbent";
            this.FI_Market_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // A_Market_Timer
            // 
            this.A_Market_Timer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_Market_Timer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.A_Market_Timer.Location = new System.Drawing.Point(286, 440);
            this.A_Market_Timer.Name = "A_Market_Timer";
            this.A_Market_Timer.Size = new System.Drawing.Size(202, 21);
            this.A_Market_Timer.TabIndex = 25;
            this.A_Market_Timer.Text = "23:33:00";
            this.A_Market_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // A_Market_Status2
            // 
            this.A_Market_Status2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_Market_Status2.ForeColor = System.Drawing.Color.DarkGray;
            this.A_Market_Status2.Location = new System.Drawing.Point(286, 419);
            this.A_Market_Status2.Name = "A_Market_Status2";
            this.A_Market_Status2.Size = new System.Drawing.Size(202, 21);
            this.A_Market_Status2.TabIndex = 24;
            this.A_Market_Status2.Text = "Åbner Om:";
            this.A_Market_Status2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // A_Market_Status
            // 
            this.A_Market_Status.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_Market_Status.ForeColor = System.Drawing.Color.Red;
            this.A_Market_Status.Location = new System.Drawing.Point(78, 419);
            this.A_Market_Status.Name = "A_Market_Status";
            this.A_Market_Status.Size = new System.Drawing.Size(202, 63);
            this.A_Market_Status.TabIndex = 23;
            this.A_Market_Status.Text = "Åbent";
            this.A_Market_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IS_Market_Timer
            // 
            this.IS_Market_Timer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_Market_Timer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IS_Market_Timer.Location = new System.Drawing.Point(286, 509);
            this.IS_Market_Timer.Name = "IS_Market_Timer";
            this.IS_Market_Timer.Size = new System.Drawing.Size(202, 21);
            this.IS_Market_Timer.TabIndex = 29;
            this.IS_Market_Timer.Text = "23:33:00";
            this.IS_Market_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IS_Market_Status2
            // 
            this.IS_Market_Status2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_Market_Status2.ForeColor = System.Drawing.Color.DarkGray;
            this.IS_Market_Status2.Location = new System.Drawing.Point(286, 488);
            this.IS_Market_Status2.Name = "IS_Market_Status2";
            this.IS_Market_Status2.Size = new System.Drawing.Size(202, 21);
            this.IS_Market_Status2.TabIndex = 28;
            this.IS_Market_Status2.Text = "Åbner Om:";
            this.IS_Market_Status2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IS_Market_Status
            // 
            this.IS_Market_Status.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_Market_Status.ForeColor = System.Drawing.Color.Red;
            this.IS_Market_Status.Location = new System.Drawing.Point(78, 488);
            this.IS_Market_Status.Name = "IS_Market_Status";
            this.IS_Market_Status.Size = new System.Drawing.Size(202, 63);
            this.IS_Market_Status.TabIndex = 27;
            this.IS_Market_Status.Text = "Åbent";
            this.IS_Market_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GlobalTimer
            // 
            this.GlobalTimer.Tick += new System.EventHandler(this.GlobalTimer_Tick);
            // 
            // DK_Timer_DateTime
            // 
            this.DK_Timer_DateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DK_Timer_DateTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DK_Timer_DateTime.Location = new System.Drawing.Point(286, 116);
            this.DK_Timer_DateTime.Name = "DK_Timer_DateTime";
            this.DK_Timer_DateTime.Size = new System.Drawing.Size(202, 21);
            this.DK_Timer_DateTime.TabIndex = 30;
            this.DK_Timer_DateTime.Text = "23:33:00";
            this.DK_Timer_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // US_Timer_DateTime
            // 
            this.US_Timer_DateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.US_Timer_DateTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.US_Timer_DateTime.Location = new System.Drawing.Point(286, 185);
            this.US_Timer_DateTime.Name = "US_Timer_DateTime";
            this.US_Timer_DateTime.Size = new System.Drawing.Size(202, 21);
            this.US_Timer_DateTime.TabIndex = 31;
            this.US_Timer_DateTime.Text = "23:33:00";
            this.US_Timer_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DE_Timer_DateTime
            // 
            this.DE_Timer_DateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DE_Timer_DateTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DE_Timer_DateTime.Location = new System.Drawing.Point(286, 254);
            this.DE_Timer_DateTime.Name = "DE_Timer_DateTime";
            this.DE_Timer_DateTime.Size = new System.Drawing.Size(202, 21);
            this.DE_Timer_DateTime.TabIndex = 32;
            this.DE_Timer_DateTime.Text = "23:33:00";
            this.DE_Timer_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SE_Timer_DateTime
            // 
            this.SE_Timer_DateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SE_Timer_DateTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SE_Timer_DateTime.Location = new System.Drawing.Point(286, 323);
            this.SE_Timer_DateTime.Name = "SE_Timer_DateTime";
            this.SE_Timer_DateTime.Size = new System.Drawing.Size(202, 21);
            this.SE_Timer_DateTime.TabIndex = 33;
            this.SE_Timer_DateTime.Text = "23:33:00";
            this.SE_Timer_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FI_Timer_DateTime
            // 
            this.FI_Timer_DateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FI_Timer_DateTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FI_Timer_DateTime.Location = new System.Drawing.Point(286, 392);
            this.FI_Timer_DateTime.Name = "FI_Timer_DateTime";
            this.FI_Timer_DateTime.Size = new System.Drawing.Size(202, 21);
            this.FI_Timer_DateTime.TabIndex = 34;
            this.FI_Timer_DateTime.Text = "23:33:00";
            this.FI_Timer_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // A_Timer_DateTime
            // 
            this.A_Timer_DateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_Timer_DateTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.A_Timer_DateTime.Location = new System.Drawing.Point(286, 461);
            this.A_Timer_DateTime.Name = "A_Timer_DateTime";
            this.A_Timer_DateTime.Size = new System.Drawing.Size(202, 21);
            this.A_Timer_DateTime.TabIndex = 35;
            this.A_Timer_DateTime.Text = "23:33:00";
            this.A_Timer_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IS_Timer_DateTime
            // 
            this.IS_Timer_DateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_Timer_DateTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IS_Timer_DateTime.Location = new System.Drawing.Point(286, 530);
            this.IS_Timer_DateTime.Name = "IS_Timer_DateTime";
            this.IS_Timer_DateTime.Size = new System.Drawing.Size(202, 21);
            this.IS_Timer_DateTime.TabIndex = 36;
            this.IS_Timer_DateTime.Text = "23:33:00";
            this.IS_Timer_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DK_WeekendClosed
            // 
            this.DK_WeekendClosed.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DK_WeekendClosed.ForeColor = System.Drawing.Color.Red;
            this.DK_WeekendClosed.Location = new System.Drawing.Point(286, 74);
            this.DK_WeekendClosed.Name = "DK_WeekendClosed";
            this.DK_WeekendClosed.Size = new System.Drawing.Size(202, 63);
            this.DK_WeekendClosed.TabIndex = 37;
            this.DK_WeekendClosed.Text = "Weekend Lukket";
            this.DK_WeekendClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DK_WeekendClosed.Visible = false;
            // 
            // US_WeekendClosed
            // 
            this.US_WeekendClosed.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.US_WeekendClosed.ForeColor = System.Drawing.Color.Red;
            this.US_WeekendClosed.Location = new System.Drawing.Point(286, 143);
            this.US_WeekendClosed.Name = "US_WeekendClosed";
            this.US_WeekendClosed.Size = new System.Drawing.Size(202, 63);
            this.US_WeekendClosed.TabIndex = 38;
            this.US_WeekendClosed.Text = "Weekend Lukket";
            this.US_WeekendClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.US_WeekendClosed.Visible = false;
            // 
            // DE_WeekendClosed
            // 
            this.DE_WeekendClosed.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DE_WeekendClosed.ForeColor = System.Drawing.Color.Red;
            this.DE_WeekendClosed.Location = new System.Drawing.Point(286, 212);
            this.DE_WeekendClosed.Name = "DE_WeekendClosed";
            this.DE_WeekendClosed.Size = new System.Drawing.Size(202, 63);
            this.DE_WeekendClosed.TabIndex = 39;
            this.DE_WeekendClosed.Text = "Weekend Lukket";
            this.DE_WeekendClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DE_WeekendClosed.Visible = false;
            // 
            // SE_WeekendClosed
            // 
            this.SE_WeekendClosed.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SE_WeekendClosed.ForeColor = System.Drawing.Color.Red;
            this.SE_WeekendClosed.Location = new System.Drawing.Point(286, 281);
            this.SE_WeekendClosed.Name = "SE_WeekendClosed";
            this.SE_WeekendClosed.Size = new System.Drawing.Size(202, 63);
            this.SE_WeekendClosed.TabIndex = 40;
            this.SE_WeekendClosed.Text = "Weekend Lukket";
            this.SE_WeekendClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SE_WeekendClosed.Visible = false;
            // 
            // FI_WeekendClosed
            // 
            this.FI_WeekendClosed.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FI_WeekendClosed.ForeColor = System.Drawing.Color.Red;
            this.FI_WeekendClosed.Location = new System.Drawing.Point(286, 350);
            this.FI_WeekendClosed.Name = "FI_WeekendClosed";
            this.FI_WeekendClosed.Size = new System.Drawing.Size(202, 63);
            this.FI_WeekendClosed.TabIndex = 41;
            this.FI_WeekendClosed.Text = "Weekend Lukket";
            this.FI_WeekendClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FI_WeekendClosed.Visible = false;
            // 
            // A_WeekendClosed
            // 
            this.A_WeekendClosed.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_WeekendClosed.ForeColor = System.Drawing.Color.Red;
            this.A_WeekendClosed.Location = new System.Drawing.Point(286, 419);
            this.A_WeekendClosed.Name = "A_WeekendClosed";
            this.A_WeekendClosed.Size = new System.Drawing.Size(202, 63);
            this.A_WeekendClosed.TabIndex = 42;
            this.A_WeekendClosed.Text = "Weekend Lukket";
            this.A_WeekendClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A_WeekendClosed.Visible = false;
            // 
            // IS_WeekendClosed
            // 
            this.IS_WeekendClosed.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_WeekendClosed.ForeColor = System.Drawing.Color.Red;
            this.IS_WeekendClosed.Location = new System.Drawing.Point(286, 488);
            this.IS_WeekendClosed.Name = "IS_WeekendClosed";
            this.IS_WeekendClosed.Size = new System.Drawing.Size(202, 63);
            this.IS_WeekendClosed.TabIndex = 43;
            this.IS_WeekendClosed.Text = "Weekend Lukket";
            this.IS_WeekendClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IS_WeekendClosed.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Aktiedysten.Properties.Resources.Island;
            this.pictureBox8.Location = new System.Drawing.Point(12, 488);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(60, 63);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 26;
            this.pictureBox8.TabStop = false;
            this.aktiedystenLogo_Tooltip.SetToolTip(this.pictureBox8, "Islandske Aktiemarked");
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Aktiedysten.Properties.Resources.Austria;
            this.pictureBox7.Location = new System.Drawing.Point(12, 419);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 63);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            this.aktiedystenLogo_Tooltip.SetToolTip(this.pictureBox7, "Østriske Aktiemarked");
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Aktiedysten.Properties.Resources.Finland;
            this.pictureBox6.Location = new System.Drawing.Point(12, 350);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 63);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.aktiedystenLogo_Tooltip.SetToolTip(this.pictureBox6, "Finske Aktiemarked");
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Aktiedysten.Properties.Resources.Sweden;
            this.pictureBox5.Location = new System.Drawing.Point(12, 281);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 63);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.aktiedystenLogo_Tooltip.SetToolTip(this.pictureBox5, "Svenske Aktiemarked");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Aktiedysten.Properties.Resources.Germany;
            this.pictureBox4.Location = new System.Drawing.Point(12, 212);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.aktiedystenLogo_Tooltip.SetToolTip(this.pictureBox4, "Tyske Aktiemarked");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Aktiedysten.Properties.Resources.UnitedStates;
            this.pictureBox3.Location = new System.Drawing.Point(12, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.aktiedystenLogo_Tooltip.SetToolTip(this.pictureBox3, "Amerikanske Aktiemarked");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aktiedysten.Properties.Resources.Denmark;
            this.pictureBox2.Location = new System.Drawing.Point(12, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.aktiedystenLogo_Tooltip.SetToolTip(this.pictureBox2, "Danske Aktiemarked");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Aktiedysten.Properties.Resources.aktiedysten_logo_big;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.aktiedystenLogo_Tooltip.SetToolTip(this.pictureBox1, "Dobbelt klik for at gå til aktiedysten website");
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // CurrencyRatesGroupBox
            // 
            this.CurrencyRatesGroupBox.Controls.Add(this.IslandishKronerCurrencyRateLabel);
            this.CurrencyRatesGroupBox.Controls.Add(this.IslandishKronerTextLabel);
            this.CurrencyRatesGroupBox.Controls.Add(this.SwedishKronerCurrencyRateLabel);
            this.CurrencyRatesGroupBox.Controls.Add(this.SwedishKronerTextLabel);
            this.CurrencyRatesGroupBox.Controls.Add(this.EuroCurrencyRateLabel);
            this.CurrencyRatesGroupBox.Controls.Add(this.EuroTextLabel);
            this.CurrencyRatesGroupBox.Controls.Add(this.DollarCurrencyRateLabel);
            this.CurrencyRatesGroupBox.Controls.Add(this.DollarTextLabel);
            this.CurrencyRatesGroupBox.Controls.Add(this.CurrencyRateLastUpdateTextLabel);
            this.CurrencyRatesGroupBox.Controls.Add(this.CurrencyRateLastUpdatedLabel);
            this.CurrencyRatesGroupBox.Controls.Add(this.BaseCurrencyLabel);
            this.CurrencyRatesGroupBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyRatesGroupBox.ForeColor = System.Drawing.Color.White;
            this.CurrencyRatesGroupBox.Location = new System.Drawing.Point(12, 559);
            this.CurrencyRatesGroupBox.Name = "CurrencyRatesGroupBox";
            this.CurrencyRatesGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.CurrencyRatesGroupBox.Size = new System.Drawing.Size(476, 245);
            this.CurrencyRatesGroupBox.TabIndex = 44;
            this.CurrencyRatesGroupBox.TabStop = false;
            this.CurrencyRatesGroupBox.Text = "Live - Valuta Kurser";
            this.CurrencyRatesGroupBox.Visible = false;
            // 
            // IslandishKronerCurrencyRateLabel
            // 
            this.IslandishKronerCurrencyRateLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IslandishKronerCurrencyRateLabel.Location = new System.Drawing.Point(259, 155);
            this.IslandishKronerCurrencyRateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.IslandishKronerCurrencyRateLabel.Name = "IslandishKronerCurrencyRateLabel";
            this.IslandishKronerCurrencyRateLabel.Size = new System.Drawing.Size(209, 25);
            this.IslandishKronerCurrencyRateLabel.TabIndex = 10;
            this.IslandishKronerCurrencyRateLabel.Text = "120";
            this.IslandishKronerCurrencyRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IslandishKronerTextLabel
            // 
            this.IslandishKronerTextLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IslandishKronerTextLabel.Location = new System.Drawing.Point(8, 155);
            this.IslandishKronerTextLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.IslandishKronerTextLabel.Name = "IslandishKronerTextLabel";
            this.IslandishKronerTextLabel.Size = new System.Drawing.Size(245, 25);
            this.IslandishKronerTextLabel.TabIndex = 9;
            this.IslandishKronerTextLabel.Text = "Islandske Kroner";
            this.IslandishKronerTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SwedishKronerCurrencyRateLabel
            // 
            this.SwedishKronerCurrencyRateLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwedishKronerCurrencyRateLabel.Location = new System.Drawing.Point(259, 125);
            this.SwedishKronerCurrencyRateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.SwedishKronerCurrencyRateLabel.Name = "SwedishKronerCurrencyRateLabel";
            this.SwedishKronerCurrencyRateLabel.Size = new System.Drawing.Size(209, 25);
            this.SwedishKronerCurrencyRateLabel.TabIndex = 8;
            this.SwedishKronerCurrencyRateLabel.Text = "120";
            this.SwedishKronerCurrencyRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwedishKronerTextLabel
            // 
            this.SwedishKronerTextLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwedishKronerTextLabel.Location = new System.Drawing.Point(8, 125);
            this.SwedishKronerTextLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.SwedishKronerTextLabel.Name = "SwedishKronerTextLabel";
            this.SwedishKronerTextLabel.Size = new System.Drawing.Size(245, 25);
            this.SwedishKronerTextLabel.TabIndex = 7;
            this.SwedishKronerTextLabel.Text = "Svenske Kroner";
            this.SwedishKronerTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EuroCurrencyRateLabel
            // 
            this.EuroCurrencyRateLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroCurrencyRateLabel.Location = new System.Drawing.Point(259, 95);
            this.EuroCurrencyRateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.EuroCurrencyRateLabel.Name = "EuroCurrencyRateLabel";
            this.EuroCurrencyRateLabel.Size = new System.Drawing.Size(209, 25);
            this.EuroCurrencyRateLabel.TabIndex = 6;
            this.EuroCurrencyRateLabel.Text = "120";
            this.EuroCurrencyRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EuroTextLabel
            // 
            this.EuroTextLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroTextLabel.Location = new System.Drawing.Point(8, 95);
            this.EuroTextLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.EuroTextLabel.Name = "EuroTextLabel";
            this.EuroTextLabel.Size = new System.Drawing.Size(245, 25);
            this.EuroTextLabel.TabIndex = 5;
            this.EuroTextLabel.Text = "Euro";
            this.EuroTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DollarCurrencyRateLabel
            // 
            this.DollarCurrencyRateLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarCurrencyRateLabel.Location = new System.Drawing.Point(256, 65);
            this.DollarCurrencyRateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.DollarCurrencyRateLabel.Name = "DollarCurrencyRateLabel";
            this.DollarCurrencyRateLabel.Size = new System.Drawing.Size(212, 25);
            this.DollarCurrencyRateLabel.TabIndex = 4;
            this.DollarCurrencyRateLabel.Text = "120";
            this.DollarCurrencyRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollarTextLabel
            // 
            this.DollarTextLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarTextLabel.Location = new System.Drawing.Point(8, 65);
            this.DollarTextLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.DollarTextLabel.Name = "DollarTextLabel";
            this.DollarTextLabel.Size = new System.Drawing.Size(242, 25);
            this.DollarTextLabel.TabIndex = 3;
            this.DollarTextLabel.Text = "Dollars";
            this.DollarTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrencyRateLastUpdateTextLabel
            // 
            this.CurrencyRateLastUpdateTextLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyRateLastUpdateTextLabel.Location = new System.Drawing.Point(8, 198);
            this.CurrencyRateLastUpdateTextLabel.Name = "CurrencyRateLastUpdateTextLabel";
            this.CurrencyRateLastUpdateTextLabel.Size = new System.Drawing.Size(460, 24);
            this.CurrencyRateLastUpdateTextLabel.TabIndex = 2;
            this.CurrencyRateLastUpdateTextLabel.Text = "Sidst Opdateret";
            this.CurrencyRateLastUpdateTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrencyRateLastUpdatedLabel
            // 
            this.CurrencyRateLastUpdatedLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyRateLastUpdatedLabel.Location = new System.Drawing.Point(8, 222);
            this.CurrencyRateLastUpdatedLabel.Name = "CurrencyRateLastUpdatedLabel";
            this.CurrencyRateLastUpdatedLabel.Size = new System.Drawing.Size(460, 16);
            this.CurrencyRateLastUpdatedLabel.TabIndex = 1;
            this.CurrencyRateLastUpdatedLabel.Text = "22-02-2020 14:33:33";
            this.CurrencyRateLastUpdatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaseCurrencyLabel
            // 
            this.BaseCurrencyLabel.Location = new System.Drawing.Point(8, 25);
            this.BaseCurrencyLabel.Name = "BaseCurrencyLabel";
            this.BaseCurrencyLabel.Size = new System.Drawing.Size(460, 25);
            this.BaseCurrencyLabel.TabIndex = 0;
            this.BaseCurrencyLabel.Text = "Danske Kroner x 100";
            this.BaseCurrencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrencyRateTimer
            // 
            this.CurrencyRateTimer.Interval = 30000;
            this.CurrencyRateTimer.Tick += new System.EventHandler(this.CurrencyRateTimer_Tick);
            // 
            // HideLiveCurrencyRatesBtn
            // 
            this.HideLiveCurrencyRatesBtn.BackColor = System.Drawing.Color.Silver;
            this.HideLiveCurrencyRatesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideLiveCurrencyRatesBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideLiveCurrencyRatesBtn.Location = new System.Drawing.Point(12, 810);
            this.HideLiveCurrencyRatesBtn.Name = "HideLiveCurrencyRatesBtn";
            this.HideLiveCurrencyRatesBtn.Size = new System.Drawing.Size(476, 43);
            this.HideLiveCurrencyRatesBtn.TabIndex = 45;
            this.HideLiveCurrencyRatesBtn.TabStop = false;
            this.HideLiveCurrencyRatesBtn.Text = "Skjul Live Valuta Kurser";
            this.HideLiveCurrencyRatesBtn.UseVisualStyleBackColor = false;
            this.HideLiveCurrencyRatesBtn.Visible = false;
            this.HideLiveCurrencyRatesBtn.Click += new System.EventHandler(this.HideLiveCurrencyRatesBtn_Click);
            // 
            // ShowLiveCurrencyRatesBtn
            // 
            this.ShowLiveCurrencyRatesBtn.BackColor = System.Drawing.Color.Silver;
            this.ShowLiveCurrencyRatesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLiveCurrencyRatesBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLiveCurrencyRatesBtn.Location = new System.Drawing.Point(12, 557);
            this.ShowLiveCurrencyRatesBtn.Name = "ShowLiveCurrencyRatesBtn";
            this.ShowLiveCurrencyRatesBtn.Size = new System.Drawing.Size(476, 43);
            this.ShowLiveCurrencyRatesBtn.TabIndex = 46;
            this.ShowLiveCurrencyRatesBtn.TabStop = false;
            this.ShowLiveCurrencyRatesBtn.Text = "Vis Live Valuta Kurser";
            this.ShowLiveCurrencyRatesBtn.UseVisualStyleBackColor = false;
            this.ShowLiveCurrencyRatesBtn.Click += new System.EventHandler(this.ShowLiveCurrencyRatesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(498, 862);
            this.Controls.Add(this.ShowLiveCurrencyRatesBtn);
            this.Controls.Add(this.HideLiveCurrencyRatesBtn);
            this.Controls.Add(this.IS_WeekendClosed);
            this.Controls.Add(this.A_WeekendClosed);
            this.Controls.Add(this.FI_WeekendClosed);
            this.Controls.Add(this.SE_WeekendClosed);
            this.Controls.Add(this.DE_WeekendClosed);
            this.Controls.Add(this.US_WeekendClosed);
            this.Controls.Add(this.DK_WeekendClosed);
            this.Controls.Add(this.IS_Timer_DateTime);
            this.Controls.Add(this.A_Timer_DateTime);
            this.Controls.Add(this.FI_Timer_DateTime);
            this.Controls.Add(this.SE_Timer_DateTime);
            this.Controls.Add(this.DE_Timer_DateTime);
            this.Controls.Add(this.US_Timer_DateTime);
            this.Controls.Add(this.DK_Timer_DateTime);
            this.Controls.Add(this.IS_Market_Timer);
            this.Controls.Add(this.IS_Market_Status2);
            this.Controls.Add(this.IS_Market_Status);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.A_Market_Timer);
            this.Controls.Add(this.A_Market_Status2);
            this.Controls.Add(this.A_Market_Status);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.FI_Market_Timer);
            this.Controls.Add(this.FI_Market_Status2);
            this.Controls.Add(this.FI_Market_Status);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.SE_Market_Timer);
            this.Controls.Add(this.SE_Market_Status2);
            this.Controls.Add(this.SE_Market_Status);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.DE_Market_Timer);
            this.Controls.Add(this.DE_Market_Status2);
            this.Controls.Add(this.DE_Market_Status);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.US_Market_Timer);
            this.Controls.Add(this.US_Market_Status2);
            this.Controls.Add(this.US_Market_Status);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.DK_Market_Timer);
            this.Controls.Add(this.DK_Market_Status2);
            this.Controls.Add(this.DK_Market_Status);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CurrencyRatesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Text = "Aktiedysten - Markeder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.notifymenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CurrencyRatesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifymenu;
        private System.Windows.Forms.ToolStripMenuItem afslutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DK_Market_Status;
        private System.Windows.Forms.Label DK_Market_Status2;
        private System.Windows.Forms.Label DK_Market_Timer;
        private System.Windows.Forms.Label US_Market_Timer;
        private System.Windows.Forms.Label US_Market_Status2;
        private System.Windows.Forms.Label US_Market_Status;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label DE_Market_Timer;
        private System.Windows.Forms.Label DE_Market_Status2;
        private System.Windows.Forms.Label DE_Market_Status;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label SE_Market_Timer;
        private System.Windows.Forms.Label SE_Market_Status2;
        private System.Windows.Forms.Label SE_Market_Status;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label FI_Market_Timer;
        private System.Windows.Forms.Label FI_Market_Status2;
        private System.Windows.Forms.Label FI_Market_Status;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label A_Market_Timer;
        private System.Windows.Forms.Label A_Market_Status2;
        private System.Windows.Forms.Label A_Market_Status;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label IS_Market_Timer;
        private System.Windows.Forms.Label IS_Market_Status2;
        private System.Windows.Forms.Label IS_Market_Status;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer GlobalTimer;
        private System.Windows.Forms.Label DK_Timer_DateTime;
        private System.Windows.Forms.Label US_Timer_DateTime;
        private System.Windows.Forms.Label DE_Timer_DateTime;
        private System.Windows.Forms.Label SE_Timer_DateTime;
        private System.Windows.Forms.Label FI_Timer_DateTime;
        private System.Windows.Forms.Label A_Timer_DateTime;
        private System.Windows.Forms.Label IS_Timer_DateTime;
        private System.Windows.Forms.ToolStripMenuItem OpenAktiedystenToolStripMenuItem;
        private System.Windows.Forms.Label DK_WeekendClosed;
        private System.Windows.Forms.Label US_WeekendClosed;
        private System.Windows.Forms.Label DE_WeekendClosed;
        private System.Windows.Forms.Label SE_WeekendClosed;
        private System.Windows.Forms.Label FI_WeekendClosed;
        private System.Windows.Forms.Label A_WeekendClosed;
        private System.Windows.Forms.Label IS_WeekendClosed;
        private System.Windows.Forms.ToolStripMenuItem StartWithWindowsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartMinimizedMenuItem;
        private System.Windows.Forms.ToolTip aktiedystenLogo_Tooltip;
        private System.Windows.Forms.GroupBox CurrencyRatesGroupBox;
        private System.Windows.Forms.Label BaseCurrencyLabel;
        private System.Windows.Forms.Label CurrencyRateLastUpdateTextLabel;
        private System.Windows.Forms.Label CurrencyRateLastUpdatedLabel;
        private System.Windows.Forms.Label IslandishKronerCurrencyRateLabel;
        private System.Windows.Forms.Label IslandishKronerTextLabel;
        private System.Windows.Forms.Label SwedishKronerCurrencyRateLabel;
        private System.Windows.Forms.Label SwedishKronerTextLabel;
        private System.Windows.Forms.Label EuroCurrencyRateLabel;
        private System.Windows.Forms.Label EuroTextLabel;
        private System.Windows.Forms.Label DollarCurrencyRateLabel;
        private System.Windows.Forms.Label DollarTextLabel;
        private System.Windows.Forms.Timer CurrencyRateTimer;
        private System.Windows.Forms.Button HideLiveCurrencyRatesBtn;
        private System.Windows.Forms.Button ShowLiveCurrencyRatesBtn;
        private System.Windows.Forms.ToolStripMenuItem AlwaysOnTopMenuItem;
    }
}

