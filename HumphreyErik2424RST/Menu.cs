// Main Menu
// This is the form that loads when you start the program!

/*** CONCEPTS COVERED ***
 ** These are only some examples of where I applied each concept. **
 * Note 01: I made a GUI.
 * Note 02: I saved my project.
 * Note 03: I used all kinds of controls and used the proper naming conventions.
 * Note 04: Arithmetic is used in Battle to change progress bars.
 * Note 05: If you're reading this, I covered comments.
 * Note 06: Attempting to flee in Battle asks the player for confirmation
 * Note 07: Every class has variables of some sort.
 * Note 08: I casted variables.
 * Note 09: The level generator is random.
 * Note 10: Counters etc. are used in the Battle level when someone's HP changes
 * Note 11: I debugged the program so it runs pretty well. Oh, turns out we /were/ taught about breakpoints!
 * Note 12: I explained my code to a rubber duck in order to make it work.
 * Note 13: I drew the icons and created a lot of the graphics used in the program.
 * Note 14: I used if statements.
 * Note 15: The level generator uses switch statements to open a level based on what number is rolled
 * Note 16: When the enemy dies in Battle, movement makes it slide down and disappear and coordinates used for ability effects.
 * Note 17: Player names are converted to uppercase in Battle. Escape characters are used for quotes and in Flee MessageBox.
 * Note 18: NO, ended up not implementing graphics
 * Note 19: I used MouseClick events!
 * Note 20: A ComboBox is used to select the equipped item in Survival.
 * Note 21: I used a loop somewhere but can't remember where
 * Note 22: The level generator uses the NewLevel() public static method. When damage is dealt in Battle, a method is triggered.
 * Note 23: NO, keyboard events not used
 * Note 24: NO, try/catch not used
 * Note 25: Arrays used in Survival ? button
 * Note 26: NO, 2D arrays not used
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text; 
using System.Linq;
using System.Media;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using LevelGenerator;
using SaveGames;
using Upgrader;

namespace HumphreyErik2424RST
{
    public partial class frmSplashScreen : Form
    {
        Random rnd = new Random();

        // Same custom font code featured in past projects, referencing msdn
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
            // Attempt to create empty save game file (prevents crash if no such file exists)
            //TextWriter esgf = new StreamWriter("SaveGame.txt");
            //esgf.Close();

            // Read the first line on the SaveGame, convert it to a boolean to determine if a save game exists
            TextReader lsGameMaster = new StreamReader("SaveGame.txt");
            lsGameMaster.ReadLine();
            SaveSystem.saveGameExists = Convert.ToBoolean(lsGameMaster.ReadLine());
            lsGameMaster.Close();

            if (SaveSystem.saveGameExists)
            {
                // Load the existing save game. This could be done with one file, but it's a new concept to me so I used multiple.
                
                // Player name + saveGameExists boolean
                TextReader lsGame = new StreamReader("SaveGame.txt");
                SaveSystem.name = lsGame.ReadLine();
                btnResetGame.Enabled = true;
                btnStart.Text = "Continue game";
                lblSaveStatus.Text = "Loaded game: " + SaveSystem.name;
                lsGame.Close();

                // Shop upgrades

                TextReader upgLoad = new StreamReader("upgrades.txt");

                Upgrades.punchAbilityLevel = Int32.Parse(upgLoad.ReadLine());
                Upgrades.kickAbilityLevel = Int32.Parse(upgLoad.ReadLine());
                Upgrades.blindAbilityLevel = Int32.Parse(upgLoad.ReadLine());
                Upgrades.healAbilityLevel = Int32.Parse(upgLoad.ReadLine());

                Upgrades.axeAbilityLevel = Int32.Parse(upgLoad.ReadLine());
                Upgrades.fireAbilityLevel = Int32.Parse(upgLoad.ReadLine());
                Upgrades.fishAbilityLevel = Int32.Parse(upgLoad.ReadLine());
                Upgrades.cookAbilityLevel = Int32.Parse(upgLoad.ReadLine());

                upgLoad.Close();
            }
            else
            {
                lblSaveStatus.Text = "No game loaded";
                btnStart.Text = "New game";
            }
          
            // Set the font of chosen controls to be the custom font
            btnExit.Font
            = btnStart.Font
            = btnOptions.Font
            = btnResetGame.Font
            = lblSaveStatus.Font
            = lblButtonDescription.Font
            = labelText;


            
            // this.ActiveControl = txtNameEntry;
        }

        // Display a description of a button's function when moused over

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            if (btnStart.Text == "New game")
               lblButtonDescription.Text = "Play the game";
            else if (btnStart.Text == "Continue game")
               lblButtonDescription.Text = "Continue your adventure";
        }

        private void btnResetGame_MouseEnter(object sender, EventArgs e)
        {
            lblButtonDescription.Text = "Clear local save data";
        }

        private void btnCheats_MouseEnter(object sender, EventArgs e)
        {
            lblButtonDescription.Text = "Configure the game";
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

        private void btnOptions_MouseEnter(object sender, EventArgs e)
        {
            lblButtonDescription.Text = "Configure the game";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the program
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Continue game")
            {
                // Generate a random level. See LevelGenerator.cs
                LevelGen.NewLevel();
            }
            else if (btnStart.Text == "New game")
            {
                // SaveSystem.cs
                SaveSystem.SaveLoader();
                this.Hide();
            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            LevelGen.difficulty = 1;
            frmBattle Battle = new frmBattle();
            Battle.Show();
            this.Hide();
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            DialogResult wantsToReset = MessageBox.Show(
                "Are you sure you want to reset ALL data? This is irreversible.",
                "Confirm reset", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (wantsToReset == DialogResult.Yes)
            {
                // Delete the existing save
                File.Delete("SaveGame.txt");
                File.Delete("upgrades.txt");
                SaveSystem.saveGameExists = false; // And change the relevant boolean  
                TextWriter saveGame = new StreamWriter("SaveGame.txt"); // Declare a new StreamWriter.
                
                saveGame.WriteLine(SaveSystem.saveGameExists.ToString().ToLower()); // Write a line of the boolean.
                saveGame.Close(); // Close the StreamWriter, saving the written lines to the text file.
                btnResetGame.Enabled = false; // Disable the reset button
                
                // Update the menu to have strings related to lack of existing save
                lblSaveStatus.Text = "No save loaded";
                btnStart.Text = "New game";

                MessageBox.Show("All local save data was cleared.",
                    "Delete success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No save data was cleared.",
                    "Delete aborted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmCheatMenu Cheats = new frmCheatMenu();
            Cheats.ShowDialog();
        }
    }
}
