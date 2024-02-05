using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }
 
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Vibra()
    {
        Handheld.Vibrate();
    }
}
