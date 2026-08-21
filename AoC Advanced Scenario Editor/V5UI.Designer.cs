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
            kryptonManager1 = new Krypton.Toolkit.KryptonManager(components);
            TabSelect = new Krypton.Navigator.KryptonNavigator();
            LoadTab = new Krypton.Navigator.KryptonPage();
            ExportImgInfo = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ScenarioStatsLabel = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            ScenarioSizeLabel = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            GameVerLabel = new Krypton.Toolkit.KryptonLabel();
            NationsTab = new Krypton.Navigator.KryptonPage();
            CitiesTab = new Krypton.Navigator.KryptonPage();
            AlliancesTab = new Krypton.Navigator.KryptonPage();
            PuppetsTab = new Krypton.Navigator.KryptonPage();
            WarsTab = new Krypton.Navigator.KryptonPage();
            InfoTab = new Krypton.Navigator.KryptonPage();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            DarkMode = new Krypton.Toolkit.KryptonToggleSwitch();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)TabSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoadTab).BeginInit();
            LoadTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NationsTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CitiesTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlliancesTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarsTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoTab).BeginInit();
            SuspendLayout();
            // 
            // kryptonManager1
            // 
            kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkModeAlternate;
            kryptonManager1.ToolkitStrings.MessageBoxStrings.LessDetails = "L&ess Details...";
            kryptonManager1.ToolkitStrings.MessageBoxStrings.MoreDetails = "&More Details...";
            // 
            // TabSelect
            // 
            TabSelect.AllowPageReorder = false;
            TabSelect.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
            TabSelect.Location = new System.Drawing.Point(0, 0);
            TabSelect.NavigatorMode = Krypton.Navigator.NavigatorMode.BarCheckButtonGroupOutside;
            TabSelect.Owner = null;
            TabSelect.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            TabSelect.Pages.AddRange(new Krypton.Navigator.KryptonPage[] { LoadTab, NationsTab, CitiesTab, AlliancesTab, PuppetsTab, WarsTab, InfoTab });
            TabSelect.SelectedIndex = 0;
            TabSelect.Size = new System.Drawing.Size(884, 440);
            TabSelect.TabIndex = 0;
            TabSelect.Text = "kryptonNavigator1";
            // 
            // LoadTab
            // 
            LoadTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            LoadTab.Controls.Add(ExportImgInfo);
            LoadTab.Controls.Add(kryptonTextBox2);
            LoadTab.Controls.Add(kryptonLabel11);
            LoadTab.Controls.Add(kryptonLabel1);
            LoadTab.Controls.Add(kryptonLabel2);
            LoadTab.Controls.Add(ScenarioStatsLabel);
            LoadTab.Controls.Add(kryptonLabel3);
            LoadTab.Controls.Add(kryptonLabel8);
            LoadTab.Controls.Add(kryptonLabel4);
            LoadTab.Controls.Add(ScenarioSizeLabel);
            LoadTab.Controls.Add(kryptonLabel5);
            LoadTab.Controls.Add(GameVerLabel);
            LoadTab.Flags = 65534;
            LoadTab.LastVisibleSet = true;
            LoadTab.MinimumSize = new System.Drawing.Size(150, 50);
            LoadTab.Name = "LoadTab";
            LoadTab.Size = new System.Drawing.Size(882, 413);
            LoadTab.Text = "Load";
            LoadTab.ToolTipTitle = "Page ToolTip";
            LoadTab.UniqueName = "5997bf6e92bb4f548a362e99cc30895f";
            // 
            // ExportImgInfo
            // 
            ExportImgInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ExportImgInfo.AutoSize = false;
            ExportImgInfo.LabelStyle = Krypton.Toolkit.LabelStyle.ItalicPanel;
            ExportImgInfo.Location = new System.Drawing.Point(687, 45);
            ExportImgInfo.Name = "ExportImgInfo";
            ExportImgInfo.Size = new System.Drawing.Size(184, 36);
            ExportImgInfo.TabIndex = 12;
            ExportImgInfo.Values.Text = "Will export without cities.\r\nCheck to export cities separately.";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            kryptonLabel11.AutoSize = false;
            kryptonLabel11.Location = new System.Drawing.Point(575, 3);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new System.Drawing.Size(39, 20);
            kryptonLabel11.TabIndex = 13;
            kryptonLabel11.Values.Text = "View:";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            kryptonLabel1.Location = new System.Drawing.Point(8, 8);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new System.Drawing.Size(111, 20);
            kryptonLabel1.TabIndex = 2;
            kryptonLabel1.Values.Text = "Select file to load";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new System.Drawing.Point(8, 65);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new System.Drawing.Size(117, 20);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "Intended timescale:";
            // 
            // ScenarioStatsLabel
            // 
            ScenarioStatsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ScenarioStatsLabel.AutoSize = false;
            ScenarioStatsLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            ScenarioStatsLabel.Location = new System.Drawing.Point(282, 260);
            ScenarioStatsLabel.Name = "ScenarioStatsLabel";
            ScenarioStatsLabel.Size = new System.Drawing.Size(66, 68);
            ScenarioStatsLabel.TabIndex = 11;
            ScenarioStatsLabel.Values.Text = "Unknown\r\nUnknown\r\nUnknown\r\nUnknown";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.ItalicPanel;
            kryptonLabel3.Location = new System.Drawing.Point(8, 91);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new System.Drawing.Size(294, 52);
            kryptonLabel3.TabIndex = 5;
            kryptonLabel3.Values.Text = "This will be used to convert dates \r\nto and from AoC's relative time format.\r\nChanging this setting requires reloading the scenario.\r\n";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            kryptonLabel8.AutoSize = false;
            kryptonLabel8.Location = new System.Drawing.Point(215, 260);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new System.Drawing.Size(61, 68);
            kryptonLabel8.TabIndex = 10;
            kryptonLabel8.Values.Text = "Nations:\r\nCities:\r\nAlliances:\r\nWars:";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            kryptonLabel4.AutoSize = false;
            kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            kryptonLabel4.Location = new System.Drawing.Point(8, 225);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new System.Drawing.Size(83, 29);
            kryptonLabel4.TabIndex = 6;
            kryptonLabel4.Values.Text = "File info";
            // 
            // ScenarioSizeLabel
            // 
            ScenarioSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ScenarioSizeLabel.AutoSize = false;
            ScenarioSizeLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            ScenarioSizeLabel.Location = new System.Drawing.Point(102, 292);
            ScenarioSizeLabel.Name = "ScenarioSizeLabel";
            ScenarioSizeLabel.Size = new System.Drawing.Size(66, 36);
            ScenarioSizeLabel.TabIndex = 9;
            ScenarioSizeLabel.Values.Text = "Unknown\r\nUnknown";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            kryptonLabel5.AutoSize = false;
            kryptonLabel5.Location = new System.Drawing.Point(11, 260);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new System.Drawing.Size(88, 148);
            kryptonLabel5.TabIndex = 7;
            kryptonLabel5.Values.Text = "Game version:\r\n\r\nWidth:\r\nHeight:\r\n\r\n\r\nStarting date:\r\n\r\nCurrent date:";
            // 
            // GameVerLabel
            // 
            GameVerLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            GameVerLabel.AutoSize = false;
            GameVerLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            GameVerLabel.Location = new System.Drawing.Point(102, 260);
            GameVerLabel.Name = "GameVerLabel";
            GameVerLabel.Size = new System.Drawing.Size(66, 20);
            GameVerLabel.TabIndex = 8;
            GameVerLabel.Values.Text = "Unknown";
            // 
            // NationsTab
            // 
            NationsTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            NationsTab.Flags = 65534;
            NationsTab.LastVisibleSet = true;
            NationsTab.MinimumSize = new System.Drawing.Size(150, 50);
            NationsTab.Name = "NationsTab";
            NationsTab.Size = new System.Drawing.Size(882, 411);
            NationsTab.Text = "Nations";
            NationsTab.ToolTipTitle = "Page ToolTip";
            NationsTab.UniqueName = "22e9fea1d2044536ba815bab9905308b";
            // 
            // CitiesTab
            // 
            CitiesTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            CitiesTab.Flags = 65534;
            CitiesTab.LastVisibleSet = true;
            CitiesTab.MinimumSize = new System.Drawing.Size(150, 50);
            CitiesTab.Name = "CitiesTab";
            CitiesTab.Size = new System.Drawing.Size(882, 411);
            CitiesTab.Text = "Cities";
            CitiesTab.ToolTipTitle = "Page ToolTip";
            CitiesTab.UniqueName = "6a9eb17dcf014334a62a6316a00b54d8";
            // 
            // AlliancesTab
            // 
            AlliancesTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            AlliancesTab.Flags = 65534;
            AlliancesTab.LastVisibleSet = true;
            AlliancesTab.MinimumSize = new System.Drawing.Size(150, 50);
            AlliancesTab.Name = "AlliancesTab";
            AlliancesTab.Size = new System.Drawing.Size(882, 411);
            AlliancesTab.Text = "Alliances";
            AlliancesTab.ToolTipTitle = "Page ToolTip";
            AlliancesTab.UniqueName = "85de7ee0f90c4ed19e7b41275220da07";
            // 
            // PuppetsTab
            // 
            PuppetsTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            PuppetsTab.Flags = 65534;
            PuppetsTab.LastVisibleSet = true;
            PuppetsTab.MinimumSize = new System.Drawing.Size(150, 50);
            PuppetsTab.Name = "PuppetsTab";
            PuppetsTab.Size = new System.Drawing.Size(882, 411);
            PuppetsTab.Text = "Puppets";
            PuppetsTab.ToolTipTitle = "Page ToolTip";
            PuppetsTab.UniqueName = "13cd4886863148838a562ba050a3d46f";
            // 
            // WarsTab
            // 
            WarsTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            WarsTab.Flags = 65534;
            WarsTab.LastVisibleSet = true;
            WarsTab.MinimumSize = new System.Drawing.Size(150, 50);
            WarsTab.Name = "WarsTab";
            WarsTab.Size = new System.Drawing.Size(882, 411);
            WarsTab.Text = "Wars";
            WarsTab.ToolTipTitle = "Page ToolTip";
            WarsTab.UniqueName = "411940ec9a3b449ab6f000c4af887176";
            // 
            // InfoTab
            // 
            InfoTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            InfoTab.Flags = 65534;
            InfoTab.LastVisibleSet = true;
            InfoTab.MinimumSize = new System.Drawing.Size(150, 50);
            InfoTab.Name = "InfoTab";
            InfoTab.Size = new System.Drawing.Size(882, 411);
            InfoTab.Text = "Help and Info";
            InfoTab.ToolTipTitle = "Page ToolTip";
            InfoTab.UniqueName = "847c70162d194074a559299725d06422";
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            kryptonLabel12.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            kryptonLabel12.Location = new System.Drawing.Point(9, 446);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Size = new System.Drawing.Size(157, 20);
            kryptonLabel12.TabIndex = 4;
            kryptonLabel12.Values.Text = "Select output destination";
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            kryptonLabel13.Location = new System.Drawing.Point(9, 495);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new System.Drawing.Size(63, 20);
            kryptonLabel13.TabIndex = 5;
            kryptonLabel13.Values.Text = "Export as:";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            kryptonLabel6.AutoSize = false;
            kryptonLabel6.Location = new System.Drawing.Point(9, 521);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new System.Drawing.Size(215, 36);
            kryptonLabel6.TabIndex = 7;
            kryptonLabel6.Values.Text = "Shift + click to set destination \r\nto the appropriate game folder folder\r\n";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            kryptonLabel7.AutoSize = false;
            kryptonLabel7.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            kryptonLabel7.Location = new System.Drawing.Point(530, 446);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new System.Drawing.Size(94, 20);
            kryptonLabel7.TabIndex = 8;
            kryptonLabel7.Values.Text = "New file name";
            // 
            // DarkMode
            // 
            DarkMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            DarkMode.Location = new System.Drawing.Point(833, 446);
            DarkMode.Name = "DarkMode";
            DarkMode.Size = new System.Drawing.Size(50, 20);
            DarkMode.TabIndex = 10;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new System.Drawing.Point(328, 495);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(90, 25);
            kryptonButton1.TabIndex = 12;
            kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new System.Drawing.Point(672, 528);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new System.Drawing.Size(90, 25);
            kryptonButton2.TabIndex = 13;
            kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            kryptonButton2.Values.Text = "kryptonButton2";
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new System.Drawing.Point(745, 508);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new System.Drawing.Size(90, 25);
            kryptonButton3.TabIndex = 14;
            kryptonButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            kryptonButton3.Values.Text = "kryptonButton3";
            // 
            // kryptonButton4
            // 
            kryptonButton4.Location = new System.Drawing.Point(667, 469);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new System.Drawing.Size(90, 25);
            kryptonButton4.TabIndex = 15;
            kryptonButton4.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            kryptonButton4.Values.Text = "kryptonButton4";
            // 
            // kryptonButton5
            // 
            kryptonButton5.Location = new System.Drawing.Point(412, 446);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.Size = new System.Drawing.Size(93, 30);
            kryptonButton5.TabIndex = 16;
            kryptonButton5.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            kryptonButton5.Values.Text = "kryptonButton5";
            // 
            // kryptonButton6
            // 
            kryptonButton6.Location = new System.Drawing.Point(305, 464);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.Size = new System.Drawing.Size(90, 25);
            kryptonButton6.TabIndex = 17;
            kryptonButton6.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            kryptonButton6.Values.Text = "kryptonButton6";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new System.Drawing.Point(9, 472);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new System.Drawing.Size(400, 23);
            kryptonTextBox1.TabIndex = 18;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new System.Drawing.Point(8, 30);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new System.Drawing.Size(400, 23);
            kryptonTextBox2.TabIndex = 19;
            kryptonTextBox2.Text = "kryptonTextBox2";
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.Location = new System.Drawing.Point(346, 530);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new System.Drawing.Size(100, 23);
            kryptonTextBox3.TabIndex = 20;
            kryptonTextBox3.Text = "kryptonTextBox3";
            // 
            // V5UI
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(884, 561);
            Controls.Add(kryptonTextBox3);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonButton6);
            Controls.Add(kryptonButton5);
            Controls.Add(kryptonButton4);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(DarkMode);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonLabel13);
            Controls.Add(kryptonLabel12);
            Controls.Add(TabSelect);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(900, 600);
            Name = "V5UI";
            Text = "Advanced Save and Scenario Editor";
            ((System.ComponentModel.ISupportInitialize)TabSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoadTab).EndInit();
            LoadTab.ResumeLayout(false);
            LoadTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NationsTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)CitiesTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlliancesTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)PuppetsTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarsTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoTab).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Krypton.Toolkit.KryptonManager kryptonManager1;
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
        private Krypton.Toolkit.KryptonToggleSwitch DarkMode;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
    }
}
