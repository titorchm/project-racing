using System.Diagnostics;
using System;
using UnityEngine;

public class TimeTracker : MonoBehaviour
{
    private Stopwatch stopWatch;

    void Start(){
        stopWatch = new Stopwatch();
    }

    public void StartStopwatch(){
        stopWatch.Start();
    }

    public void StopStopwatch(){
        stopWatch.Stop();
    }

    public bool IsRunning(){
        return stopWatch.IsRunning;
    }

    public int GetElapsedTimeMS(){
        TimeSpan ts = stopWatch.Elapsed;
        return (int) ts.TotalMilliseconds;
    }

    public string GetElapsedTime(){
        TimeSpan ts = stopWatch.Elapsed;
        string formattedTime = string.Format("{0:00}:{1:00}:{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
        return formattedTime;
    }

    public static string FormatTime(long ms){

    long minutes = ms / 60000;
    long seconds = (ms % 60000) / 1000;
    long remainingMilliseconds = ms % 1000;

    string formattedTime = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, remainingMilliseconds);
    return formattedTime;
    }
}
