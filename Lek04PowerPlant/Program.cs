namespace Lek04PowerPlant;


class Program
{
    static void Main(string[] args)
    {
        PowerPlant powerPlant = new PowerPlant();
        powerPlant.SetWarning(warningToConsole);
        powerPlant.SetWarning(EkstraMetode);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Temperatur: {powerPlant.result}");
            powerPlant.HeatUp();
            
        }

    }


    static void warningToConsole()
    {
        Console.WriteLine(" Warning!");
    }
    static void EkstraMetode()
    {
        Console.WriteLine("Der er noget galt i Barda");
    }
}