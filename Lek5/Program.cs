// See https://aka.ms/new-console-template for more information

class program
{
    static List<int> data1 = new List<int> {1,2,3,4,5};

    static List<int> numbers = new List<int> { 1, 2, 16, 4, 5, 20, 7, 105, 99, 12, 8 };
    
    static Predicate<int> ligeTal = x => x % 2 == 0;
    
    static Predicate<int> highestTal = x => x > 4;
    
    
    static Action<int> printer = x => Console.WriteLine(x);

    public static void Main(string[] args)
    {   
        List<int> data2 = data1.FindAll(ligeTal); 
        data2.ForEach(printer);
        
        Console.WriteLine();

        int highestTal = data1.Find(program.highestTal); 
        Console.WriteLine(highestTal);

        int highestTalAfterIndex = data1.FindLastIndex(program.highestTal);
        Console.WriteLine(highestTalAfterIndex); 
        
        Console.WriteLine("\n--- LINQ Query Expressions ---");

        // Lige tal og sorteret
        var evenExpressions = from x in numbers
            where x % 2 == 0
            orderby x
            select x;

        Console.WriteLine("Lige tal (sorteret):");
        foreach (int number in evenExpressions)
        {
            Console.WriteLine(number);
        }

        // Præcis to cifre og sorteret
        var twoDigitsExpressions = from x in numbers
            where x.ToString().Length == 2
            orderby x
            select x;

        Console.WriteLine("\nTo-cifrede tal (sorteret):");
        foreach (int number in twoDigitsExpressions)
        {
            Console.WriteLine(number);
        }
        
        






    }



}