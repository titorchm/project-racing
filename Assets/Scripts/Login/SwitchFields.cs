using TMPro;
using UnityEngine;

public class SwitchFields : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField firstname;
    
    [SerializeField]
    private TMP_InputField lastname;

    [SerializeField]
    private TMP_InputField email;

    private int iterator;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            iterator++;

            if(iterator > 2){
                iterator = 0;
            }

            switch(iterator)
            {
                case 0: firstname.Select();
                    break;
                case 1: lastname.Select();
                    break;
                case 2: email.Select();
                    break;
            }
        }
    }
}
