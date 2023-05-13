using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithItem : MonoBehaviour
{
    public Item PlayerModel;
    public Camera Camera;
    public Canvas Canvas;
    public Item TextTurnOff;
    public KeyCode InteractKey = KeyCode.E;

    public EnableMovement enableMovement;
    public DisableMovement disableMovement;

    public bool PlayerInTrigger = false;
    public bool PlayerTalked = false;
    public bool cameraActive = false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
      if (Input.GetKeyDown(InteractKey) && PlayerInTrigger)
      {
        if (!cameraActive) // Camera is not active, activate it
          {
              PlayerTalked = true;
              PlayerModel.gameObject.SetActive(false);
              disableMovement.gameObject.SetActive(true);
              Camera.gameObject.SetActive(true);
              Canvas.gameObject.SetActive(true);
              TextTurnOff.gameObject.SetActive(false);
              cameraActive = true;
          }
        else // Camera is active, deactivate it
          {
              PlayerModel.gameObject.SetActive(true);
              disableMovement.gameObject.SetActive(false);
              enableMovement.gameObject.SetActive(true);
              Camera.gameObject.SetActive(false);
              Canvas.gameObject.SetActive(false);
              cameraActive = false;
          }
      }
    }
    
    void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Player") && !PlayerTalked)
      {
          PlayerInTrigger = true;
          TextTurnOff.gameObject.SetActive(true);
      } else {
          PlayerInTrigger = true;
      }
    }

    void OnTriggerExit(Collider other)
    {
      if (other.CompareTag("Player"))
      {
          PlayerInTrigger = false;
          TextTurnOff.gameObject.SetActive(false);
          Camera.gameObject.SetActive(false);
      }

    }
}
