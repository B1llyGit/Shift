using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    public static int BatLevel;

    // Miss Audio Player and Clips
    public AudioSource MissPlayer;
    public AudioClip BatteryLVL1;
    public AudioClip BatteryLVL2;
    public AudioClip BatteryLVL3;

    // Start is called before the first frame update
    void Start()
    {
        BatLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            BatLevel++;
            gameObject.GetComponent<BoxCollider>().enabled = false;

            if (BatLevel == 1)
            {
                MissPlayer.PlayOneShot(BatteryLVL1, 1.0F);
            }
            else if (BatLevel == 2)
            {
                MissPlayer.PlayOneShot(BatteryLVL2, 1.0F);
            }
            else if (BatLevel == 3)
            {
                MissPlayer.PlayOneShot(BatteryLVL3, 1.0F);
            }
        }
    }



}
