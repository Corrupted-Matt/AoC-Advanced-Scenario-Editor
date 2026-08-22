using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AoC_Advanced_Scenario_Editor
{
    public partial class FlagSelect : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int FlagID { get; set; }

        public FlagSelect(Bitmap Flags)
        {
            InitializeComponent();

            Size = new Size(Flags.Width + 16, Flags.Height + 39);
            pictureBox1.Image = Flags;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            FlagID = 10 * (e.X / 36) + 10 - (e.Y / 24);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
