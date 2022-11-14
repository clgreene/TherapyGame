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
        displayedDialogue.text = currentSequence.sequence[currentLine];

    }

    //engaged by the next button on the dialogue canvas
    public void ContinueDialogue()
    {
        if(currentSequence.sequence.Length > currentLine + 1)
        {
            currentLine += 1;
            displayedDialogue.text = currentSequence.sequence[currentLine];
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
        //figuring out who we are talking to, then determining whose dialogue we need to update;
        switch (currentSequence.charName.ToString())
        {
            case "Synthetic": //are we talking to Synthetic right now?
                Debug.Log("got to the switch");
                currentStatus.Synthetic_Dialogue = currentSequence.branches[0]; //Okay then, update Novas next dialogue they will load.
                if (currentSequence.branches.Length > 1)//are there more branches to update?
                {
                    for (int i = 1; i < currentSequence.branches.Length; i++)//okay then, lets figure out whose branches we are updating.
                    {
                        switch (currentSequence.branches[i].charName.ToString())
                        {
                            case "Nova"://are we updating Novas? 
                                currentStatus.Nova_Dialogue = currentSequence.branches[i]; //set novas next dialogue to whatever this branch says to
                                break;
                            case "Sweeper"://are we updating Sweepers?
                                currentStatus.Sweeper_Dialogue = currentSequence.branches[i]; //set sweepers next dial to whatever this branch says to
                                break;
                            case "MrvN":
                                currentStatus.MrvN_Dialogue = currentSequence.branches[i];
                                break;
                            case "Synthetic":
                                currentStatus.Synthetic_Dialogue = currentSequence.branches[i];
                                break;

                        }

                    }
                }
                break;
            case "Nova": //are we talking to Nova right now?
                currentStatus.Nova_Dialogue = currentSequence.branches[0]; //Okay then, update Novas next dialogue they will load.
                if (currentSequence.branches.Length > 1)//are there more branches to update?
                {
                    for (int i = 1; i < currentSequence.branches.Length; i++)//okay then, lets figure out whose branches we are updating.
                    {
                        switch (currentSequence.branches[i].charName.ToString())
                        {
                            case "Nova"://are we updating Novas? 
                                currentStatus.Nova_Dialogue = currentSequence.branches[i]; //set novas next dialogue to whatever this branch says to
                                break;
                            case "Sweeper"://are we updating Sweepers?
                                currentStatus.Sweeper_Dialogue = currentSequence.branches[i]; //set sweepers next dial to whatever this branch says to
                                break;
                            case "MrvN":
                                currentStatus.MrvN_Dialogue = currentSequence.branches[i];
                                break;
                            case "Synthetic":
                                currentStatus.Synthetic_Dialogue = currentSequence.branches[i];
                                break;

                        }

                    }
                }
                break;

            case "Sweeper": 
                currentStatus.Sweeper_Dialogue = currentSequence.branches[0];
                if (currentSequence.branches.Length > 1)
                {
                    for (int i = 1; i < currentSequence.branches.Length; i++)
                    {
                        switch (currentSequence.branches[i].charName.ToString())
                        {
                            case "Nova":
                                currentStatus.Nova_Dialogue = currentSequence.branches[i];
                                break;
                            case "Sweeper":
                                currentStatus.Sweeper_Dialogue = currentSequence.branches[i];
                                break;
                            case "MrvN":
                                currentStatus.MrvN_Dialogue = currentSequence.branches[i];
                                break;
                        }

                    }
                }
                break;

            case "MrvN":
                currentStatus.MrvN_Dialogue = currentSequence.branches[0];
                if (currentSequence.branches.Length > 1)
                {
                    for (int i = 1; i < currentSequence.branches.Length; i++)
                    {
                        switch (currentSequence.branches[i].charName.ToString())
                        {
                            
                            case "Nova":
                                currentStatus.Nova_Dialogue = currentSequence.branches[i];
                                break;
                            case "Sweeper":
                                currentStatus.Sweeper_Dialogue = currentSequence.branches[i];
                                break;
                            case "MrvN":
                                currentStatus.MrvN_Dialogue = currentSequence.branches[i];
                                break;
                        }

                    }
                }
                break;
        }
        currentTrigger.charName = currentSequence.nextCharacter.ToString();
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
