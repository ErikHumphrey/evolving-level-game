// Battle level: Pokémon battle clone without the monsters

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumphreyErik2424RST
{
    public partial class frmBattle : Form
    {
        public frmBattle()
        {
            InitializeComponent();
            // Add pictureboxes as parents of the panel so they show panel BackgroundImage behind them when transparent
            pnlTop.Controls.Add(picPortraitEnemy);
            pnlTop.Controls.Add(picPortraitPlayer);
        }

        private void Flee(object sender, EventArgs e)
        {
            DialogResult wantsToFlee = MessageBox.Show("Are you sure you want to flee from this fight?\r\n\r\nYou won't earn any points for this level.",
            "Confirm flee",
            MessageBoxButtons.YesNo);

            if (wantsToFlee == DialogResult.Yes)
            {
                this.Close(); // Exit the level
            }
        }
    }
}
