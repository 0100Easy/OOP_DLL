using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DLL
{
    class Potion : Character
    {
        // Propery to hold the type of potion found
        // Create Enum
        // 4 Types potion == Enum

        public bool ChangingState()
        {

            int dice = RNG.Get_Instance().Next(1,7);

            if(dice == 1)
            {
                // return Poisoned state true
            }
            else if(dice == 2 || dice == 3)
            {
                // return Speed state
            } 
            else if(dice == 4 || dice == 5)
            {
                // return Invis State
            }
            else if(dice == 6)
            {
                // return the strength state 
            }
            return false; // So no error

        }


    }
}
