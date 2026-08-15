using System.Drawing;
using System.Windows.Forms;

namespace AoC_Advanced_Scenario_Editor
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.TabSelect = new System.Windows.Forms.TabControl();
            this.LoadTab = new System.Windows.Forms.TabPage();
            this.StartingDay = new System.Windows.Forms.NumericUpDown();
            this.ExportImgInfo = new System.Windows.Forms.Label();
            this.ShowCities = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ExportImage = new System.Windows.Forms.Button();
            this.MainMapSelect = new System.Windows.Forms.ComboBox();
            this.DayScale = new System.Windows.Forms.RadioButton();
            this.MonthScale = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.HomePreview = new System.Windows.Forms.PictureBox();
            this.ScenarioStatsLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CurrentYear = new System.Windows.Forms.NumericUpDown();
            this.CurrentDay = new System.Windows.Forms.NumericUpDown();
            this.CurrentMonth = new System.Windows.Forms.ComboBox();
            this.StartingYear = new System.Windows.Forms.NumericUpDown();
            this.StartingMonth = new System.Windows.Forms.ComboBox();
            this.ScenarioSizeLabel = new System.Windows.Forms.Label();
            this.GameVerLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoadScenario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ScenarioBrowse = new System.Windows.Forms.Button();
            this.ScenarioInput = new System.Windows.Forms.TextBox();
            this.NationsTab = new System.Windows.Forms.TabPage();
            this.PasteNationNames = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CapitalSelect = new System.Windows.Forms.ComboBox();
            this.SetBonusToAll = new System.Windows.Forms.Button();
            this.SetBonus = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.SetFlagID = new System.Windows.Forms.NumericUpDown();
            this.FlagPreview = new System.Windows.Forms.PictureBox();
            this.SetCEToAll = new System.Windows.Forms.Button();
            this.SetGoldToAll = new System.Windows.Forms.Button();
            this.ceLock = new System.Windows.Forms.CheckBox();
            this.DisableAI = new System.Windows.Forms.CheckBox();
            this.SetEyear = new System.Windows.Forms.NumericUpDown();
            this.SetSyear = new System.Windows.Forms.NumericUpDown();
            this.SetCE = new System.Windows.Forms.NumericUpDown();
            this.SetGold = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NationPreview = new System.Windows.Forms.PictureBox();
            this.NationsTable = new System.Windows.Forms.DataGridView();
            this.NationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationColor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CitiesTab = new System.Windows.Forms.TabPage();
            this.RemoveCore = new System.Windows.Forms.Button();
            this.PasteCityNames = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SetCoreToSelf = new System.Windows.Forms.Button();
            this.CityRevoltChance = new System.Windows.Forms.NumericUpDown();
            this.CityRightfulOwner = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CityPreview = new System.Windows.Forms.PictureBox();
            this.CitiesTable = new System.Windows.Forms.DataGridView();
            this.AlliancesTab = new System.Windows.Forms.TabPage();
            this.IsUnion = new System.Windows.Forms.CheckBox();
            this.AlliancePreview = new System.Windows.Forms.PictureBox();
            this.Unity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.AllianceNationSelect = new System.Windows.Forms.DataGridView();
            this.AllianceNationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllianceNations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllianceSelect = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AllianceLoyalty = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AlliancesTable = new System.Windows.Forms.DataGridView();
            this.AllianceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllianceMembers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllianceColor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PuppetsTab = new System.Windows.Forms.TabPage();
            this.PuppetLoyaltyDesc = new System.Windows.Forms.ComboBox();
            this.PuppetAutonomyDesc = new System.Windows.Forms.ComboBox();
            this.PuppetLoyalty = new System.Windows.Forms.NumericUpDown();
            this.PuppetAutonomy = new System.Windows.Forms.NumericUpDown();
            this.PuppetIntegration = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.PuppetsOverview = new System.Windows.Forms.DataGridView();
            this.PuppetMasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuppetMastersList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuppetsList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuppetsTable = new System.Windows.Forms.DataGridView();
            this.PuppetNationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuppetNationList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuppetMasterSelect = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WarsTab = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.ToDeath = new System.Windows.Forms.Button();
            this.MergeWars = new System.Windows.Forms.Button();
            this.WarEndYear = new System.Windows.Forms.NumericUpDown();
            this.WarEndDay = new System.Windows.Forms.NumericUpDown();
            this.WarEndMonth = new System.Windows.Forms.ComboBox();
            this.RemoveWar = new System.Windows.Forms.Button();
            this.AddWar = new System.Windows.Forms.Button();
            this.WarStartYear = new System.Windows.Forms.NumericUpDown();
            this.WarStartDay = new System.Windows.Forms.NumericUpDown();
            this.WarStartMonth = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.WarNationSelect = new System.Windows.Forms.DataGridView();
            this.WarNationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Involvement = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WarsTable = new System.Windows.Forms.DataGridView();
            this.Attackers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Defenders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.FlagEditorLink = new System.Windows.Forms.LinkLabel();
            this.ConverterLink = new System.Windows.Forms.LinkLabel();
            this.DiscordLink = new System.Windows.Forms.LinkLabel();
            this.ReadmeLink = new System.Windows.Forms.LinkLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.DestinationInput = new System.Windows.Forms.TextBox();
            this.NameSelection = new System.Windows.Forms.TextBox();
            this.DestinationBrowse = new System.Windows.Forms.Button();
            this.RunGameButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.ExportAsScenario = new System.Windows.Forms.RadioButton();
            this.ExportAsSave = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.cityX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabSelect.SuspendLayout();
            this.LoadTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartingDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingYear)).BeginInit();
            this.NationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetFlagID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlagPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetEyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetSyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NationPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NationsTable)).BeginInit();
            this.CitiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityRevoltChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CitiesTable)).BeginInit();
            this.AlliancesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlliancePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllianceNationSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlliancesTable)).BeginInit();
            this.PuppetsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PuppetLoyalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuppetAutonomy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuppetIntegration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuppetsOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuppetsTable)).BeginInit();
            this.WarsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarEndYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarEndDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarStartYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarStartDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarNationSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarsTable)).BeginInit();
            this.InfoTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSelect
            // 
            this.TabSelect.AllowDrop = true;
            this.TabSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSelect.Controls.Add(this.LoadTab);
            this.TabSelect.Controls.Add(this.NationsTab);
            this.TabSelect.Controls.Add(this.CitiesTab);
            this.TabSelect.Controls.Add(this.AlliancesTab);
            this.TabSelect.Controls.Add(this.PuppetsTab);
            this.TabSelect.Controls.Add(this.WarsTab);
            this.TabSelect.Controls.Add(this.InfoTab);
            this.TabSelect.ItemSize = new System.Drawing.Size(100, 25);
            this.TabSelect.Location = new System.Drawing.Point(0, 0);
            this.TabSelect.Margin = new System.Windows.Forms.Padding(0);
            this.TabSelect.Multiline = true;
            this.TabSelect.Name = "TabSelect";
            this.TabSelect.SelectedIndex = 0;
            this.TabSelect.Size = new System.Drawing.Size(884, 440);
            this.TabSelect.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabSelect.TabIndex = 0;
            // 
            // LoadTab
            // 
            this.LoadTab.Controls.Add(this.StartingDay);
            this.LoadTab.Controls.Add(this.ExportImgInfo);
            this.LoadTab.Controls.Add(this.ShowCities);
            this.LoadTab.Controls.Add(this.label23);
            this.LoadTab.Controls.Add(this.ExportImage);
            this.LoadTab.Controls.Add(this.MainMapSelect);
            this.LoadTab.Controls.Add(this.DayScale);
            this.LoadTab.Controls.Add(this.MonthScale);
            this.LoadTab.Controls.Add(this.label14);
            this.LoadTab.Controls.Add(this.HomePreview);
            this.LoadTab.Controls.Add(this.ScenarioStatsLabel);
            this.LoadTab.Controls.Add(this.label13);
            this.LoadTab.Controls.Add(this.label12);
            this.LoadTab.Controls.Add(this.CurrentYear);
            this.LoadTab.Controls.Add(this.CurrentDay);
            this.LoadTab.Controls.Add(this.CurrentMonth);
            this.LoadTab.Controls.Add(this.StartingYear);
            this.LoadTab.Controls.Add(this.StartingMonth);
            this.LoadTab.Controls.Add(this.ScenarioSizeLabel);
            this.LoadTab.Controls.Add(this.GameVerLabel);
            this.LoadTab.Controls.Add(this.label5);
            this.LoadTab.Controls.Add(this.label4);
            this.LoadTab.Controls.Add(this.LoadScenario);
            this.LoadTab.Controls.Add(this.label3);
            this.LoadTab.Controls.Add(this.ScenarioBrowse);
            this.LoadTab.Controls.Add(this.ScenarioInput);
            this.LoadTab.Location = new System.Drawing.Point(4, 29);
            this.LoadTab.Name = "LoadTab";
            this.LoadTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoadTab.Size = new System.Drawing.Size(876, 407);
            this.LoadTab.TabIndex = 0;
            this.LoadTab.Text = "Load";
            this.LoadTab.UseVisualStyleBackColor = true;
            // 
            // StartingDay
            // 
            this.StartingDay.Location = new System.Drawing.Point(244, 332);
            this.StartingDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.StartingDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingDay.Name = "StartingDay";
            this.StartingDay.Size = new System.Drawing.Size(40, 25);
            this.StartingDay.TabIndex = 36;
            this.StartingDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingDay.ValueChanged += new System.EventHandler(this.DateChanged);
            // 
            // ExportImgInfo
            // 
            this.ExportImgInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportImgInfo.AutoSize = true;
            this.ExportImgInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExportImgInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExportImgInfo.Location = new System.Drawing.Point(690, 40);
            this.ExportImgInfo.Name = "ExportImgInfo";
            this.ExportImgInfo.Size = new System.Drawing.Size(175, 26);
            this.ExportImgInfo.TabIndex = 35;
            this.ExportImgInfo.Text = "Will export without cities.\r\nCheck to export cities separately.";
            // 
            // ShowCities
            // 
            this.ShowCities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCities.AutoSize = true;
            this.ShowCities.Location = new System.Drawing.Point(592, 43);
            this.ShowCities.Name = "ShowCities";
            this.ShowCities.Size = new System.Drawing.Size(91, 21);
            this.ShowCities.TabIndex = 34;
            this.ShowCities.Text = "Show cities";
            this.ShowCities.UseVisualStyleBackColor = true;
            this.ShowCities.CheckedChanged += new System.EventHandler(this.ShowCities_CheckedChanged);
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(589, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 17);
            this.label23.TabIndex = 33;
            this.label23.Text = "View: ";
            // 
            // ExportImage
            // 
            this.ExportImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportImage.Enabled = false;
            this.ExportImage.Location = new System.Drawing.Point(769, 7);
            this.ExportImage.Name = "ExportImage";
            this.ExportImage.Size = new System.Drawing.Size(100, 30);
            this.ExportImage.TabIndex = 32;
            this.ExportImage.Text = "Export image";
            this.ExportImage.UseVisualStyleBackColor = true;
            this.ExportImage.Click += new System.EventHandler(this.ExportImage_Click);
            // 
            // MainMapSelect
            // 
            this.MainMapSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMapSelect.FormattingEnabled = true;
            this.MainMapSelect.Items.AddRange(new object[] {
            "Terrain",
            "De Facto",
            "De Jure"});
            this.MainMapSelect.Location = new System.Drawing.Point(637, 10);
            this.MainMapSelect.Name = "MainMapSelect";
            this.MainMapSelect.Size = new System.Drawing.Size(121, 25);
            this.MainMapSelect.TabIndex = 31;
            this.MainMapSelect.Text = "Terrain";
            this.MainMapSelect.SelectedIndexChanged += new System.EventHandler(this.UpdateMainMap);
            // 
            // DayScale
            // 
            this.DayScale.AutoSize = true;
            this.DayScale.Location = new System.Drawing.Point(14, 121);
            this.DayScale.Name = "DayScale";
            this.DayScale.Size = new System.Drawing.Size(54, 21);
            this.DayScale.TabIndex = 30;
            this.DayScale.Text = "Days";
            this.DayScale.UseVisualStyleBackColor = true;
            // 
            // MonthScale
            // 
            this.MonthScale.AutoSize = true;
            this.MonthScale.Checked = true;
            this.MonthScale.Location = new System.Drawing.Point(14, 94);
            this.MonthScale.Name = "MonthScale";
            this.MonthScale.Size = new System.Drawing.Size(70, 21);
            this.MonthScale.TabIndex = 29;
            this.MonthScale.TabStop = true;
            this.MonthScale.Text = "Months";
            this.MonthScale.UseVisualStyleBackColor = true;
            this.MonthScale.CheckedChanged += new System.EventHandler(this.ReloadRequired);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Intended timescale:";
            // 
            // HomePreview
            // 
            this.HomePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomePreview.Location = new System.Drawing.Point(385, 70);
            this.HomePreview.Name = "HomePreview";
            this.HomePreview.Size = new System.Drawing.Size(485, 331);
            this.HomePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomePreview.TabIndex = 27;
            this.HomePreview.TabStop = false;
            // 
            // ScenarioStatsLabel
            // 
            this.ScenarioStatsLabel.AutoSize = true;
            this.ScenarioStatsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScenarioStatsLabel.Location = new System.Drawing.Point(311, 235);
            this.ScenarioStatsLabel.Name = "ScenarioStatsLabel";
            this.ScenarioStatsLabel.Size = new System.Drawing.Size(66, 68);
            this.ScenarioStatsLabel.TabIndex = 26;
            this.ScenarioStatsLabel.Text = "Unknown\r\nUnknown\r\nUnknown\r\nUnknown";
            this.ScenarioStatsLabel.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(244, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 68);
            this.label13.TabIndex = 25;
            this.label13.Text = "Nations:\r\nCities:\r\nAlliances:\r\nWars:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(11, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(286, 39);
            this.label12.TabIndex = 24;
            this.label12.Text = "This will be used to convert dates \r\nto and from AoC\'s relative time format.\r\nCha" +
    "nging this setting requires reloading the scenario.";
            // 
            // CurrentYear
            // 
            this.CurrentYear.Location = new System.Drawing.Point(290, 367);
            this.CurrentYear.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.CurrentYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CurrentYear.Name = "CurrentYear";
            this.CurrentYear.Size = new System.Drawing.Size(85, 25);
            this.CurrentYear.TabIndex = 22;
            this.CurrentYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CurrentYear.ValueChanged += new System.EventHandler(this.DateChanged);
            // 
            // CurrentDay
            // 
            this.CurrentDay.Location = new System.Drawing.Point(244, 367);
            this.CurrentDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.CurrentDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CurrentDay.Name = "CurrentDay";
            this.CurrentDay.Size = new System.Drawing.Size(40, 25);
            this.CurrentDay.TabIndex = 21;
            this.CurrentDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CurrentDay.ValueChanged += new System.EventHandler(this.DateChanged);
            // 
            // CurrentMonth
            // 
            this.CurrentMonth.FormattingEnabled = true;
            this.CurrentMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CurrentMonth.Location = new System.Drawing.Point(118, 367);
            this.CurrentMonth.Name = "CurrentMonth";
            this.CurrentMonth.Size = new System.Drawing.Size(120, 25);
            this.CurrentMonth.TabIndex = 20;
            this.CurrentMonth.SelectedIndexChanged += new System.EventHandler(this.DateChanged);
            // 
            // StartingYear
            // 
            this.StartingYear.Location = new System.Drawing.Point(290, 332);
            this.StartingYear.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.StartingYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingYear.Name = "StartingYear";
            this.StartingYear.Size = new System.Drawing.Size(85, 25);
            this.StartingYear.TabIndex = 19;
            this.StartingYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingYear.ValueChanged += new System.EventHandler(this.DateChanged);
            // 
            // StartingMonth
            // 
            this.StartingMonth.FormattingEnabled = true;
            this.StartingMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.StartingMonth.Location = new System.Drawing.Point(118, 332);
            this.StartingMonth.Name = "StartingMonth";
            this.StartingMonth.Size = new System.Drawing.Size(120, 25);
            this.StartingMonth.TabIndex = 17;
            this.StartingMonth.SelectedIndexChanged += new System.EventHandler(this.DateChanged);
            // 
            // ScenarioSizeLabel
            // 
            this.ScenarioSizeLabel.AutoSize = true;
            this.ScenarioSizeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScenarioSizeLabel.Location = new System.Drawing.Point(115, 268);
            this.ScenarioSizeLabel.Name = "ScenarioSizeLabel";
            this.ScenarioSizeLabel.Size = new System.Drawing.Size(66, 34);
            this.ScenarioSizeLabel.TabIndex = 16;
            this.ScenarioSizeLabel.Text = "Unknown\r\nUnknown";
            this.ScenarioSizeLabel.Visible = false;
            // 
            // GameVerLabel
            // 
            this.GameVerLabel.AutoSize = true;
            this.GameVerLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameVerLabel.Location = new System.Drawing.Point(115, 235);
            this.GameVerLabel.Name = "GameVerLabel";
            this.GameVerLabel.Size = new System.Drawing.Size(66, 17);
            this.GameVerLabel.TabIndex = 15;
            this.GameVerLabel.Text = "Unknown";
            this.GameVerLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 153);
            this.label5.TabIndex = 14;
            this.label5.Text = "Game version:\r\n\r\nWidth:\r\nHeight:\r\n\r\n\r\nStarting date:\r\n\r\nCurrent date:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Scenario info";
            // 
            // LoadScenario
            // 
            this.LoadScenario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadScenario.ForeColor = System.Drawing.Color.Black;
            this.LoadScenario.Location = new System.Drawing.Point(244, 70);
            this.LoadScenario.Name = "LoadScenario";
            this.LoadScenario.Size = new System.Drawing.Size(130, 30);
            this.LoadScenario.TabIndex = 10;
            this.LoadScenario.Text = "Load scenario";
            this.LoadScenario.UseVisualStyleBackColor = true;
            this.LoadScenario.Click += new System.EventHandler(this.LoadScenario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select scenario to load";
            // 
            // ScenarioBrowse
            // 
            this.ScenarioBrowse.Location = new System.Drawing.Point(418, 32);
            this.ScenarioBrowse.Name = "ScenarioBrowse";
            this.ScenarioBrowse.Size = new System.Drawing.Size(88, 30);
            this.ScenarioBrowse.TabIndex = 11;
            this.ScenarioBrowse.Text = "Browse";
            this.ScenarioBrowse.UseVisualStyleBackColor = true;
            this.ScenarioBrowse.Click += new System.EventHandler(this.ScenarioBrowse_Click);
            // 
            // ScenarioInput
            // 
            this.ScenarioInput.Location = new System.Drawing.Point(11, 35);
            this.ScenarioInput.Name = "ScenarioInput";
            this.ScenarioInput.Size = new System.Drawing.Size(401, 25);
            this.ScenarioInput.TabIndex = 10;
            this.ScenarioInput.TextChanged += new System.EventHandler(this.ReloadRequired);
            // 
            // NationsTab
            // 
            this.NationsTab.Controls.Add(this.PasteNationNames);
            this.NationsTab.Controls.Add(this.label7);
            this.NationsTab.Controls.Add(this.CapitalSelect);
            this.NationsTab.Controls.Add(this.SetBonusToAll);
            this.NationsTab.Controls.Add(this.SetBonus);
            this.NationsTab.Controls.Add(this.label21);
            this.NationsTab.Controls.Add(this.SetFlagID);
            this.NationsTab.Controls.Add(this.FlagPreview);
            this.NationsTab.Controls.Add(this.SetCEToAll);
            this.NationsTab.Controls.Add(this.SetGoldToAll);
            this.NationsTab.Controls.Add(this.ceLock);
            this.NationsTab.Controls.Add(this.DisableAI);
            this.NationsTab.Controls.Add(this.SetEyear);
            this.NationsTab.Controls.Add(this.SetSyear);
            this.NationsTab.Controls.Add(this.SetCE);
            this.NationsTab.Controls.Add(this.SetGold);
            this.NationsTab.Controls.Add(this.label6);
            this.NationsTab.Controls.Add(this.NationPreview);
            this.NationsTab.Controls.Add(this.NationsTable);
            this.NationsTab.Location = new System.Drawing.Point(4, 29);
            this.NationsTab.Name = "NationsTab";
            this.NationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.NationsTab.Size = new System.Drawing.Size(876, 407);
            this.NationsTab.TabIndex = 1;
            this.NationsTab.Text = "Nations";
            this.NationsTab.UseVisualStyleBackColor = true;
            // 
            // PasteNationNames
            // 
            this.PasteNationNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PasteNationNames.Location = new System.Drawing.Point(3, 379);
            this.PasteNationNames.Name = "PasteNationNames";
            this.PasteNationNames.Size = new System.Drawing.Size(190, 25);
            this.PasteNationNames.TabIndex = 21;
            this.PasteNationNames.Text = "Paste names from clipboard";
            this.PasteNationNames.UseVisualStyleBackColor = true;
            this.PasteNationNames.Click += new System.EventHandler(this.PasteNationNames_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(667, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ctrl + click to apply\r\nto all nations";
            // 
            // CapitalSelect
            // 
            this.CapitalSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CapitalSelect.FormattingEnabled = true;
            this.CapitalSelect.Location = new System.Drawing.Point(445, 240);
            this.CapitalSelect.Name = "CapitalSelect";
            this.CapitalSelect.Size = new System.Drawing.Size(205, 25);
            this.CapitalSelect.TabIndex = 19;
            this.CapitalSelect.SelectedIndexChanged += new System.EventHandler(this.NationDetailsModified);
            // 
            // SetBonusToAll
            // 
            this.SetBonusToAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetBonusToAll.Location = new System.Drawing.Point(610, 341);
            this.SetBonusToAll.Name = "SetBonusToAll";
            this.SetBonusToAll.Size = new System.Drawing.Size(90, 25);
            this.SetBonusToAll.TabIndex = 18;
            this.SetBonusToAll.Text = "Apply to all";
            this.SetBonusToAll.UseVisualStyleBackColor = true;
            this.SetBonusToAll.Click += new System.EventHandler(this.SetToAll_Click);
            // 
            // SetBonus
            // 
            this.SetBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetBonus.Location = new System.Drawing.Point(510, 341);
            this.SetBonus.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.SetBonus.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.SetBonus.Name = "SetBonus";
            this.SetBonus.Size = new System.Drawing.Size(90, 25);
            this.SetBonus.TabIndex = 17;
            this.SetBonus.ThousandsSeparator = true;
            this.SetBonus.ValueChanged += new System.EventHandler(this.NationDetailsModified);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(813, 257);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 17);
            this.label21.TabIndex = 16;
            this.label21.Text = "Flag ID";
            // 
            // SetFlagID
            // 
            this.SetFlagID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetFlagID.Location = new System.Drawing.Point(806, 277);
            this.SetFlagID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SetFlagID.Name = "SetFlagID";
            this.SetFlagID.Size = new System.Drawing.Size(64, 25);
            this.SetFlagID.TabIndex = 15;
            this.SetFlagID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetFlagID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SetFlagID.ValueChanged += new System.EventHandler(this.NationDetailsModified);
            // 
            // FlagPreview
            // 
            this.FlagPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FlagPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FlagPreview.Location = new System.Drawing.Point(729, 308);
            this.FlagPreview.Name = "FlagPreview";
            this.FlagPreview.Size = new System.Drawing.Size(144, 96);
            this.FlagPreview.TabIndex = 14;
            this.FlagPreview.TabStop = false;
            this.FlagPreview.Click += new System.EventHandler(this.FlagPreview_Click);
            // 
            // SetCEToAll
            // 
            this.SetCEToAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetCEToAll.Location = new System.Drawing.Point(610, 374);
            this.SetCEToAll.Name = "SetCEToAll";
            this.SetCEToAll.Size = new System.Drawing.Size(90, 25);
            this.SetCEToAll.TabIndex = 12;
            this.SetCEToAll.Text = "Apply to all";
            this.SetCEToAll.UseVisualStyleBackColor = true;
            this.SetCEToAll.Click += new System.EventHandler(this.SetToAll_Click);
            // 
            // SetGoldToAll
            // 
            this.SetGoldToAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetGoldToAll.Location = new System.Drawing.Point(610, 308);
            this.SetGoldToAll.Name = "SetGoldToAll";
            this.SetGoldToAll.Size = new System.Drawing.Size(90, 25);
            this.SetGoldToAll.TabIndex = 11;
            this.SetGoldToAll.Text = "Apply to all";
            this.SetGoldToAll.UseVisualStyleBackColor = true;
            this.SetGoldToAll.Click += new System.EventHandler(this.SetToAll_Click);
            // 
            // ceLock
            // 
            this.ceLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ceLock.AutoSize = true;
            this.ceLock.Location = new System.Drawing.Point(736, 245);
            this.ceLock.Name = "ceLock";
            this.ceLock.Size = new System.Drawing.Size(72, 21);
            this.ceLock.TabIndex = 9;
            this.ceLock.Text = "CE Lock";
            this.ceLock.UseVisualStyleBackColor = true;
            this.ceLock.CheckedChanged += new System.EventHandler(this.NationDetailsModified);
            // 
            // DisableAI
            // 
            this.DisableAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DisableAI.AutoSize = true;
            this.DisableAI.Location = new System.Drawing.Point(670, 245);
            this.DisableAI.Name = "DisableAI";
            this.DisableAI.Size = new System.Drawing.Size(60, 21);
            this.DisableAI.TabIndex = 8;
            this.DisableAI.Text = "No AI";
            this.DisableAI.UseVisualStyleBackColor = true;
            this.DisableAI.CheckedChanged += new System.EventHandler(this.NationDetailsModified);
            // 
            // SetEyear
            // 
            this.SetEyear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetEyear.Location = new System.Drawing.Point(560, 275);
            this.SetEyear.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.SetEyear.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.SetEyear.Name = "SetEyear";
            this.SetEyear.Size = new System.Drawing.Size(90, 25);
            this.SetEyear.TabIndex = 6;
            this.SetEyear.ValueChanged += new System.EventHandler(this.NationDetailsModified);
            // 
            // SetSyear
            // 
            this.SetSyear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetSyear.Location = new System.Drawing.Point(445, 275);
            this.SetSyear.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.SetSyear.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.SetSyear.Name = "SetSyear";
            this.SetSyear.Size = new System.Drawing.Size(90, 25);
            this.SetSyear.TabIndex = 5;
            this.SetSyear.ValueChanged += new System.EventHandler(this.NationDetailsModified);
            // 
            // SetCE
            // 
            this.SetCE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetCE.DecimalPlaces = 1;
            this.SetCE.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SetCE.Location = new System.Drawing.Point(509, 374);
            this.SetCE.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.SetCE.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SetCE.Name = "SetCE";
            this.SetCE.Size = new System.Drawing.Size(90, 25);
            this.SetCE.TabIndex = 4;
            this.SetCE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SetCE.ValueChanged += new System.EventHandler(this.NationDetailsModified);
            // 
            // SetGold
            // 
            this.SetGold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetGold.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SetGold.Location = new System.Drawing.Point(510, 308);
            this.SetGold.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.SetGold.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.SetGold.Name = "SetGold";
            this.SetGold.Size = new System.Drawing.Size(90, 25);
            this.SetGold.TabIndex = 3;
            this.SetGold.ThousandsSeparator = true;
            this.SetGold.ValueChanged += new System.EventHandler(this.NationDetailsModified);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 153);
            this.label6.TabIndex = 2;
            this.label6.Text = "Capital:\r\n\r\nActive:                              -\r\n\r\nGold:\r\n\r\nEconomy Bonus:\r\n\r\n" +
    "Combat Efficiency: ";
            // 
            // NationPreview
            // 
            this.NationPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NationPreview.BackColor = System.Drawing.Color.Transparent;
            this.NationPreview.Location = new System.Drawing.Point(384, 3);
            this.NationPreview.Name = "NationPreview";
            this.NationPreview.Size = new System.Drawing.Size(489, 231);
            this.NationPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NationPreview.TabIndex = 1;
            this.NationPreview.TabStop = false;
            this.NationPreview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NationPreview_MouseClick);
            // 
            // NationsTable
            // 
            this.NationsTable.AllowUserToAddRows = false;
            this.NationsTable.AllowUserToDeleteRows = false;
            this.NationsTable.AllowUserToResizeRows = false;
            this.NationsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NationsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NationID,
            this.NationName,
            this.NationColor});
            this.NationsTable.Location = new System.Drawing.Point(3, 3);
            this.NationsTable.MultiSelect = false;
            this.NationsTable.Name = "NationsTable";
            this.NationsTable.RowHeadersVisible = false;
            this.NationsTable.Size = new System.Drawing.Size(375, 370);
            this.NationsTable.TabIndex = 0;
            this.NationsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeNationColor);
            this.NationsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.NationNameModified);
            this.NationsTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataError);
            this.NationsTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.NationsTable_RowEnter);
            // 
            // NationID
            // 
            this.NationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NationID.FillWeight = 20F;
            this.NationID.HeaderText = "ID";
            this.NationID.MinimumWidth = 30;
            this.NationID.Name = "NationID";
            this.NationID.ReadOnly = true;
            // 
            // NationName
            // 
            this.NationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NationName.HeaderText = "Name";
            this.NationName.MinimumWidth = 100;
            this.NationName.Name = "NationName";
            // 
            // NationColor
            // 
            this.NationColor.FillWeight = 50F;
            this.NationColor.HeaderText = "Color";
            this.NationColor.MinimumWidth = 80;
            this.NationColor.Name = "NationColor";
            this.NationColor.ReadOnly = true;
            this.NationColor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NationColor.Width = 80;
            // 
            // CitiesTab
            // 
            this.CitiesTab.AllowDrop = true;
            this.CitiesTab.Controls.Add(this.RemoveCore);
            this.CitiesTab.Controls.Add(this.PasteCityNames);
            this.CitiesTab.Controls.Add(this.label9);
            this.CitiesTab.Controls.Add(this.SetCoreToSelf);
            this.CitiesTab.Controls.Add(this.CityRevoltChance);
            this.CitiesTab.Controls.Add(this.CityRightfulOwner);
            this.CitiesTab.Controls.Add(this.label8);
            this.CitiesTab.Controls.Add(this.CityPreview);
            this.CitiesTab.Controls.Add(this.CitiesTable);
            this.CitiesTab.Location = new System.Drawing.Point(4, 29);
            this.CitiesTab.Name = "CitiesTab";
            this.CitiesTab.Size = new System.Drawing.Size(876, 407);
            this.CitiesTab.TabIndex = 2;
            this.CitiesTab.Text = "Cities";
            this.CitiesTab.UseVisualStyleBackColor = true;
            // 
            // RemoveCore
            // 
            this.RemoveCore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveCore.Location = new System.Drawing.Point(495, 290);
            this.RemoveCore.Name = "RemoveCore";
            this.RemoveCore.Size = new System.Drawing.Size(100, 30);
            this.RemoveCore.TabIndex = 13;
            this.RemoveCore.Text = "Remove core";
            this.RemoveCore.UseVisualStyleBackColor = true;
            this.RemoveCore.Click += new System.EventHandler(this.RemoveCore_Click);
            // 
            // PasteCityNames
            // 
            this.PasteCityNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PasteCityNames.Location = new System.Drawing.Point(3, 379);
            this.PasteCityNames.Name = "PasteCityNames";
            this.PasteCityNames.Size = new System.Drawing.Size(190, 25);
            this.PasteCityNames.TabIndex = 12;
            this.PasteCityNames.Text = "Paste names from clipboard";
            this.PasteCityNames.UseVisualStyleBackColor = true;
            this.PasteCityNames.Click += new System.EventHandler(this.PasteCityNames_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(387, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Shift + click to apply to all cities in a country\r\nCtrl + click to apply to all c" +
    "ities on the map";
            // 
            // SetCoreToSelf
            // 
            this.SetCoreToSelf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetCoreToSelf.Location = new System.Drawing.Point(390, 290);
            this.SetCoreToSelf.Name = "SetCoreToSelf";
            this.SetCoreToSelf.Size = new System.Drawing.Size(100, 30);
            this.SetCoreToSelf.TabIndex = 7;
            this.SetCoreToSelf.Text = "Set as core";
            this.SetCoreToSelf.UseVisualStyleBackColor = true;
            this.SetCoreToSelf.Click += new System.EventHandler(this.SetCoreToSelf_Click);
            // 
            // CityRevoltChance
            // 
            this.CityRevoltChance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CityRevoltChance.Location = new System.Drawing.Point(733, 239);
            this.CityRevoltChance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CityRevoltChance.Name = "CityRevoltChance";
            this.CityRevoltChance.Size = new System.Drawing.Size(60, 25);
            this.CityRevoltChance.TabIndex = 6;
            this.CityRevoltChance.ValueChanged += new System.EventHandler(this.CityDetailsModified);
            // 
            // CityRightfulOwner
            // 
            this.CityRightfulOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CityRightfulOwner.FormattingEnabled = true;
            this.CityRightfulOwner.Items.AddRange(new object[] {
            "No one"});
            this.CityRightfulOwner.Location = new System.Drawing.Point(390, 260);
            this.CityRightfulOwner.Name = "CityRightfulOwner";
            this.CityRightfulOwner.Size = new System.Drawing.Size(205, 25);
            this.CityRightfulOwner.TabIndex = 5;
            this.CityRightfulOwner.SelectedIndexChanged += new System.EventHandler(this.CityDetailsModified);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(337, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rightful owner:                                  Revolt chance (%):\r\n";
            // 
            // CityPreview
            // 
            this.CityPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityPreview.Location = new System.Drawing.Point(384, 3);
            this.CityPreview.Name = "CityPreview";
            this.CityPreview.Size = new System.Drawing.Size(489, 231);
            this.CityPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CityPreview.TabIndex = 3;
            this.CityPreview.TabStop = false;
            this.CityPreview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CityPreview_MouseClick);
            // 
            // CitiesTable
            // 
            this.CitiesTable.AllowDrop = true;
            this.CitiesTable.AllowUserToResizeRows = false;
            this.CitiesTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CitiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CitiesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityX,
            this.cityY,
            this.CityName});
            this.CitiesTable.Location = new System.Drawing.Point(3, 3);
            this.CitiesTable.MultiSelect = false;
            this.CitiesTable.Name = "CitiesTable";
            this.CitiesTable.RowHeadersWidth = 20;
            this.CitiesTable.Size = new System.Drawing.Size(375, 370);
            this.CitiesTable.TabIndex = 2;
            this.CitiesTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CityNameOrPosModified);
            this.CitiesTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CitiesTable_Sorted);
            this.CitiesTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataError);
            this.CitiesTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CitiesTable_RowEnter);
            this.CitiesTable.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.CitiesTable_RowsRemoved);
            // 
            // AlliancesTab
            // 
            this.AlliancesTab.Controls.Add(this.IsUnion);
            this.AlliancesTab.Controls.Add(this.AlliancePreview);
            this.AlliancesTab.Controls.Add(this.Unity);
            this.AlliancesTab.Controls.Add(this.label10);
            this.AlliancesTab.Controls.Add(this.AllianceNationSelect);
            this.AlliancesTab.Controls.Add(this.AlliancesTable);
            this.AlliancesTab.Location = new System.Drawing.Point(4, 29);
            this.AlliancesTab.Name = "AlliancesTab";
            this.AlliancesTab.Size = new System.Drawing.Size(876, 407);
            this.AlliancesTab.TabIndex = 3;
            this.AlliancesTab.Text = "Alliances";
            this.AlliancesTab.UseVisualStyleBackColor = true;
            // 
            // IsUnion
            // 
            this.IsUnion.AutoSize = true;
            this.IsUnion.Location = new System.Drawing.Point(505, 187);
            this.IsUnion.Name = "IsUnion";
            this.IsUnion.Size = new System.Drawing.Size(72, 21);
            this.IsUnion.TabIndex = 7;
            this.IsUnion.Text = "Is union";
            this.IsUnion.UseVisualStyleBackColor = true;
            this.IsUnion.CheckedChanged += new System.EventHandler(this.AllianceDetailsModified);
            // 
            // AlliancePreview
            // 
            this.AlliancePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlliancePreview.Location = new System.Drawing.Point(384, 220);
            this.AlliancePreview.Name = "AlliancePreview";
            this.AlliancePreview.Size = new System.Drawing.Size(489, 184);
            this.AlliancePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlliancePreview.TabIndex = 6;
            this.AlliancePreview.TabStop = false;
            this.AlliancePreview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AlliancePreview_MouseClick);
            // 
            // Unity
            // 
            this.Unity.DecimalPlaces = 1;
            this.Unity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Unity.Location = new System.Drawing.Point(435, 185);
            this.Unity.Name = "Unity";
            this.Unity.Size = new System.Drawing.Size(50, 25);
            this.Unity.TabIndex = 5;
            this.Unity.ValueChanged += new System.EventHandler(this.AllianceDetailsModified);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Unity:";
            // 
            // AllianceNationSelect
            // 
            this.AllianceNationSelect.AllowUserToAddRows = false;
            this.AllianceNationSelect.AllowUserToDeleteRows = false;
            this.AllianceNationSelect.AllowUserToResizeColumns = false;
            this.AllianceNationSelect.AllowUserToResizeRows = false;
            this.AllianceNationSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AllianceNationSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllianceNationSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AllianceNationID,
            this.AllianceNations,
            this.AllianceSelect,
            this.AllianceLoyalty});
            this.AllianceNationSelect.Location = new System.Drawing.Point(3, 3);
            this.AllianceNationSelect.MultiSelect = false;
            this.AllianceNationSelect.Name = "AllianceNationSelect";
            this.AllianceNationSelect.RowHeadersVisible = false;
            this.AllianceNationSelect.Size = new System.Drawing.Size(375, 401);
            this.AllianceNationSelect.TabIndex = 2;
            this.AllianceNationSelect.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllianceModified);
            this.AllianceNationSelect.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataError);
            // 
            // AllianceNationID
            // 
            this.AllianceNationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AllianceNationID.FillWeight = 20F;
            this.AllianceNationID.HeaderText = "ID";
            this.AllianceNationID.MinimumWidth = 30;
            this.AllianceNationID.Name = "AllianceNationID";
            this.AllianceNationID.ReadOnly = true;
            // 
            // AllianceNations
            // 
            this.AllianceNations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AllianceNations.FillWeight = 70F;
            this.AllianceNations.HeaderText = "Nation";
            this.AllianceNations.MinimumWidth = 50;
            this.AllianceNations.Name = "AllianceNations";
            this.AllianceNations.ReadOnly = true;
            this.AllianceNations.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AllianceSelect
            // 
            this.AllianceSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AllianceSelect.HeaderText = "Alliance";
            this.AllianceSelect.MinimumWidth = 50;
            this.AllianceSelect.Name = "AllianceSelect";
            this.AllianceSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllianceSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AllianceLoyalty
            // 
            this.AllianceLoyalty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AllianceLoyalty.FillWeight = 50F;
            this.AllianceLoyalty.HeaderText = "Loyalty";
            this.AllianceLoyalty.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.AllianceLoyalty.MinimumWidth = 20;
            this.AllianceLoyalty.Name = "AllianceLoyalty";
            this.AllianceLoyalty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AlliancesTable
            // 
            this.AlliancesTable.AllowUserToResizeRows = false;
            this.AlliancesTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlliancesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlliancesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AllianceName,
            this.AllianceMembers,
            this.AllianceColor});
            this.AlliancesTable.Location = new System.Drawing.Point(384, 3);
            this.AlliancesTable.MultiSelect = false;
            this.AlliancesTable.Name = "AlliancesTable";
            this.AlliancesTable.RowHeadersWidth = 20;
            this.AlliancesTable.Size = new System.Drawing.Size(489, 175);
            this.AlliancesTable.TabIndex = 1;
            this.AlliancesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeAllianceColor);
            this.AlliancesTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllianceModified);
            this.AlliancesTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataError);
            this.AlliancesTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlliancesTable_RowEnter);
            this.AlliancesTable.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.AlliancesTable_RowsRemoved);
            // 
            // AllianceName
            // 
            this.AllianceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AllianceName.HeaderText = "Name";
            this.AllianceName.MinimumWidth = 100;
            this.AllianceName.Name = "AllianceName";
            this.AllianceName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllianceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AllianceMembers
            // 
            this.AllianceMembers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AllianceMembers.FillWeight = 200F;
            this.AllianceMembers.HeaderText = "Members";
            this.AllianceMembers.MinimumWidth = 100;
            this.AllianceMembers.Name = "AllianceMembers";
            this.AllianceMembers.ReadOnly = true;
            this.AllianceMembers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AllianceColor
            // 
            this.AllianceColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AllianceColor.FillWeight = 50F;
            this.AllianceColor.HeaderText = "Color";
            this.AllianceColor.MinimumWidth = 50;
            this.AllianceColor.Name = "AllianceColor";
            this.AllianceColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PuppetsTab
            // 
            this.PuppetsTab.Controls.Add(this.PuppetLoyaltyDesc);
            this.PuppetsTab.Controls.Add(this.PuppetAutonomyDesc);
            this.PuppetsTab.Controls.Add(this.PuppetLoyalty);
            this.PuppetsTab.Controls.Add(this.PuppetAutonomy);
            this.PuppetsTab.Controls.Add(this.PuppetIntegration);
            this.PuppetsTab.Controls.Add(this.label25);
            this.PuppetsTab.Controls.Add(this.label24);
            this.PuppetsTab.Controls.Add(this.PuppetsOverview);
            this.PuppetsTab.Controls.Add(this.PuppetsTable);
            this.PuppetsTab.Location = new System.Drawing.Point(4, 29);
            this.PuppetsTab.Name = "PuppetsTab";
            this.PuppetsTab.Size = new System.Drawing.Size(876, 407);
            this.PuppetsTab.TabIndex = 6;
            this.PuppetsTab.Text = "Puppets";
            this.PuppetsTab.UseVisualStyleBackColor = true;
            // 
            // PuppetLoyaltyDesc
            // 
            this.PuppetLoyaltyDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PuppetLoyaltyDesc.FormattingEnabled = true;
            this.PuppetLoyaltyDesc.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.PuppetLoyaltyDesc.Location = new System.Drawing.Point(525, 365);
            this.PuppetLoyaltyDesc.Name = "PuppetLoyaltyDesc";
            this.PuppetLoyaltyDesc.Size = new System.Drawing.Size(120, 25);
            this.PuppetLoyaltyDesc.TabIndex = 11;
            this.PuppetLoyaltyDesc.SelectedIndexChanged += new System.EventHandler(this.PuppetDetailsModified);
            // 
            // PuppetAutonomyDesc
            // 
            this.PuppetAutonomyDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PuppetAutonomyDesc.FormattingEnabled = true;
            this.PuppetAutonomyDesc.Items.AddRange(new object[] {
            "Vassal",
            "Puppet",
            "Satelite"});
            this.PuppetAutonomyDesc.Location = new System.Drawing.Point(525, 330);
            this.PuppetAutonomyDesc.Name = "PuppetAutonomyDesc";
            this.PuppetAutonomyDesc.Size = new System.Drawing.Size(120, 25);
            this.PuppetAutonomyDesc.TabIndex = 10;
            this.PuppetAutonomyDesc.SelectedIndexChanged += new System.EventHandler(this.PuppetDetailsModified);
            // 
            // PuppetLoyalty
            // 
            this.PuppetLoyalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PuppetLoyalty.Location = new System.Drawing.Point(465, 365);
            this.PuppetLoyalty.Name = "PuppetLoyalty";
            this.PuppetLoyalty.Size = new System.Drawing.Size(50, 25);
            this.PuppetLoyalty.TabIndex = 9;
            this.PuppetLoyalty.ValueChanged += new System.EventHandler(this.PuppetDetailsModified);
            // 
            // PuppetAutonomy
            // 
            this.PuppetAutonomy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PuppetAutonomy.Location = new System.Drawing.Point(465, 330);
            this.PuppetAutonomy.Name = "PuppetAutonomy";
            this.PuppetAutonomy.Size = new System.Drawing.Size(50, 25);
            this.PuppetAutonomy.TabIndex = 8;
            this.PuppetAutonomy.ValueChanged += new System.EventHandler(this.PuppetDetailsModified);
            // 
            // PuppetIntegration
            // 
            this.PuppetIntegration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PuppetIntegration.Location = new System.Drawing.Point(760, 330);
            this.PuppetIntegration.Name = "PuppetIntegration";
            this.PuppetIntegration.Size = new System.Drawing.Size(50, 25);
            this.PuppetIntegration.TabIndex = 7;
            this.PuppetIntegration.ValueChanged += new System.EventHandler(this.PuppetDetailsModified);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(390, 300);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 102);
            this.label25.TabIndex = 6;
            this.label25.Text = "Puppet settings:\r\n\r\nAutonomy:\r\n\r\nLoyalty:\r\n\r\n";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(680, 300);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 51);
            this.label24.TabIndex = 5;
            this.label24.Text = "Master settings:\r\n\r\nIntegration:";
            // 
            // PuppetsOverview
            // 
            this.PuppetsOverview.AllowUserToAddRows = false;
            this.PuppetsOverview.AllowUserToDeleteRows = false;
            this.PuppetsOverview.AllowUserToResizeRows = false;
            this.PuppetsOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PuppetsOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PuppetsOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PuppetMasterID,
            this.PuppetMastersList,
            this.PuppetsList});
            this.PuppetsOverview.Location = new System.Drawing.Point(384, 3);
            this.PuppetsOverview.MultiSelect = false;
            this.PuppetsOverview.Name = "PuppetsOverview";
            this.PuppetsOverview.RowHeadersVisible = false;
            this.PuppetsOverview.Size = new System.Drawing.Size(489, 290);
            this.PuppetsOverview.TabIndex = 4;
            this.PuppetsOverview.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataError);
            this.PuppetsOverview.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PuppetsTable_RowEnter);
            // 
            // PuppetMasterID
            // 
            this.PuppetMasterID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PuppetMasterID.FillWeight = 5F;
            this.PuppetMasterID.HeaderText = "ID";
            this.PuppetMasterID.MinimumWidth = 30;
            this.PuppetMasterID.Name = "PuppetMasterID";
            this.PuppetMasterID.ReadOnly = true;
            // 
            // PuppetMastersList
            // 
            this.PuppetMastersList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PuppetMastersList.FillWeight = 30F;
            this.PuppetMastersList.HeaderText = "Nation";
            this.PuppetMastersList.MinimumWidth = 100;
            this.PuppetMastersList.Name = "PuppetMastersList";
            this.PuppetMastersList.ReadOnly = true;
            // 
            // PuppetsList
            // 
            this.PuppetsList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PuppetsList.HeaderText = "Puppets";
            this.PuppetsList.MinimumWidth = 200;
            this.PuppetsList.Name = "PuppetsList";
            this.PuppetsList.ReadOnly = true;
            this.PuppetsList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PuppetsTable
            // 
            this.PuppetsTable.AllowUserToAddRows = false;
            this.PuppetsTable.AllowUserToDeleteRows = false;
            this.PuppetsTable.AllowUserToResizeColumns = false;
            this.PuppetsTable.AllowUserToResizeRows = false;
            this.PuppetsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PuppetsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PuppetsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PuppetNationID,
            this.PuppetNationList,
            this.PuppetMasterSelect});
            this.PuppetsTable.Location = new System.Drawing.Point(3, 3);
            this.PuppetsTable.MultiSelect = false;
            this.PuppetsTable.Name = "PuppetsTable";
            this.PuppetsTable.RowHeadersVisible = false;
            this.PuppetsTable.ShowRowErrors = false;
            this.PuppetsTable.Size = new System.Drawing.Size(375, 401);
            this.PuppetsTable.TabIndex = 3;
            this.PuppetsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PuppetMasterModified);
            this.PuppetsTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataError);
            this.PuppetsTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PuppetsTable_RowEnter);
            // 
            // PuppetNationID
            // 
            this.PuppetNationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PuppetNationID.FillWeight = 20F;
            this.PuppetNationID.HeaderText = "ID";
            this.PuppetNationID.MinimumWidth = 30;
            this.PuppetNationID.Name = "PuppetNationID";
            this.PuppetNationID.ReadOnly = true;
            // 
            // PuppetNationList
            // 
            this.PuppetNationList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PuppetNationList.HeaderText = "Nation";
            this.PuppetNationList.MinimumWidth = 100;
            this.PuppetNationList.Name = "PuppetNationList";
            this.PuppetNationList.ReadOnly = true;
            this.PuppetNationList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PuppetMasterSelect
            // 
            this.PuppetMasterSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PuppetMasterSelect.HeaderText = "Master";
            this.PuppetMasterSelect.MinimumWidth = 100;
            this.PuppetMasterSelect.Name = "PuppetMasterSelect";
            this.PuppetMasterSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PuppetMasterSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // WarsTab
            // 
            this.WarsTab.Controls.Add(this.label15);
            this.WarsTab.Controls.Add(this.ToDeath);
            this.WarsTab.Controls.Add(this.MergeWars);
            this.WarsTab.Controls.Add(this.WarEndYear);
            this.WarsTab.Controls.Add(this.WarEndDay);
            this.WarsTab.Controls.Add(this.WarEndMonth);
            this.WarsTab.Controls.Add(this.RemoveWar);
            this.WarsTab.Controls.Add(this.AddWar);
            this.WarsTab.Controls.Add(this.WarStartYear);
            this.WarsTab.Controls.Add(this.WarStartDay);
            this.WarsTab.Controls.Add(this.WarStartMonth);
            this.WarsTab.Controls.Add(this.label11);
            this.WarsTab.Controls.Add(this.WarNationSelect);
            this.WarsTab.Controls.Add(this.WarsTable);
            this.WarsTab.Location = new System.Drawing.Point(4, 29);
            this.WarsTab.Name = "WarsTab";
            this.WarsTab.Size = new System.Drawing.Size(876, 407);
            this.WarsTab.TabIndex = 4;
            this.WarsTab.Text = "Wars";
            this.WarsTab.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(406, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "* former participant";
            // 
            // ToDeath
            // 
            this.ToDeath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ToDeath.Location = new System.Drawing.Point(391, 370);
            this.ToDeath.Name = "ToDeath";
            this.ToDeath.Size = new System.Drawing.Size(75, 25);
            this.ToDeath.TabIndex = 33;
            this.ToDeath.Text = "To death";
            this.ToDeath.UseVisualStyleBackColor = true;
            this.ToDeath.Click += new System.EventHandler(this.WarDetailsModified);
            // 
            // MergeWars
            // 
            this.MergeWars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MergeWars.Location = new System.Drawing.Point(216, 300);
            this.MergeWars.Name = "MergeWars";
            this.MergeWars.Size = new System.Drawing.Size(120, 25);
            this.MergeWars.TabIndex = 32;
            this.MergeWars.Text = "Merge selected";
            this.MergeWars.UseVisualStyleBackColor = true;
            this.MergeWars.Click += new System.EventHandler(this.MergeWars_Click);
            // 
            // WarEndYear
            // 
            this.WarEndYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WarEndYear.Location = new System.Drawing.Point(300, 370);
            this.WarEndYear.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.WarEndYear.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.WarEndYear.Name = "WarEndYear";
            this.WarEndYear.Size = new System.Drawing.Size(85, 25);
            this.WarEndYear.TabIndex = 31;
            this.WarEndYear.ValueChanged += new System.EventHandler(this.WarDetailsModified);
            // 
            // WarEndDay
            // 
            this.WarEndDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WarEndDay.Location = new System.Drawing.Point(254, 370);
            this.WarEndDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.WarEndDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WarEndDay.Name = "WarEndDay";
            this.WarEndDay.Size = new System.Drawing.Size(40, 25);
            this.WarEndDay.TabIndex = 30;
            this.WarEndDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WarEndDay.ValueChanged += new System.EventHandler(this.WarDetailsModified);
            // 
            // WarEndMonth
            // 
            this.WarEndMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WarEndMonth.FormattingEnabled = true;
            this.WarEndMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.WarEndMonth.Location = new System.Drawing.Point(128, 370);
            this.WarEndMonth.Name = "WarEndMonth";
            this.WarEndMonth.Size = new System.Drawing.Size(120, 25);
            this.WarEndMonth.TabIndex = 29;
            this.WarEndMonth.SelectedIndexChanged += new System.EventHandler(this.WarDetailsModified);
            // 
            // RemoveWar
            // 
            this.RemoveWar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveWar.Location = new System.Drawing.Point(90, 300);
            this.RemoveWar.Name = "RemoveWar";
            this.RemoveWar.Size = new System.Drawing.Size(120, 25);
            this.RemoveWar.TabIndex = 24;
            this.RemoveWar.Text = "Remove selected";
            this.RemoveWar.UseVisualStyleBackColor = true;
            this.RemoveWar.Click += new System.EventHandler(this.RemoveWar_Click);
            // 
            // AddWar
            // 
            this.AddWar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddWar.Location = new System.Drawing.Point(6, 300);
            this.AddWar.Name = "AddWar";
            this.AddWar.Size = new System.Drawing.Size(80, 25);
            this.AddWar.TabIndex = 23;
            this.AddWar.Text = "Add new";
            this.AddWar.UseVisualStyleBackColor = true;
            this.AddWar.Click += new System.EventHandler(this.AddWar_Click);
            // 
            // WarStartYear
            // 
            this.WarStartYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WarStartYear.Location = new System.Drawing.Point(300, 336);
            this.WarStartYear.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.WarStartYear.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.WarStartYear.Name = "WarStartYear";
            this.WarStartYear.Size = new System.Drawing.Size(85, 25);
            this.WarStartYear.TabIndex = 22;
            this.WarStartYear.ValueChanged += new System.EventHandler(this.WarDetailsModified);
            // 
            // WarStartDay
            // 
            this.WarStartDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WarStartDay.Location = new System.Drawing.Point(254, 336);
            this.WarStartDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.WarStartDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WarStartDay.Name = "WarStartDay";
            this.WarStartDay.Size = new System.Drawing.Size(40, 25);
            this.WarStartDay.TabIndex = 21;
            this.WarStartDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WarStartDay.ValueChanged += new System.EventHandler(this.WarDetailsModified);
            // 
            // WarStartMonth
            // 
            this.WarStartMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WarStartMonth.FormattingEnabled = true;
            this.WarStartMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.WarStartMonth.Location = new System.Drawing.Point(128, 336);
            this.WarStartMonth.Name = "WarStartMonth";
            this.WarStartMonth.Size = new System.Drawing.Size(120, 25);
            this.WarStartMonth.TabIndex = 20;
            this.WarStartMonth.SelectedIndexChanged += new System.EventHandler(this.WarDetailsModified);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 51);
            this.label11.TabIndex = 4;
            this.label11.Text = "Start date:\r\n\r\nTarget end date:";
            // 
            // WarNationSelect
            // 
            this.WarNationSelect.AllowUserToAddRows = false;
            this.WarNationSelect.AllowUserToDeleteRows = false;
            this.WarNationSelect.AllowUserToResizeRows = false;
            this.WarNationSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarNationSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarNationSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WarNationID,
            this.Nation,
            this.Involvement});
            this.WarNationSelect.Location = new System.Drawing.Point(520, 3);
            this.WarNationSelect.MultiSelect = false;
            this.WarNationSelect.Name = "WarNationSelect";
            this.WarNationSelect.RowHeadersVisible = false;
            this.WarNationSelect.Size = new System.Drawing.Size(353, 401);
            this.WarNationSelect.TabIndex = 3;
            this.WarNationSelect.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarParticipantsModified);
            // 
            // WarNationID
            // 
            this.WarNationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WarNationID.FillWeight = 20F;
            this.WarNationID.HeaderText = "ID";
            this.WarNationID.MinimumWidth = 20;
            this.WarNationID.Name = "WarNationID";
            this.WarNationID.ReadOnly = true;
            // 
            // Nation
            // 
            this.Nation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nation.HeaderText = "Nation";
            this.Nation.MinimumWidth = 100;
            this.Nation.Name = "Nation";
            this.Nation.ReadOnly = true;
            // 
            // Involvement
            // 
            this.Involvement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Involvement.FillWeight = 50F;
            this.Involvement.HeaderText = "Select stance";
            this.Involvement.Items.AddRange(new object[] {
            "Not involved",
            "Attacker",
            "Former attacker",
            "Defender",
            "Former defender"});
            this.Involvement.MinimumWidth = 50;
            this.Involvement.Name = "Involvement";
            this.Involvement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Involvement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // WarsTable
            // 
            this.WarsTable.AllowUserToAddRows = false;
            this.WarsTable.AllowUserToDeleteRows = false;
            this.WarsTable.AllowUserToResizeRows = false;
            this.WarsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attackers,
            this.Defenders});
            this.WarsTable.Location = new System.Drawing.Point(3, 3);
            this.WarsTable.Name = "WarsTable";
            this.WarsTable.RowHeadersWidth = 20;
            this.WarsTable.Size = new System.Drawing.Size(511, 291);
            this.WarsTable.TabIndex = 2;
            this.WarsTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarsTable_RowEnter);
            // 
            // Attackers
            // 
            this.Attackers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Attackers.HeaderText = "Attackers";
            this.Attackers.MinimumWidth = 200;
            this.Attackers.Name = "Attackers";
            this.Attackers.ReadOnly = true;
            this.Attackers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Defenders
            // 
            this.Defenders.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Defenders.HeaderText = "Defenders";
            this.Defenders.MinimumWidth = 200;
            this.Defenders.Name = "Defenders";
            this.Defenders.ReadOnly = true;
            this.Defenders.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Defenders.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // InfoTab
            // 
            this.InfoTab.Controls.Add(this.groupBox2);
            this.InfoTab.Controls.Add(this.groupBox1);
            this.InfoTab.Location = new System.Drawing.Point(4, 29);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Size = new System.Drawing.Size(876, 407);
            this.InfoTab.TabIndex = 5;
            this.InfoTab.Text = "Help & Info";
            this.InfoTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(3, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(270, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(445, 34);
            this.label19.TabIndex = 3;
            this.label19.Text = "JokuPelle for creating a wonderful space in and around this game\r\nThe AoC communi" +
    "ty for supporting me and my silly projects over the years\r\n";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(270, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Special thanks to:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(100, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "0.1.0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 51);
            this.label16.TabIndex = 0;
            this.label16.Text = "App verison: \r\n\r\nLead developer:   Corrupted Matt\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.FlagEditorLink);
            this.groupBox1.Controls.Add(this.ConverterLink);
            this.groupBox1.Controls.Add(this.DiscordLink);
            this.groupBox1.Controls.Add(this.ReadmeLink);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Help and Resources";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(6, 205);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(246, 26);
            this.label22.TabIndex = 25;
            this.label22.Text = "note: generated scenarios need to be opened \r\nand saved in game to ensure compati" +
    "bility";
            // 
            // FlagEditorLink
            // 
            this.FlagEditorLink.AutoSize = true;
            this.FlagEditorLink.Location = new System.Drawing.Point(210, 183);
            this.FlagEditorLink.Name = "FlagEditorLink";
            this.FlagEditorLink.Size = new System.Drawing.Size(48, 17);
            this.FlagEditorLink.TabIndex = 4;
            this.FlagEditorLink.TabStop = true;
            this.FlagEditorLink.Text = "GitHub";
            this.FlagEditorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FlagEditorLink_LinkClicked);
            // 
            // ConverterLink
            // 
            this.ConverterLink.AutoSize = true;
            this.ConverterLink.Location = new System.Drawing.Point(210, 149);
            this.ConverterLink.Name = "ConverterLink";
            this.ConverterLink.Size = new System.Drawing.Size(48, 17);
            this.ConverterLink.TabIndex = 3;
            this.ConverterLink.TabStop = true;
            this.ConverterLink.Text = "GitHub";
            this.ConverterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConverterLink_LinkClicked);
            // 
            // DiscordLink
            // 
            this.DiscordLink.AutoSize = true;
            this.DiscordLink.Location = new System.Drawing.Point(435, 80);
            this.DiscordLink.Name = "DiscordLink";
            this.DiscordLink.Size = new System.Drawing.Size(53, 17);
            this.DiscordLink.TabIndex = 2;
            this.DiscordLink.TabStop = true;
            this.DiscordLink.Text = "Discord";
            this.DiscordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DiscordLink_LinkClicked);
            // 
            // ReadmeLink
            // 
            this.ReadmeLink.AutoSize = true;
            this.ReadmeLink.Location = new System.Drawing.Point(240, 30);
            this.ReadmeLink.Name = "ReadmeLink";
            this.ReadmeLink.Size = new System.Drawing.Size(48, 17);
            this.ReadmeLink.TabIndex = 1;
            this.ReadmeLink.TabStop = true;
            this.ReadmeLink.Text = "GitHub";
            this.ReadmeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReadmeLink_LinkClicked);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(421, 170);
            this.label20.TabIndex = 0;
            this.label20.Text = resources.GetString("label20.Text");
            // 
            // DestinationInput
            // 
            this.DestinationInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DestinationInput.Location = new System.Drawing.Point(12, 469);
            this.DestinationInput.Name = "DestinationInput";
            this.DestinationInput.Size = new System.Drawing.Size(401, 25);
            this.DestinationInput.TabIndex = 1;
            // 
            // NameSelection
            // 
            this.NameSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NameSelection.Location = new System.Drawing.Point(524, 469);
            this.NameSelection.Name = "NameSelection";
            this.NameSelection.Size = new System.Drawing.Size(348, 25);
            this.NameSelection.TabIndex = 2;
            // 
            // DestinationBrowse
            // 
            this.DestinationBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DestinationBrowse.Location = new System.Drawing.Point(419, 466);
            this.DestinationBrowse.Name = "DestinationBrowse";
            this.DestinationBrowse.Size = new System.Drawing.Size(88, 30);
            this.DestinationBrowse.TabIndex = 5;
            this.DestinationBrowse.Text = "Browse";
            this.DestinationBrowse.UseVisualStyleBackColor = true;
            this.DestinationBrowse.Click += new System.EventHandler(this.DestinationBrowse_Click);
            // 
            // RunGameButton
            // 
            this.RunGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RunGameButton.Location = new System.Drawing.Point(667, 500);
            this.RunGameButton.Name = "RunGameButton";
            this.RunGameButton.Size = new System.Drawing.Size(100, 50);
            this.RunGameButton.TabIndex = 6;
            this.RunGameButton.Text = "Run AoC \r\nvia Steam";
            this.RunGameButton.UseVisualStyleBackColor = true;
            this.RunGameButton.Click += new System.EventHandler(this.RunGameButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenerateButton.Location = new System.Drawing.Point(773, 500);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(100, 50);
            this.GenerateButton.TabIndex = 7;
            this.GenerateButton.Text = "Export \nscenario";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 68);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select output destination\r\n\r\n\r\nExport as:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "New scenario name:";
            // 
            // ColorPicker
            // 
            this.ColorPicker.AnyColor = true;
            this.ColorPicker.FullOpen = true;
            // 
            // ExportAsScenario
            // 
            this.ExportAsScenario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExportAsScenario.AutoSize = true;
            this.ExportAsScenario.Checked = true;
            this.ExportAsScenario.Location = new System.Drawing.Point(85, 500);
            this.ExportAsScenario.Name = "ExportAsScenario";
            this.ExportAsScenario.Size = new System.Drawing.Size(76, 21);
            this.ExportAsScenario.TabIndex = 10;
            this.ExportAsScenario.TabStop = true;
            this.ExportAsScenario.Text = "Scenario";
            this.ExportAsScenario.UseVisualStyleBackColor = true;
            this.ExportAsScenario.CheckedChanged += new System.EventHandler(this.ExportTypeChanged);
            // 
            // ExportAsSave
            // 
            this.ExportAsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExportAsSave.AutoSize = true;
            this.ExportAsSave.Location = new System.Drawing.Point(172, 500);
            this.ExportAsSave.Name = "ExportAsSave";
            this.ExportAsSave.Size = new System.Drawing.Size(53, 21);
            this.ExportAsSave.TabIndex = 11;
            this.ExportAsSave.Text = "Save";
            this.ExportAsSave.UseVisualStyleBackColor = true;
            this.ExportAsSave.CheckedChanged += new System.EventHandler(this.ExportTypeChanged);
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label26.Location = new System.Drawing.Point(10, 524);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(201, 26);
            this.label26.TabIndex = 37;
            this.label26.Text = "Shift + click to set destination \r\nto the appropriate game folder folder";
            // 
            // cityX
            // 
            this.cityX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityX.FillWeight = 20F;
            this.cityX.HeaderText = "X";
            this.cityX.MinimumWidth = 30;
            this.cityX.Name = "cityX";
            this.cityX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cityY
            // 
            this.cityY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityY.FillWeight = 20F;
            this.cityY.HeaderText = "Y";
            this.cityY.MinimumWidth = 30;
            this.cityY.Name = "cityY";
            this.cityY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CityName
            // 
            this.CityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CityName.HeaderText = "Name";
            this.CityName.MinimumWidth = 100;
            this.CityName.Name = "CityName";
            this.CityName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.ExportAsSave);
            this.Controls.Add(this.ExportAsScenario);
            this.Controls.Add(this.DestinationInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.RunGameButton);
            this.Controls.Add(this.DestinationBrowse);
            this.Controls.Add(this.NameSelection);
            this.Controls.Add(this.TabSelect);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "App";
            this.Text = "Advanced Scenario Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabSelect.ResumeLayout(false);
            this.LoadTab.ResumeLayout(false);
            this.LoadTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartingDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingYear)).EndInit();
            this.NationsTab.ResumeLayout(false);
            this.NationsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetFlagID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlagPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetEyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetSyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NationPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NationsTable)).EndInit();
            this.CitiesTab.ResumeLayout(false);
            this.CitiesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityRevoltChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CitiesTable)).EndInit();
            this.AlliancesTab.ResumeLayout(false);
            this.AlliancesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlliancePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllianceNationSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlliancesTable)).EndInit();
            this.PuppetsTab.ResumeLayout(false);
            this.PuppetsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PuppetLoyalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuppetAutonomy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuppetIntegration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuppetsOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuppetsTable)).EndInit();
            this.WarsTab.ResumeLayout(false);
            this.WarsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarEndYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarEndDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarStartYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarStartDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarNationSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarsTable)).EndInit();
            this.InfoTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabSelect;
        private System.Windows.Forms.TabPage LoadTab;
        private System.Windows.Forms.TabPage NationsTab;
        private System.Windows.Forms.TabPage CitiesTab;
        private System.Windows.Forms.TabPage AlliancesTab;
        private System.Windows.Forms.TabPage WarsTab;
        private System.Windows.Forms.TabPage InfoTab;
        private System.Windows.Forms.TextBox DestinationInput;
        private System.Windows.Forms.TextBox NameSelection;
        private System.Windows.Forms.Button DestinationBrowse;
        private System.Windows.Forms.Button RunGameButton;
        private System.Windows.Forms.Button GenerateButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ScenarioBrowse;
        private TextBox ScenarioInput;
        private Label label5;
        private Label label4;
        private Button LoadScenario;
        private Label ScenarioSizeLabel;
        private Label GameVerLabel;
        private NumericUpDown StartingYear;
        private ComboBox StartingMonth;
        private NumericUpDown CurrentYear;
        private NumericUpDown CurrentDay;
        private ComboBox CurrentMonth;
        private DataGridView NationsTable;
        private PictureBox NationPreview;
        private Label label6;
        private NumericUpDown SetEyear;
        private NumericUpDown SetSyear;
        private NumericUpDown SetCE;
        private NumericUpDown SetGold;
        private CheckBox ceLock;
        private CheckBox DisableAI;
        private PictureBox CityPreview;
        private DataGridView CitiesTable;
        private Label label8;
        private NumericUpDown CityRevoltChance;
        private ComboBox CityRightfulOwner;
        private Button SetCoreToSelf;
        private Label label9;
        private DataGridView AlliancesTable;
        private DataGridView AllianceNationSelect;
        private Label label10;
        private NumericUpDown Unity;
        private PictureBox AlliancePreview;
        private CheckBox IsUnion;
        private DataGridView WarsTable;
        private DataGridView WarNationSelect;
        private Label label11;
        private NumericUpDown WarStartYear;
        private NumericUpDown WarStartDay;
        private ComboBox WarStartMonth;
        private Label label12;
        private PictureBox HomePreview;
        private Label ScenarioStatsLabel;
        private Label label13;
        private Button RemoveWar;
        private Button AddWar;
        private GroupBox groupBox2;
        private Label label17;
        private Label label16;
        private GroupBox groupBox1;
        private Label label18;
        private Label label19;
        private Label label20;
        private LinkLabel FlagEditorLink;
        private LinkLabel ConverterLink;
        private LinkLabel DiscordLink;
        private LinkLabel ReadmeLink;
        private Label label14;
        private RadioButton DayScale;
        private RadioButton MonthScale;
        private Button SetCEToAll;
        private Button SetGoldToAll;
        private ColorDialog ColorPicker;
        private NumericUpDown SetFlagID;
        private PictureBox FlagPreview;
        private Label label21;
        private Button ExportImage;
        private ComboBox MainMapSelect;
        private Label label22;
        private CheckBox ShowCities;
        private Label label23;
        private Label ExportImgInfo;
        private TabPage PuppetsTab;
        private DataGridView PuppetsTable;
        private DataGridView PuppetsOverview;
        private Label label24;
        private Label label25;
        private NumericUpDown PuppetIntegration;
        private NumericUpDown PuppetLoyalty;
        private NumericUpDown PuppetAutonomy;
        private ComboBox PuppetLoyaltyDesc;
        private ComboBox PuppetAutonomyDesc;
        private Button PasteCityNames;
        private Button MergeWars;
        private NumericUpDown WarEndYear;
        private NumericUpDown WarEndDay;
        private ComboBox WarEndMonth;
        private NumericUpDown StartingDay;
        private Button SetBonusToAll;
        private NumericUpDown SetBonus;
        private DataGridViewTextBoxColumn AllianceName;
        private DataGridViewTextBoxColumn AllianceMembers;
        private DataGridViewButtonColumn AllianceColor;
        private DataGridViewTextBoxColumn Attackers;
        private DataGridViewTextBoxColumn Defenders;
        private Button ToDeath;
        private Label label15;
        private ComboBox CapitalSelect;
        private Label label7;
        private DataGridViewTextBoxColumn WarNationID;
        private DataGridViewTextBoxColumn Nation;
        private DataGridViewComboBoxColumn Involvement;
        private RadioButton ExportAsScenario;
        private RadioButton ExportAsSave;
        private Label label26;
        private DataGridViewTextBoxColumn NationID;
        private DataGridViewTextBoxColumn NationName;
        private DataGridViewButtonColumn NationColor;
        private DataGridViewTextBoxColumn AllianceNationID;
        private DataGridViewTextBoxColumn AllianceNations;
        private DataGridViewComboBoxColumn AllianceSelect;
        private DataGridViewComboBoxColumn AllianceLoyalty;
        private DataGridViewTextBoxColumn PuppetNationID;
        private DataGridViewTextBoxColumn PuppetNationList;
        private DataGridViewComboBoxColumn PuppetMasterSelect;
        private DataGridViewTextBoxColumn PuppetMasterID;
        private DataGridViewTextBoxColumn PuppetMastersList;
        private DataGridViewTextBoxColumn PuppetsList;
        private Button PasteNationNames;
        private Button RemoveCore;
        private DataGridViewTextBoxColumn cityX;
        private DataGridViewTextBoxColumn cityY;
        private DataGridViewTextBoxColumn CityName;
    }
}

