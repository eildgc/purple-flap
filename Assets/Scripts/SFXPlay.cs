﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlay : MonoBehaviour
{

    AudioSource audioData;
    public void PlaySFX()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }
    
}
