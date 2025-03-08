using UnityEngine;

public class PersistentEventSystem : MonoBehaviour
{
    private static PersistentEventSystem instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep this EventSystem alive
        }
        else
        {
            Debug.Log("Duplicate EventSystem detected, destroying extra instance.");
            Destroy(gameObject); // Prevent duplicate EventSystems
        }
    }
}

