class TempUnit
{
    //required classes
    public static double FahrenheitToCelsius(double faren)
    {
        (faren - 32) * 5 / 9;
    }
    public static double CelsiusToFahrenheit(double cels)
    {
        (cels * 9 / 5) + 32;
    }
    public static double PoundsToKg(double pound)
    {
        pound * 0.453592;
    }
    public static double ConvertKgToPounds(double kg)
    {
        kg * 2.20462;
    }
    public static double ConvertGallonsToLiters(double gallon)
    {
        gallon * 3.78541;
    }
    public static double ConvertLitersToGallons(double liters)
    {
        liters * 0.264172;
    }
}
