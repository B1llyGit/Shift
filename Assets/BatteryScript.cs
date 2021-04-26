using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryScript : MonoBehaviour
{
    //Battery Components
    private static int BatteryLevel;
    public GameObject BatteryBlock1;
    public GameObject BatteryBlock2;
    public GameObject BatteryBlock3;

    //Two Materials On and Off
    public Material OffMat;
    public Material OnMat;

    //The Waypoint Activated upon task completion.
    public GameObject Waypoint;
    public GameObject SoundTrigger;

    //The Door triggers Activated upon task completion.
    public GameObject DoorTrigger;
    public GameObject EndDoorTrigger;

  

    //Battery Audio Player and Clips
    AudioSource BatteryPlayer;
    public AudioClip LVLup;

    // Start is called before the first frame update
    void Start()
    {
        //Setting Initial Materials
        BatteryBlock1.GetComponent<MeshRenderer>().material = OffMat;
        BatteryBlock2.GetComponent<MeshRenderer>().material = OffMat;
        BatteryBlock3.GetComponent<MeshRenderer>().material = OffMat;
    }

    // Update is called once per frame
    void Update()
    {
        BatteryLevel = DestroyTrigger.BatLevel;

        // Change the material each battery block when BatteryLevel == 1,2,3.
        //Play the correct miss response.
        if (BatteryLevel == 1)
        {
            
            BatteryBlock1.GetComponent<MeshRenderer>().material = OnMat;
            
        }
        if (BatteryLevel == 2)
        {
            BatteryBlock2.GetComponent<MeshRenderer>().material = OnMat;
            
        }
        if (BatteryLevel == 3)
        {
            BatteryBlock3.GetComponent<MeshRenderer>().material = OnMat;
            DoorTrigger.SetActive(true);
            EndDoorTrigger.SetActive(true);
            Waypoint.SetActive(true);
            EndDoorTrigger.SetActive(true);

        }
    }
}
