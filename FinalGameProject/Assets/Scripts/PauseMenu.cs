using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    private CursorLockMode previousLockMode;
    private bool previousCursorVisibility;

    void Awake()
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

        if (Input.GetKeyDown(KeyCode.P))
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
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;

        // Restore previous cursor state
        Cursor.lockState = previousLockMode;
        Cursor.visible = previousCursorVisibility;

        pauseMenu.SetActive(false);
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
