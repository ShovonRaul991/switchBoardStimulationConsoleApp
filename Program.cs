using System;
using System.Collections.Generic;
using System.Linq;
using switchBoardStimulationConsoleApp.Devices;
using switchBoardStimulationConsoleApp.Services;

namespace switchBoardStimulationConsoleApp
{
    class Program
    {
        public static void Main()
        {
            SwitchBoardServices boardService = new();


            //SpecialAc(board.AcService);


            MenuShow(boardService.CurrentBoard,boardService);



            /*    
             *    
             *    
             *     //To check if the same reference is added in both the list 
             *  
            Console.WriteLine("Fan list");
            var FanMenu = boardService.CurrentBoard.GetAllFan();
            foreach (var item in FanMenu)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Ac list");
            var AcMenu = boardService.CurrentBoard.GetAllAC();
            foreach (var item in AcMenu)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Bulb list");
            var BulbMenu = boardService.CurrentBoard.GetAllBulb();
            foreach (var item in BulbMenu)
            {
                Console.WriteLine(item.Name);
            }
            */


        }

        public static void MenuShow(SwitchBoard obj1,SwitchBoardServices obj2)
        {
            List<Appliance> listOfDevice = obj1.GetAppliance();
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
                Console.WriteLine(item.Name+" is "+obj2.CheckState(item.Name));
            }
            
            Console.WriteLine("\nChoose among the list of appliance to use: ");
            foreach (var item in Menu)
            {
                Console.WriteLine(index+" "+item.Name);
                index++;
            }
            UseItem(obj1,obj2);
        }

        
        public static void UseItem(SwitchBoard obj1,SwitchBoardServices obj2)
        {
            List<Appliance> listOfDevice = obj1.GetAppliance();
            var nameOfAppliance = UserInputHandling.UserInput("Appliance id",listOfDevice.Count-1);
            var ChoosedAppliance = listOfDevice[nameOfAppliance];
            
            Console.WriteLine("1. "+ChoosedAppliance.Name + " turn " + obj2.AskChange(ChoosedAppliance.Name));
            Console.WriteLine("2. Back");
            var selectOption = UserInputHandling.UserInput("Option");
            if(selectOption==1)
            {
                obj2.StateChange(ChoosedAppliance.Name);
                MenuShow(obj1,obj2);
            }
            else if(selectOption==2)
            {
                MenuShow(obj1,obj2);
            }
            else
            {
                Console.WriteLine("Wrong input......");
                MenuShow(obj1, obj2);
            }
            
        }
        
    }
}
