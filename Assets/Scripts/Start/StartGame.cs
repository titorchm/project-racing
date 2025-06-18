using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
[SerializeField] private StartButtonAction buttonAction;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Joystick1Button0)){

	buttonAction.StartGame();

}
    }
}
