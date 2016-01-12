using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using LevelGenerator;
using SaveGames;

namespace HumphreyErik2424RST
{
    public partial class frmNewSave : Form
    {
        // Same custom font code featured in past projects
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();

        // New font
        Font labelText;

        public frmNewSave()
        {
            InitializeComponent();

            // Use font bundled in program resources
            byte[] fontData = Properties.Resources.menuFont;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.menuFont.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.menuFont.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            // Declare typeface properties
            labelText = new Font(fonts.Families[0], 11F);
        }

        private void frmNewSave_Load(object sender, EventArgs e)
        {
            lblLoginHeader.Font = lblNameTitle.Font = txtNameEntry.Font = labelText;
            this.ActiveControl = txtNameEntry;
        }

        private void txtNameEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13) // Enter
            {
                TextWriter saveGame = new StreamWriter("SaveGame.txt");
                SaveSystem.name = txtNameEntry.Text;
                saveGame.WriteLine(SaveSystem.name);
                SaveSystem.saveGameExists = true;
                saveGame.WriteLine(SaveSystem.saveGameExists);
                saveGame.Close();
                this.Close();
            }
        }

    }
}
