using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void StartGameClick() // Accessed through the StartGame button, and triggered when clicked
    {
        Debug.Log("Yessirrr"); // Sends the debug message on click
        SceneManager.LoadScene("SampleScene"); //  Switches Scene
    }

    public void OptionsClick() // Accessed through the Options button, and triggered when clicked (Currently no options Menu)
    {
        Debug.Log("Options mmmmm"); // Sends the debug message on click
    }

    public void ExitGame() // Accessed through the Exit button, and triggered when clicked
    {
        Debug.Log("Game Poof"); // Sends the debug message on click
        Application.Quit(); // Quits game (Only in built version)
        UnityEditor.EditorApplication.isPlaying = false; // Quits game (Only in Editor)
    }
}
