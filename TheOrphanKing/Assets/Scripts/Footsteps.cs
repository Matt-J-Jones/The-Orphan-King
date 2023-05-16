using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip[] rightFootstepSounds;
    public AudioClip[] leftFootstepSounds;
    public AudioSource audioSource;

    private bool isPlaying = false;

    void Update()
    {
        if (!isPlaying)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                // Randomly select a footstep sound for the respective foot
                AudioClip footstepSound;
                if (Input.GetKeyDown(KeyCode.W))
                    footstepSound = rightFootstepSounds[Random.Range(0, rightFootstepSounds.Length)];
                else
                    footstepSound = leftFootstepSounds[Random.Range(0, leftFootstepSounds.Length)];

                // Play the footstep sound
                audioSource.clip = footstepSound;
                audioSource.Play();

                // Mark as playing
                isPlaying = true;
            }
        }
        else
        {
            if (!audioSource.isPlaying)
                isPlaying = false;
        }
    }
}
