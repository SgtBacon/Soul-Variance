using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //On press, start game
    public void StartGame()
    {
        SceneManager.LoadScene("CharacterSelect");
    }

    //On press, Quit Game
    public void QuitGame()
    {
        Application.Quit();
    }

    //On press, open Options
    public void Options()
    {
        //SceneManager.LoadScene("Options");
        Debug.Log("Options");
    }
}
