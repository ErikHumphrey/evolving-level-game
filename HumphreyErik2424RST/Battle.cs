// Battle level: Pokémon battle clone without the monsters

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LevelGenerator;
using ColourProgressBar;

namespace HumphreyErik2424RST
{
    public partial class frmBattle : Form
    {
        int secondsWaited = 0;
        int swipeFrame, flurryHits = 0;
        int enemyHealthToDecay, playerHealthToDecay;
        int playerMaxHP = 100;
        bool animationInProgress = false;
        bool isEnemyTurn, enemyDead = false;
        // string playerHitsEnemyFor = "PLAYER" + " hits " + "ENEMY" + " for "; - unused
        Image[] picHealingBeams = new Image[12];
        int beamFrame;

        // Ability damage values (per hit; negative = heal)
  
        const int DV_REST = -40;

        const int DV_PUNCH = 30;
        const int DV_FIST_FLURRY = 20;
        const int DV_ONE_PUNCH_MAN = 9999;

        const int DV_FRONT_KICK = 10;
        const int DV_TORNADO_KICK = 20;
        const int DV_WHIRLWHIND_KICK = 50;

        // All sound effects used on this level
        SoundPlayer hitSuccess = new SoundPlayer(HumphreyErik2424RST.Properties.Resources.sfxHitImproved);
        // public static SoundPlayer levelComplete = new SoundPlayer(HumphreyErik2424RST.Properties.Resources.sfxWeedVictory);   to be replaced with E-rated sound
        SoundPlayer hitSwoosh = new SoundPlayer(HumphreyErik2424RST.Properties.Resources.sfxSwoosh);
        SoundPlayer healSuccess = new SoundPlayer(HumphreyErik2424RST.Properties.Resources.sfxHealingShorter);

        public frmBattle()
        {
            InitializeComponent();
            /* Add pictureboxes as parents of the panel so they show panel BackgroundImage behind them when transparent
            pnlTop.Controls.Add(picPortraitEnemy);
            pnlTop.Controls.Add(picPortraitPlayer);
            pnlTop.Controls.Add(picSwipe); */

            picSwipe.Parent = picPortraitEnemy;
            picPunch.Parent = picPortraitEnemy;
            picHealingBeam.Parent = picPortraitPlayer;
            /// picHealingBeam.Location = new Point(0, 0);
            picHealingBeam.Location = new Point(-20, 0);
            picSwipe.Location = new Point(27, 40);

        }

        private void frmBattle_Load(object sender, EventArgs e)
        {
            resetButtons();
            playerTurn(); // Make sure it's the player's turn, just in case. You always get to go first.

            lblNamePlayer.Text = SaveGames.SaveSystem.name.ToUpper(); // Convert the user's saved name to uppercase and display it
            picPortraitEnemy.Location = new Point(437, 30);

            // Using a ResourceManager simplifies having to declare each image for each array value manually 
            for (int i = 0; i < picHealingBeams.Length; i++)
            {
                picHealingBeams[i] = (Image)Properties.Resources.ResourceManager.GetObject("imgBeam" + i.ToString("D2"));
            }

            picHealingBeam.Size = new Size(255, 218);
            ModifyProgressBarColor.SetState(prgHealthEnemy, 1);
            tmrGameTicker.Start();
            prgHealthPlayer.Maximum = prgHealthPlayer.Value = 80;

            switch (LevelGen.difficulty)
            {
                case 1:
                    prgHealthEnemy.Value = prgHealthEnemy.Maximum = 80;
                    picPortraitEnemy.Image = Properties.Resources.imgCultistAlive;
                    enemyDamaged();
                    lblNameEnemy.Text = "HOODED FIGURE";
                    break;
                case 2:
                    prgHealthEnemy.Value = prgHealthEnemy.Maximum = 100;
                    picPortraitEnemy.Image = Properties.Resources.imgRabbitAlive;
                    enemyDamaged();
                    lblNameEnemy.Text = "RABID RABBIT";
                    break;
                case 3:
                    prgHealthEnemy.Value = prgHealthEnemy.Maximum = 120;
                    picPortraitEnemy.Image = Properties.Resources.imgHammerAlive;
                    enemyDamaged();
                    lblNameEnemy.Text = "GHOSTLY HAMMER";
                    break;
                case 4:
                    prgHealthEnemy.Value = prgHealthEnemy.Maximum = 150;
                    picPortraitEnemy.Image = Properties.Resources.imgDoppelAlive;
                    enemyDamaged();
                    lblNameEnemy.Text = "DOPPELGANGER";
                    break;
                case 5:
                    prgHealthEnemy.Value = prgHealthEnemy.Maximum = 200;
                    picPortraitEnemy.Image = Properties.Resources.imgZeusAlive;
                    enemyDamaged();
                    lblNameEnemy.Text = "ZEUS";
                    break;
            }
        }

        // Top-left, top-right, bottom-left, and bottom-right buttons in purple action panel

        private void btnTL_Click(object sender, EventArgs e)
        {
            if (btnTL.Text != "FIGHT")
            {
                pnlActions.Visible = false;
            }

            if (btnTL.Text == "FIGHT")
            {
                btnTL.Text = "FIST FLURRY";
                btnTR.Text = "FRONT KICK";
                btnBL.Text = ""; // Blank unless Blind ability (e.g. Smoke Screen) is unlocked, but upgrades don't do anything yet
                btnBR.Text = "< BACK";
            }
            else if (btnTL.Text == "PUNCH")
            {
                enemyHealthToDecay = DV_PUNCH; // The damage the punch deals.
                tmrEnemyHealthDecay.Start(); // Start the health loss chain of events
            }
            else if (btnTL.Text == "FIST FLURRY")
            {
                enemyHealthToDecay = DV_FIST_FLURRY;
                tmrFistFlurry.Start();
            }
            else if (btnTL.Text == "ONE PUNCH MAN")
            {
                enemyHealthToDecay = 9999;
                tmrEnemyHealthDecay.Start();
            }
            else if (btnBR.Text == "< BACK")
                resetButtons();
        }

        // return buttons to their defaults
        void resetButtons()
        {
            btnTL.Text = "FIGHT";
            btnTR.Text = "REST";
            btnBL.Text = "ITEMS";
            btnBR.Text = "FLEE";
        }

        private void btnTR_Click(object sender, EventArgs e)
        {
            pnlActions.Visible = false;

            if (btnTR.Text == "REST")
            {
                beamFrame = 0;
                playerHealthToDecay = DV_REST;
                picHealingBeam.Visible = true;
                healSuccess.Play(); // Play healing sound
                tmrHealAnimation.Start();
                animationInProgress = true;
                tmrPlayerHealthDecay.Start();
            }
            else if (btnTR.Text == "FRONT KICK")
            {
                hitSwoosh.Play();
                swipeFrame = 0;
                picSwipe.Visible = true;
                tmrAnimationTicker.Start();
                animationInProgress = true;
                enemyHealthToDecay = 10;
                tmrEnemyHealthDecay.Start();
            }
            else if (btnTL.Text == "TORNADO KICK")
            {
                prgHealthEnemy.Value -= 10;
                enemyDamaged();
            }
        }

        private void btnBL_Click(object sender, EventArgs e)
        {
            if (btnBL.Text == "ITEMS")
            {
                frmItems Items = new frmItems();
                Items.Show();
                this.Hide();
            }
        }

        private void btnBR_Click(object sender, EventArgs e)
        {
            if (btnBR.Text != "FLEE")
            {
                pnlActions.Visible = false;
            }

            if (btnBR.Text == "FLEE")
            {
                // Confirm flee
                DialogResult wantsToFlee = MessageBox.Show("Are you sure you want to flee from this fight?\r\n\r\nYou won't earn any points for this level.",
                 "Confirm flee",
                 MessageBoxButtons.YesNo);

                if (wantsToFlee == DialogResult.Yes)
                {
                    this.Close(); // Exit the level
                }
            }
        }

        private void tmrFistFlurry_Tick(object sender, EventArgs e)
        {
            picPunch.Visible = true;

            if (flurryHits < 3)
            {
                flurryHits++;

                if (flurryHits == 1)
                {
                    hitSuccess.Play();
                    picPunch.Location = new Point(10, 95);
                    // lblStatusBar.Text = playerHitsEnemyFor + "20 x " + flurryHits + " damage!";
                }
                if (flurryHits == 2)
                {
                    picPunch.Location = new Point(87, 60);
                    // lblStatusBar.Text = playerHitsEnemyFor + "20 x " + flurryHits + " damage!";
                }
                if (flurryHits == 3)
                {
                    picPunch.Location = new Point(10, 20);
                    // lblStatusBar.Text = playerHitsEnemyFor + "20 x " + flurryHits + " damage!";
                }

                tmrEnemyHealthDecay.Start();
            }
            else
            {
                picPunch.Visible = false;
                tmrFistFlurry.Stop();
                flurryHits = 0;
            }
        }

        private void MouseLeavesButton(object sender, EventArgs e)
        {
            lblDescription.Visible = false;
        }

        // Every second, check to see if victory conditions are met, or continue to the next phase of battle (feels too inhuman if the enemy makes their move too fast)
        private void tmrGameTicker_Tick(object sender, EventArgs e)
        {
            // Plays shortly after enemy dies instead of immediately
            if (enemyDead == true)
            {
                picPortraitEnemy.Image = Properties.Resources.imgCultistDead;
                tmrDeathAnimation.Start();
                tmrGameTicker.Stop();
            }
        }

        // Front Kick animation

        private void tmrAnimationTicker_Tick(object sender, EventArgs e)
        {
            swipeFrame++;

            switch (swipeFrame)
            {
                case 1:
                    picSwipe.Image = Properties.Resources.imgSwipe1;
                    break;
                case 2:
                    picSwipe.Image = Properties.Resources.imgSwipe2;
                    break;
                case 3:
                    picSwipe.Image = Properties.Resources.imgSwipe3;
                    break;
                case 4:
                    picSwipe.Image = Properties.Resources.imgSwipe4;
                    break;
                case 5:
                    picSwipe.Image = Properties.Resources.imgSwipe5;
                    break;
                case 6:
                    picSwipe.Image = Properties.Resources.imgSwipe6;
                    break;
            }

            if (swipeFrame > 6)
            {
                picSwipe.Visible = false;
            }

            if (swipeFrame > 8)
            {
                tmrAnimationTicker.Stop();
                animationInProgress = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method that triggers when the player takes damage or is healed (e.g. by resting)

        void playerDamaged()
        {
            lblHealthPlayer.Text = prgHealthPlayer.Value + " / " + playerMaxHP; // Change the health counter to reflect the new value

            // The code below uses my custom ColourProgressBar class. You can find the source for the code I borrowed in ColourProgressBar.cs.

            // If the player has less than half their health remaining but more than 1/5, set the ProgressBar to a yellow state
            if (prgHealthPlayer.Value < prgHealthPlayer.Maximum / 2 && prgHealthPlayer.Value > prgHealthPlayer.Maximum / 5)
                ModifyProgressBarColor.SetState(prgHealthPlayer, 3);
            // If the player has less than or equal to 1/5 of their health remaining, set the ProgressBar to a red state
            else if (prgHealthPlayer.Value <= prgHealthPlayer.Maximum / 5)
                ModifyProgressBarColor.SetState(prgHealthPlayer, 2);
            // Make sure it's green while >= half maximum health
            // Note: Leave this as an else if statement, as the math is imperfect and it will appear as green when healing while health is low.
            else if (prgHealthPlayer.Value >= prgHealthPlayer.Maximum / 2)
            ModifyProgressBarColor.SetState(prgHealthPlayer, 1);

            // This is all that happens when your health depletes to 0 for now
            if (prgHealthPlayer.Value == 0)
            {
                tmrPlayerHealthDecay.Stop();
                MessageBox.Show("YOU DIED. Click OK to cheat death and continue to battle against " + lblNameEnemy + ".\r\n\r\nPROTIP: Heal yourself by clicking REST and you literally cannot die in this demo. That way you can avoid this annoying death message!", "0 health");
            }
        }

        // Same thing but for the enemy. Enemy currently cannot gain health / heal, so that part is left out

        void enemyDamaged()
        {
            lblHealthEnemy.Text = prgHealthEnemy.Value + " / " + prgHealthEnemy.Maximum; // Change the health counter to reflect the new value
            if (prgHealthEnemy.Value < prgHealthEnemy.Maximum / 2 && prgHealthEnemy.Value > prgHealthEnemy.Maximum / 5)
                ModifyProgressBarColor.SetState(prgHealthEnemy, 3);
            else if (prgHealthEnemy.Value < prgHealthEnemy.Maximum / 5)
                ModifyProgressBarColor.SetState(prgHealthEnemy, 2);

            // It is best to set the enemy to be dead here
            if (prgHealthEnemy.Value == 0)
                enemyDead = true;
        }

        private void tmrEnemyHealthDecay_Tick(object sender, EventArgs e)
        {
            // Progressively decrease the health of the enemy so it appears as if the progress bar is animating
            // This gives a smooth transition instead of the health being lost instantly
            if (enemyHealthToDecay > 0)
            {
                // Deplete progress bar to 0 if it might go under 0 to prevent a crash
                if (prgHealthEnemy.Value - 1 < 0)
                {
                    prgHealthEnemy.Value = 0;
                    enemyDamaged();
                }
                else
                {
                    enemyHealthToDecay--;
                    prgHealthEnemy.Value--;
                    enemyDamaged();
                }
            }
            else
            {
                if (!animationInProgress)
                {
                    enemyTurn();
                    tmrEnemyHealthDecay.Stop();
                }
            }
        }

        // On the enemy's turn...
        void enemyTurn()
        {
            isEnemyTurn = true;
            // If they're not dead...
            if (!enemyDead)
            {
                // Inflict damage based on the level difficulty (currently the same across all difficulties, enemy has no attack animation)
                switch (LevelGen.difficulty)
                {
                    case 1:
                        playerHealthToDecay = 30; // The damage the enemy's attack deals.
                        break;
                    case 2:
                        playerHealthToDecay = 30;
                        break;
                    case 3:
                        playerHealthToDecay = 30;
                        break;
                    case 4:
                        playerHealthToDecay = 30;
                        break;
                    case 5:
                        playerHealthToDecay = 30;
                        break;
                    // If the difficulty is anything but 5 (e.g. 6, because there is no way to beat the game)
                    default:
                        playerHealthToDecay = 15;
                        break;
                }

                // and have that damage tick down slowly, because it looks cool.
                tmrPlayerHealthDecay.Start();

                // display message on bottom panel
                statusCenter();
            }
        }

        // Change the "Choose an ACTION" to be a status bar while action happens (currently only for when enemy attacks player)
        void statusCenter()
        {
            lblHelper.Text = lblNameEnemy.Text + playerHealthToDecay + " damage!"; // Update the status bar.
            lblHelper.Location = new Point(-3, 28);
            lblHelper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        void playerTurn()
        {
            lblHelper.Text = "Choose an ACTION.";
            lblHelper.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            lblHelper.Location = new Point(69, 28);
            isEnemyTurn = false;
            pnlActions.Visible = true;
            btnTL.Text = "FIGHT";
            btnTR.Text = "REST";
            btnBL.Text = "ITEMS";
            btnBR.Text = "FLEE";
        }

        private void tmrPlayerHealthDecay_Tick(object sender, EventArgs e)
        {
            // Progressively decrease the health of the enemy so it appears as if the progress bar is animating
            // This gives a smooth transition instead of the health being lost instantly.
            // If the progress bar appears to move in more than one step or is delayed, this is the merely result of lag and the program is trying to catch up.

            // Taking damage
            if (playerHealthToDecay > 0)
            {
                // Deplete progress bar to 0 if it might go under 0 to prevent a crash
                if (prgHealthPlayer.Value - 1 < 0)
                    prgHealthPlayer.Value = 0;
                else
                {
                    playerHealthToDecay--;
                    prgHealthPlayer.Value--;
                }
            }
            // Receiving healing (like from clicking REST)
            else if (playerHealthToDecay < 0)
            {
                if (prgHealthPlayer.Value + 1 > 100)
                    prgHealthPlayer.Value = 100;
                else
                {
                    playerHealthToDecay++;
                    prgHealthPlayer.Value++;
                } 
            }
            else
            {
                tmrPlayerHealthDecay.Stop();
                tmrActionDelay.Start();
            }

            playerDamaged();
        }

        private void tmrHealAnimation_Tick(object sender, EventArgs e)
        {
            // Only 11 images in the array, but a range of 12 allows image 11 to be shown. Otherwise, the instant the image 11 appears, the PictureBox would be hidden.
            if (beamFrame < 12)
                picHealingBeam.Image = picHealingBeams[beamFrame++];
            else
            {
                tmrHealAnimation.Stop();
                animationInProgress = false;
                picHealingBeam.Visible = false;
                picHealingBeam.Image = Properties.Resources.imgBeam01;
                tmrActionDelay.Start();
            }
        }

        private void tmrActionDelay_Tick(object sender, EventArgs e)
        {
            if (secondsWaited > 0)
            {
                tmrActionDelay.Stop();
                secondsWaited = 0;
                if (isEnemyTurn)
                    playerTurn();
                else
                    enemyTurn();
            }
            else
                secondsWaited++;
        }

        private void btnTL_MouseEnter(object sender, EventArgs e)
        {
            lblDescription.Visible = true;

            if (btnTL.Text == "FIGHT")
            {
                lblDescription.Text = "Use a selection of martial arts to attack your enemy.";
            }
            else if (btnTL.Text == "PUNCH")
            {
                lblDescription.Text = "Strike your foe with a closed fist, dealing " + DV_PUNCH + " damage.";
            }
            else if (btnTL.Text == "FIST FLURRY")
            {
                lblDescription.Text = "Strike your foe three times, dealing " + DV_FIST_FLURRY * 3 + " damage total.";
            }
            else if (btnTL.Text == "ONE PUNCH MAN")
            {
                lblDescription.Text = "Obliterate your enemy with a swift blow to the vitals.";
            }
        }

        private void btnTR_MouseEnter(object sender, EventArgs e)
        {
            lblDescription.Visible = true;

            if (btnTR.Text == "REST")
            {
                lblDescription.Text = "Meditate, instantly restoring " + DV_REST.ToString().Substring(1, 2) + " health.";
            }
            else if (btnTR.Text == "FRONT KICK")
            {
                lblDescription.Text = "Quickly deliver a blow with the ball of your foot, dealing " + DV_FRONT_KICK + " damage.";
            }
            else if (btnTR.Text == "TORNADO KICK")
            {
                lblDescription.Text = "Spin 540° and deliver two flying kicks dealing a total of " + DV_TORNADO_KICK * 2 + " damage.";
            }
            else if (btnTR.Text == "WHIRLWIND KICK")
            {
                lblDescription.Text = "Deal " + DV_WHIRLWHIND_KICK + " damage to your enemy and stun them for a turn.";
            }
        }

        private void btnBL_MouseEnter(object sender, EventArgs e)
        {
            lblDescription.Visible = true;

            if (btnBL.Text == "Items")
            {
                lblDescription.Text = "Browse your inventory to use items.";
            }
        }

        private void btnBR_MouseEnter(object sender, EventArgs e)
        {
            lblDescription.Visible = true;

            if (btnBR.Text == "FLEE")
            {
                lblDescription.Text = "Flee from battle.";
            }
        }

        // Make enemy fall through ground when they die

        private void tmrDeathAnimation_Tick(object sender, EventArgs e)
        {
            if (picPortraitEnemy.Location.Y < 144)
                picPortraitEnemy.Top += 22;
            else
            {
                tmrDeathAnimation.Stop();
                // levelComplete.Play(); // The jingle is played independent of the form so that it starts before it finishes loading
                HumphreyErik2424RST.frmLevelComplete LevelComplete = new HumphreyErik2424RST.frmLevelComplete();

                LevelComplete.Show();
                this.Hide();
                tmrGameTicker.Stop();
            }
        }

        // Cheat, reducing enemy health to 10.
        private void btnBuddha_Click(object sender, EventArgs e)
        {
            prgHealthEnemy.Value = 10;
            lblHealthEnemy.Text = "10 / " + prgHealthEnemy.Maximum;
            ModifyProgressBarColor.SetState(prgHealthEnemy, 2);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Convert enemy name to title case (e.g., ERIK HUMPHREY --> Erik Humphrey)
            string titleCasedEnemyName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(lblNameEnemy.Text);
            // and then show it in a MessageBox explaining how the Battle level works
            MessageBox.Show("Click FIGHT to access your martial arts abilities. To complete the level, defeat " + titleCasedEnemyName + " before they defeat you!");
        }

        private void frmBattle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}