
using UnityEngine;

public class ItemCollect : MonoBehaviour, IInteractable
{


    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    [SerializeField] public Inventory inventory;
    [SerializeField] public PlayerInteraction playInteract;

    [SerializeField] public int itemWorth;

    public void Collect()
    {
        
    }


    public bool Interact(PlayerInteraction interactor)
    {

        inventory._stolenWorth += itemWorth;
        inventory.BackPack(gameObject.name);
        itemWorth = gameObject.GetComponent<ItemCollect>().itemWorth;
        Destroy(gameObject);

        return true;
    }   
}
