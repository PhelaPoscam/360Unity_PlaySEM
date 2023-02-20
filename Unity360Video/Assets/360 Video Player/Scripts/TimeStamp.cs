using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TimeStamp : MonoBehaviour
{
    private float startTime;

    private void Start()
    {
        startTime = Time.time;
        string filePath = Application.dataPath + "/PlayTimestamp.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine("Play button was clicked at " + startTime + " seconds.");
        }
    }
}
