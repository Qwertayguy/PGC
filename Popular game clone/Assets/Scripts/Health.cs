using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] float maxHealth = 100f;
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        health = health - 25f;
        Debug.Log(health);
    }
}

