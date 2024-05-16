using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TempScript : MonoBehaviour
{
    // Start is called before the first frame update
    

    public void TestButton()
    {
        Debug.Log(this);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
