using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button startButton;
    public Button quitButton;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Make sure to create this scene later
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
