using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDudLevels : MonoBehaviour
{
    public GameObject InteractUI;

    public bool colliding;

    public void Start()
    {
        InteractUI.SetActive(false);
        colliding = false;
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractUI.SetActive(true);
            colliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractUI.SetActive(false);
            colliding = false;
        }
    }
}

