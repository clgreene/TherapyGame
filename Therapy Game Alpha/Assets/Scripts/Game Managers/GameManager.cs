using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public SaveFile currentStatus;

    public DialogueTrigger dialTrigger;

    public GameObject officeCam;
    public GameObject apartmentCam;
    public GameObject bossCam;
    public GameObject barCam;

    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = FindObjectOfType<Camera>();
        loadState();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void loadState()
    {
        switch (currentStatus.scene)
        {
            case SaveFile.Scene.office:
                cam.transform.position = officeCam.transform.position;
                cam.transform.rotation = officeCam.transform.rotation;
                break;
            case SaveFile.Scene.apartment:
                cam.transform.position = apartmentCam.transform.position;
                cam.transform.rotation = apartmentCam.transform.rotation;
                break;
            case SaveFile.Scene.boss:
                cam.transform.position = bossCam.transform.position;
                cam.transform.rotation = bossCam.transform.rotation;
                break;
            case SaveFile.Scene.bar:
                cam.transform.position = barCam.transform.position;
                cam.transform.rotation = barCam.transform.rotation;
                break;

        }
        //look at current dialogue sequence we are in if we are in a dialogue sequence.
        //place camera in correct setting for sequence / phase of gameplay

        dialTrigger.StartDialogue();
        //if in sequence, we start that dialogue
        //if in something else, we load that managers state
    }
}
