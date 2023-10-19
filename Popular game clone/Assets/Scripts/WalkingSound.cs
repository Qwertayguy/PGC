using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSound : MonoBehaviour
{
    public AudioSource SillyWalk;

    private void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            SillyWalk.enabled = true;
        }
        else
        {
            SillyWalk.enabled = false;
        }
    }
}
