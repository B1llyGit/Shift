using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    private GameObject Target;

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.gameObject.name);
        if (collider.gameObject.name == "Third Person Player")
        {
            Target = collider.gameObject;
            Debug.Log(Target);
            Target.transform.position = Target.GetComponent<ThirdPersonMovement>().StartPosition;
            Target.transform.rotation = Target.GetComponent<ThirdPersonMovement>().StartRotation;
        }
    }
}
