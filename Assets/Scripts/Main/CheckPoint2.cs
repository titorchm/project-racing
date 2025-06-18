using UnityEngine;

public class CheckPoint2 : MonoBehaviour
{
    public PlayerData playerData;
    private void OnTriggerEnter(Collider other){
        if(!other.CompareTag("RaceCar")){
            return;
        }
        playerData.cp2 = true;
        Debug.Log("Collided with second checkpoint");
    }
}
