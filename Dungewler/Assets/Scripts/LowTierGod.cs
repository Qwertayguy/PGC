using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowTierGod : MonoBehaviour
{
    public GameObject self;
    public bool thing;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Destroy(self);
            thing = true;
        }

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (thing == true)
        {
            Destroy(self);
        }
    }
}
