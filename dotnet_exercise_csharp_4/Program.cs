using dotnet_exercise_csharp_4.Classes;
using System.Diagnostics;
using System.Runtime.InteropServices.Swift;
using static dotnet_exercise_csharp_4.Program;

namespace dotnet_exercise_csharp_4
{
    partial class Program
    {
        static void Main()
        {
            List<Appliance> devices = new List<Appliance>();

            // Add 4 appliances to devices
            devices.Add(new Washer("Electrolux", "Laundry room", 8));
            devices.Add(new Refrigerator("Cylinda", "Kitchen", 4));
            devices.Add(new Oven("Husqvarna", "Kitchen", 300));
            devices.Add(new RobotVacuum("iRobot", "Hallway", 50));
            devices.Add(new CoffeeMachine("CoffeeMaker", "Kitchen", 4));

            foreach(Appliance device in devices)
            {
                Console.WriteLine(device.GetInfo());
                device.TurnOff();
                Console.WriteLine($"Daily energy usage: " + device.GetDailyEnergyUsage());
                device.TurnOff();
                Console.WriteLine();
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

        /*  Reflektionsfrågor del 5
            -----------------------
            1) Det fungerar eftersom alla objekten äver av Appliance.
            2) Om RobotVacuum har metoden implementera så körs den egna metoden, annars körs metoden i Appliance.
            3) Det blev lättare att loopa eftersom vi inte behöver se vilken typ av objekt som ska användas.
        */
    }
}
