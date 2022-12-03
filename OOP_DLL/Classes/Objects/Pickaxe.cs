using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DLL
{
   public class Pickaxe : Character
    {

        // Validate if the pickaxe breaks
        // Pickaxe breaks wall

        bool isPickaxeEquiped = false;

        public Pickaxe(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int Row { get; }
        public int Column { get; }

        // Did it break
        public bool PickaxeRngBreak()
        {
            int a = RNG.Get_Instance().Next(1, 4);
            if(a == 2)
            {
                return true;
            }
            return false;
        }


    }
}
