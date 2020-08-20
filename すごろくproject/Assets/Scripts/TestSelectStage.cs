using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestSelectStage : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] Text data;
    public static string player_data = "1";
    static string stage_data = "Stage1";

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(this.OnClick);
    }
    
    public void OnClick()
    {
        if (button.tag.Equals("PlayerButton"))
        {
            player_data = PlayerButton();
        }
        else if (button.tag.Equals("StageButton"))
        {
            stage_data = StageButton();
        }
        else if (button.tag.Equals("DecisionButton"))
        {
            Decision(stage_data);
        }
    }
    public string PlayerButton()
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
                throw new InvalidOperationException();
        }

        return data.text;
    }
    public string StageButton()
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
                throw new InvalidOperationException();
        }
        return data.text;
    }
    public void Decision(string stage_data)
    {
        SceneManager.LoadScene(stage_data, LoadSceneMode.Single);
    }
}
