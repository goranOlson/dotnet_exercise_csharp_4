using System.Diagnostics;
using System.Runtime.InteropServices.Swift;
using static dotnet_exercise_csharp_4.Program;

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
            devices.Add(new Refrigerator("Cylinda", 4));
            devices.Add(new Oven("Husqvarna", 300));
            devices.Add(new RobotVacuum("iRobot", 50));

            RunMorningRoutine(devices);
            Console.WriteLine();
            ReportAllEnergy(devices);
        }
        static void RunMorningRoutine(List<object> devices)
        {
            Console.WriteLine("=== RunMorningRoutine ===");

            foreach (object device in devices)
            {
                // TODO:
                // 1. Kontrollera vilken typ device är.
                // 2. Casta till rätt typ.
                // 3. Anropa rätt startmetod.
                // 4. Anropa rätt stoppmetod.

                string className = device.GetType().Name;  // Washer
                
                switch (className)
                {
                    case "Washer":
                        Washer washer = (Washer)device;
                        washer.StartWash();
                        washer.StopWash();
                        break;
                    case "Refrigerator":
                        Refrigerator refrigerator = (Refrigerator)device;
                        refrigerator.StartCooling();
                        refrigerator.StopCooling();
                        break;
                    case "Oven":
                        Oven oven = (Oven)device;
                        oven.StartHeating();
                        oven.StopHeating();
                        break;
                    case "RobotVacuum":
                        RobotVacuum robotVacuum = (RobotVacuum)device;
                        robotVacuum.StartCleaning();
                        robotVacuum.StopCleaning();
                        break;
                    default:
                        Console.WriteLine(">>>> Classtype not implemented! <<<<");
                        break;
                }
            }
        }
        static void ReportAllEnergy(List<object> devices)
        {
            Console.WriteLine("=== ReportAllEnergy ===");
            foreach (object device in devices)
            {
                // TODO:
                // 1. Kontrollera vilken typ device är. 
                // 2. Casta till rätt typ.
                // 3. Anropa rätt energimetod.

                string className = device.GetType().Name;  // "Washer"

                switch (className)
                {
                    case "Washer":
                        Washer washer = (Washer)device;
                        washer.PrintWashEnergy();
                        break;
                    case "Refrigerator":
                        Refrigerator refrigerator = (Refrigerator)device;
                        refrigerator.PrintCoolingEnergy();
                        break;
                    case "Oven":
                        Oven oven = (Oven)device;
                        oven.PrintHeatingEnergy();
                        break;
                    case "RobotVacuum":
                        RobotVacuum robotVacuum = (RobotVacuum)device;
                        robotVacuum.PrintCleaningEnergy();
                        break;
                    default:
                        Console.WriteLine(">>>> Classtype not implemented! <<<<");
                        break;
                }
            }
        }




        

    }
}
