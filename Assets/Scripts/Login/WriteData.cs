using UnityEngine;

public class WriteData : MonoBehaviour
{
    public PlayerData playerData;

    public void WritePlayerData(string firstName, string lastName, string email){
        playerData.firstname = firstName;
        playerData.lastname = lastName;
        playerData.email = email;
    }
}
