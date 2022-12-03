using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace OOP_DLL
{
    public class Map
    {

        // DLL MAP 2 Variables Width < 75 and Height < 30 , Private set Public Get
        public static int mapW;
        public static int mapH;

        // make public, so set can be private
        public int Map_Width
        {
            get { return mapW; }
            private set { int max = 75; int min = 0; mapW = value; if(value > max) { value = max; } else if(value < min) { value = min; } }
        }

       public int Map_Height
        {
            get { return mapH; }
            private set { int max = 30; int min = 0; mapW = value; if (value > max) { value = max; } else if (value < min) { value = min; } }
        }

        // 1D array to hold name of strings of .Map
        string[] getMapNames;

        string[] GetMapNames
        {
            get { return getMapNames; }
            set {  } // return the correct map, when selected
        }

        string GetTxtname
        {
            get { return mapName; }
            set { mapName = value; }
        }

        // 2D char array to hold the data contained in selected Map
        public static string Path = @"C:\Users\vinny\source\repos\OOP_DLL\OOP_DLL\bin\Maps\";
        public static string mapName = " ";

        public static int userSelection;
        public static bool isMapValid = false;
        public static string ConsoleMapSelection()
        {
            do
            {
                Console.WriteLine("Select a map");
                int a = Convert.ToInt32(Console.ReadLine());
                userSelection = a;

                if (userSelection == 1)
                {
                    mapName = ("easy.map"); 
                    

                }

                else if (userSelection == 2)
                {
                    mapName = ("medium.map");
                }

                else if (userSelection == 3)
                {
                    mapName = ("hard.map");
                }

                return mapName;

            } while (isMapValid == true);
            
           
        }
        
      

        public static Character[,] Player = null;

        public char[,] mapData;
        public int mapChoice;
        public char[,] MapData
        {
            get { return mapData; }
            set 
            {
               


            }
        }
        // Make the size for every square in array
        public static int tileSize = 20;



        // Create Load Map

        /* if(UserSelection == 1){
         * MapName = "easy.map";
         * }
         * 
         * 
         *  string[] LoadTheTxt = File.ReadAllLines(Path + MapEasy);
            \
         * 
         * 
         * 
         * */

       public static void LoadMap(string MapName, Hunter hunter, Monster monster)
        {


            // Open txt file and loop in it
            // Create Load Map
          

            string[] LoadTheTxt = File.ReadAllLines(Path + MapName);
            mapH = LoadTheTxt.Length;
            mapW = LoadTheTxt[0].Length;

            // Character array = New Object Array 

            Player = new Character[mapH, mapW];

            foreach (string line in LoadTheTxt)
            {

                // ATM i hard coded MapEasy,  SWITCH CASE FOR THE MAP SELECTED, UNHARD CODE IT LATER
                char[] chars = line.ToCharArray();
                // Column and Row act as Y,X

                // Declare Column
                int column = 0;
                // Declare Row
                int row = 0;

                // After it loads all the data (Objects location)

                foreach (char objects in chars)
                {
                    // All Child Objects of Character
                    Character obj = null;
                    switch (objects)
                    {
                        // All my objects have errors, Quick solution says create Constructor with Properties 
                        case 'S':
                            obj = new Sword(row, column);
                            break;
                        case 'X':
                            obj = new Pickaxe(row, column);
                            break;
                        case 'O':
                            obj = new Shield(row, column);
                            break;
                        case 'G':
                            obj = new GG(row, column);
                            break;
                        case ' ':
                            obj = new Empty_square(row, column);
                            break;
                        case '#':
                            obj = new Wall(row, column);
                            break;
                       // ADD HUNTER AND MONSTER/MONSTERS **MISSING**
                    }
                    // Character Array Must be saved to Obj, So Load Data Contains all Information on New Objects
                    Player[row, column] = obj;
                    column++; // end of column forloop
                }
                row++; // end of row forloop


            }

            
            
            


            // Calculate the height and width of map, Set them in MapWidth and MapHeight

            //  Create Hunter and Monster / Monsters after

          
        }
        public static char Draw;
        public static void DrawConsoleMap(Hunter hunter)
        {
            for(int row = 0; row < Player.GetUpperBound(0) + 1; row++)
            {
                for(int column = 0; column < Player.GetUpperBound(1) + 1; column++)
                {
                    if(Draw == 'H')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                   else if(Draw == 'S')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                   else if(Draw == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                   else if(Draw == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                   else if(Draw == 'G')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                   else if(Draw == ' ')
                    {
                        // Empty space
                    }
                   else if(Draw == '#')
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(Draw);
                }
                Console.WriteLine();
            }
        }




    }
}
