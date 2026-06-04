using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_exercise_csharp_4.Classes
{
    internal class AirConditioner: Appliance
    {
        private int _noiseLevel;

        public int NoiseLevel
        {
            get { return _noiseLevel; }
            private set { _noiseLevel = value; }
        }

        private readonly double dailyEnergyConsumption = 11.2;

        public AirConditioner(string brand, string room, int noiseLevel): base(brand, room)
        {
            NoiseLevel = noiseLevel;
        }

        public override string GetInfo()
        {
            string state = IsOn ? "on" : "off";
            string place = Room.ToLower();
            return $"{Brand} air conditioning is in the {place} and is {state}.";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} air conditioning starts cooling.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} air conditioning stops cooling.");
        }

        public override double GetDailyEnergyUsage()
        {
            return dailyEnergyConsumption;
        }


    }
}
