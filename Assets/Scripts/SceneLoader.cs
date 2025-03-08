using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private static SceneLoader instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep this object across scenes
        }
        else
        {
            Destroy(gameObject); // Prevent duplicates
        }
    }

    public void LoadScene(string sceneName)
    {
        Debug.Log("Loading Scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void LoadQuizScene()
    {
        Debug.Log("Loading QuizScene...");
        SceneManager.LoadScene("QuizScene");
    }

    public void LoadGameRoom()
    {
        Debug.Log("Loading GameRoom...");
        SceneManager.LoadScene("GameRoom");
    }

    public void LoadInfoScene()
    {
        Debug.Log("Loading InfoScene...");
        SceneManager.LoadScene("InfoScene");
    }
}
