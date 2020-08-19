using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage
{
    Grid[] grids;
    List<Character> Characters;
    public List<int> order;
    public int turn { get; set; } = 0;
    
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
    }
    
    public void MakeStage(Grid[] grids)
    {
        this.grids = grids;
    }
    
    public void ForceAction(int actionNumber, int index)
    {
        if (actionNumber == 1) //ダイスを振る
        {
            var value = Characters[order[index]].RollDice();
            if (Characters[order[index]].coordinate + value >= grids.Length)
            {
                Characters[order[index]].FinishFlag = true;
                value =  grids.Length - Characters[order[index]].coordinate;
            }
            Characters[order[index]].Move(value);
            var action = grids[Characters[order[index]].coordinate].GetAction();
            Characters[order[index]].CharacterAction(action);
        }
    }

    public bool IfFinishGame()
    {
        if (0 == this.GetActivePlayersNum()) return true;
        else return false;
    }

    public int GetActivePlayersNum()
    {
        int num = 0;
        foreach (var character in Characters)
        {
            if (!character.FinishFlag)
            {
                num++;
            }
        }
        return num;
    }
}