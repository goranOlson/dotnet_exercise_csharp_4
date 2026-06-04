namespace dotnet_exercise_csharp_4.Classes
{
    internal class Refrigerator : Appliance
    {
        public int Temperature { get; }

        private readonly double dailyEnergyConsumption = 1.2;

        public Refrigerator(string brand, string room, int temperature) : base(brand, room)
        {
            Temperature = temperature;
        }

        public override string GetInfo()
        {
            string state = IsOn ? "running" : "off";
            string place = Room.ToLower();
            return $"{Brand} refrigerator is in the {place} and is {state}.";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} refrigerator starts cooling.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} refrigerator stops cooling.");
        }

        public override double GetDailyEnergyUsage()
        {
            return dailyEnergyConsumption;
        }
    }
}
