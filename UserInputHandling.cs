using switchBoardStimulationConsoleApp.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchBoardStimulationConsoleApp
{
    class UserInputHandling
    {
        public static int UserInput(string device)
        {
            bool invalidInput = true;
            int enteredNumber = 0;

            while (invalidInput)
            {
                try
                {
                    Console.Write("Enter the number of {0} ", device);
                    enteredNumber = Convert.ToInt32(Console.ReadLine());
                    if (enteredNumber < 0)
                    {
                        Console.WriteLine("Entered input is wrong: ");
                        continue;
                    }
                    invalidInput = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The error message is: " + ex.Message);
                }

            }
            return enteredNumber;

        }

        public static int UserInput(string device,int range)
        {
            bool invalidInput = true;
            int enteredNumber = 0;

            while (invalidInput)
            {
                try
                {
                    Console.Write("Enter the number of {0} ", device);
                    enteredNumber = Convert.ToInt32(Console.ReadLine());
                    if (enteredNumber < 0 || enteredNumber>range)
                    {
                        Console.WriteLine("Entered input is wrong: ");
                        continue;
                    }
                    invalidInput = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The error message is: " + ex.Message);
                }

            }
            return enteredNumber;

        }

    }
}
