using UnityEngine;

// PURPOSE: to help the player navigate to another scene from GameRoom to the information scene
public class InfoPanelManager : MonoBehaviour
{
    public GameObject infoPanel;
    public Transform teleportLocation; 

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by: " + other.gameObject.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger zone.");
            
            if (infoPanel == null)
            {
                Debug.LogError("InfoPanel reference is missing!");
                return;
            }

            infoPanel.SetActive(true);
            Debug.Log("InfoPanel should now be active: " + infoPanel.activeSelf);

            if (teleportLocation != null)
            {
                other.transform.position = teleportLocation.position;
                Debug.Log("Player teleported to InfoPanel.");
            }
            else
            {
                Debug.LogError("Teleport location not set!");
            }
        }
    }
}

