internal class Refrigerator
{
    public string Brand { get; }
    public int Temperature { get; }

    private readonly double kWhPerDay = 3.6;

    public Refrigerator(string brand, int temperature)
    {
        Brand = brand;
        Temperature = temperature;
    }

    public void StartCooling()
    {
        Console.WriteLine($"{Brand} refrigerator starts cooling.");
    }

    public void StopCooling()
    {
        Console.WriteLine($"{Brand} refrigerator stops cooling.");
    }

    public void PrintCoolingEnergy()
    {
        Console.WriteLine($"{Brand} refrigerator uses {kWhPerDay} kWh per day.");
    }
}


