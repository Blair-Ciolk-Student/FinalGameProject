using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator _animator;

    public GameObject OpenPanel = null;

    // Start is called before the first frame update
    void Start()
    {
        _animator = transform.Find("Door").GetComponent<Animator>();

        OpenPanel.SetActive(false);

    }

     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _animator.SetBool("open", true);
            OpenPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            _animator.SetBool("open", false);
            OpenPanel.SetActive(false);
        }
    }

    private bool IsOpenPanelActive
    {
        get
        { 
            return OpenPanel.activeInHierarchy;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(IsOpenPanelActive);
        if(IsOpenPanelActive)
        {
            if(Input.GetKey(KeyCode.E))
            {
                OpenPanel.SetActive(false);
                _animator.SetBool("open", true);
            }
        }
    }
}
