using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempScript : MonoBehaviour
{
    public Transform daTing;
    public float x;
    public float y;
    void Start()
    {
        
        transform.position = daTing.position;
        transform.position = transform.position + new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
