using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateItem : MonoBehaviour
{
    // Activates an item when active.
    public Item ghost;
    // Start is called before the first frame update
    void Start()
    {
        ghost.gameObject.SetActive(true);
    }

}
