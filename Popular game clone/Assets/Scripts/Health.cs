using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] int maxHealth = 100;
    public HealthBar healthBar;
    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthBar.SetHealth(health);
        Debug.Log(health);

        // youch animation

        if (health == 0)
        {
            Die();
        }
    }

    void Die()
    {
        // die lmao
    }
}

