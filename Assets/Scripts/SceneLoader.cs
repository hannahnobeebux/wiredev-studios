using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene switching

public class SceneLoader : MonoBehaviour
{
    public void LoadQuizScene()
    {
        Debug.Log("✅ Quiz button was clicked!");
        SceneManager.LoadScene("QuizScene"); // Ensure "QuizScene" matches exactly
    }
}
