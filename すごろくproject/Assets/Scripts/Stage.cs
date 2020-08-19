using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage
{
    List<Grid> grids = new List<Grid>();
    List<Character> Characters = new List<Character>();
    public List<int> order = new List<int>();
    public int turn { get; set; } = 0;
    
    public void MakePlayer(int playerNum)
    {
        for (int i = 1; i <= playerNum; i++)
        {
            this.Characters.Add(new Character("Player" + i) );
        }
    }

    public void MakeOrder()
    {
        Debug.Log("charactercount = "+Characters.Count);
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
            var value = Characters[order[index]-1].RollDice();
            if (Characters[order[index]-1].coordinate + value >= grids.Count)
            {
                Characters[order[index]-1].FinishFlag = true;
                value =  grids.Count - Characters[order[index]-1].coordinate -1;
            }
            Characters[order[index]-1].Move(value);
            var action = grids[Characters[order[index]-1].coordinate].GetAction();
            Characters[order[index]-1].CharacterAction(action);
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