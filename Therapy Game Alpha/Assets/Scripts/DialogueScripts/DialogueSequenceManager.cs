using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSequenceManager : MonoBehaviour
{
    //current save file holding all dialogue branching information
    public SaveFile currentStatus;

    //set by DialogueTrigger
    public DialogueSequenceObject currentSequence;
    public DialogueTrigger currentTrigger;


    //set in engine
    public GameObject dialogueBox;
    public GameObject responseOptions;
    public Text displayedDialogue;

    //set in local functions
    public int currentLine;
    public bool dialogueEnabled;

    //defined in local functions by dialogueSequenceObject
    public Button[] responses;

    void Start()
    {
        dialogueEnabled = false;
    }

    //engaged by the dialogue trigger
    public void StartDialogue()
    {
        dialogueBox.SetActive(true);
        currentLine = 0;
        dialogueEnabled = true;
        displayedDialogue.text = currentSequence.sequence[currentLine].dialogueLine;

    }

    //engaged by the next button on the dialogue canvas
    public void ContinueDialogue()
    {
        if(currentSequence.sequence.Length > currentLine + 1)
        {
            currentLine += 1;
            displayedDialogue.text = currentSequence.sequence[currentLine].dialogueLine;
        }

        else
        {
            if(currentSequence.responses.Length > 0)
            {
                Debug.Log("Respond");
                Respond();
            }
            else
            {
                Debug.Log("Exit");
                ExitDialogue();
            }
        }
    }


    public void Respond()
    {
        for (int i = 0; i < responses.Length; i++)
        {
            responses[i].GetComponent<Image>().enabled = false;
        }
        //if statement for single or options on response
        for (int i = 0; i < currentSequence.responses.Length; i++)
        {
            responses[i].GetComponent<Image>().enabled = true;
            responses[i].GetComponentInChildren<Text>().text = currentSequence.responses[i];
        }
        
        responseOptions.SetActive(true);
    }

    public void ExitDialogue()
    {
        
        currentLine = 0;
        dialogueBox.SetActive(false);
        dialogueEnabled = false;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && dialogueEnabled == true)
        {
            ContinueDialogue();
        }
    }
}
