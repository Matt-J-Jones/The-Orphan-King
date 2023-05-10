using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneController : MonoBehaviour
{
    public bool PlayerInTrigger = false;
    public Zone ZoneToDeactivate;
    public Zone ZoneToActivate;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInTrigger)
        {
            ZoneToDeactivate.gameObject.SetActive(false);
            ZoneToActivate.gameObject.SetActive(true);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInTrigger = true;
        }
    }
}
