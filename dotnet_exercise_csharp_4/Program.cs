using System.Diagnostics;
using System.Runtime.InteropServices.Swift;

namespace dotnet_exercise_csharp_4
{
    partial class Program
    {
        static void Main()
        {
            List<object> devices = new List<object>();
            // TODO:
            // Skapa minst fyra objekt:
            // Washer, Refrigerator, Oven och RobotVacuum.
            // Lägg till dem i listan devices.

            devices.Add(new Washer("Electrolux", 8));


            RunMorningRoutine(devices);
            Console.WriteLine();
            ReportAllEnergy(devices);

            
        }
        static void RunMorningRoutine(List<object> devices)
        {
            foreach (object device in devices)
            {
                // TODO:
                // 1. Kontrollera vilken typ device är.
                // 2. Casta till rätt typ.
                // 3. Anropa rätt startmetod.
                // 4. Anropa rätt stoppmetod.

                //Console.WriteLine("GetType() => " + device.GetType());
                //Console.WriteLine("Name: " + device.GetType().Name);
                string className = device.GetType().Name;
                
                switch (className)
                {
                    case "Washer":
                        Console.WriteLine("=> Washer");
                        Washer washer = (Washer)device;
                        washer.StartWash();
                        washer.StopWash();
                        break;

                    default:
                        Console.WriteLine("Classtype not implemented!");
                        break;
                }


                


                
            }
        }
        static void ReportAllEnergy(List<object> devices)
        {
            foreach (object device in devices)
            {
                // TODO:
                // 1. Kontrollera vilken typ device är. 
                // 2. Casta till rätt typ.
                // 3. Anropa rätt energimetod.
            }
        }
    }
}
