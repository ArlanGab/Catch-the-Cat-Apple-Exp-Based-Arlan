using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("GameScene");
        HealthManager.health = 3;
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void level2()
    {
        SceneManager.LoadSceneAsync("LEVEL2");
        HealthManager.health = 3;
        Time.timeScale = 1;
    }
    public void Story()
    {
        SceneManager.LoadSceneAsync("Opening");
        Time.timeScale = 1;
    }
}
