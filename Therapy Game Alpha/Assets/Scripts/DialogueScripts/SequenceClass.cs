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
        synthetic,
        sweeper,
        ash,
        burk,
        mrvn
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
    public GameObject portrait;
    public Scenes scene;

}
