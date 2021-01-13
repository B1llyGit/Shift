using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirtyUnitInteract : MonoBehaviour
{
    public float TargetDistance;

    void Update()
    {
        RaycastHit Target;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Target))
            {
                TargetDistance = Target.distance;
                if (TargetDistance <= 30)
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
