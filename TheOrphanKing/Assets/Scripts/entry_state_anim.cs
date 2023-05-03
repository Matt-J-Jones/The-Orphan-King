using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entry_state_anim : MonoBehaviour
{
    private Animator Animator;
    public string state;
    // public bool sitting = false;
    // public bool kneeling = false;
    // public bool crouching = false;
    // public bool fallen = false;
    // public bool standing = false;

    
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        Animator.SetBool(state, true);

        // if(sitting) {
        //     Animator.SetBool("Sitting", true);
        // }

        // if(kneeling) {
        //     Animator.SetBool("Kneeling", true);
        // }

        // if(crouching) {
        //     Animator.SetBool("Crouching", true);
        // }

        // if(fallen) {
        //     Animator.SetBool("Fallen", true);
        // }

        // if(standing) {
        //     Animator.SetBool("Standing", true);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
