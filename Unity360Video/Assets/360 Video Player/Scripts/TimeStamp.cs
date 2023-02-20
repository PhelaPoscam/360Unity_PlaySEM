using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class TimeStamp : MonoBehaviour
{
    private string filePath;
    private static bool hasQuit = false;

    void Start()
    {
        // Set the file path to the Application.persistentDataPath directory
        filePath = Application.dataPath + "/DateTime.txt";

        // Get the current date and time
        DateTime currentDate = DateTime.Now;

        // Write the start date and time to a text file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Start date and time: " + currentDate.ToString());
        }

         StartCoroutine(QuitAfterOneMinute());
    }

    IEnumerator QuitAfterOneMinute()
    {
        // Wait for 1 minute
        yield return new WaitForSeconds(60);

        // Quit the application
        UnityEditor.EditorApplication.isPlaying = false;
    }

    void OnApplicationQuit()
    {
        // Check if we have already written the quit date and time to the file
        if (!hasQuit)
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;

            // Append the quit date and time to the text file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("Quit date and time: " + currentDate.ToString());
            }

            // Indicate that we have already written the quit date and time to the file
            hasQuit = true;
        }
    }
}
