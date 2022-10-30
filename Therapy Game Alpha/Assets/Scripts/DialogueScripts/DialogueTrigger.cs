using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    DialogueSequenceManager dialogueManager;
    public DialogueSequenceObject triggeredSequence;
    DialogueTrigger me;



    // Start is called before the first frame update
    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueSequenceManager>();
        me = this;
    }

    //function that starts a dialogue sequence
    public void StartDialogue()
    {
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
