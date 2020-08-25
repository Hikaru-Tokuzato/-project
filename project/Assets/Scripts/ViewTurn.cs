using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewTurn : MonoBehaviour
{
    [SerializeField] private Text turnLabel;

    void SetTurn(int turn)
    {
        turnLabel.text = turn.ToString() + "ターン目";
    }
}
