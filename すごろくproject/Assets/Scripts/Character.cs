using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public int coordinate;
    public IDice dice;
    public bool FinishFlag { get; set; } = false;

    public string Name { get; } 
    // Start is called before the first frame update

    public Character(string name)
    {
        this.Name = name;
        coordinate = 1;
        dice = new Dice();
    }

    public Character(string name, IDice dice)
    {
        this.Name = name;
        coordinate = 1;
        this.dice = dice;
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

