using switchBoardStimulationConsoleApp.Devices;
using switchBoardStimulationConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchBoardStimulationConsoleApp.Services
{
    class SwitchBoardServices : IAppliance
    {

        public SwitchBoard CurrentBoard = new();


        public string StateChange(string id)
        {

            var ApplianceEntity = CurrentBoard.GetAppliance().Where(a => a.Name == id).FirstOrDefault();

            if (ApplianceEntity.State == true)
            {
                ApplianceEntity.State = false;
                return "\"OFF\"";
            }
            else
            {
                ApplianceEntity.State = true;
                return "\"ON\"";
            }
        }
        public string CheckState(string id)
        {

            var ApplianceEntity = CurrentBoard.GetAppliance().Where(a => a.Name == id).FirstOrDefault();
            if (ApplianceEntity.State == true)
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

            var ApplianceEntity = CurrentBoard.GetAppliance().Where(a => a.Name == id).FirstOrDefault();
            if (ApplianceEntity.State == false)
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
