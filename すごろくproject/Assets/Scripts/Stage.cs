using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    Grid[] grids;
    List<Character> Characters;
    int turn;
    int order;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void MakePlayer(int playerNum){
        this.Characters.Add(new Character("Taro"));
    }

    public void MakeStage()
    {
        
    }

    public void MakeOrder()
    {
        
    }

    public void ForceAction(int actionNumber)
    {
        
    }

    public bool IfFinishGame()
    {
        return true
    }
}