using UnityEngine;

public class CheckPoint1 : MonoBehaviour
{
public PlayerData playerData;
    private void OnTriggerEnter(Collider other){
        if(!other.CompareTag("RaceCar")){
            return;
        }
        playerData.cp1 = true;
        playerData.cp2 = false;
        Debug.Log("Collided with first checkpoint");
    }
}
