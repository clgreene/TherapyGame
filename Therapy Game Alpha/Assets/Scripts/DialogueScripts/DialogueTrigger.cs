using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour
{
    

    DialogueSequenceManager dialogueManager;
    public SaveFile currentStatus;
    public string charName;
    DialogueSequenceObject triggeredSequence;
    DialogueTrigger me;

    public UnityEvent endEvent;

    // Start is called before the first frame update
    void Start()
    {
        switch (charName)
        {
            case "Synthetic":
                triggeredSequence = currentStatus.Synthetic_Dialogue;
                break;
            case "Nova":
                triggeredSequence = currentStatus.Nova_Dialogue;
                break;
            case "MrvN":
                triggeredSequence = currentStatus.MrvN_Dialogue;
                break;
            case "Sweeper":
                triggeredSequence = currentStatus.Sweeper_Dialogue;
                break;

        }
        dialogueManager = FindObjectOfType<DialogueSequenceManager>();
        me = this;
    }

    //function that starts a dialogue sequence
    public void StartDialogue()
    {
        switch (charName)
        {
            case "Synthetic":
                triggeredSequence = currentStatus.Synthetic_Dialogue;
                break;
            case "Nova":
                triggeredSequence = currentStatus.Nova_Dialogue;
                break;
            case "MrvN":
                triggeredSequence = currentStatus.MrvN_Dialogue;
                break;
            case "Sweeper":
                triggeredSequence = currentStatus.Sweeper_Dialogue;
                break;

        }//who are we talking to?

        dialogueManager.currentSequence = triggeredSequence;
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
