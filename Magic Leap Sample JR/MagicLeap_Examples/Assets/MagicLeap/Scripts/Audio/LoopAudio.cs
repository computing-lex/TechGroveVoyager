using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopAudio : MonoBehaviour
{
    // Start is called before the first frame update


    public AudioClip menu;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = menu;
        audioSource.loop = true;
        audioSource.Play();
    }

}
