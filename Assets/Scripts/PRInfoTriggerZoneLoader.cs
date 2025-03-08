using UnityEngine;
using UnityEngine.SceneManagement;

public class PRInfoTriggerZoneLoader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered InfoTriggerZone, Loading InfoScene");
            SceneManager.LoadScene("PRInfoScene");
        }
    }
}
