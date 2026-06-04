namespace dotnet_exercise_csharp_4.Classes
{
    internal class Washer : Appliance
    {
        // public string Brand { get; }
        public int CapacityKg { get; }

        private readonly double kWhPerWashing = 1.2;

        private readonly double dailyEnergyConsumption = 1.2;

        public Washer(string brand, string room, int capacityKg) : base(brand, room)
        {
            CapacityKg = capacityKg;
        }

        public override string GetInfo()
        {
            string state = IsOn ? "running" : "off";
            string place = Room.ToLower();
            return $"{Brand} washer is in the {place} and is {state}.";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} washer starts a washing program.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} washer stops a washing program.");
        }

        public override double GetDailyEnergyUsage()
        {
            return dailyEnergyConsumption;
        }
    }
}
