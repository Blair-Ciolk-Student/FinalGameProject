
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public WinCondition winCondition;


    public List<string> stolen_goods;
    public int _amount;
    public int _stolenWorth;

    // Start is called before the first frame update
    void Start()
    {
        _amount = 0;
        
    }



    

    public void BackPack(string itemName)
    {

        stolen_goods.Add(itemName);
        _amount += 1;
    
        Debug.Log($"Item Name:{itemName}");
        Debug.Log($"Total amount of items: {_amount}");
        Debug.Log($"Total $$ stolen: ${_stolenWorth}");

        if(itemName == "Book")
        {
            Debug.Log("Book has been stolen");
            WinCondition winCondition = gameObject.AddComponent<WinCondition>();
            winCondition.NextLevel();
        }
        

    }
}
