using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParticles : MonoBehaviour
{
    private bool check;
    private bool checkers;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            check = true;
        }
    }
    void Start()
    {
        if (check == true)
        {
            Debug.Log("does it work");
        }
        else
        {
            Debug.Log("its working");
        }
    }

 
    void Update()
    {
        
    }
}
