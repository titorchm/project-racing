using UnityEngine;

public class DrivingManual : MonoBehaviour
{
    [SerializeField] private GameObject image;
    private bool _isActive = true;

    private void Start()
    {
        image.SetActive(_isActive);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton6))
        {
Debug.Log("KeyPressed");
            if (_isActive)
            {
                _isActive = false;
            
                image.SetActive(false);
            }
            else
            {
                _isActive = true;
                
                image.SetActive(true);
            }
        }
    }
}
