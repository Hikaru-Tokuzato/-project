using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class GameMaster : MonoBehaviour
    {
    
        private Stage _stage;
        // Start is called before the first frame update
        void Start()
        {
            StartGame();
        }

        void StartGame()
        {
            //ステージ選択
            _stage = new Stage();

            // grids の情報を取得
            // GameObject.FindWithTags
            var grids = new List<Grid>();
            var grid = GameObject.FindGameObjectsWithTag("grid");
            var koma = GameObject.Find("Player");
            foreach(GameObject i in grid)
            {
                grids.Add(i.GetComponent<Grid>());
            }
            _stage.MakeStage(grids);

            //人数聞く
            var playerNum = Convert.ToInt32(TestSelectStage.player_data);
            _stage.MakePlayer(playerNum);

            _stage.MakeOrder();

            while (!_stage.IfFinishGame())
            {
                Debug.Log("turn");
                for (int i = 0; i < _stage.GetActivePlayersNum(); i++)
                {
                    //行動の提示
                    var actionNumber = 1;
                    var value = _stage.ForceAction(actionNumber, i);
                    Vector3 tmp = grid[value-1].transform.position;
                    koma.transform.position = tmp;
                }

                _stage.turn = _stage.turn + 1;
            }
        }
    }
}
