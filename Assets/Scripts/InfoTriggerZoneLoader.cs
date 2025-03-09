using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoTriggerZoneLoader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered InfoTriggerZone, Loading InfoScene");
            SceneManager.LoadScene("InfoScene");
        }
    }
}

