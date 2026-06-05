namespace dotnet_exercise_csharp_4.Classes
{
    public class SmartLamp : Appliance
    {
        public int Brightness { get; set; }

        public SmartLamp(string brand, string room, int brightness) : base(brand, room)
        {
            Brightness = brightness;
        }

        // Varning!
        // Med 'new' så används TurnOn() i Appliance om variabeln är av typen Appliance.
        // Med 'override' så används alltid TurnOn() i SmartLamp.
        public new void TurnOn()
        {
            Console.WriteLine($"The {Brand} light is turned on");
        }
    }
}
