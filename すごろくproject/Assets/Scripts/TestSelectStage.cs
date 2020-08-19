using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestSelectStage : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] Text data;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(this.OnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        if (button.tag.Equals("PlayerBotton"))
        {
            PlayerBotton();
        }
        else if (button.tag.Equals("StageBotton"))
        {
            StageBotton();
        }
        else if (button.tag.Equals("DecisionBotton"))
        {
            Decision();
        }
    }
    public void PlayerBotton()
    {
        switch (data.text)
        {
            case "1":
                data.text = "2";
                break;
            case "2":
                data.text = "3";
                break;
            case "3":
                data.text = "4";
                break;
            case "4":
                data.text = "1";
                break;
            default:
                break;
        }
    }
    public void StageBotton()
    {
        switch (data.text)
        {
            case "Stage1":
                data.text = "Stage2";
                break;
            case "Stage2":
                data.text = "Stage3";
                break;
            case "Stage3":
                data.text = "Stage4";
                break;
            case "Stage4":
                data.text = "Stage1";
                break;
            default:
                break;

        }
    }
    public void Decision()
    {
        
        Debug.Log("test");
    }
}
