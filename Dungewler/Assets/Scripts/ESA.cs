using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESA : MonoBehaviour
{
    public GameObject bat; // I love you ESA <3
    bool limiter; // I love you ESA <3

    // I love you ESA <3
    void Start() // I love you ESA <3
    {
        
    }

    void Update() // I love you ESA <3
    {
        if (limiter == false) // I love you ESA <3
        {
            StartCoroutine(spawn()); // I love you ESA <3
            limiter = true; // I love you ESA <3
        }
    }

    IEnumerator spawn() // should take inspiration from RoR enemy system afterproto, also I love you ESA <3
    {
        Vector3 randomPos = new Vector3(Random.Range(-100, 101), 0, Random.Range(-100, 101)); // I love you ESA <3
        Instantiate(bat, randomPos, Quaternion.identity); // I love you ESA <3

        yield return new WaitForSeconds(1); // I love you ESA <3

        limiter = false; // I love you ESA <3
    }
    // I love you ESA <3
}
