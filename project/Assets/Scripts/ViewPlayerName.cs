using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ViewPlayerName : MonoBehaviour
{
    [SerializeField] private Text playerLabel;

    void SetPlayerName(string playerName)
    {
        playerLabel.text = playerName;
    }
}
