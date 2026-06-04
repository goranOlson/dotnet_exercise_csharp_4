using dotnet_exercise_csharp_4.Classes;

namespace dotnet_exercise_csharp_4
{
    public class SmartHomeController
    {
        private List<Appliance> _devices = new List<Appliance>();

        public void AddDevice(Appliance device)
        {
            _devices.Add(device);
        }

        public void TurnOnAll()
        {
            foreach (Appliance device in _devices)
            {
                device.TurnOn();
            }
        }

        public void TurnOffAll()
        {
            foreach (Appliance device in _devices)
            {
                device.TurnOff();
            }
        }

        public void PrintStatusReport()
        {
            foreach(Appliance device in _devices)
            {
                Console.WriteLine(device.GetInfo());
            }
        }

        public double GetTotalDailyEnergyUsage()
        {
            double sum = 0;

            foreach(Appliance device in _devices)
            {
                sum += device.GetDailyEnergyUsage();
            }

            return sum;
        }
    }
}
