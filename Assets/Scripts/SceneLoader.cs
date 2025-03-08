using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    private static SceneLoader instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("✅ SceneLoader Initialized - Persisting across scenes.");
        }
        else
        {
            Debug.Log("❌ Duplicate SceneLoader detected, destroying extra instance.");
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        // Try to assign the Quiz Button dynamically in InfoScene
        AssignQuizButton();
    }

    void AssignQuizButton()
    {
        Button quizButton = GameObject.Find("Quiz Button")?.GetComponent<Button>();
        if (quizButton != null)
        {
            Debug.Log("🎯 Quiz Button Found! Assigning function...");
            quizButton.onClick.RemoveAllListeners(); // Remove any old references
            quizButton.onClick.AddListener(LoadQuizScene);
        }
        else
        {
            Debug.Log("⚠️ Quiz Button Not Found in this scene.");
        }
    }

    public void LoadQuizScene()
    {
        Debug.Log("📌 Quiz Button Clicked! Loading QuizScene...");
        SceneManager.LoadScene("QuizScene");
    }
}

