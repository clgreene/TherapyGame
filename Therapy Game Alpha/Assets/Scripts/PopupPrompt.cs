using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupPrompt : MonoBehaviour
{

    public bool selected;
    public int choice;

    // Start is called before the first frame update
    void Start()
    {
        selected = false;
        choice = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void confirm()
    {
        choice = 1;
        selected = true;
    }

    public void deny()
    {
        choice = 2;
        selected = false;
    }
}
