using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ElapsedTime : MonoBehaviour
{
    private TextMeshProUGUI elapsedTime;

    void Start()
    {
        elapsedTime = gameObject.GetComponent<TextMeshProUGUI>();
    }

    public void UpdateGUI(string str)
    {
        elapsedTime.text = str;
    }
}
