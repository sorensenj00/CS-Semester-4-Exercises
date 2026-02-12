namespace lek04._5;

public class Person
{
    public String name { get; set; }
    public int age { get; set; }
    public int weight { get; set; }
    
    public Person(String name, int age, int weight)
    {
        this.name = name;
        this.age = age;
        this.weight = weight;
    }


    public override string ToString()
    {
        return "Name: " + name + " Age: " + age + " Weight: " + weight + ""; 
    }
}