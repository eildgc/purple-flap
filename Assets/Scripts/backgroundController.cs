﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundController : MonoBehaviour
{
    //Scrolling Speed
    public float speedScrollBG = 0.01f;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
            Vector2 offset = new Vector2 (Time.time * speedScrollBG, 0);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        
    }
}
