namespace dotnet_exercise_csharp_4.Classes
{
    internal class CoffeeMachine
    {
        public string Brand { get; }
        public uint CupsPerBrew { get; }

        private readonly double kWhPerBrewing = 1.8;

        public CoffeeMachine(string brand, uint cupsPerBrew)
        {
            Brand = brand;
            CupsPerBrew = cupsPerBrew;
        }

        public void StartBrewing()
        {
            Console.WriteLine($"{Brand} coffeeMachine starts brewing.");
        }

        public void StopBrewing()
        {
            Console.WriteLine($"{Brand} coffeeMachine stops brewing.");
        }

        public void PrintBrewingEnergy()
        {
            Console.WriteLine($"{Brand} robot vacuum uses {kWhPerBrewing} kWh per brewing.");
        }

    }
}
