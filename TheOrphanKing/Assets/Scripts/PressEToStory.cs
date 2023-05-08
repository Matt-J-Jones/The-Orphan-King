using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressEToStory : MonoBehaviour
{
    public bool PlayerInTrigger = false;
    public bool activated = false;
    public Item InteractionText;
    public Item StoryText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInTrigger && Input.GetKey(KeyCode.E)) {
            StoryText.gameObject.SetActive(true);
            InteractionText.gameObject.SetActive(false);
            activated = true;
        }
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
        InteractionText.gameObject.SetActive(false);
    }

  }
}
