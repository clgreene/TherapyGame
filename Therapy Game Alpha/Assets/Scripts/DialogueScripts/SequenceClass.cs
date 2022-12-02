using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SequenceClass
{
    //class for who is talking, what they are saying, and what they look like while they're saying it

    //initializing enums
    public enum Character
    {
        pc,
        synthetic,
        sweeper,
        ash,
        burk,
        mrvn,
        nova
    }

    public enum Scenes
    {
        office,
        apartment,
        synthetic,
        bar
    }

    public Character charName;
    public string dialogueLine;
    public Color textColor;
    public GameObject portrait;
    public Scenes scene;

}
