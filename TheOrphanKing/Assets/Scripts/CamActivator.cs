using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamActivator : MonoBehaviour
{
    public bool PlayerInTrigger = false;
    public Camera StartingCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInTrigger){
            StartingCamera.gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInTrigger = false;
        }

    }
}
