using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrapEvent : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip clip;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(clip, 0.8f);
    }
}
