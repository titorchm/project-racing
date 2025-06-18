using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRace : MonoBehaviour
{
[SerializeField] private StartRaceButtonAction buttonAction;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Joystick1Button0)){

	buttonAction.StartRace();

}
    }
}
