using System;
class SmartHome
{
    public static void Main()
    {
        // Creating an object of the Thermostat class
        Thermostat thermo = new Thermostat
        {
            DeviceId = 1,
            Status = "ON",
            TemperatureSetting = 24
        };
        // Displaying thermostat status
        thermo.DisplayStatus();
    }
}
