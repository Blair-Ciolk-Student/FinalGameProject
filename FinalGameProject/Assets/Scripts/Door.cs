using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;


    public bool Interact(PlayerInteraction interactor)
    {
        Debug.Log("Opening door");
        SceneManager.LoadScene(2);
        return true;
    }
}
