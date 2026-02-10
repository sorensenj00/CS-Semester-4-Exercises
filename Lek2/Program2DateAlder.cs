using Lek2;

namespace Lek2 {
    public class Alderberegning
    {
        public static void getAge(DateTime fødselsår, out int Alder)
        {
            DateTime nuværendeÅr = DateTime.Now;
            TimeSpan temp = nuværendeÅr.Subtract(fødselsår); 
            Alder = (int)(temp.TotalDays) / 365;
        }
    }
} 
