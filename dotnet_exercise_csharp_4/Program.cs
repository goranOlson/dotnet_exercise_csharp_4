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
            // 
            devices.Add(new CoffeeMachine("Xx", 4));

            RunMorningRoutine(devices);
            Console.WriteLine();
            ReportAllEnergy(devices);
        }
        static void RunMorningRoutine(List<object> devices)
        {
            Console.WriteLine("=== RunMorningRoutine ===");

            foreach (object device in devices)
            {
                string className = device.GetType().Name;  // "Washer"
                
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
                        // Console.WriteLine($"{Environment.NewLine}>>>> Classtype '{className}' not implemented! <<<<");
                        // throw new NotImplementedException();
                        break;
                }
            }
        }
        static void ReportAllEnergy(List<object> devices)
        {
            Console.WriteLine("=== ReportAllEnergy ===");
            foreach (object device in devices)
            {
                string className = device.GetType().Name;  // "Oven"

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
                        // Console.WriteLine($"{Environment.NewLine}>>>> Classtype '{className}' is not implemented! <<<<");
                        // throw new NotImplementedException();
                        break;
                }
            }
        }


        /*  Reflektionsfrågor del 1
            -----------------------
            1) Vi behöver veta objektstyp för att kunna casta objektet så vi kommer åt rätt metoder.
            2) Inget händer eftersom koden enbart anropar kända objektstyper i våra loopar.
            3) Vi behöver ändra de metoder som anropar listans objekt: RunMorningRoutine och ReportAllEnergy.
            4) Listan devices tar vilka objekt om helst. Vilket gör att okända objekt aldrig anropas.
            5) Inget! Endast kända objekttyper kommer att anropas.
        */

        /*  Reflektionsfrågor del 2
            -----------------------
            För att det nya objektet 'CoffeeMachine' ska köras måste vi ändra i metoderna 
            RunMorningRoutine och ReportAllEnergy så att även de körs.
         
         
         */
    }
}
