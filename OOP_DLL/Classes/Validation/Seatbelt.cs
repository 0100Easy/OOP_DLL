using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_DLL
{
    class Seatbelt
    {
        // Copied from class Notes LoopExerciseDebug


        const string ERROR_FILE = "Error.log";
        const bool DEBUG_MODE = true;


        static void logError(Exception myCommonException, string sFunctionName)
        {
            //handle the crash


            //detailed error
            string detailedError = DateTime.Now + " An error occured in " + sFunctionName + " myCommonException.Message";

            //write into file
            //Open the file for writing 
            StreamWriter sw = new StreamWriter(ERROR_FILE, true);

            //write the detailed error into the file
            sw.WriteLine(detailedError);

            //close the file
            sw.Close();

            if (DEBUG_MODE)
            {
                Console.WriteLine(detailedError);
            }
            else
            {
                Console.WriteLine("An ERROR occured " + DateTime.Now);
            }

            //Show generic message
            Console.WriteLine("An ERROR occured " + DateTime.Now);
            Console.ReadKey();
        }


    }

    // Error code in the catch
    /*
     *  //Show generic message
                Console.WriteLine("An ERROR occured " + DateTime.Now);

                //soft coded version
                logError(myException, System.Reflection.MethodBase.GetCurrentMethod().Name);
                taxesAmount = 0;
                return ERROR_DECIMAL;

                Console.ReadKey();
     */
}
