using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DLL
{
    public class Sword : Character
    {
        // Create a RNG Dmg from 4,9 when Sword gets created

        int increase_dmg = 0;
        public int Sword_DMG
        {
            get { return increase_dmg; }
            //                                     Included, Excluded
            set { increase_dmg = RNG.Get_Instance().Next(4,10);
                increase_dmg = value;  }
        }

        public int Row { get; }
        public int Column { get; }

        // After attack, 1/5 chance Sword breaks

        // Save rng number to a
        int a = 0;

        public Sword(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public bool RNGBreak()
        {                     // Included, Excluded
            a = RNG.Get_Instance().Next(1, 6);
            if(a == 2)
            {
                return true; // True means the sword is broken
            }

            return false; // Sword not broken

        }




    }
}
