namespace dotnet_exercise_csharp_4
{
    internal class RobotVacuum
    {
        public string Brand { get; }
        public uint BatteryLevel { get; }

        public RobotVacuum(string brand, uint batteryLevel)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }

        public void StartCleaning()
        {
            Console.WriteLine("StartCleaning");
        }

        public void StopCleaning()
        {
            Console.WriteLine("StopCleaning");
        }

        public void PrintCleaningEnergy()
        {
            Console.WriteLine("PrintCleaningEnergy");
        }
    }
}
