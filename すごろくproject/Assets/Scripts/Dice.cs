using Random = System.Random;
using UnityEngine;

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
        var temp = random.Next(MINVALUE, MAXVALUE);
        Debug.Log(temp);
        return temp;
    }
    
}
