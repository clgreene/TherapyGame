using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CreateAssetMenu]
public class DialogueSequenceObject : ScriptableObject
{
    
    public SequenceClass[] sequence;

    public ResponseClass[] responses;

    public UnityEvent endEvent;

    public SaveFile currentStatus;

    void Start()
    {
        
    }

    public void setCharDialoguePos(DialogueSequenceObject nextDialogue)
    {
        currentStatus = FindObjectOfType<DialogueSequenceManager>().currentStatus;

        switch (nextDialogue.sequence[0].charName)
        {
            case SequenceClass.Character.synthetic:
                currentStatus.Synthetic_Dialogue = nextDialogue;
                break;
        }
    }

    public void setNextDialogue(DialogueSequenceObject nextActiveDialogue)
    {
        currentStatus = FindObjectOfType<DialogueSequenceManager>().currentStatus;
        currentStatus.current_Dialogue = nextActiveDialogue;
    }

    public void changeButtonEvent()
    {

    }

}
