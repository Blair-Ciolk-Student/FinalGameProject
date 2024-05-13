using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour, IInteractable
{


    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    [SerializeField] public Inventory inventory;
    [SerializeField] public PlayerInteraction playInteract;



    public void Collect()
    {
        
    }


    public bool Interact(PlayerInteraction interactor)
    {

        inventory.BackPack(gameObject.name);
        Destroy(gameObject);

        return true;
    }   
}
