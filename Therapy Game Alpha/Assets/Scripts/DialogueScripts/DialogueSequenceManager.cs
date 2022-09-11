using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSequenceManager : MonoBehaviour
{
    //make private
    public DialogueSequenceObject currentSequence;

    public GameObject dialogueBox;
    public GameObject responseOptions;

    public int currentLine;

    public Text displayedDialogue;
    public Button responseOne;
    public Button responseTwo;
    public Button responseThree;


    public void StartDialogue()
    {
        dialogueBox.SetActive(true);
        currentLine = 0;
        displayedDialogue.text = currentSequence.sequence[currentLine];

    }

    public void ContinueDialogue()
    {
        if(currentSequence.sequence.Length >= currentLine + 1)
        {
            currentLine += 1;
            displayedDialogue.text = currentSequence.sequence[currentLine];
        }

        else
        {
            if(currentSequence.responses.Length > 0)
            {
                Respond();
            }
            else
            {
                ExitDialogue();
            }
        }
    }

    public void Respond()
    {
        //if statement for single or options on response
        responseOne.GetComponent<Text>().text = currentSequence.responses[1];
        responseOptions.SetActive(true);
    }

    public void ExitDialogue()
    {
        dialogueBox.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
