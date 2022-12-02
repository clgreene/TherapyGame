using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveSystem : MonoBehaviour
{

    public SaveFile currentStatus;
    public SaveFile defaultStatus;

    public Canvas mainScreen;
    public Canvas confirmScreen;

    public bool selected;
    public int choice;

    int saveNum;
    string saveNumText;

    // Start is called before the first frame update
    void Start()
    {
        selected = false;
        mainScreen.enabled = true;
        confirmScreen.enabled = false;
        saveNum = 0;
    }


    public void startSaveOne()
    {

        mainScreen.GetComponent<Canvas>().enabled = false;
        confirmScreen.GetComponent<Canvas>().enabled = true;

        saveNum = 1;
        saveNumText = "One";

        StartCoroutine(confirm());

    }

    public void saveGameOne()
    {
        string saveOneJson = JsonUtility.ToJson(currentStatus);
        File.WriteAllText(Application.dataPath + "/saveFileOne.json", saveOneJson);
    }

    public void deleteSaveOne()
    {
        File.Delete(Application.dataPath + "/saveFileOne.json");
    }

    public void saveGameTwo()
    {

    }

    public void deleteSaveTwo()
    {

    }

    public void saveGameThree()
    {

    }

    public void deleteSaveThree()
    {

    }


    IEnumerator confirm()
    {
        while (selected == false)
        {
            yield return null;
        }//waiting for selection to be made on confirm screen.

        yield return new WaitForSeconds(0.1f); //buffer to establish choice so we don't overlap a case being run before a choice is registered

        if (!File.Exists(Application.dataPath + "/saveFile" + saveNumText + ".json"))
        {
            switch (saveNum)
            {
                case 1:
                    if (choice == 1)
                    {
                        currentStatus = defaultStatus;
                        string saveOneJson = JsonUtility.ToJson(defaultStatus);
                        File.WriteAllText(Application.dataPath + "/saveFileOne.json", saveOneJson);
                        SceneManager.LoadScene(currentStatus.scene.ToString(), LoadSceneMode.Single);
                    }
                    else
                    {
                        mainScreen.GetComponent<Canvas>().enabled = true;
                        confirmScreen.GetComponent<Canvas>().enabled = false;
                    }
                    selected = false;
                    break;
                case 2:
                    if (choice == 1)
                    {
                        currentStatus = defaultStatus;
                        string saveTwoJson = JsonUtility.ToJson(defaultStatus);
                        File.WriteAllText(Application.dataPath + "/saveFileTwo.json", saveTwoJson);
                        SceneManager.LoadScene(currentStatus.scene.ToString(), LoadSceneMode.Single);
                    }
                    else
                    {
                        mainScreen.GetComponent<Canvas>().enabled = true;
                        confirmScreen.GetComponent<Canvas>().enabled = false;
                    }
                    selected = false;
                    break;
                case 3:
                    if (choice == 1)
                    {
                        currentStatus = defaultStatus;
                        string saveThreeJson = JsonUtility.ToJson(defaultStatus);
                        File.WriteAllText(Application.dataPath + "/saveFileThree.json", saveThreeJson);
                        SceneManager.LoadScene(currentStatus.scene.ToString(), LoadSceneMode.Single);
                    }
                    else
                    {
                        mainScreen.GetComponent<Canvas>().enabled = true;
                        confirmScreen.GetComponent<Canvas>().enabled = false;
                    }
                    selected = false;
                    break;
            }
        
        } //if file doesn't exist, create it and start game

        else
        {
            switch (saveNum)
            {
                case 1:
                    if (choice == 1)
                    {
                        string saveOneJson = File.ReadAllText(Application.dataPath + "/saveFileOne.json");
                        JsonUtility.FromJsonOverwrite(saveOneJson, currentStatus);
                        SceneManager.LoadScene(currentStatus.scene.ToString(), LoadSceneMode.Single);
                    }
                    else
                    {
                        mainScreen.GetComponent<Canvas>().enabled = true;
                        confirmScreen.GetComponent<Canvas>().enabled = false;
                    }
                    selected = false;
                    break;
                case 2:
                    if (choice == 1)
                    {
                        string saveTwoJson = File.ReadAllText(Application.dataPath + "/saveFileTwo.json");
                        JsonUtility.FromJsonOverwrite(saveTwoJson, currentStatus);
                        SceneManager.LoadScene(currentStatus.scene.ToString(), LoadSceneMode.Single);
                    }
                    else
                    {
                        mainScreen.GetComponent<Canvas>().enabled = true;
                        confirmScreen.GetComponent<Canvas>().enabled = false;
                    }
                    selected = false;
                    break;
                case 3:
                    if (choice == 1)
                    {
                        string saveThreeJson = File.ReadAllText(Application.dataPath + "/saveFileThree.json");
                        JsonUtility.FromJsonOverwrite(saveThreeJson, currentStatus);
                        SceneManager.LoadScene(currentStatus.scene.ToString(), LoadSceneMode.Single);
                    }
                    else
                    {
                        mainScreen.GetComponent<Canvas>().enabled = true;
                        confirmScreen.GetComponent<Canvas>().enabled = false;
                    }
                    selected = false;
                    break;
            }
        } //if file does exist, load it in and start game // needs to overwrite current status with json file

    }

    public void startGame()
    {
        selected = true;
        choice = 1;
    }

    public void back()
    {
        selected = true;
    }


    //delete function before final build - merely for setup purposes
    public void saveDefaultGame()
    {
        string defaultSaveJson = JsonUtility.ToJson(defaultStatus);
        File.WriteAllText(Application.dataPath + "/saveFileOne.json", defaultSaveJson);
    }
}
