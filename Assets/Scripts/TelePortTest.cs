using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelePortTest : MonoBehaviour
{
    public GameObject teleportTarget;
    public GameObject thePlayer;
    
    //Plays Clip On Collision with Player
    private void OnTriggerEnter (Collider other)  
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}
