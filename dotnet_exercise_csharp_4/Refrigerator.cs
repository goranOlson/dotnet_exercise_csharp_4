public class Refrigerator
{
    public string Brand { get; }
    public int Temperature { get; }

    public Refrigerator(string brand, int temperature)
    {
        Brand = brand;
        Temperature = temperature;
    }

    public void StartCooling()
    {
        Console.WriteLine("StartCooling");
    }

    public void StopCooling()
    {
        Console.WriteLine("StopCooling");
    }

    public void PrintCoolingEnergy()
    {
        Console.WriteLine("PrintCoolingEnergy");
    }

    public override string ToString()
    {
        return $"{Brand} {Temperature} °";
    }
}


