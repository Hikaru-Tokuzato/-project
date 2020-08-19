using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public int coordinate;
    public Dice dice;
    public bool FinishFlag { get; set; } = false;

    public string Name { get; } 
    // Start is called before the first frame update

    public Character(string name)
    {
        this.Name = name;
        coordinate = 0;
        dice = new Dice();
    }

    public void Move(int amount){
        coordinate += amount;
    }

    public int RollDice()
    {
        return dice.Roll();
    }

    public void CharacterAction(int action)
    {
        return;
    }
    
}
