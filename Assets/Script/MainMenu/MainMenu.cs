using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// For "Editor" button, on clicking the button, this function will be called and load the editor scene
    /// </summary>
    public void OpenEditor()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenTestField()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
