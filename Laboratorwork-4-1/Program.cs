namespace Laboratorwork_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#  |Truck      |Driver   |State   ");
            Console.WriteLine("-------------------------------");


            try
            {
                Driver[] drivers = JsonManager.GetDrivers();
                Truck[] trucks = JsonManager.GetTrucks();

                foreach (Truck t in trucks)
                {
                    Console.WriteLine(t.id + "  |" + t.name + "  |" + t.driver + "  |" + t.state);
                    Console.WriteLine("-------------------------------");
                }
                Console.WriteLine("\n");
                Console.WriteLine("#  |Driver |   ");
                Console.WriteLine("-------------------------------");
                foreach (Driver driver in drivers)
                {
                    Console.WriteLine(driver.id + "  |" + driver.name + "  |");
                    Console.WriteLine("-------------------------------");
                }
                Truck truck = GetDriver(trucks);
                Console.WriteLine(truck);
                truck.ChangeState();

                Console.WriteLine("#  |Truck      |Driver   |State   ");
                Console.WriteLine("-------------------------------");
                foreach (Truck t in trucks)
                {
                    Console.WriteLine(t.id + "  |" + t.name + "  |" + t.driver + "  |" + t.state);
                    Console.WriteLine("-------------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static Truck GetDriver(Truck[] trucks)
        {
            Console.WriteLine("Enter ID for search truck");
            int id = int.Parse(Console.ReadLine());
            Truck truck = Array.Find(trucks, item => item.id == id);
            return truck;
        }
    }

}