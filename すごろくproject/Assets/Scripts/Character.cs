using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int coordinate;
    string name;
    // Start is called before the first frame update
    void Start()
    {
        coordinate = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Character(string name)
    {
        this.name = name;
    }

    public void Move(int amount){
        coordinate += amount;
    }

    public int RollDice()
    {
        return 1;
    }

    public void CharacterAction(int action)
    {
        
    }
}
