using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Start Button Clicked! Loading GameRoom...");
        SceneManager.LoadScene("GameRoom"); // Ensure the correct scene name
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
