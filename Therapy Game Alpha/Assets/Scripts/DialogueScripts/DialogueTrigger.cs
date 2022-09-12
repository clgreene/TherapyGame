using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    DialogueSequenceManager dialogueManager;

    public DialogueSequenceObject triggeredSequence;

    public DialogueTrigger me;



    // Start is called before the first frame update
    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueSequenceManager>();
        me = this;
    }

    public void StartDialogue()
    {
        dialogueManager.currentSequence = triggeredSequence;
        dialogueManager.currentTrigger = me;
        dialogueManager.StartDialogue();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
