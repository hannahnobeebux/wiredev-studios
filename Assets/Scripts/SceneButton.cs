using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public string sceneToLoad;

    public void LoadScene()
    {
        GameObject sceneManagerObj = GameObject.Find("SceneManagerObject");
        if (sceneManagerObj != null)
        {
            SceneLoader sceneLoader = sceneManagerObj.GetComponent<SceneLoader>();
            if (sceneLoader != null)
            {
                sceneLoader.LoadScene(sceneToLoad);
            }
            else
            {
                Debug.LogError("SceneLoader script is missing on SceneManagerObject");
            }
        }
        else
        {
            Debug.LogError("SceneManagerObject not found");
        }
    }
}

