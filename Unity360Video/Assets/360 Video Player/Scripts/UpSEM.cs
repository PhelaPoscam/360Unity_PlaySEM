using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEditor;

public class UpSEM : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        string path = "Assets/360 Video Player/SEMRenderer/PlaySEM_SERenderer_Aleph.jar";
        Process semPROCESS = new Process();
        semPROCESS.EnableRaisingEvents = false;
        semPROCESS.StartInfo.FileName = "java.exe";
        semPROCESS.StartInfo.Arguments = "-jar " + '"' + path;
        semPROCESS.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
