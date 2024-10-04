using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    float hSpeed = 2.0f;
    float vSpeed = 2.0f;

    void Update()
    {
        float h = hSpeed * Input.GetAxis("Mouse X");
        float v = vSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(v, h, 0);
    }
}
