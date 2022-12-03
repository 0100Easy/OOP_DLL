using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DLL
{
    
    public class Controller
    {

       public void Control(Hunter player, Map map)
        {
            ConsoleKeyInfo Input = Console.ReadKey(true);
            if (Input.Key == ConsoleKey.W)
            {
                // Move Player Up ( Validate for walls )
            }
            else if (Input.Key == ConsoleKey.S)
            {
                // Move Player Down ( Validate for walls )
            }
            else if (Input.Key == ConsoleKey.A)
            {
                // Move player left ( Validate for walls )
            }
            else if(Input.Key == ConsoleKey.D)
            {
                // Move player right ( Validate for Walls )
            }
        }
             



    }
}
