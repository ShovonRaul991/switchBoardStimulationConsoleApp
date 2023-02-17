using switchBoardStimulationConsoleApp.Devices;
using switchBoardStimulationConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchBoardStimulationConsoleApp.Services
{

    class BulbServices
    {
        private List<Bulb> ListOfBulbs = new();

        public List<Bulb> getAllBulb()
        {
            return ListOfBulbs;
        }
    }
}
