using UnityEngine.Networking;
using System.Collections;
using UnityEngine;
using System;

public class HandleData : MonoBehaviour
{
    public SetDisplay setDisplay;

    private string url = "http://desktop-fw16.htl-vil.local:4173/api/round";
    private string token = "NpyuqiwOgcAiOYPGAyiBOKWbmSENtnWK";
    
    void Start()
    {
        StartCoroutine(Upload());
    }

    IEnumerator Upload()
    {
        using (UnityWebRequest www = UnityWebRequest.Post(
                url,
                String.Format(
                    "{{ \"first_name\": \"{0}\", \"last_name\": \"{1}\", \"round_time\": {2}, \"email\": \"{3}\", \"token\": \"{4}\" }}",
                    setDisplay.playerData.firstname,
                    setDisplay.playerData.lastname,
                    setDisplay.playerData.lapTime,
                    setDisplay.playerData.email,
                    token
                ),
                "application/json"
            ))
        {
            www.downloadHandler = new DownloadHandlerBuffer();

            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError(www.error);
            }
            else
            {
                PositionDataList responseData = JsonUtility.FromJson<PositionDataList>(www.downloadHandler.text);

                byte i = 0;
                
                foreach(PositionObject position in responseData.positions){
                    setDisplay.positions[i].email = position.email;
                    setDisplay.positions[i].position = position.position;
                    setDisplay.positions[i].display_name = position.display_name;
                    setDisplay.positions[i].round_time = position.round_time;

                    i++;
                }

                setDisplay.setDisplay();
            }
        }
    }
}