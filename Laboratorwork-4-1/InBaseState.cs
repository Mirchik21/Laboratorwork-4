using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorwork_4_1
{
    internal class InBaseState : IState
    {
        Driver[] drivers = JsonManager.GetDrivers(); 
        string name = "base";
        public string Name { get { return name; } }
        public void ChangeDriver(Truck truck)
        {
            Driver driver = Array.Find(drivers, item => item.id != truck.id);
            truck.driver = driver.name;
            Console.WriteLine("Driver replaced successfully");
            
        }
        public void StartRun(Truck truck)
        {
            truck.state = "run";
            Console.WriteLine($"state of truck - {truck.state}");
        }
        public void StartRepair(Truck truck)
        {
            truck.state = "repair";
            Console.WriteLine($"state of truck - {truck.state}");
        }
    }
}
