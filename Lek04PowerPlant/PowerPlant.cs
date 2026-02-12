namespace Lek04PowerPlant;

public delegate void Warning();

public class PowerPlant
{
    private Warning warning;

    public int result { get; set;}

    public void SetWarning(Warning w)
    {
        this.warning += w; 
    }
    
    public void HeatUp()
    {
        Random rnd = new Random();
        result = rnd.Next(0, 101);

        if (result > 50)
        {
            warning?.Invoke();
        }
        
    }
}



