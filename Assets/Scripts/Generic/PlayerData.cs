using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData", order = 1)]
public class PlayerData : ScriptableObject
{
    public string firstname;
    public string lastname;
    public long lapTime;
    public string email;
    public bool cp1;
    public bool cp2;

    public void ResetCheckpoints(){
        cp1 = false;
        cp2 = false;
    }
}
