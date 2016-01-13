// This class file picks contains global variables changed by the shop.

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

namespace Upgrader
{
    public static class Upgrades
    {
        // Bonuses
        static public int speedBonus;
        static public int healthBonus;

        // Shop elements
        static public int credits;

        // Battle (Punches are always top left ability, kicks are top right)
        static public int punchAbilityLevel = 1;
        static public int kickAbilityLevel = 1;
        static public int blindAbilityLevel = 0;
        static public int healAbilityLevel = 1;
    }
}
