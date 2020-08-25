using UnityEngine;
using UnityEngine.SceneManagement; //シーン切り替えに使用するライブラリ

namespace Scripts
{
    public class SceneChange : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("SelectScene", LoadSceneMode.Single);
            }
        }
    }
}