using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_exercise_csharp_4.Classes
{
    public class PizzaOven : Oven
    {
        public PizzaOven(string brand, string room, uint maxTemperature) : base(brand, room, maxTemperature)
        {
        }

        //public override void TurnOn()
        //{
        //    Console.WriteLine("Pizza oven starts at extra high temperature.");
        //}
    }
}
