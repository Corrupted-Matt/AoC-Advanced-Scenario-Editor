using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AoC_Advanced_Scenario_Editor
{
    public partial class App : Form
    {
        JsonNode origin;
        bool LoadingFinished = false;
        readonly Point[] reticle = new Point[8];
        Bitmap flags;
        Bitmap[] maps;
        // 0. Terrain   1. De Facto  2. De Jure
        // 3. De Facto Cities (4. Exportable)
        // 5. De Jure Cities (6. Exportable)

        List<int>
                TerrainRaw = [], TerrainAmounts = [], TerrainValues = [],
                OwnerRaw = [], OwnerAmounts = [], OwnerValues = [],
                OccupationsRaw = [], OccupationsAmounts = [], OccupationsValues = [];

        public App()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

            reticle[0] = new Point(0, 3);
            reticle[1] = new Point(0, 2);
            reticle[2] = new Point(0, -2);
            reticle[3] = new Point(0, -3);
            reticle[4] = new Point(2, 0);
            reticle[5] = new Point(3, 0);
            reticle[6] = new Point(-2, 0);
            reticle[7] = new Point(-3, 0);

            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\JoySparkGames\\Ages of Conflict"))
                DestinationInput.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\JoySparkGames\\Ages of Conflict\\Custom Scenarios";
        }

        #region Universal

        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            string name = NameSelection.Text;
            string destination = DestinationInput.Text;

            if (name == "" || destination == "")
            {
                foreach (Control t in Controls)
                {
                    if (t is TextBox && t.Text == "") t.Focus();
                }
                SystemSounds.Hand.Play();
                MessageBox.Show("Please provide a name and output destination");
                return;
            }

            if(origin == null)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Please load a scenario first");
                return;
            }

            if(Directory.Exists(destination + $"\\{name}"))
            {
                SystemSounds.Hand.Play();
                if (MessageBox.Show("A save/scenario with this name already exists, do you wish to overwrite it?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
                else
                    Directory.Delete(destination + $"\\{name}", true);
            }
                   
            GenerateButton.Enabled = false;
            GenerateButton.Text = "Please\nwait";

            RemoveObsoleteObjects();

            Directory.CreateDirectory(destination + $"\\{name}");
            if (File.Exists(Directory.GetParent(ScenarioInput.Text) + "\\flags.png"))
                File.Copy(Directory.GetParent(ScenarioInput.Text) + "\\flags.png", destination + $"\\{name}\\flags.png");
            if (File.Exists(Directory.GetParent(ScenarioInput.Text) + "\\flagNames.txt"))
                File.Copy(Directory.GetParent(ScenarioInput.Text) + "\\flagNames.txt", destination + $"\\{name}\\flagNames.txt");

            await Task.Run(() =>
            {
                if(ExportAsScenario.Checked)
                    File.WriteAllText(destination + $"\\{name}\\{name}.aoc", origin.ToJsonString());
                else
                    File.WriteAllText(destination + $"\\{name}\\save.aoc", origin.ToJsonString());
            });

            SystemSounds.Beep.Play();
            MessageBox.Show("Your scenario has been exported successfully");
            GenerateButton.Enabled = true;
            GenerateButton.Text = "Export\nscenario";
        }

        private void DestinationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DestinationSelectDialog = new();
            if (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) != "")
                DestinationSelectDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\JoySparkGames\\Ages of Conflict\\Custom Scenarios";
            if (DestinationSelectDialog.ShowDialog() == DialogResult.OK)
                DestinationInput.Text = DestinationSelectDialog.SelectedPath;
        }

        private void ExportTypeChanged(object sender, EventArgs e)
        {

        }

        private void RunGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "steam://rungameid/2186320",
                    UseShellExecute = true
                });
            }
            catch
            {
                RunGameButton.Enabled = false;
                SystemSounds.Hand.Play();
                MessageBox.Show("No Steam installation detected");
            }
        }

        #endregion

        #region Load Tab

        public void LoadScenario_Click(object sender, EventArgs e)
        { 
            if(LoadingFinished)
                if(MessageBox.Show("Reloading will discard all of your changes, are you sure you want to reload?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;               

            if (!File.Exists(ScenarioInput.Text))
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Required field is empty or invalid");
                ScenarioInput.Focus();
                return;
            }

            LoadingFinished = false;
            TabSelect.Enabled = false;
            LoadScenario.Text = "Loading...";


            origin = JsonNode.Parse(File.ReadAllText(ScenarioInput.Text))
                ?? throw new Exception("Scenario parsing error. Please select a .aoc file");

            if (File.Exists(Directory.GetParent(ScenarioInput.Text) + "\\flags.png"))
                flags = (Bitmap)Bitmap.FromFile(Directory.GetParent(ScenarioInput.Text) + "\\flags.png");

            PopulateForm(origin);

            LoadingFinished = true;
            TabSelect.Enabled = true;
            LoadScenario.Text = "Reload scenario";
            LoadScenario.ForeColor = System.Drawing.Color.Black;            
        }

        private void ScenarioBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ScenarioSelectDialog = new()
            {
                Filter = "AoC Scenario Files|*.aoc"
            };
            if (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) != "")
                ScenarioSelectDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\JoySparkGames\\Ages of Conflict\\Custom Scenarios";
            if (ScenarioSelectDialog.ShowDialog() == DialogResult.OK)
                ScenarioInput.Text = ScenarioSelectDialog.FileName;
        }

        private void ExportImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog ExportMapDialog = new()
            {
                Filter = "Image|*.png"
            };
            if(ExportMapDialog.ShowDialog() == DialogResult.OK)
            {
                if(!ShowCities.Checked)
                {
                    HomePreview.BackgroundImage.Save(ExportMapDialog.FileName);
                    return;
                }

                if (MainMapSelect.SelectedIndex == 2) maps[6].Save(ExportMapDialog.FileName);
                else maps[4].Save(ExportMapDialog.FileName);
            }
        }

        private void ReloadRequired(object sender, EventArgs e)
        {
            if(!LoadingFinished)
                return;

            if(LoadScenario.Text=="Reload scenario")
            {
                LoadScenario.Text = "Reload required";
                LoadScenario.ForeColor = System.Drawing.Color.Red;
                return;
            }

            LoadScenario.Text = "Reload scenario";
            LoadScenario.ForeColor = System.Drawing.Color.Black;
        }

        private void UpdateStats(JsonNode Scenario)
        {
            GameVerLabel.Text = (string)Scenario["version"];
            GameVerLabel.Visible = true;
            ScenarioSizeLabel.Text = $"{Scenario["width"]}\n{Scenario["height"]}";
            ScenarioSizeLabel.Visible = true;
            ScenarioStatsLabel.Text = $"{Scenario["nations"].AsArray().Count}\n{Scenario["cities"].AsArray().Count}\n{Scenario["alliances"].AsArray().Count}\n{Scenario["wars"].AsArray().Count}";
            ScenarioStatsLabel.Visible = true;
        }

        private void UpdateMainMap(object sender, EventArgs e)
        {
            if (maps == null)
                return;

            switch(MainMapSelect.SelectedIndex)
            {
                case 0:
                    HomePreview.BackgroundImage = maps[0];
                    break;
                case 1:
                    HomePreview.BackgroundImage = maps[1];
                    break;
                case 2:
                    HomePreview.BackgroundImage = maps[2];
                    break;
            }

            ShowCities_CheckedChanged(null, null);
        }

        private void DateChanged(object sender, EventArgs e)
        {
            if (!LoadingFinished)
                return;
            DateTime current = new((int)CurrentYear.Value, CurrentMonth.SelectedIndex + 1, (int)CurrentDay.Value);
            origin["startingYear"] = StartingYear.Value;
            origin["startingMonth"] = StartingMonth.SelectedIndex;
            origin["currentGameTime"] = GetAocTime(current.AddDays((int)StartingDay.Value));
            return;
        }

        private void ShowCities_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCities.Checked)
            {
                ExportImgInfo.Text = "Will only export cities.\nUncheck to export selected map.";
                if (maps == null)
                    return;
                if(MainMapSelect.SelectedIndex == 2) HomePreview.Image = maps[5];
                else HomePreview.Image = maps[3];
            }
            
            else
            {
                ExportImgInfo.Text = "Will export without cities.\nCheck to export cities separately.";
                HomePreview.Image = null;
            }
        }

        #endregion

        #region Nations Tab

        private void UpdateNations(JsonNode Scenario)
        {
            Color current;

            NationsTable.Rows.Clear();
            WarNationSelect.Rows.Clear();
            CityRightfulOwner.Items.Clear();
            CityRightfulOwner.Items.Add("[No one]");
            PuppetsTable.Rows.Clear();
            PuppetMasterSelect.Items.Clear();
            PuppetMasterSelect.Items.Add("[No one]");

            foreach (var n in Scenario["nations"].AsArray())
            {
                current = Color.FromArgb((int)(((float)n["color"]["r"]) * 255), (int)((float)n["color"]["g"] * 255), (int)((float)n["color"]["b"] * 255));
                NationsTable.Rows.Add((int)n["id"], (string)n["name"], $"#{current.R:X2}{current.G:X2}{current.B:X2}");
                NationsTable.Rows[(int)n["id"] - 1].Cells[2].Style.BackColor = current;

                PuppetsTable.Rows.Add((int)n["id"], (string)n["name"]);
                WarNationSelect.Rows.Add((int)n["id"], (string)n["name"]);

                CityRightfulOwner.Items.Add((string)n["name"]);
                PuppetMasterSelect.Items.Add((string)n["name"]);
            }
        }

        private void NationsTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!LoadingFinished) return;

            LoadingFinished = false;
            JsonNode n = origin["nations"][(int)NationsTable.Rows[e.RowIndex].Cells[0].Value - 1];
            int x = (int)n["pos"]["x"];
            int y = (int)n["pos"]["y"];
            NationPreview.Image = DrawZoomedMap(origin,x,y);

            CapitalSelect.Items.Clear();
            foreach (var c in origin["cities"].AsArray())
            {
                if(OwnerRaw[(int)origin["width"] * (int)c["y"] + (int)c["x"]] == (int)n["id"] ||
                    OccupationsRaw[(int)origin["width"] * (int)c["y"] + (int)c["x"]] == (int)n["id"])
                {
                    CapitalSelect.Items.Add($"[{(int)c["x"]}|{(int)c["y"]}] {c["n"]}");

                    if((int)c["x"] == x && (int)c["y"] == y)
                        CapitalSelect.SelectedIndex = CapitalSelect.Items.Count - 1;
                }
            }

            SetGold.Value = (int)n["storedBns"];
            SetBonus.Value = (int)n["customBns"];
            SetCE.Value = 6 - (decimal)n["combatEfficiency"] * (decimal)0.5;
            SetSyear.Value = GetDate((float)n["startYear"]).Year;
            SetEyear.Value = GetDate((float)n["endYear"]).Year;
            DisableAI.Checked = (bool)n["aiDisabled"];
            ceLock.Checked = (bool)n["ceLock"];
            SetFlagID.Value = (int)n["flagId"];
            FlagPreview.Image = GetFlag((int)SetFlagID.Value);
            LoadingFinished = true;
        }

        private Bitmap GetFlag(int id)
        {
            if(id == 0) return null;

            int x = 36 * ((id - 1) / 10);
            int y = 24 * (9 - ((id - 1) % 10));
            Bitmap Flag = flags.Clone(new Rectangle(x, y, 36, 24), 0);
            Bitmap FlagUpscaled = new(144,96);

            using (Graphics g = Graphics.FromImage(FlagUpscaled))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(Flag, 0, 0, 144, 96);
            }

            return FlagUpscaled;
        }

        private void FlagPreview_Click(object sender, EventArgs e)
        {
            if (!LoadingFinished || flags == null)
                return;

            using var picker = new FlagSelect(flags);
            if(picker.ShowDialog() == DialogResult.OK && picker.FlagID <= SetFlagID.Maximum)
            {
                SetFlagID.Value = picker.FlagID;
            }
        }

        private void NationPreview_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = GetMapClickPos(NationsTable, NationPreview, e.X, e.Y);
            int x = p.X;
            int y = p.Y;

            if (x < 0) return;

            foreach (DataGridViewRow r in NationsTable.Rows)
                if ((int)r.Cells[0].Value == OwnerRaw[(int)origin["width"] * y + x])
                {
                    NationsTable.CurrentCell = r.Cells[0];
                    return;
                } 
        }

        private void ChangeNationColor(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2)
                return;

            JsonNode nation = origin["nations"].AsArray()[(int)NationsTable.CurrentRow.Cells[0].Value - 1];

            ColorPicker.Color = Color.FromArgb((int)((float)nation["color"]["r"]*255), (int)((float)nation["color"]["g"] * 255), (int)((float)nation["color"]["b"] * 255));
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                nation["color"]["r"] = (float)ColorPicker.Color.R / 255;
                nation["color"]["g"] = (float)ColorPicker.Color.G / 255;
                nation["color"]["b"] = (float)ColorPicker.Color.B / 255;

                NationsTable.Rows[e.RowIndex].Cells[2].Value = $"#{ColorPicker.Color.R:X2}{ColorPicker.Color.G:X2}{ColorPicker.Color.B:X2}";
                NationsTable.Rows[e.RowIndex].Cells[2].Style.BackColor = ColorPicker.Color;
                DrawGlobalMaps(origin);
                NationPreview.Image =  DrawZoomedMap(origin, (int)nation["pos"]["x"], (int)nation["pos"]["y"]);
            }
        }

        private void NationNameModified(object sender, DataGridViewCellEventArgs e)
        {
            if (!LoadingFinished)
                return;

            JsonNode nation = origin["nations"].AsArray()[(int)NationsTable.CurrentRow.Cells[0].Value - 1];

            nation["name"] = (string)NationsTable.CurrentRow.Cells[1].Value;
        }

        private void NationDetailsModified(object sender, EventArgs e)
        {
            if (!LoadingFinished)
                return;

            JsonNode nation = origin["nations"].AsArray()[(int)NationsTable.CurrentRow.Cells[0].Value - 1];

            if(sender == CapitalSelect)
            {
                nation["pos"]["x"] = int.Parse(CapitalSelect.SelectedItem.ToString().Split(['[', '|', ']'])[1]);
                nation["pos"]["y"] = int.Parse(CapitalSelect.SelectedItem.ToString().Split(['[', '|', ']'])[2]);
                nation["originalPos"]["x"] = int.Parse(CapitalSelect.SelectedItem.ToString().Split(['[', '|', ']'])[1]);
                nation["originalPos"]["y"] = int.Parse(CapitalSelect.SelectedItem.ToString().Split(['[', '|', ']'])[2]);

                DrawGlobalMaps(origin);
                NationPreview.Image = DrawZoomedMap(origin, (int)nation["pos"]["x"], (int)nation["pos"]["y"]);
                return;
            }

            
            nation["storedBns"] = (int)SetGold.Value;
            nation["customBns"] = (int)SetBonus.Value;
            nation["combatEfficiency"] = 2 * (6 - SetCE.Value);
            nation["startYear"] = GetAocTime(new DateTime((int)SetSyear.Value,1,1));
            nation["endYear"] = GetAocTime(new DateTime((int)SetEyear.Value, 1, 1));
            nation["aiDisabled"] = DisableAI.Checked;
            nation["ceLock"] = ceLock.Checked;
            nation["flagId"] = (int)SetFlagID.Value;

            if(sender == DisableAI && ModifierKeys == Keys.Control)
                foreach (var n in origin["nations"].AsArray())
                    n["aiDisabled"] = DisableAI.Checked;

            if (sender == ceLock && ModifierKeys == Keys.Control)
                foreach (var n in origin["nations"].AsArray())
                    n["ceLock"] = DisableAI.Checked;

            FlagPreview.Image = GetFlag((int)SetFlagID.Value);
        }

        private void SetToAll_Click(object sender, EventArgs e)
        {
            if(sender == SetGoldToAll)
                foreach (var nation in origin["nations"].AsArray())
                    nation["storedBns"] = (int)SetGold.Value;
            else if (sender == SetBonusToAll)
                foreach (var nation in origin["nations"].AsArray())
                    nation["customBns"] = (int)SetBonus.Value;
            else if (sender == SetCEToAll)
                foreach (var nation in origin["nations"].AsArray())
                    nation["combatEfficiency"] = 2 * (6 - SetCE.Value);
        }

        private void PasteNationNames_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will overwrite all nation names, as they're currently ordered, with ones from your clipboard, proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            int i = 0;
            string[] names = Clipboard.GetText().Split('\n');
            foreach (string n in names)
            {
                NationsTable.Rows[i].Cells[1].Value = n;
                origin["cities"].AsArray()[i]["name"] = n;
                i++;
                if (i == NationsTable.Rows.Count) break;
            }
        }

        #endregion

        #region Cities Tab

        private void UpdateCities(JsonNode Scenario)
        {
            LoadingFinished = false;
            CitiesTable.Rows.Clear();
            foreach (var c in Scenario["cities"].AsArray())
            {
                CitiesTable.Rows.Add((int)c["x"], (int)c["y"], c["n"]);
            }
            LoadingFinished = true;
        }

        private void CitiesTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!LoadingFinished)
                return;

            LoadingFinished = false;

            if (CitiesTable.Rows[e.RowIndex].IsNewRow && origin["cities"].AsArray().Count <= e.RowIndex)
            {
                var NewCity = new JsonObject
                {
                    ["x"] = 0,
                    ["y"] = 0,
                    ["n"] = "",
                    ["r"] = 0,
                    ["rp"] = 0
                };
                origin["cities"].AsArray().Add(NewCity);
                CitiesTable.Rows[e.RowIndex].SetValues(0, 0, "");
            }

            JsonNode city = origin["cities"].AsArray()[e.RowIndex];

            CityPreview.Image = DrawZoomedMap(origin, (int)city["x"], (int)city["y"]);
            CityRightfulOwner.SelectedIndex = (int)city["r"];
            CityRevoltChance.Value = (int)city["rp"];

            LoadingFinished = true;
        }

        private void CitiesTable_Sorted(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!LoadingFinished)
                return;


            JsonArray Cities = origin["cities"].AsArray();
            var SortedCities = new JsonArray();
            int s = e.RowIndex;

            switch (CitiesTable.SortedColumn.Index)
            {
                case 0:
                    if (CitiesTable.SortOrder == SortOrder.Ascending)
                        foreach (var city in Cities.OrderBy(city => (int)city["x"]))
                        {
                            SortedCities.Add(city.DeepClone());
                        }
                    else
                        foreach (var city in Cities.OrderByDescending(city => (int)city["x"]))
                        {
                            SortedCities.Add(city.DeepClone());
                        }
                    break;
                case 1:
                    if (CitiesTable.SortOrder == SortOrder.Ascending)
                        foreach (var city in Cities.OrderBy(city => (int)city["y"]))
                        {
                            SortedCities.Add(city.DeepClone());
                        }
                    else
                        foreach (var city in Cities.OrderByDescending(city => (int)city["y"]))
                        {
                            SortedCities.Add(city.DeepClone());
                        }
                    break;
                case 2:
                    if (CitiesTable.SortOrder == SortOrder.Ascending)
                        foreach (var city in Cities.OrderBy(city => (string)city["n"]))
                        {
                            SortedCities.Add(city.DeepClone());
                        }
                    else
                        foreach (var city in Cities.OrderByDescending(city => (string)city["n"]))
                        {
                            SortedCities.Add(city.DeepClone());
                        }
                    break;
            }

            origin["cities"] = SortedCities;
        }

        private void CityPreview_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = GetMapClickPos(CitiesTable, CityPreview, e.X, e.Y);
            int x = p.X;
            int y = p.Y;

            if (x < 0) return;

            if(ModifierKeys == Keys.Shift)
            {
                foreach (var c in origin["cities"].AsArray())
                {
                    if ((int)c["x"] == x && (int)c["y"] == y)
                    {
                        CitiesTable.CurrentCell = CitiesTable.Rows[c.GetElementIndex()].Cells[2];
                        return;
                    }
                }
            }

            foreach (var c in origin["cities"].AsArray())
            {
                if (Math.Pow((int)c["x"] - x,2) + Math.Pow((int)c["y"] - y,2) < 4)
                {
                    CitiesTable.CurrentCell = CitiesTable.Rows[c.GetElementIndex()].Cells[2];
                    return;
                }
            }
        }

        private void CityNameOrPosModified(object sender, DataGridViewCellEventArgs e)
        {
            if (!LoadingFinished)
                return;

            JsonNode city = origin["cities"].AsArray()[e.RowIndex];

            if (e.ColumnIndex == 2)
            {
                city["n"] = CitiesTable.CurrentRow.Cells[2].Value.ToString();
                return;
            }
                
            foreach (var n in origin["nations"].AsArray())
            {
                if ((int)n["pos"]["x"] == (int)city["x"] && (int)n["pos"]["y"] == (int)city["y"])
                {
                    n["pos"]["x"] = int.Parse(CitiesTable.CurrentRow.Cells[0].Value.ToString());
                    n["pos"]["y"] = int.Parse(CitiesTable.CurrentRow.Cells[1].Value.ToString());
                    n["originalPos"]["x"] = int.Parse(CitiesTable.CurrentRow.Cells[0].Value.ToString());
                    n["originalPos"]["y"] = int.Parse(CitiesTable.CurrentRow.Cells[1].Value.ToString());
                }
            }
            
            city["x"] = int.Parse(CitiesTable.CurrentRow.Cells[0].Value.ToString());
            city["y"] = int.Parse(CitiesTable.CurrentRow.Cells[1].Value.ToString());

            DrawGlobalMaps(origin);
            CityPreview.Image = DrawZoomedMap(origin, (int)city["x"], (int)city["y"]);
        }

        private void CityDetailsModified(object sender, EventArgs e)
        {
            if (!LoadingFinished || CitiesTable.CurrentRow.Index == origin["cities"].AsArray().Count)
                return;

            JsonNode city = origin["cities"].AsArray()[CitiesTable.CurrentRow.Index];

            if(sender == CityRevoltChance)
            {
                city["rp"] = (int)CityRevoltChance.Value;
                return;
            }

            city["r"] = CityRightfulOwner.SelectedIndex;

            DrawGlobalMaps(origin);
            CityPreview.Image = DrawZoomedMap(origin, (int)city["x"], (int)city["y"]);
        }

        private void CitiesTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if(!LoadingFinished) return;

            origin["cities"].AsArray().RemoveAt(e.RowIndex);
            //UpdateCities(origin);
            DrawGlobalMaps(origin);
        }

        private void SetCoreToSelf_Click(object sender, EventArgs e)
        {
            if (!LoadingFinished)
                return;

            JsonNode city = origin["cities"].AsArray()[CitiesTable.CurrentRow.Index];
            int n = OwnerRaw[(int)origin["width"] * (int)city["y"] + (int)city["x"]];
            CityRightfulOwner.SelectedIndex = n;

            switch (ModifierKeys)
            {
                case Keys.Shift:
                    foreach (var c in origin["cities"].AsArray())
                    {
                        if (n == OwnerRaw[(int)origin["width"] * (int)c["y"] + (int)c["x"]])
                            c["r"] = n;
                    }
                    break;

                case Keys.Control:
                    foreach (var c in origin["cities"].AsArray())
                    {
                        c["r"] = n;
                    }
                    break;

                default:
                    city["r"] = n;
                    break;
            }

            DrawGlobalMaps(origin);
            CityPreview.Image = DrawZoomedMap(origin, (int)city["x"], (int)city["y"]);
        }

        private void RemoveCore_Click(object sender, EventArgs e)
        {
            if (!LoadingFinished)
                return;

            JsonNode city = origin["cities"].AsArray()[CitiesTable.CurrentRow.Index];
            int n = OwnerRaw[(int)origin["width"] * (int)city["y"] + (int)city["x"]];
            CityRightfulOwner.SelectedIndex = 0;

            switch (ModifierKeys)
            {
                case Keys.Shift:
                    foreach (var c in origin["cities"].AsArray())
                    {
                        if (n == OwnerRaw[(int)origin["width"] * (int)c["y"] + (int)c["x"]])
                            c["r"] = 0;
                    }
                    break;

                case Keys.Control:
                    foreach (var c in origin["cities"].AsArray())
                    {
                        c["r"] = 0;
                    }
                    break;

                default:
                    city["r"] = 0;
                    break;
            }

            DrawGlobalMaps(origin);
            CityPreview.Image = DrawZoomedMap(origin, (int)city["x"], (int)city["y"]);
        }

        private void PasteCityNames_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will overwrite all ctiy names, as they're currently ordered, with ones from your clipboard, proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            int i = 0;
            string[] names = Clipboard.GetText().Split('\n');
            foreach (string n in names)
            {
                CitiesTable.Rows[i].Cells[2].Value = n;
                origin["cities"].AsArray()[i]["name"] = n;
                i++;
                if (i == CitiesTable.Rows.Count) break;
            }
        }

        #endregion

        #region Alliances Tab

        private void UpdateAlliances(JsonNode Scenario)
        {
            LoadingFinished = false;

            Color current;
            string members = "";
            int i = 0, loyalty;
            AlliancesTable.Rows.Clear();
            AllianceNationSelect.Rows.Clear();
            AllianceSelect.Items.Clear();
            AllianceSelect.Items.Add("[None]");

            foreach (var n in Scenario["nations"].AsArray())
            {
                if ((int)n["stress"] <= 2) loyalty = 0;
                else if ((int)n["stress"] <= 5) loyalty = 1;
                else loyalty = 2;
                AllianceNationSelect.Rows.Add((int)n["id"], n["name"], AllianceSelect.Items[0], AllianceLoyalty.Items[loyalty]);
            }

            foreach (var a in Scenario["alliances"].AsArray())
            {
                AllianceSelect.Items.Add((string)a["name"]);

                foreach (var n in a["ids"].AsArray())
                {
                    members += $"{origin["nations"].AsArray()[(int)n - 1]["name"]}, ";
                    AllianceNationSelect.Rows[(int)n - 1].Cells[2].Value = AllianceSelect.Items[i+1];
                }

                members = members.Trim([' ', ',']);

                current = Color.FromArgb((int)(((float)a["color"]["r"]) * 255), (int)((float)a["color"]["g"] * 255), (int)((float)a["color"]["b"] * 255));

                AlliancesTable.Rows.Add((string)a["name"], members, $"#{current.R:X2}{current.G:X2}{current.B:X2}");
                AlliancesTable.Rows[i].Cells[2].Style.BackColor = current;

                members = "";
                i++;
            }

            LoadingFinished = true;
        }

        private void AlliancesTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!LoadingFinished)
                return;

            LoadingFinished = false;

            if (AlliancesTable.Rows[e.RowIndex].IsNewRow && origin["alliances"].AsArray().Count <= e.RowIndex)
            {
                var NewAlliance = new JsonObject
                {
                    ["name"] = "",
                    ["color"] = new JsonObject { ["r"] = (float)0.0, ["g"] = (float)0.0, ["b"] = (float)0.0, ["a"] = (float)1.0 },
                    ["ids"] = new JsonArray(),
                    ["inUnion"] = false,
                    ["unity"] = (decimal)15.0,
                    ["ne"] = false,
                    ["ce"] = false
                };
                origin["alliances"].AsArray().Add(NewAlliance);
                AllianceSelect.Items.Add("");
                AlliancesTable.Rows[e.RowIndex].SetValues("","", "#000000");
                AlliancesTable.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.Black;
            }

            JsonNode alliance = origin["alliances"].AsArray()[e.RowIndex];
            
            Unity.Value = (decimal)alliance["unity"];
            IsUnion.Checked = (bool)alliance["inUnion"];

            LoadingFinished = true;
        }

        private void AlliancePreview_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = GetMapClickPos(AlliancesTable, AlliancePreview, e.X, e.Y);
            int x = p.X;
            int y = p.Y;

            if (x < 0) return;

            foreach (DataGridViewRow r in AllianceNationSelect.Rows)
                if ((int)r.Cells[0].Value == OwnerRaw[(int)origin["width"] * y + x])
                {
                    AllianceNationSelect.CurrentCell = r.Cells[0];
                    if (AllianceSelect.Items.IndexOf(r.Cells[2].Value) == 0) return;
                    AlliancesTable.CurrentCell = AlliancesTable.Rows[AllianceSelect.Items.IndexOf(r.Cells[2].Value) - 1].Cells[0];
                    return;
                }
        }

        private void AllianceModified(object sender, DataGridViewCellEventArgs e)
        {
            if (!LoadingFinished) return;

            if(sender == AlliancesTable)
            {
                origin["alliances"][e.RowIndex]["name"] = AlliancesTable.CurrentCell.Value.ToString();
                AllianceSelect.Items[e.RowIndex + 1] = AlliancesTable.CurrentCell.Value.ToString();
            }
            else if(e.ColumnIndex == 3)
            {
                int s = 0;
                switch(AlliancesTable.CurrentCell.Value)
                {
                    case "High":
                        s = 0;
                        break;
                    case "Medium":
                        s = 3;
                        break;
                    case "Low":
                        s = 6;
                        break;
                }

                origin["nations"].AsArray()[(int)AllianceNationSelect.CurrentRow.Cells[0].Value - 1]["stress"] = s;
                return;
            }
            else
            {
                foreach (var a in origin["alliances"].AsArray())
                {
                    a["ids"].AsArray().Remove(a["ids"].AsArray().FirstOrDefault(n => n.GetValue<int>() == (int)AllianceNationSelect.CurrentRow.Cells[0].Value));
                }
                
                if (AllianceSelect.Items.IndexOf(AllianceNationSelect.CurrentCell.Value) != 0)
                    origin["alliances"].AsArray()[AllianceSelect.Items.IndexOf(AllianceNationSelect.CurrentCell.Value) - 1]["ids"].AsArray().Add((int)AllianceNationSelect.CurrentRow.Cells[0].Value);
                
                DrawGlobalMaps(origin);
            }

            string members = "";
            foreach (var a in origin["alliances"].AsArray())
            {
                foreach (var n in a["ids"].AsArray())
                {
                    members += $"{origin["nations"].AsArray()[(int)n - 1]["name"]}, ";
                    AllianceNationSelect.Rows[(int)n - 1].Cells[2].Value = AllianceSelect.Items[a.GetElementIndex() + 1];
                }

                members = members.Trim([' ', ',']);
                AlliancesTable.Rows[a.GetElementIndex()].Cells[1].Value = members;
                members = "";
            }
        }

        private void AllianceDetailsModified(object sender, EventArgs e)
        {
            if (!LoadingFinished || AlliancesTable.CurrentRow.Index == origin["alliances"].AsArray().Count)
                return;

            JsonNode alliance = origin["alliances"].AsArray()[AlliancesTable.CurrentRow.Index];

            alliance["unity"] = Unity.Value;
            alliance["inUnion"] = IsUnion.Checked;
        }

        private void ChangeAllianceColor(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2 || e.RowIndex == AlliancesTable.RowCount - 1)
                return;

            JsonNode alliance = origin["alliances"].AsArray()[e.RowIndex];

            ColorPicker.Color = Color.FromArgb((int)((float)alliance["color"]["r"] * 255), (int)((float)alliance["color"]["g"] * 255), (int)((float)alliance["color"]["b"] * 255));
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                alliance["color"]["r"] = (float)ColorPicker.Color.R / 255;
                alliance["color"]["g"] = (float)ColorPicker.Color.G / 255;
                alliance["color"]["b"] = (float)ColorPicker.Color.B / 255;

                AlliancesTable.Rows[e.RowIndex].Cells[2].Value = $"#{ColorPicker.Color.R:X2}{ColorPicker.Color.G:X2}{ColorPicker.Color.B:X2}";
                AlliancesTable.Rows[e.RowIndex].Cells[2].Style.BackColor = ColorPicker.Color;
                DrawGlobalMaps(origin);
            }
        }

        private void AlliancesTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (!LoadingFinished) return;

            origin["alliances"].AsArray().RemoveAt(e.RowIndex);
            DrawGlobalMaps(origin);
        }

        #endregion

        #region Puppets Tab

        private void UpdatePuppets(JsonNode Scenario)
        {
            LoadingFinished = false;
            PuppetsOverview.Rows.Clear();
            string puppets = "";

            foreach (var n in Scenario["nations"].AsArray())
            {
                PuppetsTable.Rows[(int)n["id"] - 1].Cells[2].Value = PuppetMasterSelect.Items[(int)n["liegeId"]];

                if (n["puppetIds"].AsArray().Count == 0)
                    continue;

                foreach (var p in n["puppetIds"].AsArray())
                {
                    puppets += $"{Scenario["nations"].AsArray()[(int)p - 1]["name"]}, ";
                }
                puppets = puppets.Trim([' ', ',']);
                PuppetsOverview.Rows.Add((int)n["id"], (string)n["name"], puppets);

                puppets = "";
            }
            PuppetInfoSource = PuppetsTable;
            LoadingFinished = true;
        }

        private void PuppetsTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!LoadingFinished) return;

            LoadingFinished = false;
            PuppetInfoSource = sender as DataGridView;
            JsonNode nation = origin["nations"].AsArray()[(int)PuppetInfoSource.Rows[e.RowIndex].Cells[0].Value - 1];

            if (nation == null)
            {
                PuppetIntegration.Value = 0;
                PuppetAutonomy.Value = 0;
                PuppetLoyalty.Value = 0;
                PuppetAutonomyDesc.SelectedIndex = 0;
                PuppetLoyaltyDesc.SelectedIndex = 0;

                return;
            }

            PuppetIntegration.Enabled = nation["puppetIds"].AsArray().Count != 0;
            PuppetAutonomy.Enabled = (int)nation["liegeId"] != 0;
            PuppetAutonomyDesc.Enabled = (int)nation["liegeId"] != 0;
            PuppetLoyalty.Enabled = (int)nation["liegeId"] != 0;
            PuppetLoyaltyDesc.Enabled = (int)nation["liegeId"] != 0;

            PuppetIntegration.Value = (int)nation["puppetIntegration"];
            PuppetAutonomy.Value = (int)nation["puppetRank"];
            PuppetLoyalty.Value = (int)nation["puppetLoyalty"];

            if(PuppetAutonomy.Value < 50) PuppetAutonomyDesc.SelectedIndex = 0;
            else if(PuppetAutonomy.Value < 75) PuppetAutonomyDesc.SelectedIndex = 1;
            else PuppetAutonomyDesc.SelectedIndex = 2;

            if (PuppetLoyalty.Value < 30) PuppetLoyaltyDesc.SelectedIndex = 0;
            else if (PuppetLoyalty.Value <= 70) PuppetLoyaltyDesc.SelectedIndex = 1;
            else PuppetLoyaltyDesc.SelectedIndex = 2;
            LoadingFinished = true;
        }

        private void PuppetMasterModified(object sender, DataGridViewCellEventArgs e)
        {
            if (!LoadingFinished) return;

            var puppet = origin["nations"].AsArray()[(int)PuppetsTable.Rows[e.RowIndex].Cells[0].Value - 1];
            puppet["liegeId"] = PuppetMasterSelect.Items.IndexOf(PuppetsTable.CurrentCell.Value);

            foreach (DataGridViewRow r in PuppetsOverview.Rows)
            {
                if (r.Cells[2].Value.ToString().Contains((string)puppet["name"]))
                {
                    JsonArray p = origin["nations"].AsArray()[(int)r.Cells[0].Value - 1]["puppetIds"].AsArray();
                    p.Remove(p.FirstOrDefault(n => n.GetValue<int>() == (int)puppet["id"]));
                    break;
                }    
            }

            if ((int)puppet["liegeId"] != 0)
            {
                var master = origin["nations"].AsArray()[PuppetMasterSelect.Items.IndexOf(PuppetsTable.CurrentCell.Value) - 1];
                master["puppetIds"].AsArray().Add((int)puppet["id"].DeepClone());
            }

            PuppetsOverview.Rows.Clear();
            string puppets = "";
            foreach (var n in origin["nations"].AsArray())
            {
                if (n["puppetIds"].AsArray().Count == 0)
                    continue;

                foreach (var p in n["puppetIds"].AsArray())
                {
                    puppets += $"{origin["nations"].AsArray()[(int)p - 1]["name"]}, ";
                }
                puppets = puppets.Trim([' ', ',']);
                PuppetsOverview.Rows.Add((int)n["id"], (string)n["name"], puppets);

                puppets = "";
            }
        }

        DataGridView PuppetInfoSource;
        public void PuppetDetailsModified(object sender, EventArgs e)
        {
            if(!LoadingFinished || PuppetsTable.CurrentRow == null) return;

            var nation = origin["nations"].AsArray()[(int)PuppetInfoSource.CurrentRow.Cells[0].Value - 1];

            if(sender == PuppetAutonomyDesc)
            {
                switch(PuppetAutonomyDesc.SelectedIndex)
                {
                    case 0:
                        PuppetAutonomy.Value = 30;
                        nation["puppetRank"] = 30;
                        break;
                    case 1:
                        PuppetAutonomy.Value = 60;
                        nation["puppetRank"] = 60;
                        break;
                    case 2:
                        PuppetAutonomy.Value = 80;
                        nation["puppetRank"] = 80;
                        break;
                }
            }
            else if(sender == PuppetLoyaltyDesc)
            {
                switch (PuppetLoyaltyDesc.SelectedIndex)
                {
                    case 0:
                        PuppetLoyalty.Value = 15;
                        break;
                    case 1:
                        PuppetLoyalty.Value = 50;
                        break;
                    case 2:
                        PuppetLoyalty.Value = 80;
                        break;
                }
            }
            else
            {
                nation["puppetIntegration"] = (int)PuppetIntegration.Value;
                nation["puppetRank"] = (int)PuppetAutonomy.Value;
                nation["puppetLoyalty"] = (int)PuppetLoyalty.Value;

                if (PuppetAutonomy.Value < 50) PuppetAutonomyDesc.SelectedIndex = 0;
                else if (PuppetAutonomy.Value < 75) PuppetAutonomyDesc.SelectedIndex = 1;
                else PuppetAutonomyDesc.SelectedIndex = 2;

                if (PuppetLoyalty.Value < 30) PuppetLoyaltyDesc.SelectedIndex = 0;
                else if (PuppetLoyalty.Value <= 70) PuppetLoyaltyDesc.SelectedIndex = 1;
                else PuppetLoyaltyDesc.SelectedIndex = 2;
            }
        }

        #endregion

        #region Wars Tab

        private void UpdateWars(JsonNode Scenario)
        {
            LoadingFinished = false;
            string attackers = "", defenders = "";
            WarsTable.Rows.Clear();
            foreach (var w in Scenario["wars"].AsArray())
            {
                foreach (var a in w["attackersLeft"].AsArray())
                {
                    attackers += $"{Scenario["nations"].AsArray()[(int)a - 1]["name"]}, ";
                }
                foreach (var a in w["attackers"].AsArray())
                {
                    if (attackers.Contains((string)Scenario["nations"].AsArray()[(int)a - 1]["name"])) continue;
                    attackers += $"{Scenario["nations"].AsArray()[(int)a - 1]["name"]}*, ";
                }
                attackers = attackers.Trim([' ', ',']);

                foreach (var d in w["defendersLeft"].AsArray())
                {
                    defenders += $"{Scenario["nations"].AsArray()[(int)d - 1]["name"]}, ";
                }
                foreach (var d in w["defenders"].AsArray())
                {
                    if (defenders.Contains((string)Scenario["nations"].AsArray()[(int)d - 1]["name"])) continue;
                    defenders += $"{Scenario["nations"].AsArray()[(int)d - 1]["name"]}*, ";
                }
                defenders = defenders.Trim([' ', ',']);

                WarsTable.Rows.Add(attackers, defenders);
                attackers = ""; defenders = "";
            }
            LoadingFinished = true;
        }

        private void WarsTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoadingFinished = false;
            var nations = origin["nations"].AsArray();
            JsonNode w = origin["wars"][e.RowIndex];
            DateTime start = GetDate((float)w["startTime"]);
            DateTime end = GetDate((float)w["startTime"] + (float)w["targetLength"]);
            WarStartYear.Value = start.Year;
            WarStartMonth.SelectedIndex = start.Month - 1;
            WarStartDay.Value = start.Day;
            WarEndYear.Value = end.Year;
            WarEndMonth.SelectedIndex = end.Month - 1;
            WarEndDay.Value = end.Day;

            foreach (var n in origin["nations"].AsArray())
            {
                WarNationSelect.Rows[(int)n["id"] - 1].Cells[2].Value = Involvement.Items[0];
            }

            foreach (DataGridViewRow r in WarNationSelect.Rows)
            {
                if (w["attackers"].AsArray().FirstOrDefault(n => n.GetValue<int>() == (int)r.Cells[0].Value) != default)
                    r.Cells[2].Value = Involvement.Items[2];
                if (w["defenders"].AsArray().FirstOrDefault(n => n.GetValue<int>() == (int)r.Cells[0].Value) != default)
                    r.Cells[2].Value = Involvement.Items[4];
                if (w["attackersLeft"].AsArray().FirstOrDefault(n => n.GetValue<int>() == (int)r.Cells[0].Value) != default)
                    r.Cells[2].Value = Involvement.Items[1];
                if (w["defendersLeft"].AsArray().FirstOrDefault(n => n.GetValue<int>() == (int)r.Cells[0].Value) != default)
                    r.Cells[2].Value = Involvement.Items[3];
            }
            LoadingFinished = true;
        }

        private void WarParticipantsModified(object sender, DataGridViewCellEventArgs e)
        {
            if (!LoadingFinished) return;

            int a = 0, d = 0;
            string attackers = "", defenders = "";
            var war = origin["wars"].AsArray()[WarsTable.CurrentRow.Index];
            war["attackers"].AsArray().Clear();
            war["attackersLeft"].AsArray().Clear();
            war["defenders"].AsArray().Clear();
            war["defendersLeft"].AsArray().Clear();
            
            foreach(DataGridViewRow r in WarNationSelect.Rows)
            {
                switch (r.Cells[2].Value)
                {
                    case "Attacker":
                        war["attackers"].AsArray().Add(r.Cells[0].Value);
                        war["attackersLeft"].AsArray().Add(r.Cells[0].Value);
                        attackers += $"{origin["nations"].AsArray()[(int)r.Cells[0].Value - 1]["name"]}, ";
                        break;
                    case "Former attacker":
                        war["attackers"].AsArray().Add(r.Cells[0].Value);
                        attackers += $"{origin["nations"].AsArray()[(int)r.Cells[0].Value - 1]["name"]}*, ";
                        break;
                    case "Defender":
                        war["defenders"].AsArray().Add(r.Cells[0].Value);
                        war["defendersLeft"].AsArray().Add(r.Cells[0].Value);
                        defenders += $"{origin["nations"].AsArray()[(int)r.Cells[0].Value - 1]["name"]}, ";
                        break;
                    case "Former defender":
                        war["defenders"].AsArray().Add(r.Cells[0].Value);
                        defenders += $"{origin["nations"].AsArray()[(int)r.Cells[0].Value - 1]["name"]}*, ";
                        break;
                    default:
                        break;
                }
            }

            attackers = attackers.Trim([' ', ',']);
            defenders = defenders.Trim([' ', ',']);
            WarsTable.CurrentRow.Cells[0].Value = attackers;
            WarsTable.CurrentRow.Cells[1].Value = defenders;

            foreach (int p in OwnerRaw)
            {
                if (war["attackers"].AsArray().FirstOrDefault(n => n.GetValue<int>() == p) != default)
                    a++;
                if (war["defenders"].AsArray().FirstOrDefault(n => n.GetValue<int>() == p) != default)
                    d++;
            }

            war["aInitArea"] = a;
            war["dIntiArea"] = d;
        }

        private void WarDetailsModified(object sender, EventArgs e)
        {
            if (!LoadingFinished) return;

            JsonNode war = origin["wars"].AsArray()[WarsTable.CurrentRow.Index];

            DateTime start = new((int)WarStartYear.Value, WarStartMonth.SelectedIndex + 1, (int)WarStartDay.Value);
            DateTime end = new((int)WarEndYear.Value, WarEndMonth.SelectedIndex + 1, (int)WarEndDay.Value);

            if (sender == ToDeath)
            {
                end = GetDate((float)war["startTime"] + 10000);
                WarEndYear.Value = end.Year;
                WarEndMonth.SelectedIndex = end.Month - 1;
                WarEndDay.Value = end.Day;
                return;
            }

            if (GetAocTime(end) - GetAocTime(start) < 0)
            {
                end = start;
                WarEndYear.Value = end.Year;
                WarEndMonth.SelectedIndex = end.Month - 1;
                WarEndDay.Value = end.Day;
            }
                
            war["startTime"] = GetAocTime(start);
            war["targetLength"] = GetAocTime(end) - GetAocTime(start);
        }

        private void AddWar_Click(object sender, EventArgs e)
        {
            if (!LoadingFinished) return;

            var NewWar = new JsonObject
            {
                ["attackers"] = new JsonArray(),
                ["attackersLeft"] = new JsonArray(),
                ["defenders"] = new JsonArray(),
                ["defendersLeft"] = new JsonArray(),
                ["targetLength"] = (float)0,
                ["startTime"] = (float)0,
                ["aInitArea"] = (int)0,
                ["dIntiArea"] = (int)0,
            };

            origin["wars"].AsArray().Add(NewWar);
            WarsTable.Rows.Add("", "");
        }

        private void RemoveWar_Click(object sender, EventArgs e)
        {
            if (!LoadingFinished) return;

            for(int i = WarsTable.Rows.Count - 1; i >= 0; i--)
            {
                if (WarsTable.SelectedRows.Contains(WarsTable.Rows[i]))
                    origin["wars"].AsArray().RemoveAt(i);
            }
            UpdateWars(origin);
        }

        private void MergeWars_Click(object sender, EventArgs e)
        {
            if (!LoadingFinished || WarsTable.SelectedRows.Count < 2) return;

            var NewWar = new JsonObject
            {
                ["attackers"] = new JsonArray(),
                ["attackersLeft"] = new JsonArray(),
                ["defenders"] = new JsonArray(),
                ["defendersLeft"] = new JsonArray(),
                ["targetLength"] = (float)0,
                ["startTime"] = (float)0,
                ["aInitArea"] = (int)0,
                ["dIntiArea"] = (int)0,
            };

            for (int i = WarsTable.Rows.Count - 1; i >= 0; i--)
            {
                if (WarsTable.SelectedRows.Contains(WarsTable.Rows[i]))
                {
                    foreach (var n in origin["wars"].AsArray()[i]["attackers"].AsArray())
                        NewWar["attackers"].AsArray().Add(n.DeepClone());
                    foreach (var n in origin["wars"].AsArray()[i]["attackersLeft"].AsArray())
                        NewWar["attackersLeft"].AsArray().Add(n.DeepClone());
                    foreach (var n in origin["wars"].AsArray()[i]["defenders"].AsArray())
                        NewWar["defenders"].AsArray().Add(n.DeepClone());
                    foreach (var n in origin["wars"].AsArray()[i]["defendersLeft"].AsArray())
                        NewWar["defendersLeft"].AsArray().Add(n.DeepClone());

                    NewWar["startTime"] = Math.Min((float)NewWar["startTime"], (float)origin["wars"].AsArray()[i]["startTime"]);
                    NewWar["targetLength"] = Math.Max((float)NewWar["targetLength"], (float)origin["wars"].AsArray()[i]["targetLength"]);
                    NewWar["aInitArea"] = (int)NewWar["aInitArea"] + (int)origin["wars"].AsArray()[i]["aInitArea"];
                    NewWar["dIntiArea"] = (int)NewWar["dIntiArea"] + (int)origin["wars"].AsArray()[i]["dIntiArea"];
                    origin["wars"].AsArray().RemoveAt(i);
                } 
            }

            origin["wars"].AsArray().Add(NewWar);
            UpdateWars(origin);
        }

        #endregion

        #region Links
        private void ReadmeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Corrupted-Matt/AoC-Advanced-Scenario-Editor/tree/master#aoc-advanced-scenario-editor",
                UseShellExecute = true
            });
        }

        private void DiscordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://discord.gg/fv3EExm6KY",
                UseShellExecute = true
            });
        }

        private void ConverterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Corrupted-Matt/AoC-Image-to-Scenario-Converter/releases",
                UseShellExecute = true
            });
        }

        private void FlagEditorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/3minutesafter15hours/aocflaguploader/releases",
                UseShellExecute = true
            });
        }

        #endregion

        #region Utilities
        private void PopulateForm(JsonNode Scenario)
        {
            UpdateStats(Scenario);

            DateTime Starting = new((int)Scenario["startingYear"], (int)Scenario["startingMonth"] + 1, 1);
            DateTime Current = GetDate((float)Scenario["currentGameTime"]);
            StartingYear.Value = Starting.Year; StartingMonth.SelectedIndex = Starting.Month - 1; StartingDay.Value = Starting.Day;
            CurrentYear.Value = Current.Year; CurrentMonth.SelectedIndex = Current.Month - 1; CurrentDay.Value = Current.Day;
            SetFlagID.Maximum = origin["nations"].AsArray().Count;

            DrawGlobalMaps(Scenario);
            UpdateNations(Scenario);
            UpdateCities(Scenario);
            UpdateAlliances(Scenario);
            UpdatePuppets(Scenario);
            UpdateWars(Scenario);
           
        }

        private DateTime GetDate(float aocTime)
        {
            if (MonthScale.Checked) return new DateTime(int.Parse(origin["startingYear"].ToString()), int.Parse(origin["startingMonth"].ToString()) + 1, 1).AddMonths((int)((float)aocTime * 2));
            else return new DateTime(int.Parse(origin["startingYear"].ToString()), int.Parse(origin["startingMonth"].ToString()) + 1, 1).AddDays(aocTime * 7);
        }

        private float GetAocTime(DateTime date)
        {
            if (MonthScale.Checked) return (float)(date - GetDate(0)).TotalDays / 60;
            else return (float)(date - GetDate(0)).TotalDays / 7;
        }

        public void DrawGlobalMaps(JsonNode Scenario)
        {
            int i = 0, w = (int)Scenario["width"], h = (int)Scenario["height"];

            if (!LoadingFinished)
            {
                TerrainRaw = []; TerrainAmounts = []; TerrainValues = [];
                OwnerRaw = []; OwnerAmounts = []; OwnerValues = [];
                OccupationsRaw = []; OccupationsAmounts = []; OccupationsValues = [];

                TerrainAmounts = (List<int>)JsonSerializer.Deserialize(Scenario["terrain2"]["amounts"], typeof(List<int>));
                TerrainValues = (List<int>)JsonSerializer.Deserialize(Scenario["terrain2"]["values"], typeof(List<int>));
                OwnerAmounts = (List<int>)JsonSerializer.Deserialize(Scenario["owner2"]["amounts"], typeof(List<int>));
                OwnerValues = (List<int>)JsonSerializer.Deserialize(Scenario["owner2"]["values"], typeof(List<int>));
                OccupationsAmounts = (List<int>)JsonSerializer.Deserialize(Scenario["occupations"]["amounts"], typeof(List<int>));
                OccupationsValues = (List<int>)JsonSerializer.Deserialize(Scenario["occupations"]["values"], typeof(List<int>));
                                
                foreach (int a in TerrainAmounts)
                {
                    for (int n = 0; n < a; n++)
                    {
                        TerrainRaw.Add(TerrainValues[i]);
                    }
                    i++;
                }

                i = 0;
                foreach (int a in OwnerAmounts)
                {
                    for (int n = 0; n < a; n++)
                    {
                        OwnerRaw.Add(OwnerValues[i]);
                    }
                    i++;
                }

                i = 0;
                foreach (int a in OccupationsAmounts)
                {
                    for (int n = 0; n < a; n++)
                    {
                        OccupationsRaw.Add(OccupationsValues[i]);
                    }
                    i++;
                }
            }

            var nations = Scenario["nations"].AsArray();
            List<Color> cc = [Color.Transparent], ac = [Color.Transparent];
            int bc;
            
            foreach(var n in nations)
            {
                cc.Add(Color.FromArgb((int)(((float)n["color"]["r"]) * 255), (int)((float)n["color"]["g"] * 255), (int)((float)n["color"]["b"] * 255)));
                bc = Math.Max(Math.Max(cc[(int)n["id"]].R, cc[(int)n["id"]].G), cc[(int)n["id"]].B);
                ac.Add(Color.FromArgb(bc, bc, bc));
            }

            maps = null;
            maps = [new(w,h), new(w, h), new(w, h), new(w, h), new(w, h), new(w, h), new(w, h)];
            // 0. Terrain   1. De Facto  2. De Jure
            // 3. De Facto Cities (4. Exportable)
            // 5. De Jure Cities (6. Exportable)
            i = 0;

            for (int y = h - 1; y>=0; y--)
            {
                for(int x = 0; x < w; x++)
                {
                    switch(TerrainRaw[i])
                    {
                        case 0:
                            maps[0].SetPixel(x, y, Color.FromArgb(0xff,0xff,0xff));
                            break;
                        case 1:
                            maps[0].SetPixel(x, y, Color.FromArgb(0x00, 0x00, 0x00));
                            break;
                        case 2:
                            maps[0].SetPixel(x, y, Color.FromArgb(0xcc, 0xcc, 0xcc));
                            break;
                        case 3:
                            maps[0].SetPixel(x, y, Color.FromArgb(0x33, 0x33, 0x33));
                            break;
                        case 4:
                            maps[0].SetPixel(x, y, Color.FromArgb(0x66, 0x66, 0x66));
                            break;
                        case 5:
                            maps[0].SetPixel(x, y, Color.FromArgb(0x99, 0x99, 0x99));
                            break;
                        case 6:
                            maps[0].SetPixel(x, y, Color.FromArgb(0x1f, 0x1f, 0x1f));
                            break;
                        case 7:
                            maps[0].SetPixel(x, y, Color.FromArgb(0x80, 0x80, 0x80));
                            break;
                        case 8:
                            maps[0].SetPixel(x, y, Color.FromArgb(0x4c, 0x4c, 0x4c));
                            break;
                    }
                        
                    if (TerrainRaw[i] == 2)
                        maps[1].SetPixel(x, y, Color.FromArgb(100, cc[OwnerRaw[i]]));
                    else
                        maps[1].SetPixel(x, y, cc[OwnerRaw[i]]);

                    if (TerrainRaw[i] == 2)
                        maps[2].SetPixel(x, y, Color.FromArgb(0xcccccc));
                    else if (OccupationsRaw[i] == 0)
                        maps[2].SetPixel(x, y, cc[OwnerRaw[i]]);
                    else
                        maps[2].SetPixel(x,y, cc[OccupationsRaw[i]]);
                    i++;
                }
            }

            int cx, cy;
            
            foreach (var c in Scenario["cities"].AsArray())
            {
                cx = (int)c["x"]; cy = h - 1 - (int)c["y"];

                if (maps[1].GetPixel(cx, cy) == cc[(int)c["r"]])
                    maps[3].SetPixel(cx, cy, Color.FromArgb(0, 255, 0));
                else
                    maps[3].SetPixel(cx, cy, Color.FromArgb(255, 255, 0));

                if (maps[2].GetPixel(cx, cy) == cc[(int)c["r"]])
                    maps[5].SetPixel(cx, cy, Color.FromArgb(0, 255, 0));
                else
                    maps[5].SetPixel(cx, cy, Color.FromArgb(255, 255, 0));

                maps[4].SetPixel(cx, cy, cc[(int)c["r"]]);
                maps[6].SetPixel(cx, cy, cc[(int)c["r"]]);
            }

            foreach (var n in nations)
            {
                cx = (int)n["pos"]["x"]; cy = h - 1 - (int)n["pos"]["y"];
                
                if (!(bool)n["destroyed"])
                {
                    maps[3].SetPixel(cx, cy, Color.FromArgb(255, 0, 0));
                    maps[4].SetPixel(cx, cy, Color.FromArgb(255, 0, 0));
                }

                maps[5].SetPixel(cx, cy, Color.FromArgb(255, 0, 0));
                maps[6].SetPixel(cx, cy, Color.FromArgb(255, 0, 0));
            }

            UpdateMainMap(null,null);


            var alliances = Scenario["alliances"].AsArray();
            Bitmap AllianceMap = new(w, h);
            i = 0;

            foreach (var a in alliances)
            {
                foreach (var n in a["ids"].AsArray())
                {
                    ac[(int)n] = Color.FromArgb((int)(((float)a["color"]["r"]) * 255), (int)((float)a["color"]["g"] * 255), (int)((float)a["color"]["b"] * 255));
                }
            }

            for (int y = h - 1; y >= 0; y--)
            {
                for (int x = 0; x < w; x++)
                {
                    if (TerrainRaw[i] != 2)
                        AllianceMap.SetPixel(x, y, ac[OwnerRaw[i]]);
                    else
                        AllianceMap.SetPixel(x, y, Color.FromArgb(100, ac[OwnerRaw[i]]));
                    i++;
                }
            }
            AlliancePreview.Image = AllianceMap;
        }

        private Bitmap DrawZoomedMap(JsonNode Scenario, int CenterX, int CenterY)
        {
            int w = (int)Scenario["width"], h = (int)Scenario["height"];
            int minX = Math.Max(0, CenterX - 100), minY = Math.Max(0, h - 1 - CenterY - 50);
            int maxX = Math.Min(w, CenterX + 100), maxY = Math.Min(h, h - 1 - CenterY + 50);

            Bitmap minimap = maps[1].Clone(new Rectangle(minX, minY, maxX - minX, maxY - minY), 0);
            Bitmap cities = maps[3].Clone(new Rectangle(minX, minY, maxX - minX, maxY - minY), 0);

            for (int x = 0; x < minimap.Width; x++)
            {
                for (int y = 0; y < minimap.Height; y++)
                {
                    if (cities.GetPixel(x, y).A != 0)
                        minimap.SetPixel(x, y, cities.GetPixel(x, y));
                }
            }

            foreach (var p in reticle)
            {
                try
                {
                    minimap.SetPixel(CenterX - minX + p.X, h - 1 - CenterY - minY + p.Y, Color.Aqua);
                }
                catch {}
            }

            Bitmap minimapUpscaled = new(minimap.Width * 4, minimap.Height * 4);
            using (Graphics g = Graphics.FromImage(minimapUpscaled))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(minimap, 0, 0, minimap.Width * 4, minimap.Height * 4);
            }

            return minimapUpscaled;
        }

        private Point GetMapClickPos(DataGridView Table, PictureBox Box, int ClickX, int ClickY)
        {
            int w = (int)origin["width"], h = (int)origin["height"];
            int x, y, CenterX, CenterY, minX, maxX, minY, maxY;
            float Xoffset, Yoffset, scale;

            if (Table == NationsTable)
            {
                CenterX = (int)origin["nations"][Table.CurrentRow.Index]["pos"]["x"];
                CenterY = (int)origin["nations"][Table.CurrentRow.Index]["pos"]["y"];
            }
            else
            {
                CenterX = (int)origin["cities"][Table.CurrentRow.Index]["x"];
                CenterY = (int)origin["cities"][Table.CurrentRow.Index]["y"];
            }

            if (Table != AlliancesTable)
            {
                minX = Math.Max(0, CenterX - 100); minY = Math.Max(0, h - 1 - CenterY - 50);
                maxX = Math.Min(w, CenterX + 100); maxY = Math.Min(h, h - 1 - CenterY + 50);

                scale = Math.Min(Box.ClientSize.Width / (float)(maxX - minX), Box.ClientSize.Height / (float)(maxY - minY));
                Xoffset = (Box.ClientSize.Width - (maxX - minX) * scale) / 2; Yoffset = (Box.ClientSize.Height - (maxY - minY) * scale) / 2;

                x = (int)((ClickX - Xoffset) / scale + minX);
                y = (int)(h - 1 - ((ClickY - Yoffset) / scale + minY));

                if (x < 0 || x > w || y < 0 || y > h)
                    return new Point(-1, -1);

                return new Point(x, y);
            }

            scale = Math.Min(Box.ClientSize.Width / (float)w, Box.ClientSize.Height / (float)h);
            Xoffset = (Box.ClientSize.Width - w * scale) / 2; Yoffset = (Box.ClientSize.Height - h * scale) / 2;

            x = (int)((ClickX - Xoffset) / scale);
            y = (int)(h - 1 - ((ClickY - Yoffset) / scale));

            if (x < 0 || x > w || y < 0 || y > h)
                return new Point(-1, -1);

            return new Point(x, y);
        }

        private void DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //fuck you, I decide what's an error
        }

        private void RemoveObsoleteObjects()
        {
            if(origin["cities"].AsArray().Count == CitiesTable.Rows.Count)
                origin["cities"].AsArray().RemoveAt(CitiesTable.Rows.Count - 1);

            if(origin["alliances"].AsArray().Count == AlliancesTable.Rows.Count)
                origin["alliances"].AsArray().RemoveAt(AlliancesTable.Rows.Count - 1);

            while ((string)WarsTable.Rows[WarsTable.Rows.Count - 1].Cells[0].Value == "")
            {
                origin["wars"].AsArray().RemoveAt(WarsTable.Rows.Count - 1);
                WarsTable.Rows.RemoveAt(WarsTable.Rows.Count - 1);
            }  
        }

        #endregion
    }
}
