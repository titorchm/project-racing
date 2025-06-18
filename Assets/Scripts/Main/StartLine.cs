using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLine : MonoBehaviour
{
    public PlayerData playerData;


    // Scripts
    private TimeTracker tt;
    private ElapsedTime et;

    private void Start()
    {
        GameObject so = GameObject.FindGameObjectWithTag("SceneObject");
        GameObject te = GameObject.FindGameObjectWithTag("TimeElapsed");

        tt = so.GetComponent<TimeTracker>();
        et = te.GetComponent<ElapsedTime>();
    }

    void Update() {
        if(!tt.IsRunning()){
            et.UpdateGUI("");
            return;
        }

        et.UpdateGUI(tt.GetElapsedTime());
    }

    private void OnTriggerEnter(Collider other)
    {
        // to prevent other objects with colliding

        if(!other.CompareTag("RaceCar")){
            return;
        }

        Debug.Log("Crossed start-line");

        // starting StopWatch if not yet

        if(!tt.IsRunning()){
            tt.StartStopwatch();
            return;
        }

        // logic for finish line

        if(playerData.cp1 && playerData.cp2){
            tt.StopStopwatch();
            playerData.lapTime = tt.GetElapsedTimeMS();
            Debug.Log(playerData.lapTime);
            CustomSceneManager.LoadSceneAsync("EndScene");
        }
    }

    
}
