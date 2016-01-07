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

namespace SaveGames
{
    public static class SaveSystem
    {
        static public bool saveGameExists = false;
        static public string name = "Player";
        static public TextWriter saveGame = new StreamWriter("SaveGame.txt");

        public static void SaveLoader()
        {
           if (saveGameExists)
            {
            TextReader loadGame = new StreamReader("SaveGame.txt");
            name = loadGame.ReadLine();
            loadGame.Close();
            }
            else
            {
                frmNewSave NewSave = new frmNewSave();
                NewSave.Show();
            }
        }
    }
}
