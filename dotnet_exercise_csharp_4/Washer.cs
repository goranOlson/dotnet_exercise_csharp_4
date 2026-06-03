internal class Washer
{
    public string Brand { get; }
    public int CapacityKg { get; }

    private readonly double kWhPerWashing = 1.2;

    public Washer(string brand, int capacityKg)
    {
        Brand = brand;
        CapacityKg = capacityKg;
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
