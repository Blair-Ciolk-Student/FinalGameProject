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
        if (Input.GetKeyDown(KeyCode.Escape)) // Change to whatever key you use to pause the game
        {
        
            TogglePause();
        }
    }
    void TogglePause()
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
