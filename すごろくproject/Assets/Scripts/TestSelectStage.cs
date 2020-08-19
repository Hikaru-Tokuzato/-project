using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestSelectStage : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] Text data;
    static string player_data = "1";
    static string stage_data = "Stage1";

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
            player_data = PlayerBotton();
        }
        else if (button.tag.Equals("StageBotton"))
        {
            stage_data = StageBotton();
        }
        else if (button.tag.Equals("DecisionBotton"))
        {
            Decision(stage_data);
        }
    }
    public string PlayerBotton()
    {
        switch (data.text)
        {
            case "1":
                data.text = "2";
                return "2";
            case "2":
                data.text = "3";
                return "3";
            case "3":
                data.text = "4";
                return "4";
            case "4":
                data.text = "1";
                return "1";
            default:
                break;
        }
        return null;
    }
    public string StageBotton()
    {
        switch (data.text)
        {
            case "Stage1":
                data.text = "Stage2";
                return "Stage2";
            case "Stage2":
                data.text = "Stage3";
                return "Stage3";
            case "Stage3":
                data.text = "Stage4";
                return "Stage4";
            case "Stage4":
                data.text = "Stage1";
                return "Stage1";
            default:
                break;
        }
        return null;
    }
    public void Decision(string stage_data)
    {
        SceneManager.LoadScene(stage_data, LoadSceneMode.Single);
    }
}
