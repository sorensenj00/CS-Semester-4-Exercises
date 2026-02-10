// See https://aka.ms/new-console-template for more information
using Lek3;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
Adresse firmaAdresse = new Adresse { vejnavn = "Hovedvejen", nummer = 42 };
List<Shape> list = new List<Shape>();
list.Add(new Circle(5, 2, 4));
list.Add(new Rectangle(4, 6, 1, 1));
list.Add(new Circle(3, 2, 2));

foreach (Shape shape in list)
{
    Console.WriteLine(shape.Area());
}

//Ny Øvelse 
Mekaniker mekaniker = new Mekaniker("Jane", firmaAdresse, 2000, 150);
Værkfører værkfører = new Værkfører("Bob", firmaAdresse, 1990, 200, 10, 500);
Synsmand synsmand = new Synsmand("Alice", firmaAdresse, 1995, 180, 5);

Console.WriteLine(mekaniker.ugeLøn());
Console.WriteLine(værkfører.ugeLøn());
Console.WriteLine(synsmand.ugeLøn());

CprNr mortencpr = new CprNr("211271",
"7777");
CprNr karinacpr = new CprNr("141174",
"8888");
var medarbejderCollection = new collectionClass<Adresse>();

var morten = new Mekaniker("Morten", firmaAdresse, mortencpr, 2000, 195);
var karina = new Mekaniker("Karina", firmaAdresse, karinacpr, 2000, 150);
var firma = new Firma(firmaAdresse);

medarbejderCollection.AddElement(firmaAdresse, karina);
medarbejderCollection.AddElement(firmaAdresse, morten);
medarbejderCollection.AddElement(firmaAdresse, firma); 



var hentetMorten = medarbejderCollection.GetElement(morten.adresse) as Medarbejder;

if (hentetMorten != null)
{
    Console.WriteLine(hentetMorten.cpr.SequenceNumber);
}

Console.WriteLine(medarbejderCollection.Size());

//Øvelse 3.8
Time t1, t2;
t1 = new Time("08:30:00");
t2 = t1; // Her sker magien: t2 er en KOPI, ikke en reference! fordi Time er en struct (value type)

t2.Hour = t2.Hour + 2; // Vi ændrer kun i t2

Console.WriteLine("T1: " + t1.ToString()); // Udskriver 08:30:00
Console.WriteLine("T2: " + t2.ToString()); // Udskriver 10:30:00



internal class collectionClass<Tkey>
{
   
    private Dictionary<Tkey, IharAdresse> collection = new Dictionary<Tkey, IharAdresse>();

    public void AddElement(Tkey key, IharAdresse element)
    {
        if (collection.ContainsKey(key))
        {
            return; 
        }
        collection[key] = element;
    }

    public IharAdresse GetElement(Tkey key)
    {
        return collection.TryGetValue(key, out IharAdresse m) ? m : null;
    }

    public int Size() => collection.Count;
}
