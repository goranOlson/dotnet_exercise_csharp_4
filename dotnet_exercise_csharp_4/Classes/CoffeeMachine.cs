using dotnet_exercise_csharp_4.Interfaces;

namespace dotnet_exercise_csharp_4.Classes
{
    internal class CoffeeMachine : Appliance, ISchedulable
    {
        public uint CupsPerBrew { get; }
        public DateTime NextRun { get; set; }

        private readonly double dailyEnergyConsumption = 0.4;

        public CoffeeMachine(string brand, string room, uint cupsPerBrew) : base(brand, room)
        {
            CupsPerBrew = cupsPerBrew;
        }
        public override string GetInfo()
        {
            string state = IsOn ? "running" : "off";
            string place = Room.ToLower();
            return $"{Brand} coffee machine is in the {place} and is {state}.";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} coffee machine starts brewing.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} coffee machine stops brewing.");
        }

        public override double GetDailyEnergyUsage()
        {
            return dailyEnergyConsumption;
        }

        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"{Brand} coffee machine is now schedualed to start brewing at " + NextRun.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
