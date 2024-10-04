using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractWithCacheCube : MonoBehaviour
{
    public Button open;
    public TextMeshProUGUI openTxt;
    public Image panelTxt;


    void Start()
    {
        open.gameObject.SetActive(false);
        openTxt.gameObject.SetActive(false);
        panelTxt.gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "cache_cube")
        {
            open.gameObject.SetActive(true);
        }

    }

    void OnCollisionExit(Collision col)
    {
        if (col.collider.tag == "cache_cube")
        {
            open.gameObject.SetActive(false);
            openTxt.gameObject.SetActive(false);
            panelTxt.gameObject.SetActive(false);
        }
    }

    public void OnOpen()
    {
        openTxt.gameObject.SetActive(true);
        panelTxt.gameObject.SetActive(true);
    }


}
