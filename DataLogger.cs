using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class DataLogger : MonoBehaviour
{
    private float startTime;
    private int clickCount = 0;

    void Start()
    {
        startTime = Time.time;
        InvokeRepeating("LogPosition", 1f, 2f);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
        }
    }

    void LogPosition()
    {
        Vector3 pos = transform.position;
        Debug.Log("Position: " + pos);
    }

    void OnApplicationQuit()
    {
        float timeSpent = Time.time - startTime;

        string data = "Clicks: " + clickCount + "\nTime: " + timeSpent;

        File.WriteAllText(Application.dataPath + "/data.txt", data);
    }
}

