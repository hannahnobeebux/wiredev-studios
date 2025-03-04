using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class QuizManager : MonoBehaviour
{
    public Button answer1;
    public Button answer2;
    public Button answer3;
    public Button answer4;
    public Button submitButton;
    private string selectedAnswer;
    private string correctAnswer = "A) Improves readability"; // Change for different questions

    void Start()
    {
        answer1.onClick.AddListener(() => SelectAnswer(answer1));
        answer2.onClick.AddListener(() => SelectAnswer(answer2));
        answer3.onClick.AddListener(() => SelectAnswer(answer3));
        answer4.onClick.AddListener(() => SelectAnswer(answer4));
        submitButton.onClick.AddListener(CheckAnswer);
    }

    void SelectAnswer(Button button)
    {
        selectedAnswer = button.GetComponentInChildren<TextMeshProUGUI>().text;
        Debug.Log("Selected Answer: " + selectedAnswer);
    }

    void CheckAnswer()
    {
        if (selectedAnswer == correctAnswer)
        {
            Debug.Log("Correct! Loading Win Scene...");
            SceneManager.LoadScene("WinScene"); // Load the win screen
        }
        else
        {
            Debug.Log("Incorrect! Try again.");
        }
    }
}

