using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class SaveFile : ScriptableObject
{
    public int saveFileNum;
    public bool inUse;
    public string scene;
    public DialogueSequenceObject currentDialogue;
    public DialogueSequenceObject MrvN_Dialogue;
    public DialogueSequenceObject Sweeper_Dialogue;
}
