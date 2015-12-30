// Main Menu
// This is the form that loads when you start the program!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LevelGenerator;

namespace HumphreyErik2424RST
{
    public partial class frmSplashScreen : Form
    {
        Random rnd = new Random();
        int levelIndex;

        public frmSplashScreen()
        {
            InitializeComponent();
        }

        // Display a description of a button's function when moused over

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            grpMainMenu.Text = "Play the game";
        }

        private void btnResetGame_MouseEnter(object sender, EventArgs e)
        {
            grpMainMenu.Text = "Clear local save data";
        }

        private void btnCheats_MouseEnter(object sender, EventArgs e)
        {
            grpMainMenu.Text = "Configure the game and enable cheats";
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            grpMainMenu.Text = "Close the program";
        }

        // Reset groupBox title when not mousing over a button

        private void MenuButtons_MouseLeave(object sender, EventArgs e)
        {
            grpMainMenu.Text = "Main Menu";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the program
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Open the level progression form
            // frmProgression Progression = new frmProgression();
            // Progression.Show();

            LevelGenerator.LevelGen.NewLevel(); // Open a random level - Call the "level generator" method from its class
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            LevelGen.difficulty = 1;
            frmBattle Battle = new frmBattle();
            Battle.Show();
            this.Hide();
        }
    }
}
