using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MenuManager : MonoBehaviour
{
    public SaveSystem saveSys;

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
        saveSys = FindObjectOfType<SaveSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (File.Exists(Application.dataPath + "/saveFileOne.json"))
        {
            startButtonOne.GetComponentInChildren<Text>().text = "Begin";
        }
        else startButtonOne.GetComponentInChildren<Text>().text = "Load";

        if (Application.dataPath + "/saveFileTwo.json" == null)
        {
            startButtonTwo.GetComponentInChildren<Text>().text = "Begin";
        }
        else startButtonTwo.GetComponentInChildren<Text>().text = "Load";

        if (Application.dataPath + "/saveFileThree.json" == null)
        {
            startButtonThree.GetComponentInChildren<Text>().text = "Begin";
        }
        else startButtonThree.GetComponentInChildren<Text>().text = "Load";

    }

    //Save system taking care of this now... delete once it's been thouroughly tested...
    /*
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
            saveSys.loadSaveOne();
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
            //load in the default json savefile into the currentStatus S.O.
            //pull current scene, character, etc from currentStatus and load them.
            SceneManager.LoadScene(currentStatus.current_Dialogue.sequence[0].scene.ToString(), LoadSceneMode.Single);
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

            //reset all values of save file one to default
        }
        prompt.selected = false;
        prompt.choice = 0;
    }



    void setCurrentStatus()
    {
        
    }
    */
}




