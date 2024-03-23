using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESA : MonoBehaviour
{
    public GameObject bat;
    bool limiter;

    // I love you ESA <3
    void Start() // I love you ESA <3
    {
        
    }

    void Update() // I love you ESA <3
    {
        if (limiter == false)
        {
            StartCoroutine(spawn());
            limiter = true;
        }
    }

    IEnumerator spawn() // should take inspiration from RoR enemy system afterproto, also I love you ESA <3
    {
        Vector3 randomPos = new Vector3(Random.Range(-100, 101), 0, Random.Range(-100, 101));
        Instantiate(bat, randomPos, Quaternion.identity);

        yield return new WaitForSeconds(1);

        limiter = false;
    }
    // I love you ESA <3
}
