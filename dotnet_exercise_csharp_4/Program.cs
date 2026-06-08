using dotnet_exercise_csharp_4.Classes;
using dotnet_exercise_csharp_4.Interfaces;

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

            // Show devices status
            controller.PrintStatusReport();
            Console.WriteLine();
            
            // Running the day's chores
            controller.TurnOnAll();
            Console.WriteLine();
            
            // Present all appliances total daily energy usage
            double totalEnegry = controller.GetTotalDailyEnergyUsage();
            Console.WriteLine("Total daily energy usage: {0:0.00} kWh", totalEnegry);
            Console.WriteLine();

            // Stop all devices
            controller.TurnOffAll();
            Console.WriteLine();

            // Set schedule for som devices
            controller.ScheduleAllSchedulableDevices(DateTime.Now.AddHours(2));
            Console.WriteLine();

            // Test with 'new TurnOn()'
            SmartLamp lamp1 = new SmartLamp("IKEA", "Hallway", 80);
            Appliance lamp2 = lamp1;
            lamp1.TurnOn();
            lamp2.TurnOn();
            Console.WriteLine();

            // Get schedulable devices
            List<ISchedulable> schedulableDevices = controller.GetSchedulableDevices();
            foreach(ISchedulable schedulable in schedulableDevices)
            {
                Console.WriteLine("Next scheduled run for type " + schedulable.GetType().Name + " is " + schedulable.NextRun);
            }
            Console.WriteLine();

            // Hitta första apparat utifrån märke
            // Schemalägg den om den har interfacet ISchedulable
            Appliance? foundDevice = controller.FindDeviceByBrand("Cylinda");  // iRobot

            if (foundDevice != null) {
                foundDevice.TurnOn();

                // Schedule appliances if it has the interface ISchedulable
                if (foundDevice is ISchedulable schedulable)
                {
                    schedulable.Schedule(DateTime.Now.AddHours(3));
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

            Reflektionsfrågor del 2
            -----------------------
            För att det nya objektet 'CoffeeMachine' ska köras måste vi ändra i metoderna.
            RunMorningRoutine och ReportAllEnergy så att även de körs.
        
            Reflektionsfrågor del 5
            -----------------------
            1) Det fungerar eftersom alla objekten äver av Appliance.
            2) Om RobotVacuum har metoden implementera så körs den egna metoden, annars körs metoden i Appliance.
            3) Det blev lättare att loopa eftersom vi inte behöver se vilken typ av objekt som ska användas.

            Reflektionsfrågor del 9
            -----------------------
            1) Metoden Schedule finns inte i klassen Appliance.
            2) Vi får bara med de objekt som har interfacet ISchedulable.
            3) RobotVacuum ärver av klassen Appliance och måste implementera alla properties och metoder i ISchedulable.
            4) Skulle metoden Schedule ligga i Appliance får alla tillgång till metoden. Då kan vi inte filtrera ut de
               objekt som vi vill ska ha metoden.
            5) Med arv hade alla objekten körts. Genom att bara vissa klasser även har interface:et så kommer endast de att körs.

            Reflektionsfrågor del 10
            ------------------------
            a) Koden godkänns inte av kompilatorn eftersom metoden i Appliance inte är markerad som virtual.
            b) Utan override i Washer så körs TurnOn() i Appliance. Visual studio föreslår använding av 'new'.
            
            Reflektionsfrågor del 11
            ------------------------
            1) Det blev olika utskrifter.
            2) SmartLamp egen TurnOn() körs när objektet är av typen SmartLamp.
            3) Appliance TurnOn() körs när objektet är av typen Appliance.
            4) Om vi loopar objekt så tror vi att vi ska få child-klassens metod, men vi får basklassens metod med 'new'.
            5) Om vi använder override så körs child-klassens metod även om variablen är av typ Appliance.
            6) Med 'new' så används TurnOn() i Appliance om variabeln är av typen Appliance. Med 'override' så används 
               TurnOn() i SmartLamp även om variabeln är av typen Appliance.

            Reflektionsfrågor del 12
            ------------------------
            1) Kompilatorn klagar på att TurnOn() i klassen Oven är 'sealed' och därför inte kan override:as i klassen PizzaOven.
            2) PizzaOven kan inte använda TurnOn() eftersom det är blockerat i Oven med tillägget 'sealed'.
            3) Man kan använda 'sealed' när man vill att alla ärvande klasser ska tvingas använda en metod skapad tidigare i arvskedjan.
            4) PizzaOven kan override:a alla metoder som inte är märkat 'sealed'.

            Reflektionsfrågor del 13
            ------------------------
            Vi kan ha klasser av olika typer i List<ISchedulable> eftersom de blir castat till ISchedulable.
        */

    }
}
