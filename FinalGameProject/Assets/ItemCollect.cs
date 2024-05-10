using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour, IInteractable
{


    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = FindFirstObjectByType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Collect()
    {
        
    }


    public bool Interact(PlayerInteraction interactor)
    {
        string objectName = gameObject.name;
        Destroy(gameObject);
        inventory.BackPack(objectName);
        Debug.Log(Interact(interactor));
        return true;
    }   
}
