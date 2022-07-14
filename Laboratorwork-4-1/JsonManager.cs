using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Laboratorwork_4_1
{
    class JsonManager
    {
        public static Truck[] Trucks;
        public static Driver[] Drivers;

        public static Truck[] GetTrucks()
        {
            if(Trucks == null)
            {
                string fileData = File.ReadAllText("../../../Data/Trucks.json");
                byte[] byteData = Encoding.UTF8.GetBytes(fileData);
                Encoding.Convert(Encoding.UTF8, Encoding.Unicode, byteData);
                Trucks = JsonConvert.DeserializeObject<Truck[]>(fileData);
            }
            return Trucks;
        }
        public static Driver[] GetDrivers()
        {
            if (Drivers == null)
            {
                string fileData = File.ReadAllText("../../../Data/Drivers.json");
                byte[] byteData = Encoding.UTF8.GetBytes(fileData);
                Encoding.Convert(Encoding.UTF8, Encoding.Unicode, byteData);
                Drivers = JsonConvert.DeserializeObject<Driver[]>(fileData);
            }
            return Drivers;
        }
    }
}
