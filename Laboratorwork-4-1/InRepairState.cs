using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorwork_4_1
{
    class InRepairState: IState
    {
        Driver[] drivers = JsonManager.GetDrivers();
        string name = "repair";
        public string Name { get { return name; } }
        public void ChangeDriver(Truck truck)
        {
            Console.WriteLine("The driver cannot be changed on the way!");

        }
        public void StartRun(Truck truck)
        {
            Random rand = new Random(); 
            int number = rand.Next(1, 2 + 1);
            if (number == 1)
                truck.state = "run";
            else if (number == 2)
                truck.state = "base";
            Console.WriteLine($"state of truck - {truck.state}");
        }
        public void StartRepair(Truck truck)
        {
            Console.WriteLine("The truck is under repair");
        }
    }
}
