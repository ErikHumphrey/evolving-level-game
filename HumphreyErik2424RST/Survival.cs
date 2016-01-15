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
using LevelGenerator;

namespace HumphreyErik2424RST
{
    public partial class frmSurvival : Form
    {
        int logsNeeded;
        int fireBurnTimer = 0;
        int fishingSpotFrame = 3;
        int fireFrame = 3;
        string treeType;

        public frmSurvival()
        {
            InitializeComponent();
        }

        private void frmSurvival_Load(object sender, EventArgs e)
        {
            tmrFishingSpotAnimation.Start();
            tmrFireAnimation.Start();

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
    }
}
