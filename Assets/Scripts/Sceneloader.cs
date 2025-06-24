using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndQuitManager : MonoBehaviour
{
    [Header("Scene Change Settings")]
    public string sceneName;

    // Call this from a button to load the scene
    public void ChangeScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene name is empty!");
        }
    }

    // Call this from a button to quit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is quitting...");
    }
}