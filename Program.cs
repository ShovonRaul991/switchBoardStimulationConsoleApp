using System;
using System.Collections.Generic;
using System.Linq;

namespace switchBoardStimulationConsoleApp
{
    class Program
    {
        public static void Main()
        {
            
            SwitchBoard board = new();

            

            MenuShow(board.ListOfappliances);
            

            
            /*    
             *    
             *    
             *     //To check if the same reference is added in both the list 
             *  
            Console.WriteLine("Fan list");
            var FanMenu = board.ListOfFans;
            foreach (var item in FanMenu)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Ac list");
            var AcMenu = board.ListofAcs;
            foreach (var item in AcMenu)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Bulb list");
            var BulbMenu = board.ListofBulbs;
            foreach (var item in BulbMenu)
            {
                Console.WriteLine(item.Name);
            }
            */


        }

        public static void MenuShow(List<Appliance> listOfDevice)
        {
            if(listOfDevice.Count == 0)
            {
                Console.WriteLine("No devices detected.");
                return;
            }
            int index = 0;
            var Menu = listOfDevice;
            Console.WriteLine("\nHere is the status of each Appliance:  ");
            foreach(var item in Menu)
            {
                Console.WriteLine(item.Name+" is "+item.CheckState());
            }
            Console.WriteLine("\nChoose among the list of appliance to use: ");
            foreach (var item in Menu)
            {
                Console.WriteLine(index+" "+item.Name);
                index++;
            }
            UseItem(listOfDevice);
        }

        public static void UseItem(List<Appliance> listOfDevice)
        {
            var nameOfAppliance = UserInputHandling.UserInput("Appliance id",listOfDevice.Count-1);
            var ChoosedAppliance = listOfDevice[nameOfAppliance];

            Console.WriteLine("1. "+ChoosedAppliance.Name + " turn " + ChoosedAppliance.AskChange());
            Console.WriteLine("2. Back");
            var selectOption = UserInputHandling.UserInput("Option");
            if(selectOption==1)
            {
                ChoosedAppliance.StateChange();
                MenuShow(listOfDevice);
            }
            else if(selectOption==2)
            {
                MenuShow(listOfDevice);
            }
            else
            {
                Console.WriteLine("Wrong input......");
                MenuShow(listOfDevice);
            }
            
        }

        


    }
}
