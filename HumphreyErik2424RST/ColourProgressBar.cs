using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumphreyErik2424RST;

/* Borrowed code used in the Battle level to change the progress bar style while still using VisualStyles, otherwise the program would look like Windows XP.
 * Originally answered by user1032613 on StackOverflow
 * Permalink: http://stackoverflow.com/a/9753302/3011319
 */

namespace ColourProgressBar
{
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
