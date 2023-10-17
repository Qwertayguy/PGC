using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMouse : MonoBehaviour
{


    
    void Update()
    {
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPosition;
    }
}
