namespace dotnet_exercise_csharp_4
{
    partial class Program
    {
        public class Washer
        {
            public string Brand { get; }
            public int CapacityKg { get; }

            public Washer(string brand, int capacityKg)
            {
                Brand = brand;
                CapacityKg = capacityKg;
            }

            public void StartWash()
            {
                Console.WriteLine("StartWash()");
            }

            public void StopWash()
            {
                Console.WriteLine("StopWash()");
            }

            public void PrintWashEnergy()
            {
                Console.WriteLine("PrintWashEnergy()");
            }



            public override string ToString()
            {
                return $"{Brand} {CapacityKg} kg";
            }
        }
    }
}
