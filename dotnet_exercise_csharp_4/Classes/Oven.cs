namespace dotnet_exercise_csharp_4.Classes
{
    public class Oven : Appliance
    {
        public uint MaxTemperature { get; }

        private readonly double dailyEnergyConsumption = 2.5;

        public Oven(string brand, string room, uint maxTemperature) : base(brand, room)
        {
            MaxTemperature = maxTemperature;
        }
        public override string GetInfo()
        {
            string state = IsOn ? "running" : "off";
            string place = Room.ToLower();
            return $"{Brand} oven is in the {place} and is {state}.";
        }

        public sealed override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} oven starts heating.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} oven stops heating.");
        }

        public override double GetDailyEnergyUsage()
        {
            return dailyEnergyConsumption;
        }
    }
}
