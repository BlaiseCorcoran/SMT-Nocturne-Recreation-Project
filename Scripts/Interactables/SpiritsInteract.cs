using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiritsInteract : MonoBehaviour
{
    public Image txtBox;
    public Text spirittxt;
    public Button interactBtn;

    void Start()
    {
        txtBox.gameObject.SetActive(false);
        interactBtn.gameObject.SetActive(false);
        spirittxt.gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            interactBtn.gameObject.SetActive(true);
        }

    }

    void OnCollisionExit(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            interactBtn.gameObject.SetActive(false);
            spirittxt.gameObject.SetActive(false);
            txtBox.gameObject.SetActive(false);
        }
    }

    public void OnInteract()
    {
        spirittxt.gameObject.SetActive(true);
        txtBox.gameObject.SetActive(true);
    }
}
