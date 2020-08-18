using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    Grid[] grids;
    List<Character> Characters;
    int turn;
    int order;
    // Start is called before the first frame update
    void Start()
    {

    }

    void AddPlayer(){
        this.Characters.Add(new Character("Taro"));
    }
}