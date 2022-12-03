using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_DLL;

namespace OOP_DLL
{
    public class ConsoleGameManager
    {
        public void RunGameLoop()
        {
            bool GameOver = false;
            Map map = new Map();
            Hunter hunter = new Hunter();
            Monster monster = new Monster();
            do
            {
                Console.WriteLine("This game uses the buttons WASD to move ");
                Console.WriteLine("Select map");

                string MapName = Map.ConsoleMapSelection();

                Map.LoadMap(MapName, hunter, monster);
                Map.DrawConsoleMap(hunter);

                Console.ReadKey(true);


            } while (GameOver == false);

        }

       


    }
}
