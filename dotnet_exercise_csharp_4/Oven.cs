namespace dotnet_exercise_csharp_4
{
    internal class Oven
    {
        public string Brand { get; }
        public uint MaxTemperature { get; }

        public Oven(string brand, uint maxTemperature)
        {
            Brand = brand;
            MaxTemperature = maxTemperature;
        }

        public void StartHeating()
        {
            Console.WriteLine("StartHeating");
        }

        public void StopHeating()
        {
            Console.WriteLine("StopHeating");
        }

        public void PrintHeatingEnergy()
        {
            Console.WriteLine("PrintHeatingEnergy");
        }
    }
}
