using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewDice : MonoBehaviour
{
    private Animator _animator;
    private bool m_isMotion = false;
    public bool IsMotion{
        get{ return m_isMotion; }
    }

    public ViewDice()
    { 
        _animator = this.GetComponent<Animator>();
    }

    public void StartAnimation(int value)
    {
        _animator.SetTrigger("ButtonTrigger");
        StartCoroutine("MotionChange");
    }

    IEnumerator MotionChange()
    {
        // https://kasatanet.hatenablog.com/entry/2017/11/26/224555
        m_isMotion = true;
      
        //遷移を待つ
        float transitionTime = 0;
        while (_animator.IsInTransition(0))
        {
            transitionTime += Time.deltaTime;
            yield return 0;
        }
        //念のためアニメーションのステートをUpdate
        //無いと遷移前ステートを取得しちゃうことがあります。。。
        _animator.Update(0);

        //モーション時間分だけ待つ
        AnimatorStateInfo stateInfo = _animator.GetCurrentAnimatorStateInfo(0);
        yield return new WaitForSeconds(stateInfo.length - transitionTime);
        
        m_isMotion = false;
    }
}
