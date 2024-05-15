using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class PlayerDataManager : MonoBehaviour
{
    readonly Inventory inventory;
    public Transform playerTransform;
    public int _stolenTotalWorth;
    public int _amount;
    public PlayerData playerData = new PlayerData();

    public void SaveGame()
    {
        playerData.position = new float[] { playerTransform.position.x, playerTransform.position.y, playerTransform.position.z };
        playerData._stolenTotalWorth = inventory._stolenWorth;
        playerData._amount = inventory._amount;
        playerData.stolen_goods = inventory.stolen_goods;

        string json = JsonUtility.ToJson(playerData);
        string path = Application.persistentDataPath + "/playerData.json";
        System.IO.File.WriteAllText(path, json);
    }

    public void LoadGame()
    {
        string path = Application.persistentDataPath + "/playerData.json";
        if (File.Exists(path))
        {
            string json = System.IO.File.ReadAllText(path);
            PlayerData loadedData = JsonUtility.FromJson<PlayerData>(json);

            playerTransform.position = new Vector3(loadedData.position[0], loadedData.position[1], loadedData.position[2]);
            Vector3 loadedPosition = new Vector3(loadedData.position[0], loadedData.position[1], loadedData.position[2]);

            FindObjectOfType<CharacterController>().enabled = false;
            Invoke("enableController", 1f);
            playerTransform.position = loadedPosition;
            inventory._stolenWorth = loadedData._stolenTotalWorth;
            inventory.stolen_goods = loadedData.stolen_goods;
            inventory._amount = loadedData._amount;

        }
        else {
            Debug.LogWarning("No File Found!");
        }
    }

    void enableController()
    {
            FindObjectOfType<CharacterController>().enabled = true;

    }
}
