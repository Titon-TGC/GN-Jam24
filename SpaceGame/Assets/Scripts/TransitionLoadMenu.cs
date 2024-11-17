using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionLoaderMenu : MonoBehaviour
{
    public Animator transition;
    public string scene;
    private GameObject menu;
    public string menuname;

    public void Update()
    {
        menu = GameObject.Find(menuname);
    }

    public void LoadNextLevelMenu()
    {
        StartCoroutine(LoadLevelMenu());
    }

    IEnumerator LoadLevelMenu()
    {
        if(menu.activeSelf)
        {
            menu.SetActive(false);
            Time.timeScale = 1f;
        }
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(scene);
    }
}
