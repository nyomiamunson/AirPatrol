using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Destroyer : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); //Get a reference to our AudioSource
    }

    void DestroyGameObject()
    {
        AudioSource audioSource; //Delcare a AudioSource reference variable
        audioSource = GetComponent<AudioSource>(); //Get a reference to our AudioSource
        audioSource.Play();
        Destroy(gameObject);
    }
}
