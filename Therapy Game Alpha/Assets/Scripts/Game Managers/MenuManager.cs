using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public SaveFile saveFileOne;
    public SaveFile saveFileTwo;
    public SaveFile saveFileThree;
    public SaveFile currentStatus; //where you are at right now while playing, not necasserily your save. Used to overwrite your save when you save the game. basically it's a temporary holding file

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


    // FILE ONE OPTIONS //

    public void loadSaveOne()
    {
        popupCanvas.enabled = true;
        StartCoroutine(confirmLoadSaveOne());
    }

    IEnumerator confirmLoadSaveOne()
    {
        while (prompt.selected == false)
        {
            yield return null;
        }
        popupCanvas.enabled = false;
        if (prompt.choice == 1)
        {
            saveFileOne.inUse = true;
            brain.activeGame = saveFileOne;
            brain.playing = true;
        }
        prompt.selected = false;
        prompt.choice = 0;

    }

    public void beginSaveOne()
    {
        popupCanvas.enabled = true;
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
            saveFileOne.inUse = true;
            
            brain.activeGame = saveFileOne;
            brain.playing = true;
            SceneManager.LoadScene(brain.activeGame.scene, LoadSceneMode.Single);
        }
        prompt.selected = false;
        prompt.choice = 0;
    }

    public void deleteSaveOne()
    {
        popupCanvas.enabled = true;
        StartCoroutine(confirmDeleteSaveOne());
    }

    IEnumerator confirmDeleteSaveOne()
    {
        while (prompt.selected == false)
        {
            yield return null;
        }
        popupCanvas.enabled = false;
        if (prompt.choice == 1)
        {
            saveFileOne.inUse = false;
            //reset all values of save file one to default
        }
        prompt.selected = false;
        prompt.choice = 0;
    }

    // FILE TWO OPTIONS //

    public void loadSaveTwo()
    {
        popupCanvas.enabled = true;
        StartCoroutine(confirmLoadSaveTwo());
    }

    IEnumerator confirmLoadSaveTwo()
    {
        while (prompt.selected == false)
        {
            yield return null;
        }
        popupCanvas.enabled = false;
        if (prompt.choice == 1)
        {
            saveFileTwo.inUse = true;
            brain.activeGame = saveFileTwo;
            brain.playing = true;
        }
        prompt.selected = false;
        prompt.choice = 0;

    }

    public void beginSaveTwo()
    {
        popupCanvas.enabled = true;
        StartCoroutine(confirmBeginSaveTwo());
    }

    IEnumerator confirmBeginSaveTwo()
    {
        while (prompt.selected == false)
        {
            yield return null;
        }
        popupCanvas.enabled = false;
        if (prompt.choice == 1)
        {
            saveFileTwo.inUse = true;
            brain.activeGame = saveFileTwo;
            brain.playing = true;
        }
        prompt.selected = false;
        prompt.choice = 0;
    }

    public void deleteSaveTwo()
    {
        popupCanvas.enabled = true;
        StartCoroutine(confirmDeleteSaveTwo());
    }

    IEnumerator confirmDeleteSaveTwo()
    {
        while (prompt.selected == false)
        {
            yield return null;
        }
        popupCanvas.enabled = false;
        if (prompt.choice == 1)
        {
            saveFileTwo.inUse = false;
            //reset all values of save file one to default
        }
        prompt.selected = false;
        prompt.choice = 0;
    }

    // FILE THREE OPTIONS //

    public void loadSaveThree()
    {
        popupCanvas.enabled = true;
        StartCoroutine(confirmLoadSaveThree());
    }

    IEnumerator confirmLoadSaveThree()
    {
        while (prompt.selected == false)
        {
            yield return null;
        }
        popupCanvas.enabled = false;
        if (prompt.choice == 1)
        {
            saveFileThree.inUse = true;
            brain.activeGame = saveFileThree;
            brain.playing = true;
        }
        prompt.selected = false;
        prompt.choice = 0;

    }

    public void beginSaveThree()
    {
        popupCanvas.enabled = true;
        StartCoroutine(confirmBeginSaveThree());
    }

    IEnumerator confirmBeginSaveThree()
    {
        while (prompt.selected == false)
        {
            yield return null;
        }
        popupCanvas.enabled = false;
        if (prompt.choice == 1)
        {
            saveFileThree.inUse = true;
            brain.activeGame = saveFileThree;
            brain.playing = true;
        }
        prompt.selected = false;
        prompt.choice = 0;
    }

    public void deleteSaveThree()
    {
        popupCanvas.enabled = true;
        StartCoroutine(confirmDeleteSaveThree());
    }

    IEnumerator confirmDeleteSaveThree()
    {
        while (prompt.selected == false)
        {
            yield return null;
        }
        popupCanvas.enabled = false;
        if (prompt.choice == 1)
        {
            saveFileThree.inUse = false;
            //reset all values of save file one to default
        }
        prompt.selected = false;
        prompt.choice = 0;
    }
}
