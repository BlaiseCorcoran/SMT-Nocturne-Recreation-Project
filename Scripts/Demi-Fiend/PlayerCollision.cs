using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text txt;

    void start()
    {
        txt.enabled = false;
    }

    void OnCollisionEnter()
    {
        txt.enabled = true;
        txt.text = "THIS IS WORKING";

        Debug.Log("HIT");

    }
}
