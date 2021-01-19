using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelePortTest : MonoBehaviour
{
    public GameObject teleportTarget;
    public GameObject thePlayer;
    
    //Teleports Player on Collision
    private void OnTriggerEnter (Collider other)  
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}
