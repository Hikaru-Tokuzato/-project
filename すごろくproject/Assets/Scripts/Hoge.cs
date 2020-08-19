
using UnityEngine;
using UnityEngine.UI;


public class Hoge : MonoBehaviour
{
    [SerializeField] Button testButton;
    [SerializeField] Text testText;

    private void Awake()
    {
        // textButton がクリックされたら testText の表示文字列を変える

        // １行の処理の書き方
        testButton.onClick.AddListener(() => TextChange("button clicked"));


        // このようにすれば複数行の処理も書ける（匿名関数）
        testButton.onClick.AddListener(() =>
        {
            Debug.Log("hoge");
            // 複数行の処理
            // 複数行の処理
            // 複数行の処理
        });
    }


    // 呼び出される処理
    private void TextChange(string text)
    {
        testText.text = text;
    }
}