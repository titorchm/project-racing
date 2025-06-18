using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLap : MonoBehaviour
{
    
	[SerializeField] private ButtonAction buttonAction;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Joystick1Button0)){

	buttonAction.RestartLap();

}
    }
}
