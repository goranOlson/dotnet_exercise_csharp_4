namespace dotnet_exercise_csharp_4
{
    internal class Oven
    {
        public string Brand { get; }
        public uint MaxTemperature { get; }

        private readonly double kWhPerHour = 2.4;

        public Oven(string brand, uint maxTemperature)
        {
            Brand = brand;
            MaxTemperature = maxTemperature;
        }

        public void StartHeating()
        {
            Console.WriteLine($"{Brand} oven starts heating.");
        }

        public void StopHeating()
        {
            Console.WriteLine($"{Brand} oven stops heating.");
        }

        public void PrintHeatingEnergy()
        {
            Console.WriteLine($"{Brand} oven uses {kWhPerHour} kWh per hour.");
        }
    }
}
