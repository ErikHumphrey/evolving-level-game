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

        public static void SaveLoader()
        {
            // Open the NewSave form 
            frmNewSave NewSave = new frmNewSave();
            NewSave.Show();
        }
    }
}
