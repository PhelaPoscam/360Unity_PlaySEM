using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEditor;



public class UpSEM : MonoBehaviour
{
    Process proc = null;
    // Start is called before the first frame update
    void Start()
    {
        string batDir = "Assets/360 Video Player/SEMRenderer/";
        proc = new Process();
        proc.StartInfo.WorkingDirectory = batDir;
        proc.StartInfo.FileName = "Start_SERenderer.bat";
        proc.StartInfo.CreateNoWindow = true;
        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        try {
        
            proc.Start();
        }catch (System.Exception e) {
            UnityEngine.Debug.LogError("Run error" + e.ToString()); // or throw new Exception
        }
        //proc.WaitForExit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnApplicationQuit()
    {
        
    }
}
