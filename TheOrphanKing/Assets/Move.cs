using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            Animator.SetBool("Walk", true);
        } else {
            Animator.SetBool("Walk", false);
        }

        // if (Input.GetKey(KeyCode.E))
        // {
        //     Animator.SetBool("Pickup", true);
        // } else {
        //     Animator.SetBool("Pickup", false);
        // }
    }
}
