using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip audioClip;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayOneShot(audioClip);
    }

    private void OnTriggerExit(Collider other)
    {
        AudioSource.Stop();
    }
}