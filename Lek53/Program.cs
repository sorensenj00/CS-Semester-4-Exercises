// See https://aka.ms/new-console-template for more information

namespace Lek53
{
    class program
    {
        private static List<Person> people1 = new List<Person>(); 
        private static List<Person> people2 = new List<Person>();
        
        static Action<Person> printer = x => Console.WriteLine(x);

        public static void Main(string[] args)
        {
            try {
                people1 = Person.ReadCSVFile("/Users/jonaslindholtsorensen/RiderProjects/CS-Semester-4-Exercises/Lek53/data1.csv");
            }
            catch (Exception ex) {
                Console.WriteLine("EXCEPTION: " + ex.Message);
            }
            Console.WriteLine();
            try
            {
                people2 = Person.ReadCSVFile("/Users/jonaslindholtsorensen/RiderProjects/CS-Semester-4-Exercises/Lek53/data2.csv");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            
            //Øvelse 5.3. 
            // 1. Alle personer med en score under 2 [cite: 66]
            List<Person> scoreUnder2 = people1.FindAll(p => p.Score < 2);
            Console.WriteLine();
            scoreUnder2.ForEach(printer);

            // 2. Alle personer med en lige score (0, 2, 4, 6...) [cite: 67]
            List<Person> evenScore = people1.FindAll(p => p.Score % 2 == 0);
            Console.WriteLine();
            evenScore.ForEach(printer);

            // 3. Lige score og vægt over 60 [cite: 68]
            List<Person> evenScoreHeavy = people1.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);
            Console.WriteLine();
            evenScoreHeavy.ForEach(printer);

            // 4. Vægt deleligt med 3 (bruger modulus %) [cite: 69, 70]
            List<Person> weightDiv3 = people1.FindAll(p => p.Weight % 3 == 0);
            Console.WriteLine();
            weightDiv3.ForEach(printer);
            
            
            //Øvelse 5.4
            // 1. Index på den første person med score præcis 3 [cite: 80]
            int indexScore3 = people1.FindIndex(p => p.Score == 3);
            Console.WriteLine(indexScore3);

            // 2. Index på den første person under 10 år, som har score 3 [cite: 81]
            int indexYoungScore3 = people1.FindIndex(p => p.Age < 10 && p.Score == 3);
            Console.WriteLine(indexYoungScore3);

            // 3. Hvor mange personer under 10 år har score 3? (Bruger FindAll) [cite: 82, 83]
            int countYoungScore3 = people1.FindAll(p => p.Age < 10 && p.Score == 3).Count;
            Console.WriteLine(countYoungScore3);

            // 4. Index på første person under 8 år, med score 3 [cite: 84]
            int indexVeryYoungScore3 = people1.FindIndex(p => p.Age < 8 && p.Score == 3);
            Console.WriteLine(indexVeryYoungScore3);
            // Bemærk: Hvis resultatet er -1, betyder det at ingen person matchede kriteriet[cite: 84].
            
            //Øvelse 5.5
            people1.Sort(new SortByScoreAndAge());
            
            
            //Øvelse 5.7: LINQ Sortering
            // Stigende orden [cite: 101]
            var sortedAsc = from p in people1
                orderby p.Score, p.Age
                select p;

            // Faldende orden [cite: 101]
            var sortedDesc = from p in people1
                orderby p.Score descending, p.Age descending
                select p;
            
            //Øvelse 5.8: LINQ på et Array
            int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 }; 

            // 1. To-cifrede ints, stigende orden (vi bruger string length som bedt om tidligere) [cite: 109]
            var toCifreAsc = numbers.Where(n => n.ToString().Length == 2).OrderBy(n => n);

            // 2. To-cifrede ints, faldende orden [cite: 109]
            var toCifreDesc = numbers.Where(n => n.ToString().Length == 2).OrderByDescending(n => n);

            // 3. Som delopgave 1, men returnerer strings (f.eks. "20", "31") [cite: 110, 111]
            var stringAsc = toCifreAsc.Select(n => n.ToString());

            // 4. Som delopgave 2, men med "even"/"uneven" tilføjet vha. conditional operator [cite: 112, 113]
            var stringDescStatus = toCifreDesc.Select(n => $"{n} {(n % 2 == 0 ? "even" : "uneven")}");
            
            //Øvelse 5.10: LINQ på 100 random integers
            Random rnd = new Random();
            List<int> randomNumbers = Enumerable.Range(1, 100).Select(x => rnd.Next(1, 500)).ToList();

            // 1. Antal ulige tal [cite: 121]
            int oddCount = randomNumbers.Count(n => n % 2 != 0);

            // 2. Antal unikke tal (f.eks. 3,3,5 giver 2) [cite: 122]
            int distinctCount = randomNumbers.Distinct().Count(); 

            // 3. De tre første ulige tal (bruger Take metoden) [cite: 123]
            var firstThreeOdds = randomNumbers.Where(n => n % 2 != 0).Take(3);

            // 4. Alle unikke ulige tal [cite: 124, 125]
            var distinctOdds = randomNumbers.Where(n => n % 2 != 0).Distinct();
            
            //Øvelse 5.11 & 5.12: Ekstra opgaver
            // 5.11 Grupper personer efter første bogstav i deres navn [cite: 129]
            var groupedByName = from p in people1
                group p by p.Name[0];

            // 5.12 Inner join mellem data1 (people1) og data2 (people2) for at finde personer der findes i begge filer [cite: 133, 134]
            var joinedPeople = from p1 in people1
                join p2 in people2 on p1.Name equals p2.Name
                select p1;
            
            
            
            
        }

        //Øvelse 5.5: Sortering med IComparer
        public class SortByScoreAndAge : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                // Sorter først efter Score [cite: 87]
                int scoreComparison = x.Score.CompareTo(y.Score);
                if (scoreComparison != 0) return scoreComparison;
        
                // Hvis score er ens, sorter efter Age [cite: 87]
                return x.Age.CompareTo(y.Age);
            }
        }



    }
}