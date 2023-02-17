using switchBoardStimulationConsoleApp.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchBoardStimulationConsoleApp.Services
{

    class FanServices
    {
        private List<Fan> ListOfFans = new();


        public List<Fan> getAllFan()
        {
            return ListOfFans;
        }
    }
}
