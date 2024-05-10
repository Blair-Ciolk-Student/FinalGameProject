using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<string> stolen_goods;
    public int _amount;
    // Start is called before the first frame update
    void Start()
    {
        _amount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackPack(string itemName)
    {

        stolen_goods.Add(itemName);
        _amount += 1;

        foreach(var n in stolen_goods)
        {
        Debug.Log(itemName);
        Debug.Log(_amount);

        }
    }
}
