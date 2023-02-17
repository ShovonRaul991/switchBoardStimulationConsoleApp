using switchBoardStimulationConsoleApp.Devices;
using switchBoardStimulationConsoleApp.Interfaces;
using switchBoardStimulationConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchBoardStimulationConsoleApp
{
    class SwitchBoardServices : IAppliance 
    {
        private List<Appliance> ListOfappliances = new();
        public FanServices FanService = new();
        public AcServices AcService = new();
        public BulbServices BulbService = new();
        
        public SwitchBoardServices() 
        {
            int switches = UserInputHandling.UserInput("Switches");
            int id = 1,fanId=0,acId =0,bulbId = 0;

            

            while (switches > 0)
            {
                Console.WriteLine("1. Fan");
                Console.WriteLine("2. AC");
                Console.WriteLine("3. Bulb");
                int ChooseAppliance = UserInputHandling.UserInput("appliance type",3);
                
                
                if(ChooseAppliance == 1 )
                {

                    FanService.getAllFan().Add(new Fan() { Name = "Appliance " + id + " fan" });
                    ListOfappliances.Add(FanService.getAllFan()[fanId]);
                   
                    fanId++;
                    id++;
                   
                }
                else if(ChooseAppliance == 2 )
                {
                    AcService.getAllAC().Add(new Ac() { Name = "Appliance " + id + " AC" });
                    ListOfappliances.Add(AcService.getAllAC()[acId]);
                    acId++;
                    id++;
                }
                else if(ChooseAppliance == 3 )
                {
                    BulbService.getAllBulb().Add(new Bulb() { Name = "Appliance " + id + " Bulb" });
                    ListOfappliances.Add(BulbService.getAllBulb()[bulbId]);
                    bulbId++;
                    id++;
                }
                switches--;
            }
            

        }
        
        public List<Appliance> GetAppliance()
        {
            return ListOfappliances;
            
        }


        public string StateChange(string id)
        {
            var ApplianceEntity = (from appliance in ListOfappliances
                              where appliance.Name== id
                              select appliance).ToList();

            if (ApplianceEntity[0].State == true)
            {
                ApplianceEntity[0].State = false;
                return "\"OFF\"";
            }
            else
            {
                ApplianceEntity[0].State = true;
                return "\"ON\"";
            }
        }
        public string CheckState(string id)
        {
            var ApplianceEntity = (from appliance in ListOfappliances
                                   where appliance.Name == id
                                   select appliance).ToList();
            if (ApplianceEntity[0].State == true)
            {
                return "\"ON\"";
            }
            else
            {
                return "\"OFF\"";
            }
        }

        public string AskChange(string id)
        {
            var ApplianceEntity = (from appliance in ListOfappliances
                                   where appliance.Name == id
                                   select appliance).ToList();
            if (ApplianceEntity[0].State == false)
            {
                return "\"ON\"";
            }
            else
            {
                return "\"OFF\"";
            }
        }

        
    }
}
