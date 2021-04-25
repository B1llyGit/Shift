using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    public static int BatLevel;
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

        }
    }
}
