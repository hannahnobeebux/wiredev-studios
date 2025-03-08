using UnityEngine;

public class CursorManager : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true; // Ensure the cursor is visible
        Cursor.lockState = CursorLockMode.None; // Unlock cursor movement
    }
}

