using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingPlatform : MonoBehaviour
{
    public GameObject thePlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == thePlayer)
        {
            thePlayer.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == thePlayer)
        {
            thePlayer.transform.parent = null;
        }
    }
}
