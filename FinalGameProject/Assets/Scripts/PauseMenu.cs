using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    public Camera playerCam;
    public GameObject cam2;
    

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape))
            {
                if(isPaused)
                {
                    ResumeGame();
                }
                else
                {
                    
                    PauseGame();
                }
            }
        

        
    }
    void Start()
    {
        pauseMenu.SetActive(false);
       
        
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        // change camera from default to 2nd
        cam2.SetActive(true);
        playerCam.enabled = false;
        playerCam.GetComponent<AudioListener>().enabled = false;
        cam2.GetComponentInChildren<Camera>().GetComponent<AudioListener>().enabled = true;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;

        cam2.GetComponentInChildren<Camera>().GetComponent<AudioListener>().enabled = false;
        playerCam.GetComponent<AudioListener>().enabled = true;
        cam2.SetActive(false);
        playerCam.enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isPaused = false;   
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TitleScreen");
        isPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
