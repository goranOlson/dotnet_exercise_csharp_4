namespace dotnet_exercise_csharp_4.Interfaces
{
    internal interface ISchedulable
    {
        DateTime NextRun { get; set;  }
        void Schedule(DateTime time);

        // Test av Default Implementation...!
        void Test(string str)
        {
            Console.WriteLine($"Test({str})");
        }
    }
}
