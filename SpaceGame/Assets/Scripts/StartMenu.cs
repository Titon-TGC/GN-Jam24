using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void StartGameClick() // Accessed through the StartGame button, and triggered when clicked
    {
        SceneManager.LoadScene("SampleScene"); //  Switches Scene
    }

    public void OptionsClick() // Accessed through the Options button, and triggered when clicked (Currently no options Menu)
    {
        SceneManager.LoadScene("Options"); //  Switches Scene
    }

    public void ExitGame() // Accessed through the Exit button, and triggered when clicked
    {
        Application.Quit(); // Quits game (Only in built version)
        UnityEditor.EditorApplication.isPlaying = false; // Quits game (Only in Editor)
    }
}
