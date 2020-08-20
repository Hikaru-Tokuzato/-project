using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class Stage
    {
        public List<IGrid> grids = new List<IGrid>();
        public List<Character> Characters = new List<Character>();
        public List<int> order = new List<int>();
        public int turn { get; set; } = 0;
    
        public void MakePlayer(int playerNum)
        {
            for (int i = 0; i < playerNum; i++)
            {
                this.Characters.Add(new Character("Player" + i) );
            }
        }

        public void MakeOrder()
        {
            Debug.Log("charactercount = "+Characters.Count);
            for (int i = 0; i < Characters.Count; i++)
            {
                order.Add(i);
            }
        }
    
        public void MakeStage(List<IGrid> grids)
        {
            this.grids = grids;
        }
    
        public int ForceAction(int actionNumber, int index)
        {
            if (Characters[order[index]].FinishFlag == true) return -1;
            int value = 0;
            
            if (actionNumber == 1) //ダイスを振る
            {
                value = Characters[order[index]].RollDice();
                if (Characters[order[index]].coordinate + value >= grids.Count - 1)
                {
                    Characters[order[index]].FinishFlag = true;
                    value = grids.Count - Characters[order[index]].coordinate -1;
                }
                Characters[order[index]].Move(value);
                var action = grids[Characters[order[index]].coordinate].GetAction();
                Characters[order[index]].CharacterAction(action);
            }

            return value;
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
}