﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendMessage : MonoBehaviour
{

    public GameObject SerialHandler;
    public GameObject InputMessage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        Text text = InputMessage.GetComponent<Text>();
        
        Debug.Log(text.text);
        SerialHandler sh = SerialHandler.GetComponent<SerialHandler>();
        sh.Write(text.text);
    }
}
