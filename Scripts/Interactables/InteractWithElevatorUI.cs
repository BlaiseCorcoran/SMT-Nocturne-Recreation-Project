using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractWithElevatorUI : MonoBehaviour
{
    //PURPOSE: SEND PLAYER TO THE SPECIFIED ROOM AT THE LOCATION OF THE ELEVATOR
    public AudioSource aud;
    public AudioSource aud2;

    //Go back to elevator (SHOULD ONLY WORK ON ROOFTOP)
    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //Sends the Player to the rooftop
    public void GoToR()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Sends the player to the 2nd floor
    public void GoTo2F()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    //Sends the Player to the 1st floor
    public void GoTo1F()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    //Sends player to the basement floor (SPAWN POINT 2)
    public void GoToB1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
