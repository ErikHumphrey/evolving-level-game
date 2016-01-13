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
using Upgrader;
using HumphreyErik2424RST;
using LevelGenerator;

namespace HumphreyErik2424RST
{
    public partial class frmCheatMenu : Form
    {
        public frmCheatMenu()
        {
            InitializeComponent();
        }

        private void frmCheatMenu_Load(object sender, EventArgs e)
        {
            nudPunchLevel.Value = Upgrades.punchAbilityLevel;
            nudKickLevel.Value = Upgrades.kickAbilityLevel;
            nudBlindLevel.Value = Upgrades.blindAbilityLevel;
            nudHealLevel.Value = Upgrades.blindAbilityLevel;
        }
    }
}
