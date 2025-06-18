using UnityEngine;

public class StartButtonAction : MonoBehaviour
{
    public void StartGame(){
        CustomSceneManager.LoadSceneAsync("LoginScene");
    }
}
