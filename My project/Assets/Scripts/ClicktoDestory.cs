using UnityEngine;

public class ClicktoDestory : MonoBehaviour
{
    private ScoreTracker scoreTracker; // Reference to the ScoreTracker script

    private void Start()
    {
        // Find the ScoreTracker script in the scene
        scoreTracker = FindObjectOfType<ScoreTracker>();
        if (scoreTracker == null)
        {
            Debug.LogError("ScoreTracker script not found!");
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        if (scoreTracker != null)
        {
            scoreTracker.IncreaseScore(); // Call the IncreaseScore method from ScoreTracker
        }
    }
}
