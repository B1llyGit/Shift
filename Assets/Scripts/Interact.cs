using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public float TargetDistance;

    void Update()
    {
        RaycastHit Target;
        if (Input.GetButtonDown("Interact"))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Target))
            {
                TargetDistance = Target.distance;
                if (TargetDistance <= 2)
                {
                    if (Target.collider.gameObject.name == "DoorSwitch")
                    {
                        Target.collider.gameObject.GetComponent<DoorSwitch>().Switch();
                    }
                    else if (Target.collider.gameObject.name == "GravitySwitch")
                    {
                        Target.collider.gameObject.GetComponent<GravitySwitch>().Switch();
                    }
                }
                print(TargetDistance);
            }
        }
    }
}
