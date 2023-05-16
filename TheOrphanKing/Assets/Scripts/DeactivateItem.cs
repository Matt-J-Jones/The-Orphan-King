using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateItem : MonoBehaviour
{
    public Item ghost;
    // Start is called before the first frame update
    void Start()
    {
        ghost.gameObject.SetActive(false);
    }
}
