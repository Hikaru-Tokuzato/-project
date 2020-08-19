using Random = System.Random;

public class Dice
{
    private const int MAXVALUE = 6;
    private const int MINVALUE = 1;

    private Random random = null;
    
    public Dice()
    {
        random = new Random();
    }
    public int Roll()
    {
        return random.Next(MINVALUE, MAXVALUE);
    }
    
}
