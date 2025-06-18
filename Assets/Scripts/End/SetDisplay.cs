using TMPro;
using UnityEngine;

public class SetDisplay : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;
    [SerializeField]
    private GameObject[] entries;

    [SerializeField]
    private TextMeshProUGUI time;

    [SerializeField]
    public PositionData[] positions;

    public TextMeshProUGUI participant;
    public TextMeshProUGUI number;
    public TextMeshProUGUI[] numbers;
    public TextMeshProUGUI[] participants;
    public TextMeshProUGUI[] times;

    public PlayerData playerData;

    public void setDisplay(){
        int i = 0;
        foreach(PositionData position in positions){
            numbers[i].text = position.position;
            participants[i].text = position.display_name;
            times[i].text = position.round_time;
            time.text = TimeTracker.FormatTime(playerData.lapTime);

            if(position.email == playerData.email){
                Vector3 panelPos = entries[i].transform.position;
                panelPos.y += 430f;
                numbers[i].color = Color.white;
                participants[i].color = Color.white;
                times[i].color = new Color32(59, 130, 246, 255);
                panel.transform.position = panelPos;
                participant.text = position.display_name;
                number.text = position.position;
            }

            i++;
        }
    }
}
