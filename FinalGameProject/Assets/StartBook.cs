using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBook : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    
    public bool Interact(PlayerInteraction interactor)
    {
        Debug.Log("Opening Book");
        return true;
    }
}
