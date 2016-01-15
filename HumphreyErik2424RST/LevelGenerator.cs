// This class file picks a random level using a static class so that its method can be called from any other file.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO; // Input-output for writing and reading save file text documents
using System.Threading.Tasks;
using System.Windows.Forms;
using HumphreyErik2424RST;

namespace LevelGenerator
{
    public static class LevelGen
    {
        static public bool saveGameExists = false;
        static Random rnd = new Random();
        static public string name = "Player";
        static public int difficulty = 0;
        static int levelIndex = 0;
        static HumphreyErik2424RST.frmSplashScreen myMenu = new HumphreyErik2424RST.frmSplashScreen();

        public static void NewLevel()
        {
            difficulty++;
            // Open a random level
            levelIndex = rnd.Next(1, 6);
            // frmBattle Battle = new frmBattle();
            // Battle.Show();
            frmSurvival Survival = new frmSurvival();
            Survival.Show();

            myMenu.Hide();
            /* 
            switch (levelIndex)
            {
                // Survival
                case 1:
                    HumphreyErik2424RST.frmSurvival Survival = new HumphreyErik2424RST.frmSurvival();
                    Survival.Show();
                    myMenu.Hide();
                    break;
                // Battle
                case 2:
                    frmBattle Battle = new frmBattle();
                    Battle.Show();
                    myMenu.Hide();
                    break;
                // RPG
                case 3:
                    frmRoleplayingGame RPG = new frmRoleplayingGame();
                    RPG.Show();
                    myMenu.Hide();
                    break;
                // Debugger (actually the name of a level for the end user to play)
                case 4:
                    frmDebugger Debugger = new frmDebugger();
                    Debugger.Show();
                    myMenu.Hide();
                    break;
                case 5:
                    frmSurvival Form3 = new frmSurvival();
                    Form3.Show();
                    myMenu.Hide();
                    break;
             
            }*/
        }
    }
}