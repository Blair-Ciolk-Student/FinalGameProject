using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBookClose : MonoBehaviour
{
    
    public StartBook _startBook;
    public FreezeCameraOnPause freezeCamScript;

    public void Close()
    {
        if(_startBook.isActive == true)
        {
            _startBook.BookUI.SetActive(false);
            _startBook.fpsControllerScript.enabled = true;

            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
            UnityEngine.Cursor.visible = false;
            freezeCamScript.TogglePause();
        }
    }
}
