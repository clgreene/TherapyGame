using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSequenceManager : MonoBehaviour
{
    //current save file holding all dialogue branching information
    public SaveFile currentStatus;

    //set by DialogueTrigger
    [HideInInspector]
    public DialogueSequenceObject currentSequence;
    [HideInInspector]
    public DialogueTrigger currentTrigger;


    //set in engine
    public GameObject dialogueBox;
    public GameObject responseOptions;
    public GameObject continuePrompt;
    public Text displayedDialogue;

    //set in local functions
    //[HideInInspector]
    public int currentLine;
    //[HideInInspector]
    public bool dialogueEnabled;

    //defined in local functions by dialogueSequenceObject
    [HideInInspector]
    public Button[] responses;

    void Start()
    {
        currentSequence = currentStatus.current_Dialogue;
    }

    //engaged by the dialogue trigger
    public void StartDialogue()
    {
        Debug.Log("Started in the manager");
        dialogueBox.SetActive(true); //dialogue ui box turned on
        currentLine = 0; //set our starting position for the dialogue lines
        dialogueEnabled = true; //setting dialogue bool for other classes to reference
        displayedDialogue.text = currentSequence.sequence[currentLine].dialogueLine; //setting text of the dialogue box to our first line of dialogue

    }

    //engaged by the next button on the dialogue canvas
    public void ContinueDialogue()
    {
        if(currentSequence.sequence.Length > currentLine + 1)
        {
            currentLine += 1;
            displayedDialogue.text = currentSequence.sequence[currentLine].dialogueLine;
            displayedDialogue.color = currentSequence.sequence[currentLine].textColor;
        }

        else
        {
            if(currentSequence.responses.Length > 0) // if there are response options for this sequence, run the response function
            {
                Debug.Log("Respond");
                Respond();
            }
            else //otherwise, we'll just exit the dialogue encounter
            {
                Debug.Log("Exit");
                ExitDialogue();
            }
        }
    }


    public void Respond()
    {

    }

    public void ExitDialogue()
    {

        currentLine = 0;
        dialogueBox.SetActive(false);
        dialogueEnabled = false;
        currentSequence.endEvent.Invoke();
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && dialogueEnabled == true)
        {
            Debug.Log("registered enter");
            ContinueDialogue();
        }
    }
}
