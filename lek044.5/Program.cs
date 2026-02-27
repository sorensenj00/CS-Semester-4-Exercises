// See https://aka.ms/new-console-template for more information

using lek04._5;

Console.WriteLine("Hello, World!");

CollectionCards cards = new();
// cards.AddCard(Card.Suit.Clubs, Card.Number.Ace);
// cards.AddCard(Card.Suit.Hearts, Card.Number.King);
// cards.AddCard(Card.Suit.Diamonds, Card.Number.Queen);
// cards.AddCard(Card.Suit.Spades, Card.Number.Jack);
// cards.AddCard(Card.Suit.Clubs, Card.Number.Ten);
// cards.AddCard(Card.Suit.Hearts, Card.Number.Nine);
// cards.AddCard(Card.Suit.Diamonds, Card.Number.Eight);
// cards.AddCard(Card.Suit.Spades, Card.Number.Seven);
// cards.AddCard(Card.Suit.Clubs, Card.Number.Six);
// cards.AddCard(Card.Suit.Hearts, Card.Number.Five);
// cards.AddCard(Card.Suit.Diamonds, Card.Number.Four);
// cards.AddCard(Card.Suit.Spades, Card.Number.Three);
//
// var billedKort = cards.filterCardGame(FilterBilledkort);
// var IkkeBilleddekort = cards.filterCardGame(FilterIkkeBilledeKort);
// var KlørKort = cards.filterCardGame(FilterByKlør);
//
//
// Console.WriteLine("Billedkort:");
// foreach (Card card in billedKort)
// {
//     Console.WriteLine(card.ToString());
// }
// Console.WriteLine("Ikke billedkort:");
// foreach (Card card in IkkeBilleddekort)
// {
//     Console.WriteLine(card.ToString());
// }
// Console.WriteLine("KlørKort: ");
// foreach (Card card in KlørKort)
// {
//     Console.WriteLine(card.ToString());
// }


static bool FilterByKlør(Card card) => card.suit == Card.Suit.Clubs;
static bool FilterBilledkort(Card card) => card.rank == Card.Number.King || card.rank == Card.Number.Queen || card.rank == Card.Number.Jack ;
static bool FilterIkkeBilledeKort(Card card) => !FilterBilledkort(card);


//PersonShizzle: 

Person p1 = new Person("joans", 20, 70); 
Person p2 = new Person("hej", 25, 80);
Person p3 = new Person("hej", 30, 90);
Person p4 = new Person("fed", 15, 150);

List<Person> personListe = new List<Person>(); 
personListe.Add(p1);
personListe.Add(p2);
personListe.Add(p3);
personListe.Add(p4);

personListe.Sort((x, y) => x.weight.CompareTo(y.weight));
foreach (Person person in personListe)
{
    Console.WriteLine(person.ToString());
}
Console.WriteLine();
personListe.Sort((x, y) => x.age.CompareTo(y.age));
foreach (Person person in personListe)
{
    Console.WriteLine(person.ToString());
}
Console.WriteLine();
personListe.Sort((x, y) => x.name.CompareTo(y.name));
foreach (Person person in personListe)
{
    Console.WriteLine(person.ToString());
}
