using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow360 : MonoBehaviour
{
    public Transform player;
    public Vector3 lookOffset = new Vector3 (0, 1, 0);
    public float dist = 5;
    public float camSpeed = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookPos = player.position + lookOffset;
        this.transform.LookAt(lookPos);

        if (Vector3.Distance(this.transform.position, lookPos) > dist)
        {
            this.transform.Translate(0, 0, camSpeed * Time.deltaTime);
        }
    }
}
