using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchBoardStimulationConsoleApp.Interfaces
{
    interface IAppliance
    {
        string StateChange(string id);
        string CheckState(string id);

        string AskChange(string id);
    }
}
