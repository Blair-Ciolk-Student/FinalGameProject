using UnityEngine;
using TMPro;

public class DisplayFPS : MonoBehaviour
{
    public TextMeshProUGUI fpsText;
    float deltaTime = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * .1f;
        int fps = Mathf.RoundToInt(1.0f / deltaTime);
        fpsText.text = $"FPS: {fps}";
    }
}
