using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorwork_4_1
{
    class InRunState: IState
    {
        Driver[] drivers = JsonManager.GetDrivers();
        string name = "run";
        public string Name { get { return name; } }
        public void ChangeDriver(Truck truck)
        {
            Console.WriteLine("the driver cannot be changed on the way");
        }
        public void StartRun(Truck truck)
        {
            
            Console.WriteLine("truck and so on the way");
        }
        public void StartRepair(Truck truck)
        {
            truck.state = "repair";
            Console.WriteLine($"state of truck - {truck.state}");
        }

    }
}
