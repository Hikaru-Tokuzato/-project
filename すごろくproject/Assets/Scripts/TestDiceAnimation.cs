using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDiceAnimation : MonoBehaviour
{
    [SerializeField] Button button;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(this.OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        anim = GetComponent<Animator>();
        anim.SetTrigger("ButtonTrigger");
    }
}
