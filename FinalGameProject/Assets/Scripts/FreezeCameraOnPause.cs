using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FreezeCameraOnPause : MonoBehaviour
{
    private Vector3 pausedCameraPosition;
    private Quaternion pausedCameraRotation;
    bool isPaused = false;


    // Update is called once per frame
    void Update()
    {
        
    }
    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            GetComponent<Camera>().enabled = false;

            
        }
        else
        {

            GetComponent<Camera>().enabled = true;            
        }
    }
}
