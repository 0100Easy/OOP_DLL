using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DLL
{
    // Should inherit Character
   public class Hunter : Character
    {
        // Name Property < 20

       public static string name;
        int max = 20;
        int min = 0;
        bool nameisValid = false;
       public string Name
        {
            
            get { return name; }
            set 
            {
                if(name.Length > max)
                {

                    // Error, To Long
                }
                else if(name.Length == min)
                {
                    // Error, No value
                }
                else
                {
                    nameisValid = true;
                }
            }
        }

        //  Property to hold score of Hunter (max == 100,000) (min == 0)
        int maxscore = 100000;
        int minscore = 0;
        int score;
        int Score
        {
            get { return score; }
            set { if(score > maxscore) { } else if(score < minscore) { } else { } }
        }

        // Property to hold state of hunter

        string hunterCurrentState;
        string HunterCurrentState
        {
            get { return hunterCurrentState; }
            // Missing the set
        }

        // Method to move the hunter

        public void MoveHunter(int x, int y)
        {

        }

        

        // Constructer set hunter freeze time to 1 second, receives (x,y) , pass base Object Constructor ???




    }
}
