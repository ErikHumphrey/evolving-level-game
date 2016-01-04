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
using Upgrader;

namespace HumphreyErik2424RST
{
    public partial class frmLevelComplete : Form
    {
        int credits = 0;

        public frmLevelComplete()
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

        private void btnBuyHatchet_MouseEnter(object sender, EventArgs e)
        {
            lblShopDescription.Text = "Chop trees faster. (Survival)";
        }

        void creditsChanged()
        {
            lblCreditCount.Text = credits.ToString();
        }

        private void btnUpgPunch_Click(object sender, EventArgs e)
        {
            switch (Upgrades.punchAbilityLevel)
            {
                case 1:
                    lblPunchName.Text = "Fist Flurry";
                    picPunchIcon.Image = Properties.Resources.flurryicon;
                    break;
                case 2:
                    lblPunchName.Text = "One Punch Man";
                    picPunchIcon.Image = Properties.Resources.onepunchmanicon;
                    btnUpgPunch.Text = "MAX";
                    btnUpgPunch.Enabled = false;
                    break;
            }

            creditsChanged();
            Upgrades.punchAbilityLevel++;
        }

        private void btnUpgBlind_Click(object sender, EventArgs e)
        {
          switch (Upgrades.SmokeAbilityLevel)
            {
                case 1:
                    lblBlindName.Text = "Blinding Powder";
                    picSmokeIcon.Image = Properties.Resources.picsmokebomb;
                    break;
                case 2:
                    lblBlindName.Text = "Smoke Screen";
                    picSmokeIcon.Image = Properties.Resources.picsmokescreen;
                    break;
                case 3:
                    lblBlindName.Text = "Pocket Sand";
                    picBlindIcon.Image = Properties.Resources.picpocketsand;
                    btnUpgSmoke.Text = "MAX";
                    btnUpgSmoke.Enabled = false;
                    break;

            }

            creditsChanged();
            Upgrades.blindAbilityLevel++;
        }

        private void grpShop_Enter(object sender, EventArgs e)
        {

        }
    }
}
