using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage
{
    List<Grid> grids;
    List<Character> Characters;
    public List<int> order;
    public int turn { get; set; } = 0;
    
    public void MakePlayer(int playerNum)
    {
        for (int i = 1; i <= playerNum; i++)
        {
            var temp = new Character("Player" + i);
            this.Characters.Add(temp);
        }
    }

    public void MakeOrder()
    {
        for (int i = 1; i <= Characters.Count; i++)
        {
            order.Add(i);
        }
    }
    
    public void MakeStage(List<Grid> grids)
    {
        this.grids = grids;
    }
    
    public void ForceAction(int actionNumber, int index)
    {
        if (actionNumber == 1) //ダイスを振る
        {
            var value = Characters[order[index]].RollDice();
            if (Characters[order[index]].coordinate + value >= grids.Count)
            {
                Characters[order[index]].FinishFlag = true;
                value =  grids.Count - Characters[order[index]].coordinate;
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