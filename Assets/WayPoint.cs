using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public GameObject nextWaypoint;
    
    

    // Start is called before the first frame update
    void Start()
    {
        // Set the waypoints initial visibilty through inspector
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            nextWaypoint.SetActive(true);
            gameObject.SetActive(false);
        }
    }



}
