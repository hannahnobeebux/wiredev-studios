using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoTriggerZoneLoader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Ensure Player is tagged correctly
        {
            Debug.Log("Player entered InfoTriggerZone! Loading InfoScene...");
            SceneManager.LoadScene("InfoScene"); // Ensure this matches the scene name
        }
    }
}

