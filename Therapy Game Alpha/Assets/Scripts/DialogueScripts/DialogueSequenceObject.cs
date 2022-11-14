using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class DialogueSequenceObject : ScriptableObject
{
    public enum Character
    {
        synthetic,
        sweeper,
        ash,
        burk,
        mrvn
    }
    
    public Character charName;

    public string[] sequence;

    public GameObject character;

    public string[] responses;

    public DialogueSequenceObject[] branches;

    public Character nextCharacter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
