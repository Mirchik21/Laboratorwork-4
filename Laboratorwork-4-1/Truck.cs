using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorwork_4_1
{
    class Truck
    {
        public int id;
        public string name;
        public string driver;
        public string state;

        public IState State;
        public Truck ()
        {

        }
        public override string ToString()
        {
            return $"id: {id}, name: {name}, driver: {driver}, state: {state}";
        }

        public void ChangeState()
        {
            switch(state)
            {
                case "base":
                    this.State = new InBaseState();
                    break;
                case "run":
                    this.State = new InRunState();
                    break;
                case "repair":
                    this.State = new InRepairState();
                    break;

            }
            Console.WriteLine("what are you want do?");
            Console.WriteLine("1 - change to driver");
            Console.WriteLine("2 - go by truck");
            Console.WriteLine("3 - truck repair");

            string action = Console.ReadLine();
            if(action == "1")
                this.State.ChangeDriver(this);
            else if(action == "2")
                this.State.StartRun(this);
            else if (action == "3")
                this.State.StartRepair(this);
        }
    }
}
