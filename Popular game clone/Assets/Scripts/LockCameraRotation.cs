using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCameraRotation : MonoBehaviour
{
    Quaternion myRotation;
    void Start()
    {
        myRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = myRotation;
    }
}
