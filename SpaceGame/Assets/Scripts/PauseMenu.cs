using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject options;

    void Start()
    {
        pauseMenu.SetActive(false);
        options.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
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
    }

    public void OnExitClick()
    {
        Debug.Log("Exit Level");
    }
}
