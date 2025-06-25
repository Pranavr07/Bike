using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndQuitManager : MonoBehaviour
{
    [Header("Scene Change Settings")]
    public string sceneName;

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

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is quitting...");
    }
}