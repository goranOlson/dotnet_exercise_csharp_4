using dotnet_exercise_csharp_4.Classes;
using dotnet_exercise_csharp_4.Interfaces;

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

            //foreach(Appliance device in _devices)
            //{
            //    sum += device.GetDailyEnergyUsage();
            //}

            _devices.ForEach(device => sum += device.GetDailyEnergyUsage());

            return sum;
        }
    
        public void ScheduleAllDevicesWrong(DateTime time)
        {
            foreach(Appliance device in _devices)
            {
                // device.Schedule(time);
                // Denna kompilerar inte eftersom klassen Appliance inte har metoden Schedule(time)
            }
        }

        public void ScheduleAllSchedulableDevices(DateTime time)
        {
            foreach (Appliance device in _devices)
            {
                // or "if (device is ISchedulable)"
                if (device is ISchedulable schedulable)
                {
                    schedulable.Schedule(time);
                }
            }
        }


        internal List<ISchedulable> GetSchedulableDevices()
        {
            List<ISchedulable> result = new List<ISchedulable>();

            foreach (Appliance device in _devices)
            {
                if (device is ISchedulable)
                {
                    result.Add((ISchedulable)device);
                }
            }
            return result;
        }
    }
}
