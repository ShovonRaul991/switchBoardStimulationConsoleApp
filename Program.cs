using System;
using System.Collections.Generic;
using System.Linq;

namespace switchBoardStimulationConsoleApp
{
    class Program
    {
        public static void Main()
        {
            
            SwitchBoardServices board = new();


            //SpecialAc(board.AcService);
            
            
            MenuShow(board);
            

            
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

        public static void MenuShow(SwitchBoardServices obj)
        {
            List<Appliance> listOfDevice = obj.GetAppliance();
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
                Console.WriteLine(item.Name+" is "+obj.CheckState(item.Name));
            }
            
            Console.WriteLine("\nChoose among the list of appliance to use: ");
            foreach (var item in Menu)
            {
                Console.WriteLine(index+" "+item.Name);
                index++;
            }
            UseItem(obj);
        }

        
        public static void UseItem(SwitchBoardServices obj)
        {
            List<Appliance> listOfDevice = obj.GetAppliance();
            var nameOfAppliance = UserInputHandling.UserInput("Appliance id",listOfDevice.Count-1);
            var ChoosedAppliance = listOfDevice[nameOfAppliance];
            
            Console.WriteLine("1. "+ChoosedAppliance.Name + " turn " + obj.AskChange(ChoosedAppliance.Name));
            Console.WriteLine("2. Back");
            var selectOption = UserInputHandling.UserInput("Option");
            if(selectOption==1)
            {
                obj.StateChange(ChoosedAppliance.Name);
                MenuShow(obj);
            }
            else if(selectOption==2)
            {
                MenuShow(obj);
            }
            else
            {
                Console.WriteLine("Wrong input......");
                MenuShow(obj);
            }
            
        }
        
        /*
        public static void SpecialAc(AcServices obj)
        {
            var acEntities = obj.getAllAC();
            if (acEntities.Count == 0)
                return;
            int acId = 0;
            foreach (var acEntity in acEntities) 
            { 
                Console.WriteLine(acId + ". " + acEntity.Name); 
                acId++;
            }
            var nameOfAppliance = UserInputHandling.UserInput("AC id", acEntities.Count - 1);
            var choosenAC = acEntities[nameOfAppliance];

            obj.servicing(choosenAC.Name);
        }
        
        */
    }
}
