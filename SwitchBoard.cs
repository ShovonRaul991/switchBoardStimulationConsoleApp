using switchBoardStimulationConsoleApp.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchBoardStimulationConsoleApp
{
    class SwitchBoard
    {
        public List<Appliance> ListOfappliances = new();
        public List<Fan> ListOfFans= new();
        public List<Ac> ListofAcs= new();
        public List<Bulb> ListofBulbs = new();
        public SwitchBoard() 
        {
            int switches = UserInputHandling.UserInput("Switches");
            int id = 1,fanId = 0,AcId = 0, bulbid = 0;
            while (switches > 0)
            {
                Console.WriteLine("1. Fan");
                Console.WriteLine("2. AC");
                Console.WriteLine("3. Bulb");
                int ChooseAppliance = UserInputHandling.UserInput("appliance type",3);
                
                
                if(ChooseAppliance == 1 )
                {
                    ListOfFans.Add(new Fan() { Name = "Appliance "+id+" fan"});
                    
                    //ListOfFans.Add(new Fan() {Name="Fan"+fanid,State=false });
                    ListOfappliances.Add(ListOfFans[fanId]);
                    fanId++; 
                    id++;
                }
                else if(ChooseAppliance == 2 )
                {
                    ListofAcs.Add(new Ac() { Name = "Appliance "+id+" AC"});
                    //ListofAcs.Add(new Ac() { Name="Ac"+acid,State=false });
                    ListOfappliances.Add(ListofAcs[AcId]);
                    AcId++;
                    id++;
                }
                else if(ChooseAppliance == 3 )
                {
                    ListofBulbs.Add(new Bulb() { Name = "Appliance "+id+" bulb"});
                    //ListofBulbs.Add(new Bulb() { Name = "Bulb" + bulbid, State = false });
                    ListOfappliances.Add(ListofBulbs[bulbid]);
                    bulbid++;
                    id++;
                }
                switches--;
            }
            
        }
    }
}
