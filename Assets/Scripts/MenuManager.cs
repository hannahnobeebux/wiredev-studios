using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Start Button Clicked - Loading GameRoom");
        SceneManager.LoadScene("GameRoom");
    }

    public void QuitGame()
    {
       Debug.Log("Quit button clicked! Exiting game...");

        // Works in a built application
        Application.Quit();

        // Works in the Unity Editor
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
