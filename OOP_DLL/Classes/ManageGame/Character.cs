using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DLL
{
    // Character cannot be instanciated = Abstract
    public abstract class Character 
    {
        // 2 Properties Hold X,Y    
        // Validate against MaxX, MaxY

        int maxX = Console.WindowWidth;
        int maxY = Console.WindowHeight;
        public int x;
        public int y;

        // Validate X and Y

        int X
        {
            get { return x; }
            set { if (x > maxX) { x = maxX; } else if (x == 0) { } x = value; }
        }

        // same ^ Y

        int Y
        {
            get { return y; }
            set { if (y > maxY) { y = maxY; } else if (y == 0) { } y = value; }
        }

        // 2 Properties to hold width and height of map
        
            //** Created in Map Class (mapW, mapH)

        // 2 Properties to hold Max Hp < 30 and Current Hp
        public int max_HP = 30;
        public int min_HP = 0;
        public int current_hp;

        public int Current_HP
        {
            get { return current_hp; }
            set { if (current_hp > max_HP) { current_hp = max_HP; } else if (current_hp < min_HP) { Hunter_Dead(); } else { current_hp = value; } }
        }

        // Create Hunter is dead bool

        public bool Hunter_Dead()
        {
            return true;
        }

        // 2 Properties to hold the strength (ad) and the armor (max 4)
        public int playerAD = 6;
        public int playerArmor = 3;

        // 1 Property to hold num of milliseconds for timer, FreezeTime (10 seconds)

        public int milliseconds = 10000;

        // Abstract method to move Character, Has (x,y) and return bool

        protected bool MoveChar(int x, int y)
        {
            return true;
        }
    }
}
