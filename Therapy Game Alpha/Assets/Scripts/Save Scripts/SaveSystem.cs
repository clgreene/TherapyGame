using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{

    public SaveFile saveOne;
    public SaveFile saveTwo;
    public SaveFile saveThree;

    public SaveFile currentStatus;

    public SaveFile saveDefault;

    // Start is called before the first frame update
    void Start()
    {
        string json = JsonUtility.ToJson(saveOne); //takes so and makes it a json text string
        Debug.Log(json);
        JsonUtility.FromJsonOverwrite(json, saveThree);
    }

    public void saveGameOne()
    {
        string saveOneJson = JsonUtility.ToJson(currentStatus);
        File.WriteAllText(Application.dataPath + "/saveFileOne.json", saveOneJson);
        Debug.Log("Saved?");
    }

    public void loadSaveOne()
    {

    }

    public void deleteSaveOne()
    {

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
}
