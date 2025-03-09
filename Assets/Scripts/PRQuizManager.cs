using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PRQuizManager : MonoBehaviour
{
    public Button answer1, answer2, answer3, answer4, submitButton;
    private string selectedAnswer;
    private string correctAnswer = "Create a new branch and make changes";

    public GameObject winPanel; 
    public GameObject losePanel; 

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
        string trimmedSelected = selectedAnswer.Trim();
        string trimmedCorrect = correctAnswer.Trim();
        Debug.Log("Checking Answer... Selected: " + selectedAnswer + ", Correct: " + correctAnswer);
        
        if (trimmedSelected.Equals(trimmedCorrect, System.StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log("Correct! Loading Win Panel...");
            winPanel.SetActive(true); 
            losePanel.SetActive(false);
            Invoke("LoadNextQuestion", 2f);
        }
        else
        {
            Debug.Log("Incorrect! Loading Lose Panel...");
            losePanel.SetActive(true); 
            winPanel.SetActive(false);
        }
    }

    public void ResetQuiz()
    {
        Debug.Log("Resetting quiz for another attempt.");
        selectedAnswer = "";
        losePanel.SetActive(false);
    }

}