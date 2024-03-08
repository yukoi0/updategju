using UnityEngine;

public class Health : MonoBehaviour
{
    private static int destroyedCount = 0; // Counter for destroyed game objects

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        // Check if the collided object has the "Trash" tag
        if (collision2D.gameObject.CompareTag("trash"))
        {
            // Destroy the trash object
            Destroy(collision2D.gameObject);

            // Increment the destroyed count
            destroyedCount++;

            // Print the destroyed count to the console
            Debug.Log("Number of trash objects destroyed: " + destroyedCount);
        }
    }
}
