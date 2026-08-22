using Krypton.Toolkit;
using System.Drawing;

namespace AoC_Advanced_Scenario_Editor
{
    public partial class V5UI : KryptonForm
    {
        int CurrentPage = 1;

        public V5UI()
        {
            InitializeComponent();
        }

        private void ThemeChange(object sender, Krypton.Navigator.KryptonPageEventArgs e)
        {
            if (e.Index != 0)
            {
                CurrentPage = TabSelect.SelectedIndex;
                return;
            }

            if (TabSelect.Pages[0].Text == "☼")
            {
                Theme.GlobalPaletteMode = PaletteMode.Microsoft365White;
                TabSelect.StateSelected.CheckButton.Back.Color1 = Color.FromArgb(255, 192, 128);
                TabSelect.StateSelected.CheckButton.Back.Color2 = Color.LightGray;
                TabSelect.Pages[0].Text = "●";
            }
            else
            {
                Theme.GlobalPaletteMode = PaletteMode.Microsoft365BlackDarkModeAlternate;
                TabSelect.StateSelected.CheckButton.Back.Color1 = Color.FromArgb(192, 64, 0);
                TabSelect.StateSelected.CheckButton.Back.Color2 = Color.DimGray;
                TabSelect.Pages[0].Text = "☼";
            }

            TabSelect.SelectedIndex = CurrentPage;
        }
    }
}
