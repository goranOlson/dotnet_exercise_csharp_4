namespace dotnet_exercise_csharp_4.Classes
{
    internal class RobotVacuum : Appliance
    {
        public uint BatteryLevel { get; }

        // private readonly double kWhPerRun = 0.4;

        private readonly double dailyEnergyConsumption = 0.4;

        public RobotVacuum(string brand, string room, uint batteryLevel) : base(brand, room)
        {
            BatteryLevel = batteryLevel;
        }
        public override string GetInfo()
        {
            string state = IsOn ? "running" : "off";
            string place = Room.ToLower();
            return $"{Brand} robot vacuum is in the {place} and is {state}.";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} robot vacuum starts cleaning.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} robot vacuum stops cleaning.");
        }

        public override double GetDailyEnergyUsage()
        {
            return dailyEnergyConsumption;
        }
    }
}
