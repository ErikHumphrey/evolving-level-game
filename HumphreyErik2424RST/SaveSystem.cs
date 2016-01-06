using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using HumphreyErik2424RST;

namespace SaveGames
{
    public static class SaveSystem
    {
        static public bool saveGameExists = false;
        static public string name = "Player";
        static public TextWriter saveGame = new StreamWriter("SaveGame.txt");
        static public TextReader loadGame = new StreamReader("SaveGame.txt");

        public static void saveLoader()
        {
            if (saveGameExists)
            {
                name = loadGame.ReadLine();
            }
            //   }
            else
            {
                frmNewSave NewSave = new frmNewSave();
                NewSave.Show();
            }
        }
    }
}
