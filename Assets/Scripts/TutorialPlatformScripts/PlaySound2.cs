using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound2 : MonoBehaviour
{
    public GameObject theTrigg;

    public AudioSource soundPlayer;

    public AudioClip miss;

    void Start()
    {
        //soundPlayer= GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            theTrigg.SetActive(false);
            soundPlayer.PlayOneShot(miss, 1.0F);
        }
    }

}

