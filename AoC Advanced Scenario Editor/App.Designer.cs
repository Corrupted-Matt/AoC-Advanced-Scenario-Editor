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
            TabSelect = new TabControl();
            LoadTab = new TabPage();
            StartingDay = new NumericUpDown();
            ExportImgInfo = new Label();
            ShowCities = new CheckBox();
            label23 = new Label();
            ExportImage = new Button();
            MainMapSelect = new ComboBox();
            DayScale = new RadioButton();
            MonthScale = new RadioButton();
            label14 = new Label();
            HomePreview = new PictureBox();
            ScenarioStatsLabel = new Label();
            label13 = new Label();
            label12 = new Label();
            CurrentYear = new NumericUpDown();
            CurrentDay = new NumericUpDown();
            CurrentMonth = new ComboBox();
            StartingYear = new NumericUpDown();
            StartingMonth = new ComboBox();
            ScenarioSizeLabel = new Label();
            GameVerLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            LoadScenario = new Button();
            label3 = new Label();
            ScenarioBrowse = new Button();
            ScenarioInput = new TextBox();
            NationsTab = new TabPage();
            label30 = new Label();
            PasteNationNames = new Button();
            label7 = new Label();
            CapitalSelect = new ComboBox();
            SetBonusToAll = new Button();
            SetBonus = new NumericUpDown();
            label21 = new Label();
            SetFlagID = new NumericUpDown();
            FlagPreview = new PictureBox();
            SetCEToAll = new Button();
            SetGoldToAll = new Button();
            ceLock = new CheckBox();
            DisableAI = new CheckBox();
            SetEyear = new NumericUpDown();
            SetSyear = new NumericUpDown();
            SetCE = new NumericUpDown();
            SetGold = new NumericUpDown();
            label6 = new Label();
            NationPreview = new PictureBox();
            NationsTable = new DataGridView();
            NationID = new DataGridViewTextBoxColumn();
            NationName = new DataGridViewTextBoxColumn();
            NationColor = new DataGridViewButtonColumn();
            CitiesTab = new TabPage();
            ShowGrid = new CheckBox();
            label29 = new Label();
            label28 = new Label();
            ImportCities = new Button();
            RemoveCore = new Button();
            PasteCityNames = new Button();
            label9 = new Label();
            SetCoreToSelf = new Button();
            CityRevoltChance = new NumericUpDown();
            CityRightfulOwner = new ComboBox();
            label8 = new Label();
            CityPreview = new PictureBox();
            CitiesTable = new DataGridView();
            cityX = new DataGridViewTextBoxColumn();
            cityY = new DataGridViewTextBoxColumn();
            CityName = new DataGridViewTextBoxColumn();
            AlliancesTab = new TabPage();
            label27 = new Label();
            IsUnion = new CheckBox();
            AlliancePreview = new PictureBox();
            Unity = new NumericUpDown();
            label10 = new Label();
            AllianceNationSelect = new DataGridView();
            AllianceNationID = new DataGridViewTextBoxColumn();
            AllianceNations = new DataGridViewTextBoxColumn();
            AllianceSelect = new DataGridViewComboBoxColumn();
            AllianceLoyalty = new DataGridViewComboBoxColumn();
            AlliancesTable = new DataGridView();
            AllianceName = new DataGridViewTextBoxColumn();
            AllianceMembers = new DataGridViewTextBoxColumn();
            AllianceColor = new DataGridViewButtonColumn();
            PuppetsTab = new TabPage();
            PuppetLoyaltyDesc = new ComboBox();
            PuppetAutonomyDesc = new ComboBox();
            PuppetLoyalty = new NumericUpDown();
            PuppetAutonomy = new NumericUpDown();
            PuppetIntegration = new NumericUpDown();
            label25 = new Label();
            label24 = new Label();
            PuppetsOverview = new DataGridView();
            PuppetMasterID = new DataGridViewTextBoxColumn();
            PuppetMastersList = new DataGridViewTextBoxColumn();
            PuppetsList = new DataGridViewTextBoxColumn();
            PuppetsTable = new DataGridView();
            PuppetNationID = new DataGridViewTextBoxColumn();
            PuppetNationList = new DataGridViewTextBoxColumn();
            PuppetMasterSelect = new DataGridViewComboBoxColumn();
            WarsTab = new TabPage();
            label15 = new Label();
            ToDeath = new Button();
            MergeWars = new Button();
            WarEndYear = new NumericUpDown();
            WarEndDay = new NumericUpDown();
            WarEndMonth = new ComboBox();
            RemoveWar = new Button();
            AddWar = new Button();
            WarStartYear = new NumericUpDown();
            WarStartDay = new NumericUpDown();
            WarStartMonth = new ComboBox();
            label11 = new Label();
            WarNationSelect = new DataGridView();
            WarNationID = new DataGridViewTextBoxColumn();
            Nation = new DataGridViewTextBoxColumn();
            Involvement = new DataGridViewComboBoxColumn();
            WarsTable = new DataGridView();
            Attackers = new DataGridViewTextBoxColumn();
            Defenders = new DataGridViewTextBoxColumn();
            InfoTab = new TabPage();
            groupBox2 = new GroupBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            groupBox1 = new GroupBox();
            label22 = new Label();
            FlagEditorLink = new LinkLabel();
            ConverterLink = new LinkLabel();
            DiscordLink = new LinkLabel();
            ReadmeLink = new LinkLabel();
            label20 = new Label();
            DestinationInput = new TextBox();
            NameSelection = new TextBox();
            DestinationBrowse = new Button();
            RunGameButton = new Button();
            GenerateButton = new Button();
            label1 = new Label();
            label2 = new Label();
            ColorPicker = new ColorDialog();
            ExportAsScenario = new RadioButton();
            ExportAsSave = new RadioButton();
            label26 = new Label();
            TabSelect.SuspendLayout();
            LoadTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StartingDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HomePreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CurrentYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CurrentDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartingYear).BeginInit();
            NationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SetBonus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SetFlagID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlagPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SetEyear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SetSyear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SetCE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SetGold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NationPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NationsTable).BeginInit();
            CitiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CityRevoltChance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CityPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CitiesTable).BeginInit();
            AlliancesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AlliancePreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Unity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllianceNationSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlliancesTable).BeginInit();
            PuppetsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PuppetLoyalty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuppetAutonomy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuppetIntegration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsOverview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsTable).BeginInit();
            WarsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WarEndYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarEndDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarStartYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarStartDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarNationSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarsTable).BeginInit();
            InfoTab.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TabSelect
            // 
            TabSelect.AllowDrop = true;
            TabSelect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabSelect.Controls.Add(LoadTab);
            TabSelect.Controls.Add(NationsTab);
            TabSelect.Controls.Add(CitiesTab);
            TabSelect.Controls.Add(AlliancesTab);
            TabSelect.Controls.Add(PuppetsTab);
            TabSelect.Controls.Add(WarsTab);
            TabSelect.Controls.Add(InfoTab);
            TabSelect.ItemSize = new Size(100, 25);
            TabSelect.Location = new Point(0, 0);
            TabSelect.Margin = new Padding(0);
            TabSelect.Multiline = true;
            TabSelect.Name = "TabSelect";
            TabSelect.SelectedIndex = 0;
            TabSelect.Size = new Size(884, 440);
            TabSelect.SizeMode = TabSizeMode.Fixed;
            TabSelect.TabIndex = 0;
            // 
            // LoadTab
            // 
            LoadTab.Controls.Add(StartingDay);
            LoadTab.Controls.Add(ExportImgInfo);
            LoadTab.Controls.Add(ShowCities);
            LoadTab.Controls.Add(label23);
            LoadTab.Controls.Add(ExportImage);
            LoadTab.Controls.Add(MainMapSelect);
            LoadTab.Controls.Add(DayScale);
            LoadTab.Controls.Add(MonthScale);
            LoadTab.Controls.Add(label14);
            LoadTab.Controls.Add(HomePreview);
            LoadTab.Controls.Add(ScenarioStatsLabel);
            LoadTab.Controls.Add(label13);
            LoadTab.Controls.Add(label12);
            LoadTab.Controls.Add(CurrentYear);
            LoadTab.Controls.Add(CurrentDay);
            LoadTab.Controls.Add(CurrentMonth);
            LoadTab.Controls.Add(StartingYear);
            LoadTab.Controls.Add(StartingMonth);
            LoadTab.Controls.Add(ScenarioSizeLabel);
            LoadTab.Controls.Add(GameVerLabel);
            LoadTab.Controls.Add(label5);
            LoadTab.Controls.Add(label4);
            LoadTab.Controls.Add(LoadScenario);
            LoadTab.Controls.Add(label3);
            LoadTab.Controls.Add(ScenarioBrowse);
            LoadTab.Controls.Add(ScenarioInput);
            LoadTab.Location = new Point(4, 29);
            LoadTab.Name = "LoadTab";
            LoadTab.Padding = new Padding(3);
            LoadTab.Size = new Size(876, 407);
            LoadTab.TabIndex = 0;
            LoadTab.Text = "Load";
            LoadTab.UseVisualStyleBackColor = true;
            // 
            // StartingDay
            // 
            StartingDay.Location = new Point(244, 332);
            StartingDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            StartingDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            StartingDay.Name = "StartingDay";
            StartingDay.Size = new Size(40, 25);
            StartingDay.TabIndex = 36;
            StartingDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            StartingDay.ValueChanged += DateChanged;
            // 
            // ExportImgInfo
            // 
            ExportImgInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExportImgInfo.AutoSize = true;
            ExportImgInfo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ExportImgInfo.ForeColor = SystemColors.ControlDarkDark;
            ExportImgInfo.Location = new Point(690, 40);
            ExportImgInfo.Name = "ExportImgInfo";
            ExportImgInfo.Size = new Size(175, 26);
            ExportImgInfo.TabIndex = 35;
            ExportImgInfo.Text = "Will export without cities.\r\nCheck to export cities separately.";
            // 
            // ShowCities
            // 
            ShowCities.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowCities.AutoSize = true;
            ShowCities.Location = new Point(592, 43);
            ShowCities.Name = "ShowCities";
            ShowCities.Size = new Size(91, 21);
            ShowCities.TabIndex = 34;
            ShowCities.Text = "Show cities";
            ShowCities.UseVisualStyleBackColor = true;
            ShowCities.CheckedChanged += ShowCities_CheckedChanged;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Location = new Point(589, 13);
            label23.Name = "label23";
            label23.Size = new Size(42, 17);
            label23.TabIndex = 33;
            label23.Text = "View: ";
            // 
            // ExportImage
            // 
            ExportImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExportImage.Enabled = false;
            ExportImage.Location = new Point(769, 7);
            ExportImage.Name = "ExportImage";
            ExportImage.Size = new Size(100, 30);
            ExportImage.TabIndex = 32;
            ExportImage.Text = "Export image";
            ExportImage.UseVisualStyleBackColor = true;
            ExportImage.Click += ExportImage_Click;
            // 
            // MainMapSelect
            // 
            MainMapSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MainMapSelect.FormattingEnabled = true;
            MainMapSelect.Items.AddRange(new object[] { "Terrain", "De Facto", "De Jure" });
            MainMapSelect.Location = new Point(637, 10);
            MainMapSelect.Name = "MainMapSelect";
            MainMapSelect.Size = new Size(121, 25);
            MainMapSelect.TabIndex = 31;
            MainMapSelect.Text = "Terrain";
            MainMapSelect.SelectedIndexChanged += UpdateMainMap;
            // 
            // DayScale
            // 
            DayScale.AutoSize = true;
            DayScale.Location = new Point(14, 121);
            DayScale.Name = "DayScale";
            DayScale.Size = new Size(54, 21);
            DayScale.TabIndex = 30;
            DayScale.Text = "Days";
            DayScale.UseVisualStyleBackColor = true;
            // 
            // MonthScale
            // 
            MonthScale.AutoSize = true;
            MonthScale.Checked = true;
            MonthScale.Location = new Point(14, 94);
            MonthScale.Name = "MonthScale";
            MonthScale.Size = new Size(70, 21);
            MonthScale.TabIndex = 29;
            MonthScale.TabStop = true;
            MonthScale.Text = "Months";
            MonthScale.UseVisualStyleBackColor = true;
            MonthScale.CheckedChanged += ReloadRequired;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 70);
            label14.Name = "label14";
            label14.Size = new Size(120, 17);
            label14.TabIndex = 28;
            label14.Text = "Intended timescale:";
            // 
            // HomePreview
            // 
            HomePreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HomePreview.BackgroundImageLayout = ImageLayout.Zoom;
            HomePreview.Location = new Point(385, 70);
            HomePreview.Name = "HomePreview";
            HomePreview.Size = new Size(485, 331);
            HomePreview.SizeMode = PictureBoxSizeMode.Zoom;
            HomePreview.TabIndex = 27;
            HomePreview.TabStop = false;
            // 
            // ScenarioStatsLabel
            // 
            ScenarioStatsLabel.AutoSize = true;
            ScenarioStatsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ScenarioStatsLabel.Location = new Point(311, 235);
            ScenarioStatsLabel.Name = "ScenarioStatsLabel";
            ScenarioStatsLabel.Size = new Size(66, 68);
            ScenarioStatsLabel.TabIndex = 26;
            ScenarioStatsLabel.Text = "Unknown\r\nUnknown\r\nUnknown\r\nUnknown";
            ScenarioStatsLabel.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(244, 235);
            label13.Name = "label13";
            label13.Size = new Size(61, 68);
            label13.TabIndex = 25;
            label13.Text = "Nations:\r\nCities:\r\nAlliances:\r\nWars:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(11, 150);
            label12.Name = "label12";
            label12.Size = new Size(286, 39);
            label12.TabIndex = 24;
            label12.Text = "This will be used to convert dates \r\nto and from AoC's relative time format.\r\nChanging this setting requires reloading the scenario.";
            // 
            // CurrentYear
            // 
            CurrentYear.Location = new Point(290, 367);
            CurrentYear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            CurrentYear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CurrentYear.Name = "CurrentYear";
            CurrentYear.Size = new Size(85, 25);
            CurrentYear.TabIndex = 22;
            CurrentYear.Value = new decimal(new int[] { 1, 0, 0, 0 });
            CurrentYear.ValueChanged += DateChanged;
            // 
            // CurrentDay
            // 
            CurrentDay.Location = new Point(244, 367);
            CurrentDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            CurrentDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CurrentDay.Name = "CurrentDay";
            CurrentDay.Size = new Size(40, 25);
            CurrentDay.TabIndex = 21;
            CurrentDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            CurrentDay.ValueChanged += DateChanged;
            // 
            // CurrentMonth
            // 
            CurrentMonth.FormattingEnabled = true;
            CurrentMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            CurrentMonth.Location = new Point(118, 367);
            CurrentMonth.Name = "CurrentMonth";
            CurrentMonth.Size = new Size(120, 25);
            CurrentMonth.TabIndex = 20;
            CurrentMonth.SelectedIndexChanged += DateChanged;
            // 
            // StartingYear
            // 
            StartingYear.Location = new Point(290, 332);
            StartingYear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            StartingYear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            StartingYear.Name = "StartingYear";
            StartingYear.Size = new Size(85, 25);
            StartingYear.TabIndex = 19;
            StartingYear.Value = new decimal(new int[] { 1, 0, 0, 0 });
            StartingYear.ValueChanged += DateChanged;
            // 
            // StartingMonth
            // 
            StartingMonth.FormattingEnabled = true;
            StartingMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            StartingMonth.Location = new Point(118, 332);
            StartingMonth.Name = "StartingMonth";
            StartingMonth.Size = new Size(120, 25);
            StartingMonth.TabIndex = 17;
            StartingMonth.SelectedIndexChanged += DateChanged;
            // 
            // ScenarioSizeLabel
            // 
            ScenarioSizeLabel.AutoSize = true;
            ScenarioSizeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ScenarioSizeLabel.Location = new Point(115, 268);
            ScenarioSizeLabel.Name = "ScenarioSizeLabel";
            ScenarioSizeLabel.Size = new Size(66, 34);
            ScenarioSizeLabel.TabIndex = 16;
            ScenarioSizeLabel.Text = "Unknown\r\nUnknown";
            ScenarioSizeLabel.Visible = false;
            // 
            // GameVerLabel
            // 
            GameVerLabel.AutoSize = true;
            GameVerLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            GameVerLabel.Location = new Point(115, 235);
            GameVerLabel.Name = "GameVerLabel";
            GameVerLabel.Size = new Size(66, 17);
            GameVerLabel.TabIndex = 15;
            GameVerLabel.Text = "Unknown";
            GameVerLabel.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 235);
            label5.Name = "label5";
            label5.Size = new Size(91, 153);
            label5.TabIndex = 14;
            label5.Text = "Game version:\r\n\r\nWidth:\r\nHeight:\r\n\r\n\r\nStarting date:\r\n\r\nCurrent date:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(8, 210);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 13;
            label4.Text = "Scenario info";
            // 
            // LoadScenario
            // 
            LoadScenario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LoadScenario.ForeColor = Color.Black;
            LoadScenario.Location = new Point(244, 70);
            LoadScenario.Name = "LoadScenario";
            LoadScenario.Size = new Size(130, 30);
            LoadScenario.TabIndex = 10;
            LoadScenario.Text = "Load scenario";
            LoadScenario.UseVisualStyleBackColor = true;
            LoadScenario.Click += LoadScenario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 15);
            label3.Name = "label3";
            label3.Size = new Size(141, 17);
            label3.TabIndex = 12;
            label3.Text = "Select scenario to load";
            // 
            // ScenarioBrowse
            // 
            ScenarioBrowse.Location = new Point(418, 32);
            ScenarioBrowse.Name = "ScenarioBrowse";
            ScenarioBrowse.Size = new Size(88, 30);
            ScenarioBrowse.TabIndex = 11;
            ScenarioBrowse.Text = "Browse";
            ScenarioBrowse.UseVisualStyleBackColor = true;
            ScenarioBrowse.Click += ScenarioBrowse_Click;
            // 
            // ScenarioInput
            // 
            ScenarioInput.Location = new Point(11, 35);
            ScenarioInput.Name = "ScenarioInput";
            ScenarioInput.Size = new Size(401, 25);
            ScenarioInput.TabIndex = 10;
            ScenarioInput.TextChanged += ReloadRequired;
            // 
            // NationsTab
            // 
            NationsTab.Controls.Add(label30);
            NationsTab.Controls.Add(PasteNationNames);
            NationsTab.Controls.Add(label7);
            NationsTab.Controls.Add(CapitalSelect);
            NationsTab.Controls.Add(SetBonusToAll);
            NationsTab.Controls.Add(SetBonus);
            NationsTab.Controls.Add(label21);
            NationsTab.Controls.Add(SetFlagID);
            NationsTab.Controls.Add(FlagPreview);
            NationsTab.Controls.Add(SetCEToAll);
            NationsTab.Controls.Add(SetGoldToAll);
            NationsTab.Controls.Add(ceLock);
            NationsTab.Controls.Add(DisableAI);
            NationsTab.Controls.Add(SetEyear);
            NationsTab.Controls.Add(SetSyear);
            NationsTab.Controls.Add(SetCE);
            NationsTab.Controls.Add(SetGold);
            NationsTab.Controls.Add(label6);
            NationsTab.Controls.Add(NationPreview);
            NationsTab.Controls.Add(NationsTable);
            NationsTab.Location = new Point(4, 29);
            NationsTab.Name = "NationsTab";
            NationsTab.Padding = new Padding(3);
            NationsTab.Size = new Size(876, 407);
            NationsTab.TabIndex = 1;
            NationsTab.Text = "Nations";
            NationsTab.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label30.ForeColor = SystemColors.ControlDarkDark;
            label30.Location = new Point(656, 237);
            label30.Name = "label30";
            label30.Size = new Size(215, 13);
            label30.TabIndex = 37;
            label30.Text = "You can also select a country on the map";
            // 
            // PasteNationNames
            // 
            PasteNationNames.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PasteNationNames.Location = new Point(3, 379);
            PasteNationNames.Name = "PasteNationNames";
            PasteNationNames.Size = new Size(200, 25);
            PasteNationNames.TabIndex = 21;
            PasteNationNames.Text = "Paste names from clipboard";
            PasteNationNames.UseVisualStyleBackColor = true;
            PasteNationNames.Click += PasteNationNames_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(665, 275);
            label7.Name = "label7";
            label7.Size = new Size(106, 26);
            label7.TabIndex = 20;
            label7.Text = "Ctrl + click to apply\r\nto all nations";
            // 
            // CapitalSelect
            // 
            CapitalSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CapitalSelect.FormattingEnabled = true;
            CapitalSelect.Location = new Point(445, 240);
            CapitalSelect.Name = "CapitalSelect";
            CapitalSelect.Size = new Size(205, 25);
            CapitalSelect.TabIndex = 19;
            CapitalSelect.SelectedIndexChanged += NationDetailsModified;
            // 
            // SetBonusToAll
            // 
            SetBonusToAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetBonusToAll.Location = new Point(610, 341);
            SetBonusToAll.Name = "SetBonusToAll";
            SetBonusToAll.Size = new Size(90, 25);
            SetBonusToAll.TabIndex = 18;
            SetBonusToAll.Text = "Apply to all";
            SetBonusToAll.UseVisualStyleBackColor = true;
            SetBonusToAll.Click += SetToAll_Click;
            // 
            // SetBonus
            // 
            SetBonus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetBonus.Location = new Point(510, 341);
            SetBonus.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            SetBonus.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            SetBonus.Name = "SetBonus";
            SetBonus.Size = new Size(90, 25);
            SetBonus.TabIndex = 17;
            SetBonus.ThousandsSeparator = true;
            SetBonus.ValueChanged += NationDetailsModified;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Location = new Point(813, 257);
            label21.Name = "label21";
            label21.Size = new Size(48, 17);
            label21.TabIndex = 16;
            label21.Text = "Flag ID";
            // 
            // SetFlagID
            // 
            SetFlagID.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SetFlagID.Location = new Point(806, 277);
            SetFlagID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            SetFlagID.Name = "SetFlagID";
            SetFlagID.Size = new Size(64, 25);
            SetFlagID.TabIndex = 15;
            SetFlagID.TextAlign = HorizontalAlignment.Center;
            SetFlagID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            SetFlagID.ValueChanged += NationDetailsModified;
            // 
            // FlagPreview
            // 
            FlagPreview.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FlagPreview.BackColor = Color.FromArgb(224, 224, 224);
            FlagPreview.Location = new Point(729, 308);
            FlagPreview.Name = "FlagPreview";
            FlagPreview.Size = new Size(144, 96);
            FlagPreview.TabIndex = 14;
            FlagPreview.TabStop = false;
            FlagPreview.Click += FlagPreview_Click;
            // 
            // SetCEToAll
            // 
            SetCEToAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetCEToAll.Location = new Point(610, 374);
            SetCEToAll.Name = "SetCEToAll";
            SetCEToAll.Size = new Size(90, 25);
            SetCEToAll.TabIndex = 12;
            SetCEToAll.Text = "Apply to all";
            SetCEToAll.UseVisualStyleBackColor = true;
            SetCEToAll.Click += SetToAll_Click;
            // 
            // SetGoldToAll
            // 
            SetGoldToAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetGoldToAll.Location = new Point(610, 308);
            SetGoldToAll.Name = "SetGoldToAll";
            SetGoldToAll.Size = new Size(90, 25);
            SetGoldToAll.TabIndex = 11;
            SetGoldToAll.Text = "Apply to all";
            SetGoldToAll.UseVisualStyleBackColor = true;
            SetGoldToAll.Click += SetToAll_Click;
            // 
            // ceLock
            // 
            ceLock.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ceLock.AutoSize = true;
            ceLock.Location = new Point(734, 255);
            ceLock.Name = "ceLock";
            ceLock.Size = new Size(72, 21);
            ceLock.TabIndex = 9;
            ceLock.Text = "CE Lock";
            ceLock.UseVisualStyleBackColor = true;
            ceLock.CheckedChanged += NationDetailsModified;
            // 
            // DisableAI
            // 
            DisableAI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DisableAI.AutoSize = true;
            DisableAI.Location = new Point(668, 255);
            DisableAI.Name = "DisableAI";
            DisableAI.Size = new Size(60, 21);
            DisableAI.TabIndex = 8;
            DisableAI.Text = "No AI";
            DisableAI.UseVisualStyleBackColor = true;
            DisableAI.CheckedChanged += NationDetailsModified;
            // 
            // SetEyear
            // 
            SetEyear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetEyear.Location = new Point(560, 275);
            SetEyear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            SetEyear.Minimum = new decimal(new int[] { 20000, 0, 0, int.MinValue });
            SetEyear.Name = "SetEyear";
            SetEyear.Size = new Size(90, 25);
            SetEyear.TabIndex = 6;
            SetEyear.ValueChanged += NationDetailsModified;
            // 
            // SetSyear
            // 
            SetSyear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetSyear.Location = new Point(445, 275);
            SetSyear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            SetSyear.Minimum = new decimal(new int[] { 20000, 0, 0, int.MinValue });
            SetSyear.Name = "SetSyear";
            SetSyear.Size = new Size(90, 25);
            SetSyear.TabIndex = 5;
            SetSyear.ValueChanged += NationDetailsModified;
            // 
            // SetCE
            // 
            SetCE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetCE.DecimalPlaces = 1;
            SetCE.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            SetCE.Location = new Point(509, 374);
            SetCE.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            SetCE.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            SetCE.Name = "SetCE";
            SetCE.Size = new Size(90, 25);
            SetCE.TabIndex = 4;
            SetCE.Value = new decimal(new int[] { 1, 0, 0, 0 });
            SetCE.ValueChanged += NationDetailsModified;
            // 
            // SetGold
            // 
            SetGold.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetGold.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            SetGold.Location = new Point(510, 308);
            SetGold.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            SetGold.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            SetGold.Name = "SetGold";
            SetGold.Size = new Size(90, 25);
            SetGold.TabIndex = 3;
            SetGold.ThousandsSeparator = true;
            SetGold.ValueChanged += NationDetailsModified;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(385, 242);
            label6.Name = "label6";
            label6.Size = new Size(170, 153);
            label6.TabIndex = 2;
            label6.Text = "Capital:\r\n\r\nActive:                              -\r\n\r\nGold:\r\n\r\nEconomy Bonus:\r\n\r\nCombat Efficiency: ";
            // 
            // NationPreview
            // 
            NationPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NationPreview.BackColor = Color.Transparent;
            NationPreview.Location = new Point(384, 3);
            NationPreview.Name = "NationPreview";
            NationPreview.Size = new Size(489, 231);
            NationPreview.SizeMode = PictureBoxSizeMode.Zoom;
            NationPreview.TabIndex = 1;
            NationPreview.TabStop = false;
            NationPreview.MouseClick += NationPreview_MouseClick;
            NationPreview.MouseWheel += MapZoomChanged;
            // 
            // NationsTable
            // 
            NationsTable.AllowUserToAddRows = false;
            NationsTable.AllowUserToDeleteRows = false;
            NationsTable.AllowUserToResizeRows = false;
            NationsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            NationsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NationsTable.Columns.AddRange(new DataGridViewColumn[] { NationID, NationName, NationColor });
            NationsTable.Location = new Point(3, 3);
            NationsTable.MultiSelect = false;
            NationsTable.Name = "NationsTable";
            NationsTable.RowHeadersVisible = false;
            NationsTable.Size = new Size(375, 370);
            NationsTable.TabIndex = 0;
            NationsTable.CellContentClick += ChangeNationColor;
            NationsTable.CellEndEdit += NationNameModified;
            NationsTable.DataError += DataError;
            NationsTable.RowEnter += NationsTable_RowEnter;
            // 
            // NationID
            // 
            NationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NationID.FillWeight = 20F;
            NationID.HeaderText = "ID";
            NationID.MinimumWidth = 30;
            NationID.Name = "NationID";
            NationID.ReadOnly = true;
            // 
            // NationName
            // 
            NationName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NationName.HeaderText = "Name";
            NationName.MinimumWidth = 100;
            NationName.Name = "NationName";
            // 
            // NationColor
            // 
            NationColor.FillWeight = 50F;
            NationColor.HeaderText = "Color";
            NationColor.MinimumWidth = 80;
            NationColor.Name = "NationColor";
            NationColor.ReadOnly = true;
            NationColor.Resizable = DataGridViewTriState.False;
            NationColor.Width = 80;
            // 
            // CitiesTab
            // 
            CitiesTab.AllowDrop = true;
            CitiesTab.Controls.Add(ShowGrid);
            CitiesTab.Controls.Add(label29);
            CitiesTab.Controls.Add(label28);
            CitiesTab.Controls.Add(ImportCities);
            CitiesTab.Controls.Add(RemoveCore);
            CitiesTab.Controls.Add(PasteCityNames);
            CitiesTab.Controls.Add(label9);
            CitiesTab.Controls.Add(SetCoreToSelf);
            CitiesTab.Controls.Add(CityRevoltChance);
            CitiesTab.Controls.Add(CityRightfulOwner);
            CitiesTab.Controls.Add(label8);
            CitiesTab.Controls.Add(CityPreview);
            CitiesTab.Controls.Add(CitiesTable);
            CitiesTab.Location = new Point(4, 29);
            CitiesTab.Name = "CitiesTab";
            CitiesTab.Size = new Size(876, 407);
            CitiesTab.TabIndex = 2;
            CitiesTab.Text = "Cities";
            CitiesTab.UseVisualStyleBackColor = true;
            // 
            // ShowGrid
            // 
            ShowGrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ShowGrid.AutoSize = true;
            ShowGrid.Location = new Point(630, 240);
            ShowGrid.Name = "ShowGrid";
            ShowGrid.Size = new Size(86, 21);
            ShowGrid.TabIndex = 37;
            ShowGrid.Text = "Show grid";
            ShowGrid.UseVisualStyleBackColor = true;
            ShowGrid.CheckedChanged += ShowGrid_CheckedChanged;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label29.ForeColor = SystemColors.ControlDarkDark;
            label29.Location = new Point(627, 264);
            label29.Name = "label29";
            label29.Size = new Size(242, 39);
            label29.TabIndex = 36;
            label29.Text = "You can also select a city from the map above\r\nHolding Shift will bypass aim assist\r\nHolding Ctrl will instead move the current city";
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label28.AutoSize = true;
            label28.Location = new Point(390, 245);
            label28.Name = "label28";
            label28.Size = new Size(114, 17);
            label28.TabIndex = 15;
            label28.Text = "Revolt chance (%):";
            // 
            // ImportCities
            // 
            ImportCities.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ImportCities.Location = new Point(209, 379);
            ImportCities.Name = "ImportCities";
            ImportCities.Size = new Size(169, 25);
            ImportCities.TabIndex = 14;
            ImportCities.Text = "Import cities";
            ImportCities.UseVisualStyleBackColor = true;
            ImportCities.Click += ImportCities_Click;
            // 
            // RemoveCore
            // 
            RemoveCore.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveCore.Location = new Point(495, 325);
            RemoveCore.Name = "RemoveCore";
            RemoveCore.Size = new Size(100, 30);
            RemoveCore.TabIndex = 13;
            RemoveCore.Text = "Remove core";
            RemoveCore.UseVisualStyleBackColor = true;
            RemoveCore.Click += RemoveCore_Click;
            // 
            // PasteCityNames
            // 
            PasteCityNames.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PasteCityNames.Location = new Point(3, 379);
            PasteCityNames.Name = "PasteCityNames";
            PasteCityNames.Size = new Size(200, 25);
            PasteCityNames.TabIndex = 12;
            PasteCityNames.Text = "Paste names from clipboard";
            PasteCityNames.UseVisualStyleBackColor = true;
            PasteCityNames.Click += PasteCityNames_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(387, 358);
            label9.Name = "label9";
            label9.Size = new Size(234, 26);
            label9.TabIndex = 11;
            label9.Text = "Shift + click to apply to all cities in a country\r\nCtrl + click to apply to all cities on the map";
            // 
            // SetCoreToSelf
            // 
            SetCoreToSelf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetCoreToSelf.Location = new Point(390, 325);
            SetCoreToSelf.Name = "SetCoreToSelf";
            SetCoreToSelf.Size = new Size(100, 30);
            SetCoreToSelf.TabIndex = 7;
            SetCoreToSelf.Text = "Set as core";
            SetCoreToSelf.UseVisualStyleBackColor = true;
            SetCoreToSelf.Click += SetCoreToSelf_Click;
            // 
            // CityRevoltChance
            // 
            CityRevoltChance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CityRevoltChance.Location = new Point(520, 243);
            CityRevoltChance.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            CityRevoltChance.Name = "CityRevoltChance";
            CityRevoltChance.Size = new Size(60, 25);
            CityRevoltChance.TabIndex = 6;
            CityRevoltChance.ValueChanged += CityDetailsModified;
            // 
            // CityRightfulOwner
            // 
            CityRightfulOwner.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CityRightfulOwner.FormattingEnabled = true;
            CityRightfulOwner.Items.AddRange(new object[] { "No one" });
            CityRightfulOwner.Location = new Point(390, 295);
            CityRightfulOwner.Name = "CityRightfulOwner";
            CityRightfulOwner.Size = new Size(205, 25);
            CityRightfulOwner.TabIndex = 5;
            CityRightfulOwner.SelectedIndexChanged += CityDetailsModified;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(390, 275);
            label8.Name = "label8";
            label8.Size = new Size(95, 17);
            label8.TabIndex = 4;
            label8.Text = "Rightful owner:\r\n";
            // 
            // CityPreview
            // 
            CityPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CityPreview.Location = new Point(384, 3);
            CityPreview.Name = "CityPreview";
            CityPreview.Size = new Size(489, 231);
            CityPreview.SizeMode = PictureBoxSizeMode.Zoom;
            CityPreview.TabIndex = 3;
            CityPreview.TabStop = false;
            CityPreview.MouseClick += CityPreview_MouseClick;
            CityPreview.MouseWheel += MapZoomChanged;
            // 
            // CitiesTable
            // 
            CitiesTable.AllowDrop = true;
            CitiesTable.AllowUserToResizeRows = false;
            CitiesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CitiesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CitiesTable.Columns.AddRange(new DataGridViewColumn[] { cityX, cityY, CityName });
            CitiesTable.Location = new Point(3, 3);
            CitiesTable.MultiSelect = false;
            CitiesTable.Name = "CitiesTable";
            CitiesTable.RowHeadersWidth = 20;
            CitiesTable.Size = new Size(375, 370);
            CitiesTable.TabIndex = 2;
            CitiesTable.CellEndEdit += CityNameOrPosModified;
            CitiesTable.ColumnHeaderMouseClick += CitiesTable_Sorted;
            CitiesTable.DataError += DataError;
            CitiesTable.RowEnter += CitiesTable_RowEnter;
            CitiesTable.RowsRemoved += CitiesTable_RowsRemoved;
            // 
            // cityX
            // 
            cityX.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cityX.FillWeight = 20F;
            cityX.HeaderText = "X";
            cityX.MinimumWidth = 30;
            cityX.Name = "cityX";
            cityX.Resizable = DataGridViewTriState.True;
            // 
            // cityY
            // 
            cityY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cityY.FillWeight = 20F;
            cityY.HeaderText = "Y";
            cityY.MinimumWidth = 30;
            cityY.Name = "cityY";
            cityY.Resizable = DataGridViewTriState.True;
            // 
            // CityName
            // 
            CityName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CityName.HeaderText = "Name";
            CityName.MinimumWidth = 100;
            CityName.Name = "CityName";
            CityName.Resizable = DataGridViewTriState.True;
            // 
            // AlliancesTab
            // 
            AlliancesTab.Controls.Add(label27);
            AlliancesTab.Controls.Add(IsUnion);
            AlliancesTab.Controls.Add(AlliancePreview);
            AlliancesTab.Controls.Add(Unity);
            AlliancesTab.Controls.Add(label10);
            AlliancesTab.Controls.Add(AllianceNationSelect);
            AlliancesTab.Controls.Add(AlliancesTable);
            AlliancesTab.Location = new Point(4, 29);
            AlliancesTab.Name = "AlliancesTab";
            AlliancesTab.Size = new Size(876, 407);
            AlliancesTab.TabIndex = 3;
            AlliancesTab.Text = "Alliances";
            AlliancesTab.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label27.ForeColor = SystemColors.ControlDarkDark;
            label27.Location = new Point(689, 191);
            label27.Name = "label27";
            label27.Size = new Size(179, 26);
            label27.TabIndex = 35;
            label27.Text = "You can also select a country and \r\nthe alliance it's in from the map";
            // 
            // IsUnion
            // 
            IsUnion.AutoSize = true;
            IsUnion.Location = new Point(505, 187);
            IsUnion.Name = "IsUnion";
            IsUnion.Size = new Size(72, 21);
            IsUnion.TabIndex = 7;
            IsUnion.Text = "Is union";
            IsUnion.UseVisualStyleBackColor = true;
            IsUnion.CheckedChanged += AllianceDetailsModified;
            // 
            // AlliancePreview
            // 
            AlliancePreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AlliancePreview.Location = new Point(384, 220);
            AlliancePreview.Name = "AlliancePreview";
            AlliancePreview.Size = new Size(489, 184);
            AlliancePreview.SizeMode = PictureBoxSizeMode.Zoom;
            AlliancePreview.TabIndex = 6;
            AlliancePreview.TabStop = false;
            AlliancePreview.MouseClick += AlliancePreview_MouseClick;
            // 
            // Unity
            // 
            Unity.DecimalPlaces = 1;
            Unity.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Unity.Location = new Point(435, 185);
            Unity.Name = "Unity";
            Unity.Size = new Size(50, 25);
            Unity.TabIndex = 5;
            Unity.ValueChanged += AllianceDetailsModified;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(390, 188);
            label10.Name = "label10";
            label10.Size = new Size(40, 17);
            label10.TabIndex = 3;
            label10.Text = "Unity:";
            // 
            // AllianceNationSelect
            // 
            AllianceNationSelect.AllowUserToAddRows = false;
            AllianceNationSelect.AllowUserToDeleteRows = false;
            AllianceNationSelect.AllowUserToResizeColumns = false;
            AllianceNationSelect.AllowUserToResizeRows = false;
            AllianceNationSelect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AllianceNationSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllianceNationSelect.Columns.AddRange(new DataGridViewColumn[] { AllianceNationID, AllianceNations, AllianceSelect, AllianceLoyalty });
            AllianceNationSelect.Location = new Point(3, 3);
            AllianceNationSelect.MultiSelect = false;
            AllianceNationSelect.Name = "AllianceNationSelect";
            AllianceNationSelect.RowHeadersVisible = false;
            AllianceNationSelect.Size = new Size(375, 401);
            AllianceNationSelect.TabIndex = 2;
            AllianceNationSelect.CellEndEdit += AllianceModified;
            AllianceNationSelect.DataError += DataError;
            // 
            // AllianceNationID
            // 
            AllianceNationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllianceNationID.FillWeight = 20F;
            AllianceNationID.HeaderText = "ID";
            AllianceNationID.MinimumWidth = 30;
            AllianceNationID.Name = "AllianceNationID";
            AllianceNationID.ReadOnly = true;
            // 
            // AllianceNations
            // 
            AllianceNations.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllianceNations.FillWeight = 70F;
            AllianceNations.HeaderText = "Nation";
            AllianceNations.MinimumWidth = 50;
            AllianceNations.Name = "AllianceNations";
            AllianceNations.ReadOnly = true;
            AllianceNations.Resizable = DataGridViewTriState.True;
            // 
            // AllianceSelect
            // 
            AllianceSelect.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllianceSelect.HeaderText = "Alliance";
            AllianceSelect.MinimumWidth = 50;
            AllianceSelect.Name = "AllianceSelect";
            AllianceSelect.Resizable = DataGridViewTriState.True;
            AllianceSelect.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AllianceLoyalty
            // 
            AllianceLoyalty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllianceLoyalty.FillWeight = 50F;
            AllianceLoyalty.HeaderText = "Loyalty";
            AllianceLoyalty.Items.AddRange(new object[] { "High", "Medium", "Low" });
            AllianceLoyalty.MinimumWidth = 20;
            AllianceLoyalty.Name = "AllianceLoyalty";
            AllianceLoyalty.Resizable = DataGridViewTriState.True;
            // 
            // AlliancesTable
            // 
            AlliancesTable.AllowUserToResizeRows = false;
            AlliancesTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AlliancesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AlliancesTable.Columns.AddRange(new DataGridViewColumn[] { AllianceName, AllianceMembers, AllianceColor });
            AlliancesTable.Location = new Point(384, 3);
            AlliancesTable.MultiSelect = false;
            AlliancesTable.Name = "AlliancesTable";
            AlliancesTable.RowHeadersWidth = 20;
            AlliancesTable.Size = new Size(489, 175);
            AlliancesTable.TabIndex = 1;
            AlliancesTable.CellContentClick += ChangeAllianceColor;
            AlliancesTable.CellEndEdit += AllianceModified;
            AlliancesTable.DataError += DataError;
            AlliancesTable.RowEnter += AlliancesTable_RowEnter;
            AlliancesTable.RowsRemoved += AlliancesTable_RowsRemoved;
            // 
            // AllianceName
            // 
            AllianceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllianceName.HeaderText = "Name";
            AllianceName.MinimumWidth = 100;
            AllianceName.Name = "AllianceName";
            AllianceName.Resizable = DataGridViewTriState.True;
            AllianceName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AllianceMembers
            // 
            AllianceMembers.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllianceMembers.FillWeight = 200F;
            AllianceMembers.HeaderText = "Members";
            AllianceMembers.MinimumWidth = 100;
            AllianceMembers.Name = "AllianceMembers";
            AllianceMembers.ReadOnly = true;
            AllianceMembers.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AllianceColor
            // 
            AllianceColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllianceColor.FillWeight = 50F;
            AllianceColor.HeaderText = "Color";
            AllianceColor.MinimumWidth = 50;
            AllianceColor.Name = "AllianceColor";
            AllianceColor.Resizable = DataGridViewTriState.True;
            // 
            // PuppetsTab
            // 
            PuppetsTab.Controls.Add(PuppetLoyaltyDesc);
            PuppetsTab.Controls.Add(PuppetAutonomyDesc);
            PuppetsTab.Controls.Add(PuppetLoyalty);
            PuppetsTab.Controls.Add(PuppetAutonomy);
            PuppetsTab.Controls.Add(PuppetIntegration);
            PuppetsTab.Controls.Add(label25);
            PuppetsTab.Controls.Add(label24);
            PuppetsTab.Controls.Add(PuppetsOverview);
            PuppetsTab.Controls.Add(PuppetsTable);
            PuppetsTab.Location = new Point(4, 29);
            PuppetsTab.Name = "PuppetsTab";
            PuppetsTab.Size = new Size(876, 407);
            PuppetsTab.TabIndex = 6;
            PuppetsTab.Text = "Puppets";
            PuppetsTab.UseVisualStyleBackColor = true;
            // 
            // PuppetLoyaltyDesc
            // 
            PuppetLoyaltyDesc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetLoyaltyDesc.FormattingEnabled = true;
            PuppetLoyaltyDesc.Items.AddRange(new object[] { "Low", "Medium", "High" });
            PuppetLoyaltyDesc.Location = new Point(525, 365);
            PuppetLoyaltyDesc.Name = "PuppetLoyaltyDesc";
            PuppetLoyaltyDesc.Size = new Size(120, 25);
            PuppetLoyaltyDesc.TabIndex = 11;
            PuppetLoyaltyDesc.SelectedIndexChanged += PuppetDetailsModified;
            // 
            // PuppetAutonomyDesc
            // 
            PuppetAutonomyDesc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetAutonomyDesc.FormattingEnabled = true;
            PuppetAutonomyDesc.Items.AddRange(new object[] { "Vassal", "Puppet", "Satelite" });
            PuppetAutonomyDesc.Location = new Point(525, 330);
            PuppetAutonomyDesc.Name = "PuppetAutonomyDesc";
            PuppetAutonomyDesc.Size = new Size(120, 25);
            PuppetAutonomyDesc.TabIndex = 10;
            PuppetAutonomyDesc.SelectedIndexChanged += PuppetDetailsModified;
            // 
            // PuppetLoyalty
            // 
            PuppetLoyalty.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetLoyalty.Location = new Point(465, 365);
            PuppetLoyalty.Name = "PuppetLoyalty";
            PuppetLoyalty.Size = new Size(50, 25);
            PuppetLoyalty.TabIndex = 9;
            PuppetLoyalty.ValueChanged += PuppetDetailsModified;
            // 
            // PuppetAutonomy
            // 
            PuppetAutonomy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetAutonomy.Location = new Point(465, 330);
            PuppetAutonomy.Name = "PuppetAutonomy";
            PuppetAutonomy.Size = new Size(50, 25);
            PuppetAutonomy.TabIndex = 8;
            PuppetAutonomy.ValueChanged += PuppetDetailsModified;
            // 
            // PuppetIntegration
            // 
            PuppetIntegration.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetIntegration.Location = new Point(760, 330);
            PuppetIntegration.Name = "PuppetIntegration";
            PuppetIntegration.Size = new Size(50, 25);
            PuppetIntegration.TabIndex = 7;
            PuppetIntegration.ValueChanged += PuppetDetailsModified;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label25.AutoSize = true;
            label25.Location = new Point(390, 300);
            label25.Name = "label25";
            label25.Size = new Size(101, 102);
            label25.TabIndex = 6;
            label25.Text = "Puppet settings:\r\n\r\nAutonomy:\r\n\r\nLoyalty:\r\n\r\n";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label24.AutoSize = true;
            label24.Location = new Point(680, 300);
            label24.Name = "label24";
            label24.Size = new Size(101, 51);
            label24.TabIndex = 5;
            label24.Text = "Master settings:\r\n\r\nIntegration:";
            // 
            // PuppetsOverview
            // 
            PuppetsOverview.AllowUserToAddRows = false;
            PuppetsOverview.AllowUserToDeleteRows = false;
            PuppetsOverview.AllowUserToResizeRows = false;
            PuppetsOverview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PuppetsOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PuppetsOverview.Columns.AddRange(new DataGridViewColumn[] { PuppetMasterID, PuppetMastersList, PuppetsList });
            PuppetsOverview.Location = new Point(384, 3);
            PuppetsOverview.MultiSelect = false;
            PuppetsOverview.Name = "PuppetsOverview";
            PuppetsOverview.RowHeadersVisible = false;
            PuppetsOverview.Size = new Size(489, 290);
            PuppetsOverview.TabIndex = 4;
            PuppetsOverview.DataError += DataError;
            PuppetsOverview.RowEnter += PuppetsTable_RowEnter;
            // 
            // PuppetMasterID
            // 
            PuppetMasterID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PuppetMasterID.FillWeight = 5F;
            PuppetMasterID.HeaderText = "ID";
            PuppetMasterID.MinimumWidth = 30;
            PuppetMasterID.Name = "PuppetMasterID";
            PuppetMasterID.ReadOnly = true;
            // 
            // PuppetMastersList
            // 
            PuppetMastersList.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PuppetMastersList.FillWeight = 30F;
            PuppetMastersList.HeaderText = "Nation";
            PuppetMastersList.MinimumWidth = 100;
            PuppetMastersList.Name = "PuppetMastersList";
            PuppetMastersList.ReadOnly = true;
            // 
            // PuppetsList
            // 
            PuppetsList.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PuppetsList.HeaderText = "Puppets";
            PuppetsList.MinimumWidth = 200;
            PuppetsList.Name = "PuppetsList";
            PuppetsList.ReadOnly = true;
            PuppetsList.Resizable = DataGridViewTriState.True;
            // 
            // PuppetsTable
            // 
            PuppetsTable.AllowUserToAddRows = false;
            PuppetsTable.AllowUserToDeleteRows = false;
            PuppetsTable.AllowUserToResizeColumns = false;
            PuppetsTable.AllowUserToResizeRows = false;
            PuppetsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PuppetsTable.Columns.AddRange(new DataGridViewColumn[] { PuppetNationID, PuppetNationList, PuppetMasterSelect });
            PuppetsTable.Location = new Point(3, 3);
            PuppetsTable.MultiSelect = false;
            PuppetsTable.Name = "PuppetsTable";
            PuppetsTable.RowHeadersVisible = false;
            PuppetsTable.ShowRowErrors = false;
            PuppetsTable.Size = new Size(375, 401);
            PuppetsTable.TabIndex = 3;
            PuppetsTable.CellEndEdit += PuppetMasterModified;
            PuppetsTable.DataError += DataError;
            PuppetsTable.RowEnter += PuppetsTable_RowEnter;
            // 
            // PuppetNationID
            // 
            PuppetNationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PuppetNationID.FillWeight = 20F;
            PuppetNationID.HeaderText = "ID";
            PuppetNationID.MinimumWidth = 30;
            PuppetNationID.Name = "PuppetNationID";
            PuppetNationID.ReadOnly = true;
            // 
            // PuppetNationList
            // 
            PuppetNationList.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PuppetNationList.HeaderText = "Nation";
            PuppetNationList.MinimumWidth = 100;
            PuppetNationList.Name = "PuppetNationList";
            PuppetNationList.ReadOnly = true;
            PuppetNationList.Resizable = DataGridViewTriState.True;
            // 
            // PuppetMasterSelect
            // 
            PuppetMasterSelect.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PuppetMasterSelect.HeaderText = "Master";
            PuppetMasterSelect.MinimumWidth = 100;
            PuppetMasterSelect.Name = "PuppetMasterSelect";
            PuppetMasterSelect.Resizable = DataGridViewTriState.True;
            PuppetMasterSelect.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // WarsTab
            // 
            WarsTab.Controls.Add(label15);
            WarsTab.Controls.Add(ToDeath);
            WarsTab.Controls.Add(MergeWars);
            WarsTab.Controls.Add(WarEndYear);
            WarsTab.Controls.Add(WarEndDay);
            WarsTab.Controls.Add(WarEndMonth);
            WarsTab.Controls.Add(RemoveWar);
            WarsTab.Controls.Add(AddWar);
            WarsTab.Controls.Add(WarStartYear);
            WarsTab.Controls.Add(WarStartDay);
            WarsTab.Controls.Add(WarStartMonth);
            WarsTab.Controls.Add(label11);
            WarsTab.Controls.Add(WarNationSelect);
            WarsTab.Controls.Add(WarsTable);
            WarsTab.Location = new Point(4, 29);
            WarsTab.Name = "WarsTab";
            WarsTab.Size = new Size(876, 407);
            WarsTab.TabIndex = 4;
            WarsTab.Text = "Wars";
            WarsTab.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label15.ForeColor = SystemColors.ControlDarkDark;
            label15.Location = new Point(406, 300);
            label15.Name = "label15";
            label15.Size = new Size(108, 13);
            label15.TabIndex = 34;
            label15.Text = "* former participant";
            // 
            // ToDeath
            // 
            ToDeath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ToDeath.Location = new Point(391, 370);
            ToDeath.Name = "ToDeath";
            ToDeath.Size = new Size(75, 25);
            ToDeath.TabIndex = 33;
            ToDeath.Text = "To death";
            ToDeath.UseVisualStyleBackColor = true;
            ToDeath.Click += WarDetailsModified;
            // 
            // MergeWars
            // 
            MergeWars.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MergeWars.Location = new Point(216, 300);
            MergeWars.Name = "MergeWars";
            MergeWars.Size = new Size(120, 25);
            MergeWars.TabIndex = 32;
            MergeWars.Text = "Merge selected";
            MergeWars.UseVisualStyleBackColor = true;
            MergeWars.Click += MergeWars_Click;
            // 
            // WarEndYear
            // 
            WarEndYear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarEndYear.Location = new Point(300, 370);
            WarEndYear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            WarEndYear.Minimum = new decimal(new int[] { 20000, 0, 0, int.MinValue });
            WarEndYear.Name = "WarEndYear";
            WarEndYear.Size = new Size(85, 25);
            WarEndYear.TabIndex = 31;
            WarEndYear.ValueChanged += WarDetailsModified;
            // 
            // WarEndDay
            // 
            WarEndDay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarEndDay.Location = new Point(254, 370);
            WarEndDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            WarEndDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WarEndDay.Name = "WarEndDay";
            WarEndDay.Size = new Size(40, 25);
            WarEndDay.TabIndex = 30;
            WarEndDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            WarEndDay.ValueChanged += WarDetailsModified;
            // 
            // WarEndMonth
            // 
            WarEndMonth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarEndMonth.FormattingEnabled = true;
            WarEndMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            WarEndMonth.Location = new Point(128, 370);
            WarEndMonth.Name = "WarEndMonth";
            WarEndMonth.Size = new Size(120, 25);
            WarEndMonth.TabIndex = 29;
            WarEndMonth.SelectedIndexChanged += WarDetailsModified;
            // 
            // RemoveWar
            // 
            RemoveWar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveWar.Location = new Point(90, 300);
            RemoveWar.Name = "RemoveWar";
            RemoveWar.Size = new Size(120, 25);
            RemoveWar.TabIndex = 24;
            RemoveWar.Text = "Remove selected";
            RemoveWar.UseVisualStyleBackColor = true;
            RemoveWar.Click += RemoveWar_Click;
            // 
            // AddWar
            // 
            AddWar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddWar.Location = new Point(6, 300);
            AddWar.Name = "AddWar";
            AddWar.Size = new Size(80, 25);
            AddWar.TabIndex = 23;
            AddWar.Text = "Add new";
            AddWar.UseVisualStyleBackColor = true;
            AddWar.Click += AddWar_Click;
            // 
            // WarStartYear
            // 
            WarStartYear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarStartYear.Location = new Point(300, 336);
            WarStartYear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            WarStartYear.Minimum = new decimal(new int[] { 20000, 0, 0, int.MinValue });
            WarStartYear.Name = "WarStartYear";
            WarStartYear.Size = new Size(85, 25);
            WarStartYear.TabIndex = 22;
            WarStartYear.ValueChanged += WarDetailsModified;
            // 
            // WarStartDay
            // 
            WarStartDay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarStartDay.Location = new Point(254, 336);
            WarStartDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            WarStartDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WarStartDay.Name = "WarStartDay";
            WarStartDay.Size = new Size(40, 25);
            WarStartDay.TabIndex = 21;
            WarStartDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            WarStartDay.ValueChanged += WarDetailsModified;
            // 
            // WarStartMonth
            // 
            WarStartMonth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarStartMonth.FormattingEnabled = true;
            WarStartMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            WarStartMonth.Location = new Point(128, 336);
            WarStartMonth.Name = "WarStartMonth";
            WarStartMonth.Size = new Size(120, 25);
            WarStartMonth.TabIndex = 20;
            WarStartMonth.SelectedIndexChanged += WarDetailsModified;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(8, 341);
            label11.Name = "label11";
            label11.Size = new Size(104, 51);
            label11.TabIndex = 4;
            label11.Text = "Start date:\r\n\r\nTarget end date:";
            // 
            // WarNationSelect
            // 
            WarNationSelect.AllowUserToAddRows = false;
            WarNationSelect.AllowUserToDeleteRows = false;
            WarNationSelect.AllowUserToResizeRows = false;
            WarNationSelect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            WarNationSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WarNationSelect.Columns.AddRange(new DataGridViewColumn[] { WarNationID, Nation, Involvement });
            WarNationSelect.Location = new Point(520, 3);
            WarNationSelect.MultiSelect = false;
            WarNationSelect.Name = "WarNationSelect";
            WarNationSelect.RowHeadersVisible = false;
            WarNationSelect.Size = new Size(353, 401);
            WarNationSelect.TabIndex = 3;
            WarNationSelect.CellEndEdit += WarParticipantsModified;
            // 
            // WarNationID
            // 
            WarNationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WarNationID.FillWeight = 20F;
            WarNationID.HeaderText = "ID";
            WarNationID.MinimumWidth = 20;
            WarNationID.Name = "WarNationID";
            WarNationID.ReadOnly = true;
            // 
            // Nation
            // 
            Nation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nation.HeaderText = "Nation";
            Nation.MinimumWidth = 100;
            Nation.Name = "Nation";
            Nation.ReadOnly = true;
            // 
            // Involvement
            // 
            Involvement.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Involvement.FillWeight = 50F;
            Involvement.HeaderText = "Select stance";
            Involvement.Items.AddRange(new object[] { "Not involved", "Attacker", "Former attacker", "Defender", "Former defender" });
            Involvement.MinimumWidth = 50;
            Involvement.Name = "Involvement";
            Involvement.Resizable = DataGridViewTriState.True;
            Involvement.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // WarsTable
            // 
            WarsTable.AllowUserToAddRows = false;
            WarsTable.AllowUserToDeleteRows = false;
            WarsTable.AllowUserToResizeRows = false;
            WarsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WarsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WarsTable.Columns.AddRange(new DataGridViewColumn[] { Attackers, Defenders });
            WarsTable.Location = new Point(3, 3);
            WarsTable.Name = "WarsTable";
            WarsTable.RowHeadersWidth = 20;
            WarsTable.Size = new Size(511, 291);
            WarsTable.TabIndex = 2;
            WarsTable.RowEnter += WarsTable_RowEnter;
            // 
            // Attackers
            // 
            Attackers.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Attackers.HeaderText = "Attackers";
            Attackers.MinimumWidth = 200;
            Attackers.Name = "Attackers";
            Attackers.ReadOnly = true;
            Attackers.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Defenders
            // 
            Defenders.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Defenders.HeaderText = "Defenders";
            Defenders.MinimumWidth = 200;
            Defenders.Name = "Defenders";
            Defenders.ReadOnly = true;
            Defenders.Resizable = DataGridViewTriState.True;
            Defenders.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // InfoTab
            // 
            InfoTab.Controls.Add(groupBox2);
            InfoTab.Controls.Add(groupBox1);
            InfoTab.Location = new Point(4, 29);
            InfoTab.Name = "InfoTab";
            InfoTab.Size = new Size(876, 407);
            InfoTab.TabIndex = 5;
            InfoTab.Text = "Help & Info";
            InfoTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Location = new Point(3, 279);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(870, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "About";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(270, 45);
            label19.Name = "label19";
            label19.Size = new Size(445, 34);
            label19.TabIndex = 3;
            label19.Text = "JokuPelle for creating a wonderful space in and around this game\r\nThe AoC community for supporting me and my silly projects over the years\r\n";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(270, 20);
            label18.Name = "label18";
            label18.Size = new Size(109, 17);
            label18.TabIndex = 2;
            label18.Text = "Special thanks to:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label17.Location = new Point(100, 25);
            label17.Name = "label17";
            label17.Size = new Size(37, 17);
            label17.TabIndex = 1;
            label17.Text = "0.2.5";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 25);
            label16.Name = "label16";
            label16.Size = new Size(205, 51);
            label16.TabIndex = 0;
            label16.Text = "App verison: \r\n\r\nLead developer:   Corrupted Matt\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(FlagEditorLink);
            groupBox1.Controls.Add(ConverterLink);
            groupBox1.Controls.Add(DiscordLink);
            groupBox1.Controls.Add(ReadmeLink);
            groupBox1.Controls.Add(label20);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(870, 270);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Help and Resources";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label22.ForeColor = SystemColors.ControlDarkDark;
            label22.Location = new Point(6, 205);
            label22.Name = "label22";
            label22.Size = new Size(246, 26);
            label22.TabIndex = 25;
            label22.Text = "note: generated scenarios need to be opened \r\nand saved in game to ensure compatibility";
            // 
            // FlagEditorLink
            // 
            FlagEditorLink.AutoSize = true;
            FlagEditorLink.Location = new Point(210, 183);
            FlagEditorLink.Name = "FlagEditorLink";
            FlagEditorLink.Size = new Size(48, 17);
            FlagEditorLink.TabIndex = 4;
            FlagEditorLink.TabStop = true;
            FlagEditorLink.Text = "GitHub";
            FlagEditorLink.LinkClicked += FlagEditorLink_LinkClicked;
            // 
            // ConverterLink
            // 
            ConverterLink.AutoSize = true;
            ConverterLink.Location = new Point(210, 149);
            ConverterLink.Name = "ConverterLink";
            ConverterLink.Size = new Size(48, 17);
            ConverterLink.TabIndex = 3;
            ConverterLink.TabStop = true;
            ConverterLink.Text = "GitHub";
            ConverterLink.LinkClicked += ConverterLink_LinkClicked;
            // 
            // DiscordLink
            // 
            DiscordLink.AutoSize = true;
            DiscordLink.Location = new Point(435, 80);
            DiscordLink.Name = "DiscordLink";
            DiscordLink.Size = new Size(53, 17);
            DiscordLink.TabIndex = 2;
            DiscordLink.TabStop = true;
            DiscordLink.Text = "Discord";
            DiscordLink.LinkClicked += DiscordLink_LinkClicked;
            // 
            // ReadmeLink
            // 
            ReadmeLink.AutoSize = true;
            ReadmeLink.Location = new Point(240, 30);
            ReadmeLink.Name = "ReadmeLink";
            ReadmeLink.Size = new Size(48, 17);
            ReadmeLink.TabIndex = 1;
            ReadmeLink.TabStop = true;
            ReadmeLink.Text = "GitHub";
            ReadmeLink.LinkClicked += ReadmeLink_LinkClicked;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 30);
            label20.Name = "label20";
            label20.Size = new Size(421, 170);
            label20.TabIndex = 0;
            label20.Text = resources.GetString("label20.Text");
            // 
            // DestinationInput
            // 
            DestinationInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DestinationInput.Location = new Point(12, 469);
            DestinationInput.Name = "DestinationInput";
            DestinationInput.Size = new Size(401, 25);
            DestinationInput.TabIndex = 1;
            // 
            // NameSelection
            // 
            NameSelection.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NameSelection.Location = new Point(524, 469);
            NameSelection.Name = "NameSelection";
            NameSelection.Size = new Size(348, 25);
            NameSelection.TabIndex = 2;
            // 
            // DestinationBrowse
            // 
            DestinationBrowse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DestinationBrowse.Location = new Point(419, 466);
            DestinationBrowse.Name = "DestinationBrowse";
            DestinationBrowse.Size = new Size(88, 30);
            DestinationBrowse.TabIndex = 5;
            DestinationBrowse.Text = "Browse";
            DestinationBrowse.UseVisualStyleBackColor = true;
            DestinationBrowse.Click += DestinationBrowse_Click;
            // 
            // RunGameButton
            // 
            RunGameButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RunGameButton.Location = new Point(667, 500);
            RunGameButton.Name = "RunGameButton";
            RunGameButton.Size = new Size(100, 50);
            RunGameButton.TabIndex = 6;
            RunGameButton.Text = "Run AoC \r\nvia Steam";
            RunGameButton.UseVisualStyleBackColor = true;
            RunGameButton.Click += RunGameButton_Click;
            // 
            // GenerateButton
            // 
            GenerateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GenerateButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            GenerateButton.Location = new Point(773, 500);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(100, 50);
            GenerateButton.TabIndex = 7;
            GenerateButton.Text = "Export \nscenario";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(9, 449);
            label1.Name = "label1";
            label1.Size = new Size(152, 68);
            label1.TabIndex = 8;
            label1.Text = "Select output destination\r\n\r\n\r\nExport as:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(521, 449);
            label2.Name = "label2";
            label2.Size = new Size(126, 17);
            label2.TabIndex = 9;
            label2.Text = "New scenario name:";
            // 
            // ColorPicker
            // 
            ColorPicker.AnyColor = true;
            ColorPicker.FullOpen = true;
            // 
            // ExportAsScenario
            // 
            ExportAsScenario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExportAsScenario.AutoSize = true;
            ExportAsScenario.Checked = true;
            ExportAsScenario.Location = new Point(85, 500);
            ExportAsScenario.Name = "ExportAsScenario";
            ExportAsScenario.Size = new Size(76, 21);
            ExportAsScenario.TabIndex = 10;
            ExportAsScenario.TabStop = true;
            ExportAsScenario.Text = "Scenario";
            ExportAsScenario.UseVisualStyleBackColor = true;
            ExportAsScenario.CheckedChanged += ExportTypeChanged;
            // 
            // ExportAsSave
            // 
            ExportAsSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExportAsSave.AutoSize = true;
            ExportAsSave.Location = new Point(172, 500);
            ExportAsSave.Name = "ExportAsSave";
            ExportAsSave.Size = new Size(53, 21);
            ExportAsSave.TabIndex = 11;
            ExportAsSave.Text = "Save";
            ExportAsSave.UseVisualStyleBackColor = true;
            ExportAsSave.CheckedChanged += ExportTypeChanged;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label26.ForeColor = SystemColors.ControlDarkDark;
            label26.Location = new Point(10, 524);
            label26.Name = "label26";
            label26.Size = new Size(201, 26);
            label26.TabIndex = 37;
            label26.Text = "Shift + click to set destination \r\nto the appropriate game folder folder";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(label26);
            Controls.Add(ExportAsSave);
            Controls.Add(ExportAsScenario);
            Controls.Add(DestinationInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GenerateButton);
            Controls.Add(RunGameButton);
            Controls.Add(DestinationBrowse);
            Controls.Add(NameSelection);
            Controls.Add(TabSelect);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(900, 600);
            Name = "App";
            Text = "Advanced Scenario Editor";
            Load += Form1_Load;
            TabSelect.ResumeLayout(false);
            LoadTab.ResumeLayout(false);
            LoadTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StartingDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)HomePreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)CurrentYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)CurrentDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartingYear).EndInit();
            NationsTab.ResumeLayout(false);
            NationsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SetBonus).EndInit();
            ((System.ComponentModel.ISupportInitialize)SetFlagID).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlagPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)SetEyear).EndInit();
            ((System.ComponentModel.ISupportInitialize)SetSyear).EndInit();
            ((System.ComponentModel.ISupportInitialize)SetCE).EndInit();
            ((System.ComponentModel.ISupportInitialize)SetGold).EndInit();
            ((System.ComponentModel.ISupportInitialize)NationPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)NationsTable).EndInit();
            CitiesTab.ResumeLayout(false);
            CitiesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CityRevoltChance).EndInit();
            ((System.ComponentModel.ISupportInitialize)CityPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)CitiesTable).EndInit();
            AlliancesTab.ResumeLayout(false);
            AlliancesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AlliancePreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)Unity).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllianceNationSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlliancesTable).EndInit();
            PuppetsTab.ResumeLayout(false);
            PuppetsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PuppetLoyalty).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuppetAutonomy).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuppetIntegration).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsOverview).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsTable).EndInit();
            WarsTab.ResumeLayout(false);
            WarsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WarEndYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarEndDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarStartYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarStartDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarNationSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarsTable).EndInit();
            InfoTab.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private Button ImportCities;
        private Label label28;
        private Label label27;
        private Label label29;
        private Label label30;
        private CheckBox ShowGrid;
    }
}

