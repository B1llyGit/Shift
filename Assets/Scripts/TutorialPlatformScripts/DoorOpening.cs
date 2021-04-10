using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    [SerializeField] private Animator theAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Sphere"))
        {
            theAnimationController.SetBool("DoorOpen", true);
        }

        else if (other.CompareTag("Player"))
            {
                theAnimationController.SetBool("DoorHubOpen", true);
            }

    }
}
