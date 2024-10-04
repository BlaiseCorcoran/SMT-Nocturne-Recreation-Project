using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InteractWithDoor : MonoBehaviour
{
    //PURPOSE:  THIS SCRIPT WILL LET THE PLAYER INTERACT WITH OBJECTS.
    //          WHEN THE PLAYER OBJECT COLLIDES WITH THE OBJECT
    //          THEY WILL BE PROMPTED WITH A BUTTON.
    //          

    public Button next;

    void Start()
    {
        next.gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "door") {
            next.gameObject.SetActive(true);
        }

    }

    void OnCollisionExit(Collision col)
    {
        if(col.collider.tag == "door")
        {
            next.gameObject.SetActive(false);
        }
    }

    public void OnNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void To1FStairs()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void BFloorBackToElevator()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}

   
