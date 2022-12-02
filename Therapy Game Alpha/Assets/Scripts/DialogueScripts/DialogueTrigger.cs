using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour
{
    

    DialogueSequenceManager dialogueManager;
    SaveFile currentStatus;
    public DialogueSequenceObject triggeredSequence;
    DialogueTrigger me;

    public UnityEvent endEvent;

    // Start is called before the first frame update
    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueSequenceManager>(); //find the dialogue manager in the scene

        currentStatus = dialogueManager.currentStatus; //find the current status set it.

        me = this;
    }

    //function that starts a dialogue sequence
    public void StartDialogue()
    {
        switch (currentStatus.current_Dialogue.sequence[0].charName)
        {
            case SequenceClass.Character.synthetic:
                triggeredSequence = currentStatus.Synthetic_Dialogue;
                break;
            case SequenceClass.Character.nova:
                triggeredSequence = currentStatus.Nova_Dialogue;
                break;
            case SequenceClass.Character.mrvn:
                triggeredSequence = currentStatus.MrvN_Dialogue;
                break;
            case SequenceClass.Character.sweeper:
                triggeredSequence = currentStatus.Sweeper_Dialogue;
                break;

        } //who are we talking to

        dialogueManager.currentSequence = currentStatus.current_Dialogue;
        dialogueManager.currentTrigger = me;
        dialogueManager.StartDialogue();

    }

    public void EndDialogue()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
