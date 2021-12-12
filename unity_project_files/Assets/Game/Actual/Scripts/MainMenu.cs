using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void PlayAgain()
    {
        StartCoroutine(LoadLevelAsync());

        SceneManager.LoadScene(1);
    }

    private IEnumerator LoadLevelAsync()
    {
        var progress = SceneManager.LoadSceneAsync("TestScene1");

        while (!progress.isDone)
        {
            yield return null;
        }

        Debug.Log("Scene Loaded");
    }
    
}
