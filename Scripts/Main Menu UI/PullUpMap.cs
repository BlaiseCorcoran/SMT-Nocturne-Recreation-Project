using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PullUpMap : MonoBehaviour
{
    public Image map;

    // Start is called before the first frame update
    void Start()
    {
        map.enabled = false;

    

        /*if (Input.GetKeyDown(KeyCode.M))
        {
            map.enabled = false;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            map.enabled = true;
        }

        if(Input.GetKeyDown(KeyCode.N))
        {
            map.enabled = false;
        }

    }
}
