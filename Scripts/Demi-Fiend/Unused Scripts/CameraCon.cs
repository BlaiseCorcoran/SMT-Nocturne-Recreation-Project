using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{
    //PURPOSE: Follow behind the player at all times

    //Global Variables
    public Transform camTarget;
    public float pLerp = 1f;
    public float rLerp = 1f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);
    }
}
