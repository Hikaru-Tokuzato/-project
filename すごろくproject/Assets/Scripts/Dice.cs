using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class Dice : MonoBehaviour
{
    private const int MAXVALUE = 6;
    private const int MINVALUE = 1;

    private Random random = null;
    // Start is called before the first frame update
    void Start()
    {
        random = new Random();
    }
    public int Roll()
    {
        return random.Next(MINVALUE, MAXVALUE);
    }
    
}
