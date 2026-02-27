namespace Lek53;

public static class PersonExtensions 
{
    // Øvelse 5.6: Sætter Accepted = true for dem der opfylder betingelsen [cite: 93, 98]
    public static void SetAccepted(this List<Person> lst, Predicate<Person> pred) 
    {
        lst.FindAll(pred).ForEach(p => p.Accepted = true);
    }

    // Øvelse 5.9: Nulstiller Accepted til false for alle [cite: 117, 118]
    public static void Reset(this List<Person> lst)
    {
        lst.ForEach(p => p.Accepted = false);
    }
}