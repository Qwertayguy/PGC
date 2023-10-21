using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(GameObject.FindWithTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
