using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DLL
{
    class Shield : Character
    {
        // Same Process as Sword class, Copy --> paste, change variable names
        // RNG Armor = 3,6
        // RNGBROKEN = 1,4

        int increase_armor = 0;
        public int Shield_Armor
        {
            get { return increase_armor; }
            //                                     Included, Excluded
            set
            {
                increase_armor = RNG.Get_Instance().Next(3, 7);
                increase_armor = value;
            }
        }

        public int Row { get; }
        public int Column { get; }

        // After attack, 1/5 chance Sword breaks

        // Save rng number to a
        int a = 0;

        public Shield(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public bool RNGShieldBreak()
        {                     // Included, Excluded
            a = RNG.Get_Instance().Next(1, 5);
            if (a == 2)
            {
                return true; // True means the shield is broken
            }

            return false; // Shield not broken

        }



    }
}
