using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowTierGod : MonoBehaviour
{
    public GameObject self;
    public bool thing;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag + other.gameObject.name);
        if (other.gameObject.CompareTag("StuffPoint") & other.gameObject.transform.parent.gameObject != self)
        {
            Debug.Log(other.gameObject.transform.parent.name);
            Debug.Log(other.gameObject.name);
            Debug.Log("Death :(");
            //Destroy(self); //when you can prove that this shit actually works remove this line and make a "thing" checker in void start
            thing = true;
        }

    }
    
    void Start()
    {
        if (thing == true)
        {
            Destroy(self);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
