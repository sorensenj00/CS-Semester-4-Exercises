// See https://aka.ms/new-console-template for more information
using System.Drawing;
using Sem4;

Console.WriteLine("Hello, World!");


Person p = new("John");
Console.WriteLine(p);
p.Name = "Jane";
Console.WriteLine(p);


Animal animal = new("Dog");
Console.WriteLine(animal);
Console.WriteLine(animal.isDog());
animal.specie = "Cat";
Console.WriteLine(animal.isDog());
Console.WriteLine();
Console.WriteLine("Hvad for et dyr skal oprettes?");
string input = Console.ReadLine();
Animal animal2 = new(input);
Console.WriteLine(animal2);


while (input != "stop")
{
    Console.WriteLine("Hvad for et dyr skal oprettes? skriv stop");
    input = Console.ReadLine();
    Animal animal3 = new(input);
    Console.WriteLine(animal3 +" er blevet oprettet");
}


MyList myList = new MyList();
myList.printList();
myList.AddToList(6);
myList.printList();
Console.WriteLine();


MyList myListRandom = new MyList();
Random random = new Random();
for (int i = 0; i < 10; i++) { 
myListRandom.AddToList(random.Next(1, 100));
}

myListRandom.printList();



