using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayNewGame : MonoBehaviour
{
    //PURPOSE: SEND PLAYER TO THE SPECIFIED SCENE

    public AudioSource aud;
    public AudioSource aud2;

    //Sends player to the Main Menu
    public void ToMain()
    {
        StartCoroutine(mainPage());
    }

    IEnumerator mainPage()
    {
        aud.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Starts a new game
    public void StartNewGame()
    {
        StartCoroutine(NewGame());
    }

    IEnumerator NewGame()
    {
        aud.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    //Sends Player to Credits Page
    public void ToCredits()
    {
        StartCoroutine(credit());
    }

    IEnumerator credit()
    {
        aud2.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
