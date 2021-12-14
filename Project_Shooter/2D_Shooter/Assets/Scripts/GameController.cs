using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Shooter");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
