using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlayer : MonoBehaviour
{
     public AudioClip[] audioSources;
     public AudioSource randomSound;
 
     // Start is called before the first frame update
     void Start()
     {
         randomSound = this.GetComponent<AudioSource>();
         randomSound.clip = this.audioSources[Random.Range(0, audioSources.Length)];
         randomSound.volume = 0.3f;
         randomSound.Play(0);
        //  Debug.Log("Music playingg ... {0}", randomSound);
     }
 

}
