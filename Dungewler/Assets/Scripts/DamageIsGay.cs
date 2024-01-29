using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DamageIsGay : MonoBehaviour
{
    public int Health = 100;
    private bool IsColliding = false;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            IsColliding = true;
        }
    }
    void Update()
    {
        if (IsColliding == true)
        {
            Health = Health - 5;
        }
        if (Health < 1)
        {
            Debug.Log("Skill issue");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

}