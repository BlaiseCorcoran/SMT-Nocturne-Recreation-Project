using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    public AudioSource aud;

    //takes the player back to the main menu from the credits
    public void BackFromCredits()
    {
        StartCoroutine(back());
    }

    IEnumerator back()
    {
        aud.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
