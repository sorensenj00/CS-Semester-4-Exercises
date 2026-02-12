namespace lek04._5;

public class CollectionCards
{
    public delegate bool FilterCardDelegate(Card card);
    
    private List<Card> cards = new List<Card>();

    public void AddCard(Card.Suit suit, Card.Number number)
    {
        Card card = new Card(suit, number);
        cards.Add(card);
    }

    public List<Card> filterCardGame(FilterCardDelegate filter)
    {
        List<Card> result = new List<Card>(); 
        foreach (Card card in cards)
        {
            if (filter(card))
            {
                result.Add(card);
            }
        }
        return result;
    }
}