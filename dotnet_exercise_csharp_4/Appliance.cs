namespace dotnet_exercise_csharp_4
{
    public class Appliance
    {
        public string Brand { get; }
        public string Room  { get; }
        public bool IsOn { get; protected set; }

        public Appliance(string brand, string room)
        {
            Brand = brand;
            Room = room;
            IsOn = false;
        }

        public virtual string GetInfo()
        {
            return $"{Brand} in {Room}";
        }

        public virtual void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} was started");
        }

        public virtual void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} was stopped");
        }

        public virtual double GetDailyEnergyUsage()
        {
            return 0;
        }
    }
}
