// Form for the Survival level
// Master skills like firemaking, woodcutting, fishing, and cooking in this point-and-click game!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumphreyErik2424RST;
using LevelGenerator;

namespace HumphreyErik2424RST
{
    public partial class frmSurvival : Form
    {
        // Global declarations
        Random rnd = new Random();

        int logsNeeded;
        int logCount;
        int fireBurnTimer = 0;
        int fishingSpotFrame = 3;
        int fireFrame = 3;
        int unlitFireImageIndex = 0;

        string treeType;
        
        private Icon firemakingIcon = Properties.Resources.cursorFiremaking;
        private Icon woodcuttingIcon = Properties.Resources.cursorWoodcutting;
        private Icon fishingIcon = Properties.Resources.cursorFishing;
        private Icon cookingIcon = Properties.Resources.cursorCooking;
        private Icon cursorIcon = Properties.Resources.cursorPointer;
        private Icon bagIcon = Properties.Resources.cursorInTheBag;

        public frmSurvival()
        {
            InitializeComponent();

         /* Set cursors for the clickable objects. I referenced Microsoft documentation to figure out
            how to do this with .ico files, as in previous projects I used .cur files. This disposes
            the cursors at the end and also prevents them from vanishing quickly at form load. */
           picFirePit.Cursor = new Cursor(firemakingIcon.Handle);
           picTree.Cursor = new Cursor(woodcuttingIcon.Handle);
           picFishingSpot.Cursor = new Cursor(fishingIcon.Handle);
           this.Cursor = new Cursor(cursorIcon.Handle);
        }

        private void frmSurvival_Load(object sender, EventArgs e)
        {
            tmrFishingSpotAnimation.Start();
            // tmrFireAnimation.Start();

            cboEquippedItem.Items.Add("Bronze hatchet");
            cboEquippedItem.Items.Add("Matchbox");
            cboEquippedItem.Items.Add("Fishing rod");
                
            /*
            switch (LevelGen.difficulty)
            {
                case 1:
                    logsNeeded = 10;
                    treeType = "normal";
                    break;
                case 2:
                    logsNeeded = 20;
                    treeType = "oak";
                    break;
                case 3:
                    logsNeeded = 30;
                    treeType = "willow";
                    break;
                case 4:
                    logsNeeded = 40;
                    treeType = "maple";
                    break;
                case 5:
                    logsNeeded = 50;
                    treeType = "yew";
                    break;
          * 
            }*/ 
        }

        private void tmrFishingSpotAnimation_Tick(object sender, EventArgs e)
        {
            if (fishingSpotFrame == 4)
                fishingSpotFrame = 1;
            else
                fishingSpotFrame++;

            switch (fishingSpotFrame)
            {
                case 1:
                    picFishingSpot.Image = Properties.Resources.imgWaterAnimation1;
                    break;
                case 2:
                    picFishingSpot.Image = Properties.Resources.imgWaterAnimation2;
                    break;
                case 3:
                    picFishingSpot.Image = Properties.Resources.imgWaterAnimation3;
                    break;
            }
        }

        private void tmrFireAnimation_Tick(object sender, EventArgs e)
        {
            if (fireFrame == 4)
                fireFrame = 1;
            else
                fireFrame++;

            switch (fireFrame)
            {
                case 1:
                    picFirePit.Image = Properties.Resources.imgFirePitLit1;
                    break;
                case 2:
                    picFirePit.Image = Properties.Resources.imgFirePitLit2;
                    break;
                case 3:
                    picFirePit.Image = Properties.Resources.imgFirePitLit3;
                    break;
            }
        }

        private void picTree_Click(object sender, EventArgs e)
        {
            if (cboEquippedItem.SelectedText.Contains("ha"))
            {
                int cut;
                lstGameLog.Items.Add("You swing your " + cboEquippedItem.SelectedText.ToLower() + " at the tree.");
                lstGameLog.TopIndex = lstGameLog.Items.Count - 1;
                cut = rnd.Next(1, 4);
                if (cut == 3)
                {
                    logCount++;
                    cboEquippedItem.Items.Add("Logs");
                    lstGameLog.Items.Add("You get some logs.");
                    lstInventory.Items.Add("Logs");
                    picTree.Image = Properties.Resources.stumpfix11;
                    lstGameLog.TopIndex = lstGameLog.Items.Count - 1;
                }
            }
            else
                lstGameLog.Items.Add("Nothing interesting happens.");
                lstGameLog.TopIndex = lstGameLog.Items.Count - 1;
        }

        /* unlitFireImageIndex
         * 0: no logs
         * 1: logs in pit
         * 2: fire lit */

        private void picFirePit_Click(object sender, EventArgs e)
        {
            lstGameLog.Items.Add(picFirePit.Image.ToString());
            if (cboEquippedItem.SelectedText == "Logs" && unlitFireImageIndex == 0)
            {
                // lstInventory.Items.Remove("Logs");
                picFirePit.Image = Properties.Resources.imgFirePitLogs;
                unlitFireImageIndex = 1;
            }
            else if (cboEquippedItem.SelectedText == "Matchbox" && unlitFireImageIndex == 1)
            {
                picFirePit.Image = Properties.Resources.imgFirePitLit2;
                tmrFireAnimation.Start();
                unlitFireImageIndex = 2;
            }
            else
                lstGameLog.Items.Add("Nothing interesting happens.");
        }

        private void tmrRegrow_Tick(object sender, EventArgs e)
        {

        }

        private void frmSurvival_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Dispose custom cursors
            firemakingIcon.Dispose();
            fishingIcon.Dispose();
            woodcuttingIcon.Dispose();
            bagIcon.Dispose();
            cursorIcon.Dispose();
            cookingIcon.Dispose();
        }

        // If the mouse enters a clickable object in the Game View panel (Tree, fire pit, fishing spot)
        private void clickableEnter(object sender, EventArgs e)
        {
            // Check what item is equipped in the ComboBox
            if (cboEquippedItem.SelectedText == "Tinderbox")
                this.Cursor = new Cursor(firemakingIcon.Handle);
            else if (cboEquippedItem.SelectedText.Contains("ha"))
                this.Cursor = new Cursor(woodcuttingIcon.Handle);
            else if (cboEquippedItem.SelectedText.Contains("Fish") || cboEquippedItem.SelectedText == "Golden harpoon")
                this.Cursor = new Cursor(fishingIcon.Handle);
        }
    }
}
