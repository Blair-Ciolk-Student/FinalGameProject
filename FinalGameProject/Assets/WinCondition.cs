
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public Inventory inventory;
    
    // Start is called before the first frame update
    void Start()
    {
        inventory = GetComponent<Inventory>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevel()
    {
        Debug.Log("End");
        // gets the curent screen
        Scene sceneLoaded = SceneManager.GetActiveScene();
        // loads next level
        SceneManager.LoadScene(sceneLoaded.buildIndex + 1);

    }
}
