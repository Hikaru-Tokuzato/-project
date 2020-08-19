using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

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
                _stage.ForceAction(actionNumber, i);
            }

            _stage.turn = _stage.turn + 1;
        }
    }
}
