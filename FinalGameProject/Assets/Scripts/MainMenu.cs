using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject _titleMenuGO, _optionsMenuGO;

    public void Start()
    { 
        _optionsMenuGO.SetActive(false);
        if(_titleMenuGO.activeSelf == false)
        {
            _titleMenuGO.SetActive(true);
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Options()
    {
        _optionsMenuGO.SetActive(true);
        _titleMenuGO.SetActive(false);
    }

    public void Back()
    {
        _optionsMenuGO.SetActive(false);
        _titleMenuGO.SetActive(true);
    }
}
