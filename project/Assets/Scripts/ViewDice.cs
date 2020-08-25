using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewDice : MonoBehaviour
{
    private Animator _animator;
    
    public ViewDice()
    { 
        _animator = this.GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        throw new NotImplementedException("実装してないで");
    }

    public void StopAnimation(int value)
    {
        throw new NotImplementedException("実装してないで");
    }
}
