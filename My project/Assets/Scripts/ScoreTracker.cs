using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    private int score = 0; // Variable to store the score
    private Text scoreText; // Reference to the UI Text component for displaying the score

    private void Start()
    {
        // Find the UI Text component with a specific tag
        GameObject textObject = GameObject.FindGameObjectWithTag("ScoreText");
        if (textObject != null)
        {
            scoreText = textObject.GetComponent<Text>();
            if (scoreText == null)
            {
                Debug.LogError("UI Text component not found on the object with the 'ScoreText' tag.");
            }
            else
            {
                UpdateScoreText(); // Update the score text when the game starts
            }
        }
        else
        {
            Debug.LogError("No object found with the 'ScoreText' tag.");
        }
    }

    public void IncreaseScore()
    {
        score++; // Increment the score
        UpdateScoreText(); // Update the score text
    }

    private void UpdateScoreText()
    {
        // Update the text of the UI Text component to display the current score
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
