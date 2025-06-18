using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomSceneManager: MonoBehaviour
{
    public static void LoadScene(string sceneName)
    {
        // Check if the scene exists before loading
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene " + sceneName + " cannot be loaded. Make sure it exists in the build settings.");
        }
    }

    // Static method for asynchronous scene loading
    public static void LoadSceneAsync(string sceneName)
    {
        // Create a GameObject to run the coroutine if it doesn't exist
        GameObject sceneLoaderObject = new GameObject("SceneLoader");
        SceneLoader loader = sceneLoaderObject.AddComponent<SceneLoader>();
        loader.StartCoroutine(loader.LoadSceneAsyncCoroutine(sceneName));
    }

    public static void RestartScene(){
        LoadScene(SceneManager.GetActiveScene().name);
    }
}


public class SceneLoader : MonoBehaviour
{
    public IEnumerator LoadSceneAsyncCoroutine(string sceneName)
    {
        // Check if the scene can be loaded
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

            // While the scene is still loading, yield the coroutine
            while (!asyncLoad.isDone)
            {
                // You can add code here to show a loading screen or update a progress bar
                Debug.Log("Loading progress: " + (asyncLoad.progress * 100) + "%");
                yield return null;  // Wait for the next frame
            }

            // Scene is fully loaded, optionally clean up the SceneLoader object
            Destroy(gameObject);
        }
        else
        {
            Debug.LogError("Scene " + sceneName + " cannot be loaded. Make sure it exists in the build settings.");
        }
    }
}
