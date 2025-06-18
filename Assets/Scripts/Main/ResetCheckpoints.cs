using UnityEngine;

public class ResetCheckpoints : MonoBehaviour
{
    public PlayerData playerData;

    void Start()
    {
        playerData.ResetCheckpoints();
    }
}
