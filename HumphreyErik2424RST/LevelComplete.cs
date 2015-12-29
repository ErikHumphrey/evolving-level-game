using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumphreyErik2424RST;

namespace HumphreyErik2424RST
{
    public partial class LevelComplete : Form
    {
        public LevelComplete()
        {
            InitializeComponent();
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            LevelGenerator.LevelGen.NewLevel();
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            DialogResult wantsToStop = MessageBox.Show("Are you sure you want to return to the main menu?\r\n\r\nProgress up to this point has been saved.", "Confirm return", MessageBoxButtons.YesNo);
            if (wantsToStop == DialogResult.Yes)
            {
                this.Hide();
                frmSplashScreen menu = new frmSplashScreen();
                menu.Show();
            }
        }
    }
}
