using UnityEngine;
using TMPro;

public class StartRaceButtonAction : MonoBehaviour
{
    public TMP_InputField firstName;
    public TMP_InputField lastName;
    public TMP_InputField email;

    public WriteData data;

    public void StartRace(){
        if(CheckInput.CheckInputData(firstName.text, lastName.text, email.text) == "empty"){

            return;
        }
        if(CheckInput.CheckInputData(firstName.text, lastName.text, email.text) == "email"){

            return;
        }
        data.WritePlayerData(firstName.text, lastName.text, email.text);
        CustomSceneManager.LoadSceneAsync("MainScene");
    }
}
