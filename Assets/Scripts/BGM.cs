using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    AudioSource audioSource;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        DontDestroyOnLoad(this);
    }
}