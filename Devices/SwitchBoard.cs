using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchBoardStimulationConsoleApp.Devices
{
    class SwitchBoard
    {

        private readonly List<Appliance> ListOfappliances = new();
        private readonly List<Bulb> ListOfBulbs = new();
        private readonly List<Fan> ListOfFans = new();
        private readonly List<Ac> ListOfAcs = new();


        public SwitchBoard()
        {
            int switches = UserInputHandling.UserInput("Switches");
            int id = 1, fanId = 0, acId = 0, bulbId = 0;



            while (switches > 0)
            {
                Console.WriteLine("1. Fan");
                Console.WriteLine("2. AC");
                Console.WriteLine("3. Bulb");
                int ChooseAppliance = UserInputHandling.UserInput("appliance type", 3);


                if (ChooseAppliance == 1)
                {

                    ListOfFans.Add(new Fan() { Name = "Appliance " + id + " fan" });
                    ListOfappliances.Add(ListOfFans[fanId]);

                    fanId++;
                    id++;

                }
                else if (ChooseAppliance == 2)
                {
                    ListOfAcs.Add(new Ac() { Name = "Appliance " + id + " AC" });
                    ListOfappliances.Add(ListOfAcs[acId]);
                    acId++;
                    id++;
                }
                else if (ChooseAppliance == 3)
                {
                    ListOfBulbs.Add(new Bulb() { Name = "Appliance " + id + " Bulb" });
                    ListOfappliances.Add(ListOfBulbs[bulbId]);
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
        public List<Bulb> GetAllBulb()
        {
            return ListOfBulbs;
        }
        public List<Fan> GetAllFan()
        {
            return ListOfFans;
        }
        public List<Ac> GetAllAC()
        {
            return ListOfAcs;
        }

    }
}
