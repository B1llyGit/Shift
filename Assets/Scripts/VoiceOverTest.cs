using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOverTest : MonoBehaviour
{
    public AudioSource voiceoverSource;

    void Start()
    {
        voiceoverSource = GetComponent<AudioSource> ();
    }

    private void OnTriggerEnter (Collider other)  
    {
        if (other.gameObject.tag == "Player")
        {
            voiceoverSource.Play();
        }
    }
}
