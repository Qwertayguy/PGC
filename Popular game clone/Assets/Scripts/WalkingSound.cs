using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class WalkingSound : MonoBehaviour
{
    AudioSource audioSource;
    bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if(isMoving == true)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
}
