using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionUpdate : MonoBehaviour
{
    private GameObject Controller;
    public bool Red;

    // Start is called before the first frame update
    void Start()
    {
        Controller = GameObject.Find("Controller");
    }

    // Update is called once per frame
    void Update()
    {
        if (Red)
        {
            if (Controller.GetComponent<Shift>().RedActive)
            {
                GetComponent<Renderer>().material = Controller.GetComponent<Shift>().RActive;
                GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                GetComponent<MeshRenderer>().receiveShadows = true;
                if (GetComponent<BoxCollider>())
                {
                    GetComponent<BoxCollider>().enabled = true;
                }
                else if (GetComponent<MeshCollider>())
                {
                    GetComponent<MeshCollider>().enabled = true;
                }
            }
            if (!Controller.GetComponent<Shift>().RedActive)
            {
                GetComponent<Renderer>().material = Controller.GetComponent<Shift>().RInactive;
                GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
                GetComponent<MeshRenderer>().receiveShadows = false;
                if (GetComponent<BoxCollider>())
                {
                    GetComponent<BoxCollider>().enabled = false;
                }
                else if (GetComponent<MeshCollider>())
                {
                    GetComponent<MeshCollider>().enabled = false;
                }
            }
        }
        else
        {
            if (Controller.GetComponent<Shift>().BlueActive)
            {
                GetComponent<Renderer>().material = Controller.GetComponent<Shift>().BActive;
                GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                GetComponent<MeshRenderer>().receiveShadows = true;
                if (GetComponent<BoxCollider>())
                {
                    GetComponent<BoxCollider>().enabled = true;
                }
                else if (GetComponent<MeshCollider>())
                {
                    GetComponent<MeshCollider>().enabled = true;
                }
            }
            if (!Controller.GetComponent<Shift>().BlueActive)
            {
                GetComponent<Renderer>().material = Controller.GetComponent<Shift>().BInactive;
                GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
                GetComponent<MeshRenderer>().receiveShadows = false;
                if (GetComponent<BoxCollider>())
                {
                    GetComponent<BoxCollider>().enabled = false;
                }
                else if (GetComponent<MeshCollider>())
                {
                    GetComponent<MeshCollider>().enabled = false;
                }
            }
        }
    }
}
