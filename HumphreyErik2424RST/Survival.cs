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
        string treeType;

        public frmSurvival()
        {
            InitializeComponent();
        }

        private void frmSurvival_Load(object sender, EventArgs e)
        {/*
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
    }
}
