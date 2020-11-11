using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOverTest : MonoBehaviour
{
    public AudioSource voiceoverSource;


    // Start is called before the first frame update
    void Start()
    {
        voiceoverSource = GetComponent<AudioSource> ();
    }

    
    //Plays Clip On Collision with Player
    private void OnTriggerEnter (Collider other)  
    {
        if (other.gameObject.tag == "Player")
        {
            voiceoverSource.Play();
        }
    }
}
