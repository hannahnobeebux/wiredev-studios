using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToGameButton : MonoBehaviour
{
    [SerializeField] private string gameSceneName = "GameRoom";
    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(ReturnToGame);
        }
        else
        {
            Debug.LogError("ReturnToGameButton script is missing a Button component");
        }
    }

    private void ReturnToGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}

