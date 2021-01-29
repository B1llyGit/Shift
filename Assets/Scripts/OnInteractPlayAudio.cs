using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractPlayAudio : MonoBehaviour
{

    public AudioSource teleport;

    void Start()
    {
        teleport = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            teleport.Play();

            Destroy (collision.gameObject);
        }
    }
}

