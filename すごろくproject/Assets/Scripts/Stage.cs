using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    Grid[] grids;
    List<Character> Characters;
    int activePlayer;
    List<int> order;
    
    public void MakePlayer(int playerNum)
    {
        for (int i = 1; i <= playerNum; i++)
        {
            this.Characters.Add(new Character("Player" + i));
        }
    }

    public void MakeOrder()
    {
        for (int i = 1; i <= Characters.Count; i++)
        {
            order.Add(i);
        }

        activePlayer = order[0];
    }
    
    public void MakeStage(Grid[] grids)
    {
        this.grids = grids;
    }
    
    public void ForceAction(int actionNumber)
    {
        if (actionNumber == 1) //ダイスを振る
        {
            var value = Characters[actionNumber].RollDice();
            Characters[actionNumber].Move(value);
            var action = grids[Characters[actionNumber].coordinate].GetAction();
            Characters[actionNumber].CharacterAction(action);
        }
    }

    public bool IfFinishGame()
    {
        return true;
    }
}