using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    
    public SaveFile saveFileOne;
    public SaveFile saveFileTwo;
    public SaveFile saveFileThree;

    public Button startButtonOne;
    public Button startButtonTwo;
    public Button startButtonThree;

    public Button loadButtonOne;
    public Button loadButtonTwo;
    public Button loadButtonThree;

    public Button deleteButtonOne;
    public Button deleteButtonTwo;
    public Button deleteButtonThree;

    public GameBrain brain;

    public Canvas popupCanvas;

    public PopupPrompt prompt;

    float waitTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (saveFileOne.inUse == false)
        {
            startButtonOne.interactable = true;
            loadButtonOne.interactable = false;
            deleteButtonOne.interactable = false;
            
        }

        else
        {
            startButtonOne.interactable = false;
            loadButtonOne.interactable = true;
            deleteButtonOne.interactable = true;
        }

        if (saveFileTwo.inUse == false)
        {
            startButtonTwo.interactable = true;
            loadButtonTwo.interactable = false;
            deleteButtonTwo.interactable = false;

        }

        else
        {
            startButtonTwo.interactable = false;
            loadButtonTwo.interactable = true;
            deleteButtonTwo.interactable = true;
        }

        if (saveFileThree.inUse == false)
        {
            startButtonThree.interactable = true;
            loadButtonThree.interactable = false;
            deleteButtonThree.interactable = false;

        }

        else
        {
            startButtonThree.interactable = false;
            loadButtonThree.interactable = true;
            deleteButtonThree.interactable = true;
        }
    }


    //File One Buttons//
    public void loadSaveOne()
    {
        brain.playing = true;
        brain.activeGame = saveFileOne;
    }

    public void beginSaveOne()
    {
        
        popupCanvas.enabled = true;
        saveFileOne.inUse = true;
        brain.activeGame = saveFileOne;
        StartCoroutine(confirmBeginSaveOne());

    }

    IEnumerator confirmBeginSaveOne()
    {
        while (prompt.selected == false)
        {
            yield return null;
        }
        popupCanvas.enabled = false;
        if (prompt.choice == 1)
        {
            brain.playing = true;
        }
        else if (prompt.choice == 2)
        {
            saveFileOne.inUse = false;
            brain.playing = false;
        }
        prompt.selected = false;
        prompt.choice = 0;
    }

    public void deleteSaveOne()
    {
        saveFileOne.inUse = false;
    }


    //File Two Buttons//
    public void loadSaveTwo()
    {
        brain.playing = true;
        brain.activeGame = saveFileTwo;
    }

    public void beginSaveTwo()
    {
        saveFileTwo.inUse = true;
        brain.playing = true;
        brain.activeGame = saveFileTwo;
    }

    public void deleteSaveTwo()
    {
        saveFileTwo.inUse = false;
    }

    //File Three Buttons//
    public void loadSaveThree()
    {
        brain.playing = true;
        brain.activeGame = saveFileThree;
    }

    public void beginSaveThree()
    {
        saveFileThree.inUse = true;
        brain.playing = true;
        brain.activeGame = saveFileThree;
    }

    public void deleteSaveThree()
    {
        saveFileThree.inUse = false;
    }


}
