using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumphreyErik2424RST;
using Upgrader;

namespace HumphreyErik2424RST
{
    public partial class frmLevelComplete : Form
    {
        int credits = 9999999;

        public frmLevelComplete()
        {
            InitializeComponent();
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            LevelGenerator.LevelGen.NewLevel();
            saveGame();
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            DialogResult wantsToStop = MessageBox.Show("Are you sure you want to return to the main menu?\r\n\r\nProgress up to this point will be saved.", "Confirm return", MessageBoxButtons.YesNo);
            if (wantsToStop == DialogResult.Yes)
            {
                this.Hide();
                frmSplashScreen menu = new frmSplashScreen();
                menu.Show();
            }

            saveGame();
        }

        private void btnBuyHatchet_MouseEnter(object sender, EventArgs e)
        {
            lblShopDescription.Text = "Chop trees faster. (Survival)";
        }

        void creditsChanged()
        {
            lblCreditCount.Text = credits.ToString();
        }

        // Upgrade punch ability

        private void btnUpgPunch_Click(object sender, EventArgs e)
        {
            switch (Upgrades.punchAbilityLevel)
            {
                case 1:
                    lblPunchName.Text = "Fist Flurry";
                    picPunchIcon.Image = Properties.Resources.iconFistFlurry;
                    Upgrades.punchAbilityLevel++;
                    break;
                case 2:
                    lblPunchName.Text = "One Punch Man";
                    picPunchIcon.Image = Properties.Resources.iconOnePunchMan;
                    Upgrades.punchAbilityLevel++;
                    btnUpgPunch.Text = "MAX";
                    btnUpgPunch.Enabled = false;
                    break;
            }

            creditsChanged();
        }

        // Upgrade kick ability

        private void btnUpgKick_Click(object sender, EventArgs e)
        {
            switch (Upgrades.kickAbilityLevel)
            {
                case 1:
                    lblKickName.Text = "Tornado Kick";
                    picKickIcon.Image = Properties.Resources.iconTornadoKick;
                    Upgrades.kickAbilityLevel++;
                    break;
                case 2:
                    lblKickName.Text = "Whirlwind Kick";
                    picKickIcon.Image = Properties.Resources.iconWhirlwindKick;
                    Upgrades.kickAbilityLevel++;
                    btnUpgKick.Text = "MAX";
                    btnUpgKick.Enabled = false;
                    break;
            }

            creditsChanged();
        }

        // Upgrade blind ability

        private void btnUpgBlind_Click(object sender, EventArgs e)
        {
            switch (Upgrades.blindAbilityLevel)
            {
                case 0:
                    lblBlindName.Text = "Blinding Powder";
                    picBlindIcon.Image = Properties.Resources.iconBlindingPowder;
                    break;
                case 1:
                    lblBlindName.Text = "Smoke Screen";
                    picBlindIcon.Image = Properties.Resources.iconSmokeScreenAlt;
                    break;
                case 2:
                    lblBlindName.Text = "Pocket Sand";
                    picBlindIcon.Image = Properties.Resources.iconPocketSand;
                    btnUpgBlind.Text = "MAX";
                    btnUpgBlind.Enabled = false;
                    break;

            }

            creditsChanged();
            Upgrades.blindAbilityLevel++;
        }
        //                     TextReader loadUpgrade = new StreamReader("Upgrades.txt");
        // Upgrade heal

        private void btnUpgHeal_Click(object sender, EventArgs e)
        {
            switch (Upgrades.healAbilityLevel)
            {
                case 1:
                    lblHealName.Text = "Rest";
                    picHealIcon.Image = Properties.Resources.iconRest;
                    break;
                case 2:
                    lblHealName.Text = "Meditate";
                    picHealIcon.Image = Properties.Resources.iconMeditate;
                    break;
                case 3:
                    lblHealName.Text = "Self-Repair";
                    picHealIcon.Image = Properties.Resources.iconSelfRepair;
                    btnUpgHeal.Text = "MAX";
                    btnUpgHeal.Enabled = false;
                    break;
            }

            Upgrades.healAbilityLevel++;


            creditsChanged();
        }

        // Save upgrade level values - order is important
        void saveGame()
        {
            File.Delete("upgrades.txt");
            File.Delete("credits.txt");

            TextWriter ssUpgrades = new StreamWriter("upgrades.txt");
            TextWriter ssCredits = new StreamWriter("credits.txt");

            ssUpgrades.WriteLine(Upgrades.punchAbilityLevel);
            ssUpgrades.WriteLine(Upgrades.kickAbilityLevel);
            ssUpgrades.WriteLine(Upgrades.blindAbilityLevel);
            ssUpgrades.WriteLine(Upgrades.healAbilityLevel);

            ssUpgrades.WriteLine(Upgrades.axeAbilityLevel);
            ssUpgrades.WriteLine(Upgrades.fireAbilityLevel);
            ssUpgrades.WriteLine(Upgrades.fishAbilityLevel);
            ssUpgrades.WriteLine(Upgrades.cookAbilityLevel);

            ssCredits.WriteLine(Upgrades.credits);

            ssUpgrades.Close();
            ssCredits.Close();
        }

        private void btnUpgAxe_Click(object sender, EventArgs e)
        {
            switch (Upgrades.axeAbilityLevel)
            {
                case 0:
                    lblHealName.Text = "Bronze hatchet";
                    picHealIcon.Image = Properties.Resources.iconRest;
                    break;
                case 1:
                    lblHealName.Text = "Iron hatchet";
                    picHealIcon.Image = Properties.Resources.imgSurvivalIronHatchet;
                    break;
                case 2:
                    lblHealName.Text = "Goldsteel hatchet";
                    picHealIcon.Image = Properties.Resources.imgSurvivalGoldsteelHatchet;
                    btnUpgHeal.Text = "MAX";
                    btnUpgHeal.Enabled = false;
                    break;
            }
        }

        private void btnUpgFire_Click(object sender, EventArgs e)
        {
            switch (Upgrades.fireAbilityLevel)
            {
                case 1:
                    lblHealName.Text = "";
                    picHealIcon.Image = Properties.Resources.iconRest;
                    break;
                case 2:
                    lblHealName.Text = "Tinderbox";
                    picHealIcon.Image = Properties.Resources.imgSurvivalTinderbox;
                    break;
                case 3:
                    lblHealName.Text = "Conjure Lightning";
                    picHealIcon.Image = Properties.Resources.imgSurvivalConjureLightningImproved;
                    btnUpgHeal.Text = "MAX";
                    btnUpgHeal.Enabled = false;
                    break;
            }
        }

        private void btnUpgFish_Click(object sender, EventArgs e)
        {
            switch (Upgrades.fishAbilityLevel)
            {
                case 1:
                    lblHealName.Text = "Fishing net";
                    picHealIcon.Image = Properties.Resources.iconRest;
                    break;
                case 2:
                    lblHealName.Text = "Fishing rod";
                    picHealIcon.Image = Properties.Resources.iconMeditate;
                    break;
                case 3:
                    lblHealName.Text = "Golden harpoon";
                    picHealIcon.Image = Properties.Resources.iconSelfRepair;
                    btnUpgHeal.Text = "MAX";
                    btnUpgHeal.Enabled = false;
                    break;
            }
        }

        private void btnUpgCook_Click(object sender, EventArgs e)
        {
            switch (Upgrades.cookAbilityLevel)
            {
                case 1:
                    lblHealName.Text = "Cookbook: Instincts";
                    picHealIcon.Image = Properties.Resources.iconRest;
                    break;
                case 2:
                    lblHealName.Text = "Cookbook: Sous-chef";
                    picHealIcon.Image = Properties.Resources.iconMeditate;
                    break;
                case 3:
                    lblHealName.Text = "Cookbook: Ramsay";
                    picHealIcon.Image = Properties.Resources.iconSelfRepair;
                    btnUpgHeal.Text = "MAX";
                    btnUpgHeal.Enabled = false;
                    break;
            }
        }

        private void frmLevelComplete_Load(object sender, EventArgs e)
        {

        }

        private void btnUpgPunch_MouseEnter(object sender, EventArgs e)
        {
            lblShopDescription.Text = "Upgrade Punch ability. (500 credits)";
            lblUpgradeCost.Text = "500";
        }
    }
}
