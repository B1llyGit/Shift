using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : MonoBehaviour
{
    public GameObject InteractUI;

    public bool colliding;

    public void Start()
    {
        InteractUI.SetActive(false);
        colliding = false;
    }

    void Update()
    {
        if (colliding == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Level01"); // CHANGE THIS WHEN SCENE NAME CHANGES
        }

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

