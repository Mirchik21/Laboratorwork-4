using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorwork_4_1
{
    interface IState
    {
        string Name { get; }
        void ChangeDriver(Truck truck);
        void StartRun(Truck truck);
        void StartRepair(Truck truck);
        
    }
}
