using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DLL
{
    
        public class RNG : Random
        {

            // Instance is a variable we can create to have the class of something to be static
            // this would equate to one copy

            // This keeps the thread secure
            private static RNG instance = null;

            private RNG() : base() { } // this calls constructor
                                       // Create a function called Get_instance
            public static RNG Get_Instance()
            {
                if (instance == null)
                {
                    // this is saying, in any new sitation, run this code
                    // if instance is the same variable, while = same number
                    // if instance is a new variable, new RNG
                    instance = new RNG();
                }

                // The return
                return instance;


            }


        }
    }

