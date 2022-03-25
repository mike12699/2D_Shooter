using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject helpPanel;
    public void LoadGame()
    {
        SceneManager.LoadScene("Shooter");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void OpenPanel()
    {
        helpPanel.transform.gameObject.SetActive(true);
    }

    public void ClosePanel()
    {
        helpPanel.transform.gameObject.SetActive(false);
    }
}
