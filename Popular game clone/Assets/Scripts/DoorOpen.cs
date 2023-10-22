using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    bool check;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            Destroy(collision.gameObject);
            Debug.Log("syk");
        }
    
    }

    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            Destroy(collision.gameObject);
            Debug.Log("syk");
        }
    }

    private void Update()
    {
        if(check == true)
        {
            Destroy(this.gameObject);
            Debug.Log("syk");
        }
    }

}
 
