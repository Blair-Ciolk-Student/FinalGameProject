using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    private CursorLockMode previousLockMode;
    private bool previousCursorVisibility;

    public FPSController fpsControllerScript;



    void Start()
    {
       
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }

        isPaused = false;

        
    }

    void Update()
    {
       // Debug.Log("cursor visible?: " + Cursor.visible);
       // Debug.Log("cursor locked?: " + Cursor.lockState);
    //Debug.Log("Is game paused: " + isPaused);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
               // Debug.Log("Resume");
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;

        pauseMenu.SetActive(true);

        // Save previous cursor state
        previousLockMode = Cursor.lockState;
        previousCursorVisibility = Cursor.visible;

        // Unlock cursor and make it visible
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        fpsControllerScript.enabled = false;


    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;

        // Restore previous cursor state
        Cursor.lockState = previousLockMode;
        Cursor.visible = previousCursorVisibility;

        pauseMenu.SetActive(false);

        fpsControllerScript.enabled = true;

    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TitleScreen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
