using System.Drawing;
using System.Windows.Forms;

namespace AoC_Advanced_Scenario_Editor
{
    partial class V5UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer? components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components is not null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V5UI));
            Theme = new Krypton.Toolkit.KryptonManager(components);
            TabSelect = new Krypton.Navigator.KryptonNavigator();
            ThemeSwitch = new Krypton.Navigator.KryptonPage();
            kryptonLabel19 = new Krypton.Toolkit.KryptonLabel();
            LoadTab = new Krypton.Navigator.KryptonPage();
            CurrentDay = new Krypton.Toolkit.KryptonNumericUpDown();
            StartingDay = new Krypton.Toolkit.KryptonNumericUpDown();
            CurrentYear = new Krypton.Toolkit.KryptonNumericUpDown();
            StartingYear = new Krypton.Toolkit.KryptonNumericUpDown();
            ShowCities = new Krypton.Toolkit.KryptonCheckBox();
            CurrentMonth = new Krypton.Toolkit.KryptonComboBox();
            DayScale = new Krypton.Toolkit.KryptonRadioButton();
            MainMapSelect = new Krypton.Toolkit.KryptonComboBox();
            MonthScale = new Krypton.Toolkit.KryptonRadioButton();
            StartingMonth = new Krypton.Toolkit.KryptonComboBox();
            HomePreview = new Krypton.Toolkit.KryptonPictureBox();
            ExportImgInfo = new Krypton.Toolkit.KryptonLabel();
            ScenarioInput = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            ExportImage = new Krypton.Toolkit.KryptonButton();
            ScenarioBrowse = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            LoadScenario = new Krypton.Toolkit.KryptonButton();
            ScenarioStatsLabel = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            ScenarioSizeLabel = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            GameVerLabel = new Krypton.Toolkit.KryptonLabel();
            NationsTab = new Krypton.Navigator.KryptonPage();
            SetFlagID = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            ceLock = new Krypton.Toolkit.KryptonCheckBox();
            CapitalSelect = new Krypton.Toolkit.KryptonComboBox();
            DisableAI = new Krypton.Toolkit.KryptonCheckBox();
            SetEyear = new Krypton.Toolkit.KryptonNumericUpDown();
            SetSyear = new Krypton.Toolkit.KryptonNumericUpDown();
            SetGold = new Krypton.Toolkit.KryptonNumericUpDown();
            SetCE = new Krypton.Toolkit.KryptonNumericUpDown();
            SetBonus = new Krypton.Toolkit.KryptonNumericUpDown();
            SetBonusToAll = new Krypton.Toolkit.KryptonButton();
            SetCEToAll = new Krypton.Toolkit.KryptonButton();
            SetGoldToAll = new Krypton.Toolkit.KryptonButton();
            FlagPreview = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            NationPreview = new Krypton.Toolkit.KryptonPictureBox();
            NationsTable = new Krypton.Toolkit.KryptonDataGridView();
            NationID = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            NationName = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            NationColor = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            PasteNationNames = new Krypton.Toolkit.KryptonButton();
            CitiesTab = new Krypton.Navigator.KryptonPage();
            kryptonLabel18 = new Krypton.Toolkit.KryptonLabel();
            RemoveCore = new Krypton.Toolkit.KryptonButton();
            CityRevoltChance = new Krypton.Toolkit.KryptonNumericUpDown();
            ShowGrid = new Krypton.Toolkit.KryptonCheckBox();
            CityRightfulOwner = new Krypton.Toolkit.KryptonComboBox();
            SetCoreToSelf = new Krypton.Toolkit.KryptonButton();
            kryptonLabel17 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel16 = new Krypton.Toolkit.KryptonLabel();
            ImportCities = new Krypton.Toolkit.KryptonButton();
            PasteCityNames = new Krypton.Toolkit.KryptonButton();
            CitiesTable = new Krypton.Toolkit.KryptonDataGridView();
            cityX = new Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            cityY = new Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            CityName = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            CityPreview = new Krypton.Toolkit.KryptonPictureBox();
            AlliancesTab = new Krypton.Navigator.KryptonPage();
            AlliancePreview = new Krypton.Toolkit.KryptonPictureBox();
            Unity = new Krypton.Toolkit.KryptonNumericUpDown();
            IsUnion = new Krypton.Toolkit.KryptonCheckBox();
            kryptonLabel20 = new Krypton.Toolkit.KryptonLabel();
            AlliancesTable = new Krypton.Toolkit.KryptonDataGridView();
            AllianceName = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            AllianceMembers = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            AllianceColor = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            AllianceNationSelect = new Krypton.Toolkit.KryptonDataGridView();
            AllianceNationID = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            AllianceNations = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            AllianceSelect = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            AllianceLoyalty = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            kryptonLabel21 = new Krypton.Toolkit.KryptonLabel();
            PuppetsTab = new Krypton.Navigator.KryptonPage();
            PuppetLoyaltyDesc = new Krypton.Toolkit.KryptonComboBox();
            PuppetAutonomyDesc = new Krypton.Toolkit.KryptonComboBox();
            PuppetIntegration = new Krypton.Toolkit.KryptonNumericUpDown();
            PuppetLoyalty = new Krypton.Toolkit.KryptonNumericUpDown();
            PuppetAutonomy = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonLabel23 = new Krypton.Toolkit.KryptonLabel();
            PuppetsOverview = new Krypton.Toolkit.KryptonDataGridView();
            PuppetMasterID = new DataGridViewTextBoxColumn();
            PuppetMastersList = new DataGridViewTextBoxColumn();
            PuppetsList = new DataGridViewTextBoxColumn();
            kryptonLabel22 = new Krypton.Toolkit.KryptonLabel();
            PuppetsTable = new Krypton.Toolkit.KryptonDataGridView();
            PuppetNationID = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            PuppetNationList = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            PuppetMasterSelect = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            WarsTab = new Krypton.Navigator.KryptonPage();
            kryptonLabel25 = new Krypton.Toolkit.KryptonLabel();
            WarNationSelect = new Krypton.Toolkit.KryptonDataGridView();
            WarNationID = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            Nation = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            Involvement = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            WarsTable = new Krypton.Toolkit.KryptonDataGridView();
            Attackers = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            Defenders = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            MergeWars = new Krypton.Toolkit.KryptonButton();
            RemoveWar = new Krypton.Toolkit.KryptonButton();
            AddWar = new Krypton.Toolkit.KryptonButton();
            ToDeath = new Krypton.Toolkit.KryptonButton();
            WarEndDay = new Krypton.Toolkit.KryptonNumericUpDown();
            WarStartDay = new Krypton.Toolkit.KryptonNumericUpDown();
            WarEndYear = new Krypton.Toolkit.KryptonNumericUpDown();
            WarStartYear = new Krypton.Toolkit.KryptonNumericUpDown();
            WarEndMonth = new Krypton.Toolkit.KryptonComboBox();
            WarStartMonth = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel24 = new Krypton.Toolkit.KryptonLabel();
            InfoTab = new Krypton.Navigator.KryptonPage();
            AboutGroupBox = new Krypton.Toolkit.KryptonGroupBox();
            HelpGroupBox = new Krypton.Toolkit.KryptonGroupBox();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            RunGameButton = new Krypton.Toolkit.KryptonButton();
            GenerateButton = new Krypton.Toolkit.KryptonButton();
            DestinationBrowse = new Krypton.Toolkit.KryptonButton();
            DestinationInput = new Krypton.Toolkit.KryptonTextBox();
            NameSelection = new Krypton.Toolkit.KryptonTextBox();
            ExportAsScenario = new Krypton.Toolkit.KryptonRadioButton();
            ExportAsSave = new Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)TabSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThemeSwitch).BeginInit();
            ThemeSwitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoadTab).BeginInit();
            LoadTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CurrentMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainMapSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartingMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HomePreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NationsTab).BeginInit();
            NationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CapitalSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlagPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NationPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NationsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CitiesTab).BeginInit();
            CitiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CityRightfulOwner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CitiesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CityPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlliancesTab).BeginInit();
            AlliancesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AlliancePreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlliancesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllianceNationSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsTab).BeginInit();
            PuppetsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PuppetLoyaltyDesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuppetAutonomyDesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsOverview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarsTab).BeginInit();
            WarsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WarNationSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarEndMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarStartMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoTab).BeginInit();
            InfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AboutGroupBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AboutGroupBox.Panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HelpGroupBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HelpGroupBox.Panel).BeginInit();
            SuspendLayout();
            // 
            // Theme
            // 
            Theme.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            Theme.ToolkitStrings.MessageBoxStrings.LessDetails = "L&ess Details...";
            Theme.ToolkitStrings.MessageBoxStrings.MoreDetails = "&More Details...";
            // 
            // TabSelect
            // 
            TabSelect.AllowPageReorder = false;
            TabSelect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabSelect.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.None;
            TabSelect.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.None;
            TabSelect.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide;
            TabSelect.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage;
            TabSelect.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            TabSelect.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small;
            TabSelect.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle;
            TabSelect.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            TabSelect.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            TabSelect.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            TabSelect.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            TabSelect.ControlKryptonFormFeatures = false;
            TabSelect.Location = new Point(0, 0);
            TabSelect.NavigatorMode = Krypton.Navigator.NavigatorMode.BarCheckButtonGroupOutside;
            TabSelect.Owner = null;
            TabSelect.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            TabSelect.Pages.AddRange(new Krypton.Navigator.KryptonPage[] { ThemeSwitch, LoadTab, NationsTab, CitiesTab, AlliancesTab, PuppetsTab, WarsTab, InfoTab });
            TabSelect.SelectedIndex = 7;
            TabSelect.Size = new Size(884, 440);
            TabSelect.StateSelected.CheckButton.Back.Color1 = Color.FromArgb(192, 64, 0);
            TabSelect.StateSelected.CheckButton.Back.Color2 = Color.DimGray;
            TabSelect.TabIndex = 0;
            TabSelect.Text = "kryptonNavigator1";
            TabSelect.Selected += ThemeChange;
            // 
            // ThemeSwitch
            // 
            ThemeSwitch.AutoHiddenSlideSize = new Size(200, 200);
            ThemeSwitch.Controls.Add(kryptonLabel19);
            ThemeSwitch.Flags = 65534;
            ThemeSwitch.LastVisibleSet = true;
            ThemeSwitch.MinimumSize = new Size(150, 50);
            ThemeSwitch.Name = "ThemeSwitch";
            ThemeSwitch.Size = new Size(882, 413);
            ThemeSwitch.Text = "☼";
            ThemeSwitch.ToolTipTitle = "Page ToolTip";
            ThemeSwitch.UniqueName = "9431ccd091bc4fe18e0a9427caeb0b93";
            // 
            // kryptonLabel19
            // 
            kryptonLabel19.Location = new Point(11, 8);
            kryptonLabel19.Name = "kryptonLabel19";
            kryptonLabel19.Size = new Size(336, 20);
            kryptonLabel19.TabIndex = 31;
            kryptonLabel19.Values.Text = "Well, this is awkward... you're not supposed to see this page";
            // 
            // LoadTab
            // 
            LoadTab.AutoHiddenSlideSize = new Size(200, 200);
            LoadTab.Controls.Add(CurrentDay);
            LoadTab.Controls.Add(StartingDay);
            LoadTab.Controls.Add(CurrentYear);
            LoadTab.Controls.Add(StartingYear);
            LoadTab.Controls.Add(ShowCities);
            LoadTab.Controls.Add(CurrentMonth);
            LoadTab.Controls.Add(DayScale);
            LoadTab.Controls.Add(MainMapSelect);
            LoadTab.Controls.Add(MonthScale);
            LoadTab.Controls.Add(StartingMonth);
            LoadTab.Controls.Add(HomePreview);
            LoadTab.Controls.Add(ExportImgInfo);
            LoadTab.Controls.Add(ScenarioInput);
            LoadTab.Controls.Add(kryptonLabel11);
            LoadTab.Controls.Add(ExportImage);
            LoadTab.Controls.Add(ScenarioBrowse);
            LoadTab.Controls.Add(kryptonLabel1);
            LoadTab.Controls.Add(kryptonLabel2);
            LoadTab.Controls.Add(LoadScenario);
            LoadTab.Controls.Add(ScenarioStatsLabel);
            LoadTab.Controls.Add(kryptonLabel3);
            LoadTab.Controls.Add(kryptonLabel8);
            LoadTab.Controls.Add(kryptonLabel4);
            LoadTab.Controls.Add(ScenarioSizeLabel);
            LoadTab.Controls.Add(kryptonLabel5);
            LoadTab.Controls.Add(GameVerLabel);
            LoadTab.Flags = 65534;
            LoadTab.LastVisibleSet = true;
            LoadTab.MinimumSize = new Size(150, 50);
            LoadTab.Name = "LoadTab";
            LoadTab.Size = new Size(882, 413);
            LoadTab.Text = "Load";
            LoadTab.ToolTipTitle = "Page ToolTip";
            LoadTab.UniqueName = "5997bf6e92bb4f548a362e99cc30895f";
            // 
            // CurrentDay
            // 
            CurrentDay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CurrentDay.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            CurrentDay.Location = new Point(215, 377);
            CurrentDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            CurrentDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CurrentDay.Name = "CurrentDay";
            CurrentDay.Size = new Size(47, 22);
            CurrentDay.TabIndex = 35;
            CurrentDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // StartingDay
            // 
            StartingDay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StartingDay.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            StartingDay.Location = new Point(215, 349);
            StartingDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            StartingDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            StartingDay.Name = "StartingDay";
            StartingDay.Size = new Size(47, 22);
            StartingDay.TabIndex = 36;
            StartingDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CurrentYear
            // 
            CurrentYear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CurrentYear.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            CurrentYear.Location = new Point(268, 377);
            CurrentYear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            CurrentYear.Minimum = new decimal(new int[] { 20000, 0, 0, int.MinValue });
            CurrentYear.Name = "CurrentYear";
            CurrentYear.Size = new Size(80, 22);
            CurrentYear.TabIndex = 33;
            CurrentYear.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // StartingYear
            // 
            StartingYear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StartingYear.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            StartingYear.Location = new Point(268, 349);
            StartingYear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            StartingYear.Minimum = new decimal(new int[] { 20000, 0, 0, int.MinValue });
            StartingYear.Name = "StartingYear";
            StartingYear.Size = new Size(80, 22);
            StartingYear.TabIndex = 34;
            StartingYear.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // ShowCities
            // 
            ShowCities.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowCities.AutoSize = false;
            ShowCities.Location = new Point(630, 37);
            ShowCities.Name = "ShowCities";
            ShowCities.Size = new Size(53, 20);
            ShowCities.TabIndex = 26;
            ShowCities.Values.Text = "Cities";
            // 
            // CurrentMonth
            // 
            CurrentMonth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CurrentMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            CurrentMonth.Location = new Point(90, 377);
            CurrentMonth.Name = "CurrentMonth";
            CurrentMonth.Size = new Size(120, 22);
            CurrentMonth.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            CurrentMonth.TabIndex = 28;
            // 
            // DayScale
            // 
            DayScale.Location = new Point(201, 65);
            DayScale.Name = "DayScale";
            DayScale.Size = new Size(58, 20);
            DayScale.TabIndex = 27;
            DayScale.Values.Text = "Weeks";
            // 
            // MainMapSelect
            // 
            MainMapSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MainMapSelect.Items.AddRange(new object[] { "Terrain", "De Facto", "De Jure" });
            MainMapSelect.Location = new Point(669, 8);
            MainMapSelect.Name = "MainMapSelect";
            MainMapSelect.Size = new Size(100, 22);
            MainMapSelect.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            MainMapSelect.TabIndex = 27;
            MainMapSelect.Text = "Terrain";
            // 
            // MonthScale
            // 
            MonthScale.Checked = true;
            MonthScale.Location = new Point(131, 65);
            MonthScale.Name = "MonthScale";
            MonthScale.Size = new Size(64, 20);
            MonthScale.TabIndex = 26;
            MonthScale.Values.Text = "Months";
            // 
            // StartingMonth
            // 
            StartingMonth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StartingMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            StartingMonth.Location = new Point(90, 349);
            StartingMonth.Name = "StartingMonth";
            StartingMonth.Size = new Size(120, 22);
            StartingMonth.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            StartingMonth.TabIndex = 25;
            // 
            // HomePreview
            // 
            HomePreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HomePreview.Location = new Point(354, 79);
            HomePreview.Name = "HomePreview";
            HomePreview.Size = new Size(525, 329);
            HomePreview.TabIndex = 23;
            HomePreview.TabStop = false;
            // 
            // ExportImgInfo
            // 
            ExportImgInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExportImgInfo.AutoSize = false;
            ExportImgInfo.Location = new Point(685, 35);
            ExportImgInfo.Name = "ExportImgInfo";
            ExportImgInfo.Size = new Size(184, 36);
            ExportImgInfo.StateCommon.ShortText.Color1 = Color.Gray;
            ExportImgInfo.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            ExportImgInfo.TabIndex = 12;
            ExportImgInfo.Values.Text = "Will export without cities.\r\nCheck to export cities separately.";
            // 
            // ScenarioInput
            // 
            ScenarioInput.Location = new Point(8, 34);
            ScenarioInput.Name = "ScenarioInput";
            ScenarioInput.Size = new Size(400, 23);
            ScenarioInput.TabIndex = 19;
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonLabel11.AutoSize = false;
            kryptonLabel11.Location = new Point(625, 10);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(39, 20);
            kryptonLabel11.TabIndex = 13;
            kryptonLabel11.Values.Text = "View:";
            // 
            // ExportImage
            // 
            ExportImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExportImage.Location = new Point(775, 8);
            ExportImage.Name = "ExportImage";
            ExportImage.Size = new Size(100, 22);
            ExportImage.TabIndex = 15;
            ExportImage.Values.DropDownArrowColor = Color.Empty;
            ExportImage.Values.Text = "Export image";
            // 
            // ScenarioBrowse
            // 
            ScenarioBrowse.Location = new Point(414, 34);
            ScenarioBrowse.Name = "ScenarioBrowse";
            ScenarioBrowse.Size = new Size(80, 23);
            ScenarioBrowse.TabIndex = 16;
            ScenarioBrowse.Values.DropDownArrowColor = Color.Empty;
            ScenarioBrowse.Values.Text = "Browse";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            kryptonLabel1.Location = new Point(8, 10);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(111, 20);
            kryptonLabel1.TabIndex = 2;
            kryptonLabel1.Values.Text = "Select file to load\r\n";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(8, 65);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(117, 20);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "Intended timescale:";
            // 
            // LoadScenario
            // 
            LoadScenario.Location = new Point(11, 140);
            LoadScenario.Name = "LoadScenario";
            LoadScenario.Size = new Size(126, 30);
            LoadScenario.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LoadScenario.TabIndex = 12;
            LoadScenario.Values.DropDownArrowColor = Color.Empty;
            LoadScenario.Values.Text = "Load";
            // 
            // ScenarioStatsLabel
            // 
            ScenarioStatsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ScenarioStatsLabel.AutoSize = false;
            ScenarioStatsLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            ScenarioStatsLabel.Location = new Point(282, 259);
            ScenarioStatsLabel.Name = "ScenarioStatsLabel";
            ScenarioStatsLabel.Size = new Size(66, 68);
            ScenarioStatsLabel.TabIndex = 11;
            ScenarioStatsLabel.Values.Text = "Unknown\r\nUnknown\r\nUnknown\r\nUnknown";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(8, 85);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(270, 48);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.Gray;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            kryptonLabel3.TabIndex = 5;
            kryptonLabel3.Values.Text = "This will be used to convert dates \r\nto and from AoC's relative time format.\r\nChanging this setting requires reloading the scenario.\r\n";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel8.AutoSize = false;
            kryptonLabel8.Location = new Point(215, 259);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(61, 68);
            kryptonLabel8.TabIndex = 10;
            kryptonLabel8.Values.Text = "Nations:\r\nCities:\r\nAlliances:\r\nWars:";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel4.AutoSize = false;
            kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            kryptonLabel4.Location = new Point(5, 224);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(83, 29);
            kryptonLabel4.TabIndex = 6;
            kryptonLabel4.Values.Text = "File info";
            // 
            // ScenarioSizeLabel
            // 
            ScenarioSizeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ScenarioSizeLabel.AutoSize = false;
            ScenarioSizeLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            ScenarioSizeLabel.Location = new Point(100, 291);
            ScenarioSizeLabel.Name = "ScenarioSizeLabel";
            ScenarioSizeLabel.Size = new Size(66, 36);
            ScenarioSizeLabel.TabIndex = 9;
            ScenarioSizeLabel.Values.Text = "Unknown\r\nUnknown";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel5.AutoSize = false;
            kryptonLabel5.Location = new Point(8, 259);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(88, 148);
            kryptonLabel5.TabIndex = 7;
            kryptonLabel5.Values.Text = "Game version:\r\n\r\nWidth:\r\nHeight:\r\n\r\n\r\nStarting date:\r\n\r\nCurrent date:";
            // 
            // GameVerLabel
            // 
            GameVerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GameVerLabel.AutoSize = false;
            GameVerLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            GameVerLabel.Location = new Point(100, 259);
            GameVerLabel.Name = "GameVerLabel";
            GameVerLabel.Size = new Size(66, 20);
            GameVerLabel.TabIndex = 8;
            GameVerLabel.Values.Text = "Unknown";
            // 
            // NationsTab
            // 
            NationsTab.AutoHiddenSlideSize = new Size(200, 200);
            NationsTab.Controls.Add(SetFlagID);
            NationsTab.Controls.Add(kryptonLabel15);
            NationsTab.Controls.Add(ceLock);
            NationsTab.Controls.Add(CapitalSelect);
            NationsTab.Controls.Add(DisableAI);
            NationsTab.Controls.Add(SetEyear);
            NationsTab.Controls.Add(SetSyear);
            NationsTab.Controls.Add(SetGold);
            NationsTab.Controls.Add(SetCE);
            NationsTab.Controls.Add(SetBonus);
            NationsTab.Controls.Add(SetBonusToAll);
            NationsTab.Controls.Add(SetCEToAll);
            NationsTab.Controls.Add(SetGoldToAll);
            NationsTab.Controls.Add(FlagPreview);
            NationsTab.Controls.Add(kryptonLabel9);
            NationsTab.Controls.Add(kryptonLabel10);
            NationsTab.Controls.Add(kryptonLabel14);
            NationsTab.Controls.Add(NationPreview);
            NationsTab.Controls.Add(NationsTable);
            NationsTab.Controls.Add(PasteNationNames);
            NationsTab.Flags = 65534;
            NationsTab.LastVisibleSet = true;
            NationsTab.MinimumSize = new Size(150, 50);
            NationsTab.Name = "NationsTab";
            NationsTab.Size = new Size(882, 413);
            NationsTab.Text = "Nations";
            NationsTab.ToolTipTitle = "Page ToolTip";
            NationsTab.UniqueName = "22e9fea1d2044536ba815bab9905308b";
            // 
            // SetFlagID
            // 
            SetFlagID.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SetFlagID.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            SetFlagID.Location = new Point(792, 284);
            SetFlagID.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            SetFlagID.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            SetFlagID.Name = "SetFlagID";
            SetFlagID.Size = new Size(87, 22);
            SetFlagID.TabIndex = 42;
            SetFlagID.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel15.AutoSize = false;
            kryptonLabel15.Location = new Point(735, 286);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Size = new Size(51, 20);
            kryptonLabel15.TabIndex = 41;
            kryptonLabel15.Values.Text = "Flag ID:";
            // 
            // ceLock
            // 
            ceLock.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ceLock.Location = new Point(450, 388);
            ceLock.Name = "ceLock";
            ceLock.Size = new Size(66, 20);
            ceLock.TabIndex = 32;
            ceLock.Values.Text = "CE Lock";
            // 
            // CapitalSelect
            // 
            CapitalSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CapitalSelect.Location = new Point(442, 239);
            CapitalSelect.Name = "CapitalSelect";
            CapitalSelect.Size = new Size(221, 22);
            CapitalSelect.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            CapitalSelect.TabIndex = 31;
            // 
            // DisableAI
            // 
            DisableAI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DisableAI.Location = new Point(389, 388);
            DisableAI.Name = "DisableAI";
            DisableAI.Size = new Size(55, 20);
            DisableAI.TabIndex = 31;
            DisableAI.Values.Text = "No AI";
            // 
            // SetEyear
            // 
            SetEyear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetEyear.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            SetEyear.Location = new Point(563, 269);
            SetEyear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            SetEyear.Minimum = new decimal(new int[] { 20000, 0, 0, int.MinValue });
            SetEyear.Name = "SetEyear";
            SetEyear.Size = new Size(100, 22);
            SetEyear.TabIndex = 31;
            SetEyear.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // SetSyear
            // 
            SetSyear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetSyear.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            SetSyear.Location = new Point(442, 269);
            SetSyear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            SetSyear.Minimum = new decimal(new int[] { 20000, 0, 0, int.MinValue });
            SetSyear.Name = "SetSyear";
            SetSyear.Size = new Size(100, 22);
            SetSyear.TabIndex = 32;
            SetSyear.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // SetGold
            // 
            SetGold.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetGold.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            SetGold.Location = new Point(505, 299);
            SetGold.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            SetGold.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            SetGold.Name = "SetGold";
            SetGold.Size = new Size(100, 22);
            SetGold.TabIndex = 34;
            SetGold.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // SetCE
            // 
            SetCE.AllowDecimals = true;
            SetCE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetCE.DecimalPlaces = 1;
            SetCE.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            SetCE.Location = new Point(505, 359);
            SetCE.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            SetCE.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            SetCE.Name = "SetCE";
            SetCE.Size = new Size(100, 22);
            SetCE.TabIndex = 35;
            SetCE.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // SetBonus
            // 
            SetBonus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetBonus.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            SetBonus.Location = new Point(505, 329);
            SetBonus.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            SetBonus.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            SetBonus.Name = "SetBonus";
            SetBonus.Size = new Size(100, 22);
            SetBonus.TabIndex = 33;
            SetBonus.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // SetBonusToAll
            // 
            SetBonusToAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetBonusToAll.Location = new Point(611, 329);
            SetBonusToAll.Name = "SetBonusToAll";
            SetBonusToAll.Size = new Size(90, 22);
            SetBonusToAll.TabIndex = 36;
            SetBonusToAll.Values.DropDownArrowColor = Color.Empty;
            SetBonusToAll.Values.Text = "Apply to all";
            // 
            // SetCEToAll
            // 
            SetCEToAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetCEToAll.Location = new Point(611, 359);
            SetCEToAll.Name = "SetCEToAll";
            SetCEToAll.Size = new Size(90, 22);
            SetCEToAll.TabIndex = 37;
            SetCEToAll.Values.DropDownArrowColor = Color.Empty;
            SetCEToAll.Values.Text = "Apply to all";
            // 
            // SetGoldToAll
            // 
            SetGoldToAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetGoldToAll.Location = new Point(611, 299);
            SetGoldToAll.Name = "SetGoldToAll";
            SetGoldToAll.Size = new Size(90, 22);
            SetGoldToAll.TabIndex = 32;
            SetGoldToAll.Values.DropDownArrowColor = Color.Empty;
            SetGoldToAll.Values.Text = "Apply to all";
            // 
            // FlagPreview
            // 
            FlagPreview.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FlagPreview.Location = new Point(735, 312);
            FlagPreview.Name = "FlagPreview";
            FlagPreview.Size = new Size(144, 96);
            FlagPreview.TabIndex = 40;
            FlagPreview.TabStop = false;
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel9.AutoSize = false;
            kryptonLabel9.Location = new Point(384, 239);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(190, 148);
            kryptonLabel9.TabIndex = 36;
            kryptonLabel9.Values.Text = "Capital:\r\n\r\nActive:                                         -\r\n\r\nGold:\r\n\r\nEconomy Bonus:\r\n\r\nCombat Efficiency: \r\n";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel10.AutoSize = false;
            kryptonLabel10.Location = new Point(515, 388);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(186, 19);
            kryptonLabel10.StateCommon.ShortText.Color1 = Color.Silver;
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            kryptonLabel10.TabIndex = 39;
            kryptonLabel10.Values.Text = "← Ctrl + click to apply to all nations";
            // 
            // kryptonLabel14
            // 
            kryptonLabel14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel14.AutoSize = false;
            kryptonLabel14.Location = new Point(671, 235);
            kryptonLabel14.Name = "kryptonLabel14";
            kryptonLabel14.Size = new Size(209, 19);
            kryptonLabel14.StateCommon.ShortText.Color1 = Color.Silver;
            kryptonLabel14.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            kryptonLabel14.TabIndex = 38;
            kryptonLabel14.Values.Text = "You can also select a country on the map";
            // 
            // NationPreview
            // 
            NationPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NationPreview.Location = new Point(384, 3);
            NationPreview.Name = "NationPreview";
            NationPreview.Size = new Size(495, 231);
            NationPreview.SizeMode = PictureBoxSizeMode.Zoom;
            NationPreview.TabIndex = 31;
            NationPreview.TabStop = false;
            // 
            // NationsTable
            // 
            NationsTable.AllowUserToAddRows = false;
            NationsTable.AllowUserToDeleteRows = false;
            NationsTable.AllowUserToResizeRows = false;
            NationsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            NationsTable.BorderStyle = BorderStyle.None;
            NationsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NationsTable.Columns.AddRange(new DataGridViewColumn[] { NationID, NationName, NationColor });
            NationsTable.Location = new Point(3, 3);
            NationsTable.MultiSelect = false;
            NationsTable.Name = "NationsTable";
            NationsTable.RowHeadersVisible = false;
            NationsTable.Size = new Size(375, 376);
            NationsTable.TabIndex = 0;
            // 
            // NationID
            // 
            NationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NationID.FillWeight = 20F;
            NationID.HeaderText = "ID";
            NationID.MinimumWidth = 30;
            NationID.Name = "NationID";
            NationID.ReadOnly = true;
            NationID.Resizable = DataGridViewTriState.True;
            NationID.Width = 64;
            // 
            // NationName
            // 
            NationName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NationName.HeaderText = "Name";
            NationName.MinimumWidth = 100;
            NationName.Name = "NationName";
            NationName.Resizable = DataGridViewTriState.True;
            NationName.Width = 230;
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
            // PasteNationNames
            // 
            PasteNationNames.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PasteNationNames.Location = new Point(3, 385);
            PasteNationNames.Name = "PasteNationNames";
            PasteNationNames.Size = new Size(220, 25);
            PasteNationNames.TabIndex = 31;
            PasteNationNames.Values.DropDownArrowColor = Color.Empty;
            PasteNationNames.Values.Text = "Paste names from clipboard";
            // 
            // CitiesTab
            // 
            CitiesTab.AutoHiddenSlideSize = new Size(200, 200);
            CitiesTab.Controls.Add(kryptonLabel18);
            CitiesTab.Controls.Add(RemoveCore);
            CitiesTab.Controls.Add(CityRevoltChance);
            CitiesTab.Controls.Add(ShowGrid);
            CitiesTab.Controls.Add(CityRightfulOwner);
            CitiesTab.Controls.Add(SetCoreToSelf);
            CitiesTab.Controls.Add(kryptonLabel17);
            CitiesTab.Controls.Add(kryptonLabel16);
            CitiesTab.Controls.Add(ImportCities);
            CitiesTab.Controls.Add(PasteCityNames);
            CitiesTab.Controls.Add(CitiesTable);
            CitiesTab.Controls.Add(CityPreview);
            CitiesTab.Flags = 65534;
            CitiesTab.LastVisibleSet = true;
            CitiesTab.MinimumSize = new Size(150, 50);
            CitiesTab.Name = "CitiesTab";
            CitiesTab.Size = new Size(882, 413);
            CitiesTab.Text = "Cities";
            CitiesTab.ToolTipTitle = "Page ToolTip";
            CitiesTab.UniqueName = "6a9eb17dcf014334a62a6316a00b54d8";
            // 
            // kryptonLabel18
            // 
            kryptonLabel18.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel18.AutoSize = false;
            kryptonLabel18.Location = new Point(389, 341);
            kryptonLabel18.Name = "kryptonLabel18";
            kryptonLabel18.Size = new Size(227, 33);
            kryptonLabel18.StateCommon.ShortText.Color1 = Color.Silver;
            kryptonLabel18.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            kryptonLabel18.TabIndex = 49;
            kryptonLabel18.Values.Text = "Shift + click to apply to all cities in a country\r\nCtrl + click to apply to all cities on the map";
            // 
            // RemoveCore
            // 
            RemoveCore.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveCore.Location = new Point(495, 316);
            RemoveCore.Name = "RemoveCore";
            RemoveCore.Size = new Size(100, 22);
            RemoveCore.TabIndex = 48;
            RemoveCore.Values.DropDownArrowColor = Color.Empty;
            RemoveCore.Values.Text = "Remove core";
            // 
            // CityRevoltChance
            // 
            CityRevoltChance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CityRevoltChance.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            CityRevoltChance.Location = new Point(500, 239);
            CityRevoltChance.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            CityRevoltChance.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            CityRevoltChance.Name = "CityRevoltChance";
            CityRevoltChance.Size = new Size(70, 22);
            CityRevoltChance.TabIndex = 47;
            CityRevoltChance.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // ShowGrid
            // 
            ShowGrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ShowGrid.AutoSize = false;
            ShowGrid.Location = new Point(618, 240);
            ShowGrid.Name = "ShowGrid";
            ShowGrid.Size = new Size(47, 20);
            ShowGrid.TabIndex = 44;
            ShowGrid.Values.Text = "Grid";
            // 
            // CityRightfulOwner
            // 
            CityRightfulOwner.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CityRightfulOwner.Location = new Point(389, 288);
            CityRightfulOwner.Name = "CityRightfulOwner";
            CityRightfulOwner.Size = new Size(206, 22);
            CityRightfulOwner.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            CityRightfulOwner.TabIndex = 43;
            // 
            // SetCoreToSelf
            // 
            SetCoreToSelf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetCoreToSelf.Location = new Point(389, 316);
            SetCoreToSelf.Name = "SetCoreToSelf";
            SetCoreToSelf.Size = new Size(100, 22);
            SetCoreToSelf.TabIndex = 45;
            SetCoreToSelf.Values.DropDownArrowColor = Color.Empty;
            SetCoreToSelf.Values.Text = "Set as core";
            // 
            // kryptonLabel17
            // 
            kryptonLabel17.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel17.AutoSize = false;
            kryptonLabel17.Location = new Point(667, 237);
            kryptonLabel17.Name = "kryptonLabel17";
            kryptonLabel17.Size = new Size(212, 48);
            kryptonLabel17.StateCommon.ShortText.Color1 = Color.Silver;
            kryptonLabel17.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            kryptonLabel17.TabIndex = 46;
            kryptonLabel17.Values.Text = "You can also select a city on the map\r\nHold Shift to bypass aim assist\r\nHold Ctrl to move the current city instead";
            // 
            // kryptonLabel16
            // 
            kryptonLabel16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel16.AutoSize = false;
            kryptonLabel16.Location = new Point(384, 239);
            kryptonLabel16.Name = "kryptonLabel16";
            kryptonLabel16.Size = new Size(110, 52);
            kryptonLabel16.TabIndex = 31;
            kryptonLabel16.Values.Text = "Revolt chance [%]:\r\n\r\nRightful owner:";
            // 
            // ImportCities
            // 
            ImportCities.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ImportCities.Location = new Point(228, 385);
            ImportCities.Name = "ImportCities";
            ImportCities.Size = new Size(150, 25);
            ImportCities.TabIndex = 34;
            ImportCities.Values.DropDownArrowColor = Color.Empty;
            ImportCities.Values.Text = "Import cities";
            // 
            // PasteCityNames
            // 
            PasteCityNames.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PasteCityNames.Location = new Point(3, 385);
            PasteCityNames.Name = "PasteCityNames";
            PasteCityNames.Size = new Size(220, 25);
            PasteCityNames.TabIndex = 33;
            PasteCityNames.Values.DropDownArrowColor = Color.Empty;
            PasteCityNames.Values.Text = "Paste names from clipboard";
            // 
            // CitiesTable
            // 
            CitiesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CitiesTable.BorderStyle = BorderStyle.None;
            CitiesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CitiesTable.Columns.AddRange(new DataGridViewColumn[] { cityX, cityY, CityName });
            CitiesTable.Location = new Point(3, 3);
            CitiesTable.MultiSelect = false;
            CitiesTable.Name = "CitiesTable";
            CitiesTable.RowHeadersWidth = 15;
            CitiesTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            CitiesTable.Size = new Size(375, 376);
            CitiesTable.TabIndex = 31;
            // 
            // cityX
            // 
            cityX.AllowDecimals = false;
            cityX.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cityX.FillWeight = 20F;
            cityX.HeaderText = "X";
            cityX.MinimumWidth = 30;
            cityX.Name = "cityX";
            cityX.Resizable = DataGridViewTriState.True;
            cityX.SortMode = DataGridViewColumnSortMode.Automatic;
            cityX.Width = 93;
            // 
            // cityY
            // 
            cityY.AllowDecimals = false;
            cityY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cityY.FillWeight = 20F;
            cityY.HeaderText = "Y";
            cityY.MinimumWidth = 30;
            cityY.Name = "cityY";
            cityY.Resizable = DataGridViewTriState.True;
            cityY.SortMode = DataGridViewColumnSortMode.Automatic;
            cityY.Width = 159;
            // 
            // CityName
            // 
            CityName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CityName.HeaderText = "Name";
            CityName.MinimumWidth = 100;
            CityName.Name = "CityName";
            CityName.Resizable = DataGridViewTriState.True;
            CityName.Width = 108;
            // 
            // CityPreview
            // 
            CityPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CityPreview.Location = new Point(384, 3);
            CityPreview.Name = "CityPreview";
            CityPreview.Size = new Size(495, 231);
            CityPreview.SizeMode = PictureBoxSizeMode.Zoom;
            CityPreview.TabIndex = 32;
            CityPreview.TabStop = false;
            // 
            // AlliancesTab
            // 
            AlliancesTab.AutoHiddenSlideSize = new Size(200, 200);
            AlliancesTab.Controls.Add(AlliancePreview);
            AlliancesTab.Controls.Add(Unity);
            AlliancesTab.Controls.Add(IsUnion);
            AlliancesTab.Controls.Add(kryptonLabel20);
            AlliancesTab.Controls.Add(AlliancesTable);
            AlliancesTab.Controls.Add(AllianceNationSelect);
            AlliancesTab.Controls.Add(kryptonLabel21);
            AlliancesTab.Flags = 65534;
            AlliancesTab.LastVisibleSet = true;
            AlliancesTab.MinimumSize = new Size(150, 50);
            AlliancesTab.Name = "AlliancesTab";
            AlliancesTab.Size = new Size(882, 413);
            AlliancesTab.Text = "Alliances";
            AlliancesTab.ToolTipTitle = "Page ToolTip";
            AlliancesTab.UniqueName = "85de7ee0f90c4ed19e7b41275220da07";
            // 
            // AlliancePreview
            // 
            AlliancePreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AlliancePreview.Location = new Point(384, 210);
            AlliancePreview.Name = "AlliancePreview";
            AlliancePreview.Size = new Size(495, 200);
            AlliancePreview.SizeMode = PictureBoxSizeMode.Zoom;
            AlliancePreview.TabIndex = 33;
            AlliancePreview.TabStop = false;
            // 
            // Unity
            // 
            Unity.AllowDecimals = true;
            Unity.DecimalPlaces = 1;
            Unity.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Unity.Location = new Point(432, 184);
            Unity.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            Unity.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            Unity.Name = "Unity";
            Unity.Size = new Size(60, 22);
            Unity.TabIndex = 49;
            Unity.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // IsUnion
            // 
            IsUnion.AutoSize = false;
            IsUnion.Location = new Point(500, 186);
            IsUnion.Name = "IsUnion";
            IsUnion.Size = new Size(67, 20);
            IsUnion.TabIndex = 48;
            IsUnion.Values.Text = "Is union";
            // 
            // kryptonLabel20
            // 
            kryptonLabel20.AutoSize = false;
            kryptonLabel20.Location = new Point(384, 185);
            kryptonLabel20.Name = "kryptonLabel20";
            kryptonLabel20.Size = new Size(42, 20);
            kryptonLabel20.TabIndex = 31;
            kryptonLabel20.Values.Text = "Unity:";
            // 
            // AlliancesTable
            // 
            AlliancesTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AlliancesTable.BorderStyle = BorderStyle.None;
            AlliancesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AlliancesTable.Columns.AddRange(new DataGridViewColumn[] { AllianceName, AllianceMembers, AllianceColor });
            AlliancesTable.Location = new Point(384, 3);
            AlliancesTable.MultiSelect = false;
            AlliancesTable.Name = "AlliancesTable";
            AlliancesTable.RowHeadersWidth = 15;
            AlliancesTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            AlliancesTable.Size = new Size(495, 175);
            AlliancesTable.TabIndex = 34;
            // 
            // AllianceName
            // 
            AllianceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllianceName.HeaderText = "Name";
            AllianceName.MinimumWidth = 100;
            AllianceName.Name = "AllianceName";
            AllianceName.Resizable = DataGridViewTriState.True;
            AllianceName.Width = 157;
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
            AllianceMembers.Width = 215;
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
            // AllianceNationSelect
            // 
            AllianceNationSelect.AllowUserToAddRows = false;
            AllianceNationSelect.AllowUserToDeleteRows = false;
            AllianceNationSelect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AllianceNationSelect.BorderStyle = BorderStyle.None;
            AllianceNationSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllianceNationSelect.Columns.AddRange(new DataGridViewColumn[] { AllianceNationID, AllianceNations, AllianceSelect, AllianceLoyalty });
            AllianceNationSelect.Location = new Point(3, 3);
            AllianceNationSelect.MultiSelect = false;
            AllianceNationSelect.Name = "AllianceNationSelect";
            AllianceNationSelect.RowHeadersVisible = false;
            AllianceNationSelect.Size = new Size(375, 407);
            AllianceNationSelect.TabIndex = 31;
            // 
            // AllianceNationID
            // 
            AllianceNationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllianceNationID.FillWeight = 20F;
            AllianceNationID.HeaderText = "ID";
            AllianceNationID.MinimumWidth = 30;
            AllianceNationID.Name = "AllianceNationID";
            AllianceNationID.ReadOnly = true;
            AllianceNationID.Resizable = DataGridViewTriState.True;
            AllianceNationID.Width = 59;
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
            AllianceNations.Width = 126;
            // 
            // AllianceSelect
            // 
            AllianceSelect.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllianceSelect.DropDownWidth = 121;
            AllianceSelect.HeaderText = "Alliance";
            AllianceSelect.MinimumWidth = 50;
            AllianceSelect.Name = "AllianceSelect";
            AllianceSelect.Resizable = DataGridViewTriState.True;
            AllianceSelect.SortMode = DataGridViewColumnSortMode.Automatic;
            AllianceSelect.Width = 75;
            // 
            // AllianceLoyalty
            // 
            AllianceLoyalty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllianceLoyalty.DropDownWidth = 121;
            AllianceLoyalty.FillWeight = 50F;
            AllianceLoyalty.HeaderText = "Loyalty";
            AllianceLoyalty.Items.Add("High");
            AllianceLoyalty.Items.Add("Medium");
            AllianceLoyalty.Items.Add("Low");
            AllianceLoyalty.MinimumWidth = 20;
            AllianceLoyalty.Name = "AllianceLoyalty";
            AllianceLoyalty.Resizable = DataGridViewTriState.True;
            AllianceLoyalty.Width = 114;
            // 
            // kryptonLabel21
            // 
            kryptonLabel21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonLabel21.AutoSize = false;
            kryptonLabel21.Location = new Point(706, 179);
            kryptonLabel21.Name = "kryptonLabel21";
            kryptonLabel21.Size = new Size(173, 33);
            kryptonLabel21.StateCommon.ShortText.Color1 = Color.Silver;
            kryptonLabel21.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            kryptonLabel21.TabIndex = 50;
            kryptonLabel21.Values.Text = "You can also select a country and \r\nthe alliance it's in from the map\r\n";
            // 
            // PuppetsTab
            // 
            PuppetsTab.AutoHiddenSlideSize = new Size(200, 200);
            PuppetsTab.Controls.Add(PuppetLoyaltyDesc);
            PuppetsTab.Controls.Add(PuppetAutonomyDesc);
            PuppetsTab.Controls.Add(PuppetIntegration);
            PuppetsTab.Controls.Add(PuppetLoyalty);
            PuppetsTab.Controls.Add(PuppetAutonomy);
            PuppetsTab.Controls.Add(kryptonLabel23);
            PuppetsTab.Controls.Add(PuppetsOverview);
            PuppetsTab.Controls.Add(kryptonLabel22);
            PuppetsTab.Controls.Add(PuppetsTable);
            PuppetsTab.Flags = 65534;
            PuppetsTab.LastVisibleSet = true;
            PuppetsTab.MinimumSize = new Size(150, 50);
            PuppetsTab.Name = "PuppetsTab";
            PuppetsTab.Size = new Size(882, 413);
            PuppetsTab.Text = "Puppets";
            PuppetsTab.ToolTipTitle = "Page ToolTip";
            PuppetsTab.UniqueName = "13cd4886863148838a562ba050a3d46f";
            // 
            // PuppetLoyaltyDesc
            // 
            PuppetLoyaltyDesc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetLoyaltyDesc.Items.AddRange(new object[] { "Low", "Medium", "High" });
            PuppetLoyaltyDesc.Location = new Point(531, 369);
            PuppetLoyaltyDesc.Name = "PuppetLoyaltyDesc";
            PuppetLoyaltyDesc.Size = new Size(100, 22);
            PuppetLoyaltyDesc.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            PuppetLoyaltyDesc.TabIndex = 31;
            // 
            // PuppetAutonomyDesc
            // 
            PuppetAutonomyDesc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetAutonomyDesc.Items.AddRange(new object[] { "Vassal", "Puppet", "Satelite" });
            PuppetAutonomyDesc.Location = new Point(531, 339);
            PuppetAutonomyDesc.Name = "PuppetAutonomyDesc";
            PuppetAutonomyDesc.Size = new Size(100, 22);
            PuppetAutonomyDesc.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            PuppetAutonomyDesc.TabIndex = 32;
            // 
            // PuppetIntegration
            // 
            PuppetIntegration.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetIntegration.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            PuppetIntegration.Location = new Point(730, 339);
            PuppetIntegration.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            PuppetIntegration.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            PuppetIntegration.Name = "PuppetIntegration";
            PuppetIntegration.Size = new Size(60, 22);
            PuppetIntegration.TabIndex = 50;
            PuppetIntegration.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // PuppetLoyalty
            // 
            PuppetLoyalty.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetLoyalty.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            PuppetLoyalty.Location = new Point(465, 369);
            PuppetLoyalty.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            PuppetLoyalty.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            PuppetLoyalty.Name = "PuppetLoyalty";
            PuppetLoyalty.Size = new Size(60, 22);
            PuppetLoyalty.TabIndex = 49;
            PuppetLoyalty.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // PuppetAutonomy
            // 
            PuppetAutonomy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetAutonomy.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            PuppetAutonomy.Location = new Point(465, 339);
            PuppetAutonomy.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            PuppetAutonomy.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            PuppetAutonomy.Name = "PuppetAutonomy";
            PuppetAutonomy.Size = new Size(60, 22);
            PuppetAutonomy.TabIndex = 48;
            PuppetAutonomy.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // kryptonLabel23
            // 
            kryptonLabel23.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel23.AutoSize = false;
            kryptonLabel23.Location = new Point(650, 309);
            kryptonLabel23.Name = "kryptonLabel23";
            kryptonLabel23.Size = new Size(97, 52);
            kryptonLabel23.TabIndex = 32;
            kryptonLabel23.Values.Text = "Master settings:\r\n\r\nIntegration:";
            // 
            // PuppetsOverview
            // 
            PuppetsOverview.AllowUserToAddRows = false;
            PuppetsOverview.AllowUserToDeleteRows = false;
            PuppetsOverview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PuppetsOverview.BorderStyle = BorderStyle.None;
            PuppetsOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PuppetsOverview.Columns.AddRange(new DataGridViewColumn[] { PuppetMasterID, PuppetMastersList, PuppetsList });
            PuppetsOverview.Location = new Point(384, 3);
            PuppetsOverview.MultiSelect = false;
            PuppetsOverview.Name = "PuppetsOverview";
            PuppetsOverview.ReadOnly = true;
            PuppetsOverview.RowHeadersVisible = false;
            PuppetsOverview.RowHeadersWidth = 15;
            PuppetsOverview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            PuppetsOverview.Size = new Size(495, 300);
            PuppetsOverview.TabIndex = 36;
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
            // kryptonLabel22
            // 
            kryptonLabel22.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel22.AutoSize = false;
            kryptonLabel22.Location = new Point(384, 309);
            kryptonLabel22.Name = "kryptonLabel22";
            kryptonLabel22.Size = new Size(98, 84);
            kryptonLabel22.TabIndex = 31;
            kryptonLabel22.Values.Text = "Puppet settings:\r\n\r\nAutonomy:\r\n\r\nLoyalty:";
            // 
            // PuppetsTable
            // 
            PuppetsTable.AllowUserToAddRows = false;
            PuppetsTable.AllowUserToDeleteRows = false;
            PuppetsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PuppetsTable.BorderStyle = BorderStyle.None;
            PuppetsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PuppetsTable.Columns.AddRange(new DataGridViewColumn[] { PuppetNationID, PuppetNationList, PuppetMasterSelect });
            PuppetsTable.Location = new Point(3, 3);
            PuppetsTable.MultiSelect = false;
            PuppetsTable.Name = "PuppetsTable";
            PuppetsTable.RowHeadersVisible = false;
            PuppetsTable.Size = new Size(375, 407);
            PuppetsTable.TabIndex = 35;
            // 
            // PuppetNationID
            // 
            PuppetNationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PuppetNationID.FillWeight = 20F;
            PuppetNationID.HeaderText = "ID";
            PuppetNationID.MinimumWidth = 30;
            PuppetNationID.Name = "PuppetNationID";
            PuppetNationID.ReadOnly = true;
            PuppetNationID.Width = 45;
            // 
            // PuppetNationList
            // 
            PuppetNationList.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PuppetNationList.HeaderText = "Nation";
            PuppetNationList.MinimumWidth = 100;
            PuppetNationList.Name = "PuppetNationList";
            PuppetNationList.ReadOnly = true;
            PuppetNationList.Resizable = DataGridViewTriState.True;
            PuppetNationList.Width = 164;
            // 
            // PuppetMasterSelect
            // 
            PuppetMasterSelect.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PuppetMasterSelect.DropDownWidth = 121;
            PuppetMasterSelect.HeaderText = "Master";
            PuppetMasterSelect.MinimumWidth = 100;
            PuppetMasterSelect.Name = "PuppetMasterSelect";
            PuppetMasterSelect.Resizable = DataGridViewTriState.True;
            PuppetMasterSelect.SortMode = DataGridViewColumnSortMode.Automatic;
            PuppetMasterSelect.Width = 165;
            // 
            // WarsTab
            // 
            WarsTab.AutoHiddenSlideSize = new Size(200, 200);
            WarsTab.Controls.Add(kryptonLabel25);
            WarsTab.Controls.Add(WarNationSelect);
            WarsTab.Controls.Add(WarsTable);
            WarsTab.Controls.Add(MergeWars);
            WarsTab.Controls.Add(RemoveWar);
            WarsTab.Controls.Add(AddWar);
            WarsTab.Controls.Add(ToDeath);
            WarsTab.Controls.Add(WarEndDay);
            WarsTab.Controls.Add(WarStartDay);
            WarsTab.Controls.Add(WarEndYear);
            WarsTab.Controls.Add(WarStartYear);
            WarsTab.Controls.Add(WarEndMonth);
            WarsTab.Controls.Add(WarStartMonth);
            WarsTab.Controls.Add(kryptonLabel24);
            WarsTab.Flags = 65534;
            WarsTab.LastVisibleSet = true;
            WarsTab.MinimumSize = new Size(150, 50);
            WarsTab.Name = "WarsTab";
            WarsTab.Size = new Size(882, 413);
            WarsTab.Text = "Wars";
            WarsTab.ToolTipTitle = "Page ToolTip";
            WarsTab.UniqueName = "411940ec9a3b449ab6f000c4af887176";
            // 
            // kryptonLabel25
            // 
            kryptonLabel25.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel25.AutoSize = false;
            kryptonLabel25.Location = new Point(375, 309);
            kryptonLabel25.Name = "kryptonLabel25";
            kryptonLabel25.Size = new Size(107, 19);
            kryptonLabel25.StateCommon.ShortText.Color1 = Color.Silver;
            kryptonLabel25.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            kryptonLabel25.TabIndex = 48;
            kryptonLabel25.Values.Text = "* former participant";
            // 
            // WarNationSelect
            // 
            WarNationSelect.AllowUserToAddRows = false;
            WarNationSelect.AllowUserToDeleteRows = false;
            WarNationSelect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WarNationSelect.BorderStyle = BorderStyle.None;
            WarNationSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WarNationSelect.Columns.AddRange(new DataGridViewColumn[] { WarNationID, Nation, Involvement });
            WarNationSelect.Location = new Point(488, 3);
            WarNationSelect.MultiSelect = false;
            WarNationSelect.Name = "WarNationSelect";
            WarNationSelect.RowHeadersVisible = false;
            WarNationSelect.RowHeadersWidth = 15;
            WarNationSelect.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            WarNationSelect.Size = new Size(391, 407);
            WarNationSelect.TabIndex = 47;
            // 
            // WarNationID
            // 
            WarNationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WarNationID.FillWeight = 20F;
            WarNationID.HeaderText = "ID";
            WarNationID.MinimumWidth = 20;
            WarNationID.Name = "WarNationID";
            WarNationID.ReadOnly = true;
            WarNationID.Width = 86;
            // 
            // Nation
            // 
            Nation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nation.HeaderText = "Nation";
            Nation.MinimumWidth = 100;
            Nation.Name = "Nation";
            Nation.ReadOnly = true;
            Nation.Width = 143;
            // 
            // Involvement
            // 
            Involvement.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Involvement.DropDownWidth = 121;
            Involvement.FillWeight = 50F;
            Involvement.HeaderText = "Select stance";
            Involvement.Items.Add("Not involved");
            Involvement.Items.Add("Attacker");
            Involvement.Items.Add("Former attacker");
            Involvement.Items.Add("Defender");
            Involvement.Items.Add("Former defender");
            Involvement.MinimumWidth = 50;
            Involvement.Name = "Involvement";
            Involvement.Resizable = DataGridViewTriState.True;
            Involvement.SortMode = DataGridViewColumnSortMode.Automatic;
            Involvement.Width = 161;
            // 
            // WarsTable
            // 
            WarsTable.AllowUserToAddRows = false;
            WarsTable.AllowUserToDeleteRows = false;
            WarsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WarsTable.BorderStyle = BorderStyle.None;
            WarsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WarsTable.Columns.AddRange(new DataGridViewColumn[] { Attackers, Defenders });
            WarsTable.Location = new Point(3, 3);
            WarsTable.Name = "WarsTable";
            WarsTable.ReadOnly = true;
            WarsTable.RowHeadersWidth = 15;
            WarsTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            WarsTable.Size = new Size(479, 300);
            WarsTable.TabIndex = 31;
            // 
            // Attackers
            // 
            Attackers.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Attackers.HeaderText = "Attackers";
            Attackers.MinimumWidth = 200;
            Attackers.Name = "Attackers";
            Attackers.ReadOnly = true;
            Attackers.SortMode = DataGridViewColumnSortMode.NotSortable;
            Attackers.Width = 232;
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
            Defenders.Width = 232;
            // 
            // MergeWars
            // 
            MergeWars.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MergeWars.Location = new Point(220, 309);
            MergeWars.Name = "MergeWars";
            MergeWars.Size = new Size(120, 22);
            MergeWars.TabIndex = 46;
            MergeWars.Values.DropDownArrowColor = Color.Empty;
            MergeWars.Values.Text = "Merge Selected";
            // 
            // RemoveWar
            // 
            RemoveWar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveWar.Location = new Point(94, 309);
            RemoveWar.Name = "RemoveWar";
            RemoveWar.Size = new Size(120, 22);
            RemoveWar.TabIndex = 45;
            RemoveWar.Values.DropDownArrowColor = Color.Empty;
            RemoveWar.Values.Text = "Remove Selected";
            // 
            // AddWar
            // 
            AddWar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddWar.Location = new Point(8, 309);
            AddWar.Name = "AddWar";
            AddWar.Size = new Size(80, 22);
            AddWar.TabIndex = 44;
            AddWar.Values.DropDownArrowColor = Color.Empty;
            AddWar.Values.Text = "Add new";
            // 
            // ToDeath
            // 
            ToDeath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ToDeath.Location = new Point(374, 377);
            ToDeath.Name = "ToDeath";
            ToDeath.Size = new Size(80, 22);
            ToDeath.TabIndex = 31;
            ToDeath.Values.DropDownArrowColor = Color.Empty;
            ToDeath.Values.Text = "To death";
            // 
            // WarEndDay
            // 
            WarEndDay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarEndDay.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            WarEndDay.Location = new Point(235, 377);
            WarEndDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            WarEndDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WarEndDay.Name = "WarEndDay";
            WarEndDay.Size = new Size(47, 22);
            WarEndDay.TabIndex = 42;
            WarEndDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // WarStartDay
            // 
            WarStartDay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarStartDay.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            WarStartDay.Location = new Point(235, 349);
            WarStartDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            WarStartDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WarStartDay.Name = "WarStartDay";
            WarStartDay.Size = new Size(47, 22);
            WarStartDay.TabIndex = 43;
            WarStartDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // WarEndYear
            // 
            WarEndYear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarEndYear.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            WarEndYear.Location = new Point(288, 377);
            WarEndYear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            WarEndYear.Minimum = new decimal(new int[] { 20000, 0, 0, int.MinValue });
            WarEndYear.Name = "WarEndYear";
            WarEndYear.Size = new Size(80, 22);
            WarEndYear.TabIndex = 40;
            WarEndYear.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // WarStartYear
            // 
            WarStartYear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarStartYear.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            WarStartYear.Location = new Point(288, 349);
            WarStartYear.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            WarStartYear.Minimum = new decimal(new int[] { 20000, 0, 0, int.MinValue });
            WarStartYear.Name = "WarStartYear";
            WarStartYear.Size = new Size(80, 22);
            WarStartYear.TabIndex = 41;
            WarStartYear.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // WarEndMonth
            // 
            WarEndMonth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarEndMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            WarEndMonth.Location = new Point(110, 377);
            WarEndMonth.Name = "WarEndMonth";
            WarEndMonth.Size = new Size(120, 22);
            WarEndMonth.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            WarEndMonth.TabIndex = 39;
            // 
            // WarStartMonth
            // 
            WarStartMonth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WarStartMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            WarStartMonth.Location = new Point(110, 349);
            WarStartMonth.Name = "WarStartMonth";
            WarStartMonth.Size = new Size(120, 22);
            WarStartMonth.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            WarStartMonth.TabIndex = 38;
            // 
            // kryptonLabel24
            // 
            kryptonLabel24.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel24.AutoSize = false;
            kryptonLabel24.Location = new Point(8, 349);
            kryptonLabel24.Name = "kryptonLabel24";
            kryptonLabel24.Size = new Size(98, 52);
            kryptonLabel24.TabIndex = 37;
            kryptonLabel24.Values.Text = "Start date:\r\n\r\nTarget end date:";
            // 
            // InfoTab
            // 
            InfoTab.AutoHiddenSlideSize = new Size(200, 200);
            InfoTab.Controls.Add(AboutGroupBox);
            InfoTab.Controls.Add(HelpGroupBox);
            InfoTab.Flags = 65534;
            InfoTab.LastVisibleSet = true;
            InfoTab.MinimumSize = new Size(150, 50);
            InfoTab.Name = "InfoTab";
            InfoTab.Size = new Size(882, 413);
            InfoTab.Text = "Help and Info";
            InfoTab.ToolTipTitle = "Page ToolTip";
            InfoTab.UniqueName = "847c70162d194074a559299725d06422";
            // 
            // AboutGroupBox
            // 
            AboutGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AboutGroupBox.Location = new Point(3, 258);
            AboutGroupBox.Size = new Size(876, 152);
            AboutGroupBox.TabIndex = 32;
            AboutGroupBox.Values.Heading = "About";
            // 
            // HelpGroupBox
            // 
            HelpGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HelpGroupBox.Location = new Point(3, 3);
            HelpGroupBox.Size = new Size(876, 250);
            HelpGroupBox.TabIndex = 31;
            HelpGroupBox.Values.Heading = "Help and Resources";
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel12.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            kryptonLabel12.Location = new Point(9, 453);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Size = new Size(157, 20);
            kryptonLabel12.TabIndex = 4;
            kryptonLabel12.Values.Text = "Select output destination";
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel13.Location = new Point(9, 502);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(63, 20);
            kryptonLabel13.TabIndex = 5;
            kryptonLabel13.Values.Text = "Export as:";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel6.AutoSize = false;
            kryptonLabel6.Location = new Point(9, 523);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(215, 36);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.Gray;
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            kryptonLabel6.TabIndex = 7;
            kryptonLabel6.Values.Text = "Shift + click to set destination \r\nto the appropriate game folder folder\r\n";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel7.AutoSize = false;
            kryptonLabel7.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            kryptonLabel7.Location = new Point(530, 453);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(94, 20);
            kryptonLabel7.TabIndex = 8;
            kryptonLabel7.Values.Text = "New file name";
            // 
            // RunGameButton
            // 
            RunGameButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RunGameButton.Location = new Point(677, 504);
            RunGameButton.Name = "RunGameButton";
            RunGameButton.Size = new Size(100, 56);
            RunGameButton.TabIndex = 13;
            RunGameButton.Values.DropDownArrowColor = Color.Empty;
            RunGameButton.Values.Text = "Run AoC\r\nvia Steam";
            // 
            // GenerateButton
            // 
            GenerateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GenerateButton.Location = new Point(783, 504);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(100, 56);
            GenerateButton.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            GenerateButton.TabIndex = 14;
            GenerateButton.Values.DropDownArrowColor = Color.Empty;
            GenerateButton.Values.Text = "Export";
            // 
            // DestinationBrowse
            // 
            DestinationBrowse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DestinationBrowse.Location = new Point(415, 475);
            DestinationBrowse.Name = "DestinationBrowse";
            DestinationBrowse.Size = new Size(80, 23);
            DestinationBrowse.TabIndex = 17;
            DestinationBrowse.Values.DropDownArrowColor = Color.Empty;
            DestinationBrowse.Values.Text = "Browse";
            // 
            // DestinationInput
            // 
            DestinationInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DestinationInput.Location = new Point(9, 475);
            DestinationInput.Name = "DestinationInput";
            DestinationInput.Size = new Size(400, 23);
            DestinationInput.TabIndex = 18;
            // 
            // NameSelection
            // 
            NameSelection.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NameSelection.Location = new Point(530, 475);
            NameSelection.Name = "NameSelection";
            NameSelection.Size = new Size(353, 23);
            NameSelection.TabIndex = 20;
            // 
            // ExportAsScenario
            // 
            ExportAsScenario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExportAsScenario.AutoSize = false;
            ExportAsScenario.Checked = true;
            ExportAsScenario.Location = new Point(78, 502);
            ExportAsScenario.Name = "ExportAsScenario";
            ExportAsScenario.Size = new Size(69, 20);
            ExportAsScenario.TabIndex = 28;
            ExportAsScenario.Values.Text = "Scenario";
            // 
            // ExportAsSave
            // 
            ExportAsSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExportAsSave.AutoSize = false;
            ExportAsSave.Location = new Point(153, 502);
            ExportAsSave.Name = "ExportAsSave";
            ExportAsSave.Size = new Size(48, 20);
            ExportAsSave.TabIndex = 29;
            ExportAsSave.Values.Text = "Save";
            // 
            // V5UI
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(884, 561);
            Controls.Add(ExportAsSave);
            Controls.Add(ExportAsScenario);
            Controls.Add(NameSelection);
            Controls.Add(DestinationInput);
            Controls.Add(DestinationBrowse);
            Controls.Add(GenerateButton);
            Controls.Add(RunGameButton);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonLabel13);
            Controls.Add(kryptonLabel12);
            Controls.Add(TabSelect);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 600);
            Name = "V5UI";
            Text = "Advanced Save and Scenario Editor";
            TransparencyKey = Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)TabSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThemeSwitch).EndInit();
            ThemeSwitch.ResumeLayout(false);
            ThemeSwitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoadTab).EndInit();
            LoadTab.ResumeLayout(false);
            LoadTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CurrentMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainMapSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartingMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)HomePreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)NationsTab).EndInit();
            NationsTab.ResumeLayout(false);
            NationsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CapitalSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlagPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)NationPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)NationsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)CitiesTab).EndInit();
            CitiesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CityRightfulOwner).EndInit();
            ((System.ComponentModel.ISupportInitialize)CitiesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)CityPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlliancesTab).EndInit();
            AlliancesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AlliancePreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlliancesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllianceNationSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsTab).EndInit();
            PuppetsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PuppetLoyaltyDesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuppetAutonomyDesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsOverview).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarsTab).EndInit();
            WarsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WarNationSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarEndMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarStartMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoTab).EndInit();
            InfoTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AboutGroupBox.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)AboutGroupBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)HelpGroupBox.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)HelpGroupBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Krypton.Toolkit.KryptonManager Theme;
        private Krypton.Navigator.KryptonNavigator TabSelect;
        private Krypton.Navigator.KryptonPage LoadTab;
        private Krypton.Navigator.KryptonPage NationsTab;
        private Krypton.Navigator.KryptonPage CitiesTab;
        private Krypton.Navigator.KryptonPage AlliancesTab;
        private Krypton.Navigator.KryptonPage PuppetsTab;
        private Krypton.Navigator.KryptonPage WarsTab;
        private Krypton.Navigator.KryptonPage InfoTab;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel ExportImgInfo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel ScenarioStatsLabel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel ScenarioSizeLabel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel GameVerLabel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonButton LoadScenario;
        private Krypton.Toolkit.KryptonButton RunGameButton;
        private Krypton.Toolkit.KryptonButton GenerateButton;
        private Krypton.Toolkit.KryptonButton ExportImage;
        private Krypton.Toolkit.KryptonButton ScenarioBrowse;
        private Krypton.Toolkit.KryptonButton DestinationBrowse;
        private Krypton.Toolkit.KryptonTextBox DestinationInput;
        private Krypton.Toolkit.KryptonTextBox ScenarioInput;
        private Krypton.Toolkit.KryptonTextBox NameSelection;
        private Krypton.Toolkit.KryptonPictureBox HomePreview;
        private Krypton.Toolkit.KryptonComboBox MainMapSelect;
        private Krypton.Toolkit.KryptonComboBox StartingMonth;
        private Krypton.Toolkit.KryptonComboBox CurrentMonth;
        private Krypton.Toolkit.KryptonCheckBox ShowCities;
        private Krypton.Toolkit.KryptonRadioButton MonthScale;
        private Krypton.Toolkit.KryptonRadioButton DayScale;
        private Krypton.Toolkit.KryptonRadioButton ExportAsScenario;
        private Krypton.Toolkit.KryptonRadioButton ExportAsSave;
        private Krypton.Toolkit.KryptonDataGridView NationsTable;
        private Krypton.Toolkit.KryptonPictureBox NationPreview;
        private Krypton.Toolkit.KryptonButton PasteNationNames;
        private Krypton.Toolkit.KryptonButton SetGoldToAll;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonPictureBox FlagPreview;
        private Krypton.Toolkit.KryptonButton SetBonusToAll;
        private Krypton.Toolkit.KryptonButton SetCEToAll;
        private Krypton.Toolkit.KryptonComboBox CapitalSelect;
        private Krypton.Toolkit.KryptonNumericUpDown SetEyear;
        private Krypton.Toolkit.KryptonNumericUpDown SetSyear;
        private Krypton.Toolkit.KryptonNumericUpDown SetGold;
        private Krypton.Toolkit.KryptonNumericUpDown SetCE;
        private Krypton.Toolkit.KryptonNumericUpDown SetBonus;
        private Krypton.Toolkit.KryptonCheckBox DisableAI;
        private Krypton.Toolkit.KryptonCheckBox ceLock;
        private Krypton.Toolkit.KryptonNumericUpDown SetFlagID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonPictureBox CityPreview;
        private Krypton.Toolkit.KryptonDataGridView CitiesTable;
        private Krypton.Toolkit.KryptonButton ImportCities;
        private Krypton.Toolkit.KryptonButton PasteCityNames;
        private Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private Krypton.Toolkit.KryptonNumericUpDown CityRevoltChance;
        private Krypton.Toolkit.KryptonCheckBox ShowGrid;
        private Krypton.Toolkit.KryptonComboBox CityRightfulOwner;
        private Krypton.Toolkit.KryptonButton SetCoreToSelf;
        private Krypton.Toolkit.KryptonLabel kryptonLabel17;
        private Krypton.Toolkit.KryptonLabel kryptonLabel18;
        private Krypton.Toolkit.KryptonButton RemoveCore;
        private Krypton.Navigator.KryptonPage ThemeSwitch;
        private Krypton.Toolkit.KryptonLabel kryptonLabel19;
        private Krypton.Toolkit.KryptonPictureBox AlliancePreview;
        private Krypton.Toolkit.KryptonDataGridView AllianceNationSelect;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn NationID;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn NationName;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn NationColor;
        private Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn cityX;
        private Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn cityY;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn CityName;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn AllianceNationID;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn AllianceNations;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn AllianceSelect;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn AllianceLoyalty;
        private Krypton.Toolkit.KryptonDataGridView AlliancesTable;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn AllianceName;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn AllianceMembers;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn AllianceColor;
        private Krypton.Toolkit.KryptonNumericUpDown Unity;
        private Krypton.Toolkit.KryptonCheckBox IsUnion;
        private Krypton.Toolkit.KryptonLabel kryptonLabel20;
        private Krypton.Toolkit.KryptonLabel kryptonLabel21;
        private Krypton.Toolkit.KryptonNumericUpDown CurrentYear;
        private Krypton.Toolkit.KryptonNumericUpDown StartingYear;
        private Krypton.Toolkit.KryptonNumericUpDown CurrentDay;
        private Krypton.Toolkit.KryptonNumericUpDown StartingDay;
        private Krypton.Toolkit.KryptonDataGridView PuppetsOverview;
        private Krypton.Toolkit.KryptonDataGridView PuppetsTable;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PuppetNationID;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PuppetNationList;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn PuppetMasterSelect;
        private DataGridViewTextBoxColumn PuppetMasterID;
        private DataGridViewTextBoxColumn PuppetMastersList;
        private DataGridViewTextBoxColumn PuppetsList;
        private Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private Krypton.Toolkit.KryptonLabel kryptonLabel23;
        private Krypton.Toolkit.KryptonNumericUpDown PuppetIntegration;
        private Krypton.Toolkit.KryptonNumericUpDown PuppetLoyalty;
        private Krypton.Toolkit.KryptonNumericUpDown PuppetAutonomy;
        private Krypton.Toolkit.KryptonComboBox PuppetLoyaltyDesc;
        private Krypton.Toolkit.KryptonComboBox PuppetAutonomyDesc;
        private Krypton.Toolkit.KryptonNumericUpDown WarEndDay;
        private Krypton.Toolkit.KryptonNumericUpDown WarStartDay;
        private Krypton.Toolkit.KryptonNumericUpDown WarEndYear;
        private Krypton.Toolkit.KryptonNumericUpDown WarStartYear;
        private Krypton.Toolkit.KryptonComboBox WarEndMonth;
        private Krypton.Toolkit.KryptonComboBox WarStartMonth;
        private Krypton.Toolkit.KryptonLabel kryptonLabel24;
        private Krypton.Toolkit.KryptonButton ToDeath;
        private Krypton.Toolkit.KryptonButton RemoveWar;
        private Krypton.Toolkit.KryptonButton AddWar;
        private Krypton.Toolkit.KryptonButton MergeWars;
        private Krypton.Toolkit.KryptonDataGridView WarsTable;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Attackers;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Defenders;
        private Krypton.Toolkit.KryptonDataGridView WarNationSelect;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn WarNationID;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Nation;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn Involvement;
        private Krypton.Toolkit.KryptonLabel kryptonLabel25;
        private Krypton.Toolkit.KryptonGroupBox AboutGroupBox;
        private Krypton.Toolkit.KryptonGroupBox HelpGroupBox;
    }
}
