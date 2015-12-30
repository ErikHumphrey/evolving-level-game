// Battle level: Pokémon battle clone without the monsters

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LevelGenerator;

namespace HumphreyErik2424RST
{
    public partial class frmBattle : Form
    {
        int swipeFrame, flurryHits = 0;
        int enemyMaxHP = 100;
        bool selectingAttack = false;
        bool enemyDead = false;
        string playerHitsEnemyFor = "PLAYER" + " hits " + "ENEMY" + " for ";

        // All sound effects used on this level
        SoundPlayer hitSuccess = new SoundPlayer(HumphreyErik2424RST.Properties.Resources.sfxHitImproved);
        SoundPlayer levelComplete = new SoundPlayer(HumphreyErik2424RST.Properties.Resources.sfxWeedVictory);

        public frmBattle()
        {
            InitializeComponent();
            /* Add pictureboxes as parents of the panel so they show panel BackgroundImage behind them when transparent
            pnlTop.Controls.Add(picPortraitEnemy);
            pnlTop.Controls.Add(picPortraitPlayer);
            pnlTop.Controls.Add(picSwipe); */

            picSwipe.Parent = picPortraitEnemy;
            picPunch.Parent = picPortraitEnemy;
            picPunch.BringToFront();
            picSwipe.Location = new Point(27, 40);

        }

        private void frmBattle_Load(object sender, EventArgs e)
        {
            tmrGameTicker.Start();
            prgHealthPlayer.Maximum = prgHealthPlayer.Value = 100;

            switch (LevelGen.difficulty)
            {
                case 1:
                    prgHealthEnemy.Maximum = enemyMaxHP;
                    prgHealthEnemy.Value = 80;
                    break;
                case 2:
                    prgHealthEnemy.Value = prgHealthEnemy.Maximum = 100;
                    enemyDamaged();
                    break;
                case 3:
                    prgHealthEnemy.Value = prgHealthEnemy.Maximum = 120;
                    enemyDamaged();
                    break;
                case 4:
                    prgHealthEnemy.Value = prgHealthEnemy.Maximum = 150;
                    enemyDamaged();
                    break;
                case 5:
                    prgHealthEnemy.Value = prgHealthEnemy.Maximum = 200;
                    enemyDamaged();
                    break;
            }
        }

        // Top-left, top-right, bottom-left, and bottom-right buttons in purple action panel

        private void btnTL_Click(object sender, EventArgs e)
        {
            if (btnTL.Text == "FIGHT")
            {
                selectingAttack = true;
                // Change the text of button's to the player's combat abilities
                btnTL.Text = "FIST FLURRY";
                btnTR.Text = "FRONT KICK";
            }
            else if (btnTL.Text == "PUNCH")
            {
                prgHealthEnemy.Value -= 30;
                enemyDamaged();
                lblStatusBar.Text = playerHitsEnemyFor + "30 damage!";
            }
            else if (btnTL.Text == "FIST FLURRY")
            {
                tmrFistFlurry.Start();
            }
            else if (btnTL.Text == "ONE PUNCH MAN")
            {
                prgHealthEnemy.Value -= 9999;
                enemyDamaged();
                lblStatusBar.Text = playerHitsEnemyFor + "9999 damage!";
            }
        }

        private void btnTR_Click(object sender, EventArgs e)
        {
            if (btnTR.Text == "FLEE")
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
            else if (btnTR.Text == "FRONT KICK")
            {
                swipeFrame = 0;
                picSwipe.Visible = true;
                tmrAnimationTicker.Start();
                prgHealthEnemy.Value -= 10;
                enemyDamaged();
            }
            else if (btnTL.Text == "TORNADO KICK")
            {
                prgHealthEnemy.Value -= 10;
                enemyDamaged();
            }
        }

        private void btnBL_Click(object sender, EventArgs e)
        {

        }

        private void btnBR_Click(object sender, EventArgs e)
        {
        }

        private void tmrFistFlurry_Tick(object sender, EventArgs e)
        {
            picPunch.Visible = true;

            if (flurryHits < 3)
            {
                flurryHits++;
                // Set enemy health to 0 if the blow would be overkill to prevent crash
                if (prgHealthEnemy.Value - 20 < 0)
                    prgHealthEnemy.Value = 0;
                else
                    prgHealthEnemy.Value -= 20;
                if (flurryHits == 1)
                {
                    hitSuccess.Play();
                    picPunch.Location = new Point(10, 95);
                    lblStatusBar.Text = playerHitsEnemyFor + "20 x " + flurryHits + " damage!";
                }
                if (flurryHits == 2)
                {
                    picPunch.Location = new Point(87, 60);
                    lblStatusBar.Text = playerHitsEnemyFor + "20 x " + flurryHits + " damage!";
                }
                if (flurryHits == 3)
                {
                    picPunch.Location = new Point(10, 20);
                    lblStatusBar.Text = playerHitsEnemyFor + "20 x " + flurryHits + " damage!";
                }

                enemyDamaged();
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
            if (prgHealthEnemy.Value == 0)
            {
                lblStatusBar.Text = "ENEMY" + " has been defeated!";
                enemyDead = true;
            }
            if (enemyDead == true)
            {
                levelComplete.Play();
                HumphreyErik2424RST.frmLevelComplete LevelComplete = new HumphreyErik2424RST.frmLevelComplete();
                LevelComplete.Show();
                this.Hide();
                tmrGameTicker.Stop();
            }
        }

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
                tmrAnimationTicker.Stop();
                picSwipe.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void enemyDamaged()
        {
            lblEnemyHP.Text = prgHealthEnemy.Value + " / " + enemyMaxHP; // Change the health counter to reflect the new value
        }
    }
}
