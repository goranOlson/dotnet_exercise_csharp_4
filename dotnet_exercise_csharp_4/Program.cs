using dotnet_exercise_csharp_4.Classes;

namespace dotnet_exercise_csharp_4
{
    partial class Program
    {
        static void Main()
        {
            // Create appliances
            SmartHomeController controller = new SmartHomeController();

            controller.AddDevice(new Washer("Electrolux", "Laundry room", 8));
            controller.AddDevice(new Refrigerator("Cylinda", "Kitchen", 4));
            controller.AddDevice(new Oven("Husqvarna", "Kitchen", 300));
            controller.AddDevice(new RobotVacuum("iRobot", "Hallway", 50));
            controller.AddDevice(new CoffeeMachine("CoffeeMaker", "Kitchen", 4));
            
            // Add extra appliance
            controller.AddDevice(new AirConditioner("Samsung", "Living room", 38));

            // Running the day's chores
            controller.PrintStatusReport();
            Console.WriteLine();
            
            controller.TurnOnAll();
            Console.WriteLine();
            
            // Present all appliances total daily energy usage
            double totalEnegry = controller.GetTotalDailyEnergyUsage();
            Console.WriteLine("Total daily energy usage: {0:0.00} kWh", totalEnegry);
            Console.WriteLine();

            controller.TurnOffAll();

        }







        /*  Reflektionsfrågor del 1
            -----------------------
            1) Vi behöver veta objektstyp för att kunna casta objektet så vi kommer åt rätt metoder.
            2) Inget händer eftersom koden enbart anropar kända objektstyper i våra loopar.
            3) Vi behöver ändra de metoder som anropar listans objekt: RunMorningRoutine och ReportAllEnergy.
            4) Listan devices tar vilka objekt om helst. Vilket gör att okända objekt aldrig anropas.
            5) Inget! Endast kända objekttyper kommer att anropas.

            Reflektionsfrågor del 2
            -----------------------
            För att det nya objektet 'CoffeeMachine' ska köras måste vi ändra i metoderna 
            RunMorningRoutine och ReportAllEnergy så att även de körs.
        
            Reflektionsfrågor del 5
            -----------------------
            1) Det fungerar eftersom alla objekten äver av Appliance.
            2) Om RobotVacuum har metoden implementera så körs den egna metoden, annars körs metoden i Appliance.
            3) Det blev lättare att loopa eftersom vi inte behöver se vilken typ av objekt som ska användas.
        */
    }
}
