﻿// Main Menu
// This is the form that loads when you start the program!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text; 
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LevelGenerator;
using SaveGames;

namespace HumphreyErik2424RST
{
    public partial class frmSplashScreen : Form
    {
        Random rnd = new Random();
        int levelIndex;

        // Same custom font code featured in past projects
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();

        // New font
        Font labelText;

        public frmSplashScreen()
        {
            InitializeComponent();

            // Use font bundled in program resources
            byte[] fontData = Properties.Resources.menuFont;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.menuFont.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.menuFont.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            // Declare typeface properties
            labelText = new Font(fonts.Families[0], 11F);
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            //             LevelGen.saveGameExists = Convert.ToBoolean(LevelGen.loadGame.ReadLine());
            btnExit.Font = btnStart.Font = btnCheats.Font = btnResetGame.Font = lblSaveStatus.Font = lblButtonDescription.Font = labelText;
            // this.ActiveControl = txtNameEntry;
        }

        // Display a description of a button's function when moused over

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            lblButtonDescription.Text = "Play the game";
        }

        private void btnResetGame_MouseEnter(object sender, EventArgs e)
        {
            lblButtonDescription.Text = "Clear local save data";
        }

        private void btnCheats_MouseEnter(object sender, EventArgs e)
        {
            lblButtonDescription.Text = "Configure the game and enable cheats";
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            lblButtonDescription.Text = "Close the program";
        }

        // Reset groupBox title when not mousing over a button

        private void MenuButtons_MouseLeave(object sender, EventArgs e)
        {
            lblButtonDescription.Text = "Main Menu";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the program
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            LevelGen.difficulty = 1;
            frmBattle Battle = new frmBattle();
            Battle.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSaveStatus.Text = SaveSystem.name;
        }

        // It's not really easy to make the SaveSystem class load the name here, so we use a timer to check if the global variable has been changed.

        private void tmrSaveLoader_Tick(object sender, EventArgs e)
        {

        }
    }
}
