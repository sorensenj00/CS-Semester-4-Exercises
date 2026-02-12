namespace lek04._5;

public class Card
{
    public Suit suit { get; set; }
    public Number rank { get; set; }
    
    public Card(Suit suit, Number rank)
    {
        this.suit = suit;
        this.rank = rank;
    }

    
    
    
    public override string ToString()
    {
        return suit + " " + rank;
    }
    
    public enum Number
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }
    public enum Suit
    {
    Clubs, Diamonds, Hearts, Spades
    }
}