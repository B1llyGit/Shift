using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    Vector3 originalPos;
    Vector3 SpawnPos;
    public GameObject BallReset;

    void Start()
    {
        
        originalPos = gameObject.transform.position;
        SpawnPos = BallReset.transform.position;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fog")
        {
            gameObject.transform.position = originalPos;
            GetComponent<Rigidbody>().velocity = Vector3.zero; //Get Rigidbody and set velocity to (0f, 0f, 0f)
        }

        if (other.gameObject.tag == "BatteryTrigger")
        {
            gameObject.transform.position = originalPos;
            GetComponent<Rigidbody>().velocity = Vector3.zero; //Get Rigidbody and set velocity to (0f, 0f, 0f)
        }
    }


     void Update()
    {
       if  (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.transform.position = SpawnPos;
            GetComponent<Rigidbody>().velocity = Vector3.zero; //Get Rigidbody and set velocity to (0f, 0f, 0f)
        }
    }
}
