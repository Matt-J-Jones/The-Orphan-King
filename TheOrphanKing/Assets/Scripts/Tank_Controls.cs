using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Controls : MonoBehaviour
{
     private CharacterController controller;
 
     public float speed = 6f;
     public float turnSpeed = 90f;

     public bool turning = false;
     public bool cutscene = false;
 
     private void Start()
     {
         controller = GetComponent<CharacterController>();
     }
 
     private void Update()
     {
        if (!turning && !cutscene)
        {
            Vector3 movDir;
    
            transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
            movDir = transform.forward * Input.GetAxis("Vertical") * speed;
    
            // moves the character in horizontal direction
            controller.Move(movDir * Time.deltaTime - Vector3.up * 0.1f);
        }
     }

    void CheckTurning() 
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            turning = true;
        }

        else {
            turning = false;
        }
    }
 }