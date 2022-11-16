using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{

    public SaveFile currentStatus;
    public SaveFile defaultStatus;



    // Start is called before the first frame update
    void Start()
    {

    }


    public void startSaveOne()
    {
        string saveOneJson = JsonUtility.ToJson(defaultStatus);
        File.WriteAllText(Application.dataPath + "/saveFileOne.json", saveOneJson);
    }

    public void saveGameOne()
    {
        string saveOneJson = JsonUtility.ToJson(currentStatus);
        File.WriteAllText(Application.dataPath + "/saveFileOne.json", saveOneJson);
    }

    public void loadSaveOne()
    {
        string saveOneJson = File.ReadAllText(Application.dataPath + "/saveFileOne.json");

        JsonUtility.FromJsonOverwrite(saveOneJson, currentStatus);
    }

    public void deleteSaveOne()
    {
        File.Delete(Application.dataPath + "/saveFileOne.json");
    }

    public void saveGameTwo()
    {

    }

    public void loadSaveTwo()
    {

    }

    public void deleteSaveTwo()
    {

    }

    public void saveGameThree()
    {

    }

    public void loadSaveThree()
    {

    }

    public void deleteSaveThree()
    {

    }


    //delete function before final build - merely for setup purposes
    public void saveDefaultGame()
    {
        string defaultSaveJson = JsonUtility.ToJson(defaultStatus);
        File.WriteAllText(Application.dataPath + "/saveFileOne.json", defaultSaveJson);
    }
}
