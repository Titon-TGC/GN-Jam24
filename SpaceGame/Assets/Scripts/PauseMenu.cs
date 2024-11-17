using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenu;
    public GameObject options;

    void Start()
    {
        pauseMenu.SetActive(false);
        options.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && options.activeSelf == false)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void OnOptionsClick()
    {
        pauseMenu.SetActive(false);
        options.SetActive(true);
    }

    public void OnOptionsBack()
    {
        options.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void OnResumeClick()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
