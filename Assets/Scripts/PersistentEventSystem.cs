using UnityEngine;

// PURPOSE: To manage extra objects created in the "DontDestroyOnLoad" scene such as EventSystem and SceneManagerObject
public class PersistentEventSystem : MonoBehaviour
{
    private static PersistentEventSystem instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.Log("Duplicate EventSystem detected, destroying extra instance.");
            Destroy(gameObject);
        }
    }
}

