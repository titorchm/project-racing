using UnityEngine;

[CreateAssetMenu(fileName = "PositionData", menuName = "ScriptableObjects/PositionData")]
public class PositionData: ScriptableObject
{
    public string position;
    public string display_name;
    public string round_time;
    public string email;
}
