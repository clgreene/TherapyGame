using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SequenceClass
{
    //initializing enums
    public enum Character
    {
        synthetic,
        sweeper,
        ash,
        burk,
        mrvn
    }

    public Character charName;
    public string dialogueLine;
    public GameObject portrait;

}
