using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public Camera Active_Cam; 
    public bool PlayerInTrigger = false; 


    // Update is called once per frame
    void Update()
    {
        if (PlayerInTrigger)
        {
          Active_Cam.gameObject.SetActive(true);
        }

        else if (!PlayerInTrigger)
        {
          Active_Cam.gameObject.SetActive(false);
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