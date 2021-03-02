using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation2 : MonoBehaviour
{
    [SerializeField] private Animator theAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            theAnimationController.SetBool("PlaySetTwoDown", true);
        }
        
    }
}
