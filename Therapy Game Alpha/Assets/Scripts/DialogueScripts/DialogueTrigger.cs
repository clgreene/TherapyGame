using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    DialogueSequenceManager dialogueManager;
    public SaveFile currentStatus;
    public string charName;
    DialogueSequenceObject triggeredSequence;
    DialogueTrigger me;



    // Start is called before the first frame update
    void Start()
    {
        switch (charName)
        {
            case "Synthetic":
                triggeredSequence = currentStatus.SyntheticDialogue;
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
                triggeredSequence = currentStatus.SyntheticDialogue;
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

        switch (triggeredSequence.charName)
        {
            case "Nova":
                dialogueManager.charName = "Nova";
                break;
            case "MrvN":
                dialogueManager.charName = "MrvN";
                break;
            case "Sweeper":
                dialogueManager.charName = "Sweeper";
                break;
        }
    }

    public void EndDialogue()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
