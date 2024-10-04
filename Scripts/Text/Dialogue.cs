using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestSpiritDialogue : MonoBehaviour
{
    //DISPLAYS TEXT THAT SAYS 
    //"THIS WORKS"

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float txtSpeed;
    private int index;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLn());
    }


    IEnumerator TypeLn()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(txtSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = 
                
                string.Empty;
            StartCoroutine(TypeLn());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}


