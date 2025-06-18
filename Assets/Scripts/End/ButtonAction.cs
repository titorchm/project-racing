using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    public void RestartGame(){
        CustomSceneManager.LoadSceneAsync("LoginScene");
    }

    public void RestartLap(){
        CustomSceneManager.LoadSceneAsync("MainScene");
    }
}
