using dotnet_exercise_csharp_4;

internal class Washer2 : Appliance
{
    // public string Brand { get; }
    public int CapacityKg { get; }

    private readonly double kWhPerWashing = 1.2;

    public Washer2(string brand, string room, int capacityKg) : base(brand, room)
    {
        CapacityKg = capacityKg;
    }

    public override string GetInfo()
    {
        string state = IsOn ? "running" : "off";
        return $"{Brand} washer is in room {Room} and is {state}.";
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
        return base.GetDailyEnergyUsage();
    }



    public void StartWash()
    {
        Console.WriteLine($"{Brand} washer starts washing.");
    }

    public void StopWash()
    {
        Console.WriteLine($"{Brand} washer stops washing.");
    }

    public void PrintWashEnergy()
    {
        Console.WriteLine($"{Brand} washer uses {kWhPerWashing} kWh per wash.");
    }
}
