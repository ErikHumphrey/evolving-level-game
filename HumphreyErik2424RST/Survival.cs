/*** Form for the Survival level ***
 * Master skills like firemaking, woodcutting, fishing, and cooking in this point-and-click game!
 * What makes this level unique from RuneScape, from which it is based, is the side view for fishing, making it
   require more skill. It also looks cool. */

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

        int fishCooked = 0;
        int fishNeeded;

        int fishingSpotFrame = 3;
        int fireFrame = 3;
        int unlitFireImageIndex = 0;

        int pointsToDecay = 0;
        int bonusPoints = 0;

        string treeType = "normal";

        string fishDirection = "right";

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
            // Determine the fish needed to be cooked
            switch (LevelGen.difficulty)
            {
                case 1:
                    fishNeeded = 2;
                    treeType = "normal";
                    break;
                case 2:
                    fishNeeded = 5;
                    treeType = "oak";
                    break;
                case 3:
                    fishNeeded = 10;
                    treeType = "willow";
                    break;
                case 4:
                    fishNeeded = 15;
                    treeType = "maple";
                    break;
                case 5:
                    fishNeeded = 20;
                    treeType = "yew";
                    break;
            }

            updateObjective(); // Update the label with the objective

            tmrBonusPointsDecay.Start();

            picFish.Parent = pnlSideView;
            picFish.Location = new Point(20, 115);

            tmrFishMovement.Start();
            tmrFishingSpotAnimation.Start();
            // tmrFireAnimation.Start();

            cboEquippedItem.Items.Add("Empty hands");
            cboEquippedItem.SelectedText = "Empty hands";
            cboEquippedItem.Items.Add("Bronze hatchet");
            cboEquippedItem.Items.Add("Matchbox");
            cboEquippedItem.Items.Add("Fishing rod");
        }

        private void tmrFishingSpotAnimation_Tick(object sender, EventArgs e)
        {
            if (fishingSpotFrame == 3)
                fishingSpotFrame = 1;
            else
                fishingSpotFrame++;

            switch (fishingSpotFrame)
            {
                case 1:
                    picFishingSpot.Image = picFishingSpotSide.Image = Properties.Resources.imgWaterAnimation1;
                    break;
                case 2:
                    picFishingSpot.Image = picFishingSpotSide.Image = Properties.Resources.imgWaterAnimation2;
                    break;
                case 3:
                    picFishingSpot.Image = picFishingSpotSide.Image = Properties.Resources.imgWaterAnimation3;
                    break;
            }
        }

        private void tmrFireAnimation_Tick(object sender, EventArgs e)
        {
            // Change the fire's image

            if (fireFrame == 3)
                fireFrame = 1;
            else
                fireFrame++;

            switch (fireFrame)
            {
                case 1:
                    picFirePit.Image = picFireSide.Image = Properties.Resources.imgFirePitLit1;
                    break;
                case 2:
                    picFirePit.Image = picFireSide.Image = Properties.Resources.imgFirePitLit2;
                    break;
                case 3:
                    picFirePit.Image = picFireSide.Image = Properties.Resources.imgFirePitLit3;
                    break;
            }

            // The fire goes out after 25s, punishing the player for not fishing fast enough (or prior to starting)

            prgFireFuel.Value -= 8;
            if (prgFireFuel.Value <= 0)
            {
                tmrFireAnimation.Stop();
                prgFireFuel.Visible = false;
                picFirePit.Image = Properties.Resources.imgFirePitEmpty;
            }
        }

        private void picTree_Click(object sender, EventArgs e)
        {

            // If the selected item is a hatchet and the tree isn't regrowing...
            if (cboEquippedItem.SelectedText.Contains("ha") && !tmrRegrow.Enabled)
            {
                lstGameLog.Items.Add("You swing your " + cboEquippedItem.SelectedText.ToLower() + " at the tree."); // Message

                // 33% to successfully gather some logs from the tree
                // There is a credits bonus for getting logs or felling the tree in a minimal amount of tries.
                // 5 tries effectively gives no bonus.
                int cut;
                int cutLuckyBonus = 400;
                cut = rnd.Next(1, 4);
                if (cut == 1)
                {
                    cboEquippedItem.Items.Add("Logs");
                    lstGameLog.Items.Add("You get some logs.");
                    pointsToDecay += cutLuckyBonus; // Award bonus points

                    // 50% chance to also chop the tree down too
                    int stump;
                    int fellLuckyBonus = 800;
                    stump = rnd.Next(1, 3);
                    if (stump == 1)
                    {
                        picTree.Image = picTreeSide.Image = Properties.Resources.stumpfix11; // Tree image changes to a stump
                        tmrRegrow.Start(); // Start the tree's regrowth
                        prgTreeGrowth.Visible = true;
                        pointsToDecay += fellLuckyBonus;
                        lstGameLog.Items.Add("You fell the tree.");
                        //treeDown.Play(); // Play a satisfying tree felling sound
                    }
                    else
                        fellLuckyBonus -= 200;
                }
                else
                    cutLuckyBonus -= 100; // Lose bonus points


            }
            else
                lstGameLog.Items.Add("Nothing interesting happens."); // Using any other item on the tree

            update();
        }

        // Scroll Listbox to bottom
        void update()
        {
            lstGameLog.TopIndex = lstGameLog.Items.Count - 1;
        }

        /* unlitFireImageIndex
         * 0: no logs
         * 1: logs in pit
         * 2: fire lit
         * 3: cooked fish on fire (must be picked up)
         * 4: burnt fish on fire (must be picked up)*/

        private void picFirePit_Click(object sender, EventArgs e)
        {
            if (cboEquippedItem.SelectedText == "Logs" && unlitFireImageIndex == 0)
            {
                lstGameLog.Items.Remove("Logs");
                // Add logs to fire pit
                picFirePit.Image = picFireSide.Image = Properties.Resources.imgFirePitLogs;
                unlitFireImageIndex = 1;
            }
            else if (cboEquippedItem.SelectedText == "Matchbox" && unlitFireImageIndex == 1)
            {
                lstGameLog.Items.Add("You attempt to light the logs.");
                // Fire starts
                lstGameLog.Items.Add("The fire catches and the logs begin to burn.");
                picFirePit.Image = picFireSide.Image = Properties.Resources.imgFirePitLit2;
                prgFireFuel.Value = 2000;
                prgFireFuel.Visible = true;
                tmrFireAnimation.Start(); 
                unlitFireImageIndex = 2;
            }
            else if (cboEquippedItem.SelectedText == "Uncooked fish" && unlitFireImageIndex == 2)
            {
                tmrFireAnimation.Stop();
                prgFireFuel.Visible = false;
                lstGameLog.Items.Add("You place the fish on the fire.");

                // 33.3% chance to burn fish
                int rollToCookFish;
                rollToCookFish = rnd.Next(1, 4);
                if (rollToCookFish == 3)
                {
                    lstGameLog.Items.Add("You burn the fish. Yuck!");
                    picFirePit.Image = picFireSide.Image = Properties.Resources.imgPitBurntFish;
                    unlitFireImageIndex = 4;
                }
                else
                {
                    lstGameLog.Items.Add("You cook the fish. Yum!");
                    picFirePit.Image = picFireSide.Image = Properties.Resources.imgFishCooked2;
                    unlitFireImageIndex = 3;
                }
            }
            // If there's a fish on the fire pit, empty hands must be used to remove it.
            else if (unlitFireImageIndex == 3 || unlitFireImageIndex == 4)
            {
                if (cboEquippedItem.SelectedText == "Empty hands")
                {
                    // If it's the cooked fish, award progress.
                    if (unlitFireImageIndex == 3)
                    {
                        fishCooked++;
                        updateObjective();
                    }
                    unlitFireImageIndex = 0;
                    // Set it back to an empty fire pit
                    picFirePit.Image = picFireSide.Image = Properties.Resources.imgFirePitEmpty;
                }
                else
                    lstGameLog.Items.Add("Your fish is blocking the fire pit.");
            }
            else
                lstGameLog.Items.Add("Nothing interesting happens.");
            update();
        }

        private void tmrRegrow_Tick(object sender, EventArgs e)
        {
            prgTreeGrowth.Value += 10;
            if (prgTreeGrowth.Value >= 2000)
            {
                tmrRegrow.Stop();
                prgTreeGrowth.Visible = false;
                picTree.Image = picTreeSide.Image = Properties.Resources.tree;
                prgTreeGrowth.Value = 0;
            }
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

        private void tmrFishMovement_Tick(object sender, EventArgs e)
        {
            int x;
            int y;

            x = picFish.Location.X; // Get the current X and Y
            y = picFish.Location.Y; // Just makes the code below easier to read, I guess

            // Fish starts moving left if it moves beyond right threshold
            if (x > 197)
            {
                picFish.Image = Properties.Resources.imgFishSmallBackFlip;
                fishDirection = "left";
            }
            // Fish starts moving right if it moves beyond left threshold
            else if (x < 8)
            {
                picFish.Image = Properties.Resources.imgFishSmallBack;
                fishDirection = "right";
            }

            switch (fishDirection) // Control fishDirection using x coordinate
            {
                case "left":
                    x--;
                    break;
                case "right":
                    x++;
                    break;
            }

            picFish.Location = new Point(x, y); // Move dancing man to the new coordinates
        }

        /* The bonus point timer is constantly running to decay any bonus points added.
           Obviously, it would be more efficient to add these instantly, but video games
           tend to have point counters rapidly change because it looks cool to have the
           number values spinning up. This is similar to the tmrHealthDecay in the Battle
           level whenever a character's health changes. It's also featured on the Level
           Complete screen when credits are actually awarded. In those, the timer isn't
           constantly running, but I found it worked better here. */

        private void tmrBonusPointsDecay_Tick(object sender, EventArgs e)
        {
            if (pointsToDecay > 0)
            {
                pointsToDecay -= 4;
                bonusPoints += 4;
                lblBonusPointsCounter.Text = bonusPoints.ToString();
            }
            else
                pointsToDecay = 0;
        }

        private void clickableLeave(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(cursorIcon.Handle);
        }

        private void picFishingSpot_Click(object sender, EventArgs e)
        {
            if (cboEquippedItem.SelectedText.Contains("Fi"))
            {
                lstGameLog.Items.Add("You cast your " + cboEquippedItem.SelectedText.ToLower() + " into the water...");
                tmrFishingDelay.Start();
                picFishingLine.Visible = true;

            }
            else
                lstGameLog.Items.Add("Nothing interesting happens.");

            update();
        }

        private void tmrFishingDelay_Tick(object sender, EventArgs e)
        {
            tmrFishingDelay.Stop();

            if (picFish.Bounds.IntersectsWith(picFishingLine.Bounds))
            {
                lstGameLog.Items.Add("...and catch a fish!");
                cboEquippedItem.Items.Add("Uncooked fish");
                picFish.Visible = false;
            }
            else
            {
                lstGameLog.Items.Add("You didn't find anything this time.");
            }

            update();
            picFishingSpot.Visible = picFishingLine.Visible = picFishingSpotSide.Visible = false;
            tmrFishRespawn.Start();
            prgFishRespawn.Visible = true;
        }

        private void tmrFishRespawn_Tick(object sender, EventArgs e)
        {
            // Progress bar increments faster if fish was not caught
            // Visually seems to disappear early because of Windows's progress bar animations
            if (picFish.Visible == true)
                prgFishRespawn.Value += 125;
            else
                prgFishRespawn.Value += 10;
            if (prgFishRespawn.Value >= 2000)
            {
                tmrFishRespawn.Stop();
                prgFishRespawn.Visible = false;
                picFishingSpot.Visible = picFishingLine.Visible = picFish.Visible = true;
                prgFishRespawn.Value = 0;
            }
        }

        void updateObjective()
        {
            lblFishCookedCounter.Text = fishCooked + " / " + fishNeeded; // Update the label

            // If the objective is met, close the level and open the level complete screen!
            if (fishCooked == fishNeeded)
            {
                frmBattle.levelComplete.Play();
                frmLevelComplete LevelComplete = new frmLevelComplete();
                LevelComplete.Show();
                this.Hide();
            }
        }
    }
}