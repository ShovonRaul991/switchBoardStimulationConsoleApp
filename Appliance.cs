using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using switchBoardStimulationConsoleApp.Interfaces;

namespace switchBoardStimulationConsoleApp
{
    class Appliance : IAppliance
    {
        public string Name { get; set; }


        public bool State { get; set; }

        public string StateChange()
        {
            
            if(State == true)
            {
                State = false;
                return "\"OFF\"";
            }
            else
            {
                State = true;
                return "\"ON\"";
            }
        }
        public string CheckState()
        {
            if(State == true)
            {
                return "\"ON\"";
            }
            else
            {
                return "\"OFF\"";
            }
        }

        public string AskChange()
        {
            if (State == false)
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
