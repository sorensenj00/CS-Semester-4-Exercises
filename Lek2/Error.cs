namespace Lek2
{
    public static class Error
    {
        // 1. Denne metode kaster fejlen
        static private void MyMethodWithError(int num = 0)
        {
            Console.WriteLine("Indeni MyMethodWithError...");

            // Vi fremprovokerer en fejl. 
            // Hvis num er 0 (default), kaster C# automatisk en DivideByZeroException.
            int result = 10 / num;

            Console.WriteLine("Dette bliver aldrig udskrevet, hvis num er 0");
        }

        // 2. Denne metode kalder den første og håndterer fejlen
        static public void MyNormalMethod(int num = 0)
        {
            try
            {
                Console.WriteLine("Prøver at kalde MyMethodWithError...");
                MyMethodWithError(num);
            }
            catch (Exception ex)
            {
                // Her fanger vi fejlen fra MyMethodWithError
                Console.WriteLine("CATCH: En fejl blev fanget i MyNormalMethod!");
                Console.WriteLine("Fejlbesked: " + ex.Message);
            }
            finally
            {
                // Dette kører ALTID, uanset om der var en fejl eller ej
                Console.WriteLine("FINALLY: Denne del kører altid.");
            }
        }
    }
}