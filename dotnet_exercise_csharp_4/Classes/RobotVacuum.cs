namespace dotnet_exercise_csharp_4.Classes
{
    internal class RobotVacuum
    {
        public string Brand { get; }
        public uint BatteryLevel { get; }

        private readonly double kWhPerRun = 0.4;

        public RobotVacuum(string brand, uint batteryLevel)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }

        public void StartCleaning()
        {
            Console.WriteLine($"{Brand} robot vacuum starts cleaning.");
        }

        public void StopCleaning()
        {
            Console.WriteLine($"{Brand} robot vacuum stops cleaning.");

        }

        public void PrintCleaningEnergy()
        {
            Console.WriteLine($"{Brand} robot vacuum uses {kWhPerRun} kWh per cleaning.");
        }
    }
}
