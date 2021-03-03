using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameObject Target;
    public Vector3 newStart;
    public Quaternion newRotate;

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.gameObject.name);
        if (collider.gameObject.name == "Third Person Player")
        {
            Target = collider.gameObject;
            Debug.Log(Target);
            Target.GetComponent<ThirdPersonMovement>().StartPosition = newStart;
            Target.GetComponent<ThirdPersonMovement>().StartRotation = newRotate;
        }
    }
}
