using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu]
[System.Serializable]
public class SaveFile : ScriptableObject
{
    public int saveFileNum;
    public bool inUse;

    public enum Scene
    {
        menu,
        office,
        boss,
        apartment,
        bar
    }


    public Scene scene = new Scene();

    public DialogueSequenceObject current_Dialogue;
    public DialogueSequenceObject Synthetic_Dialogue;
    public DialogueSequenceObject MrvN_Dialogue;
    public DialogueSequenceObject Sweeper_Dialogue;
    public DialogueSequenceObject Nova_Dialogue;
    public DialogueSequenceObject Berk_Dialogue;
    public DialogueSequenceObject Ash_Dialogue;
}
