namespace dotnet_exercise_csharp_4
{
    class Program
    {
        static void Main()
        {
            List<object> devices = new List<object>();
            // TODO:
            // Skapa minst fyra objekt:
            // Washer, Refrigerator, Oven och RobotVacuum.
            // Lägg till dem i listan devices.
            RunMorningRoutine(devices);
            Console.WriteLine();
            ReportAllEnergy(devices);
        }
        static void RunMorningRoutine(List<object> devices)
        {
            foreach (object device in devices)
            {
                // TODO:
                // 1. Kontrollera vilken typ device är.
                // 2. Casta till rätt typ.
                // 3. Anropa rätt startmetod.
                // 4. Anropa rätt stoppmetod.
            }
        }
        static void ReportAllEnergy(List<object> devices)
        {
            foreach (object device in devices)
            {
                // TODO:
                // 1. Kontrollera vilken typ device är. 
                // 2. Casta till rätt typ.
                // 3. Anropa rätt energimetod.
            }
        }
    }
}
