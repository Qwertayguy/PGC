using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
   
      
    private void OnCollisionEnter2d(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Kys");
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Kys");
    }

}
 
