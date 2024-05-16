using UnityEngine;

public class StartBook : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    
    public GameObject BookUI;
    public bool isActive = false;

    public TutorialBookClose _tutBookClose;

    public Camera mainCamera;
    
    public delegate void InteractionEventHandler();
    public InteractionEventHandler OnInteraction;

    public FPSController fpsControllerScript;


     //public FreezeCameraOnPause freezeCam = Camera.main.GetComponent<FreezeCameraOnPause>();
     

         
    private void Start()
    {
        BookUI.SetActive(false);
    }

    public bool Interact(PlayerInteraction interactor)
    {
        GameObject cameraObject = GameObject.FindWithTag("MainCamera");

        FreezeCameraOnPause freezeCamOnP = cameraObject.GetComponent<FreezeCameraOnPause>();

        

        Debug.Log("Opening Book");

        isActive = true;
        
        BookUI.SetActive(true);
        freezeCamOnP.TogglePause();

        fpsControllerScript.enabled = false;
        
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        UnityEngine.Cursor.visible = true;

        return true;


    }
    
}
