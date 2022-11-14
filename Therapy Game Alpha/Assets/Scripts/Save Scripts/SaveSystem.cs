using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{

    public SaveFile saveOne;
    public SaveFile saveTwo;
    public SaveFile saveThree;

    public SaveFile saveDefault;

    // Start is called before the first frame update
    void Start()
    {
        string json = JsonUtility.ToJson(saveOne); //takes so and makes it a json text string
        Debug.Log(json);
        JsonUtility.FromJsonOverwrite(json, saveThree);
    }

    private class PlayerData
    {

    }
}
