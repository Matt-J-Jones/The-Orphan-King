using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivate : MonoBehaviour
{
    public bool PlayerInTrigger = false;
    public bool activated = false;
    public Canvas InteractionText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player") && !activated)
    {
        PlayerInTrigger = true;
        InteractionText.gameObject.SetActive(true);
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
