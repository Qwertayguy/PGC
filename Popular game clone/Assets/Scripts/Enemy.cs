using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform Player;
    public Transform HitPoint;
    public float HitRange = 1f;
    public LayerMask HateLayers;
    SpriteRenderer spriteRenderer;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        Vector3 direction = Player.position - transform.position;

        Vector3 moveAmount = direction.normalized * speed * Time.deltaTime;

        transform.Translate(moveAmount);
    }

    private void Update()
    {
        Attack();
    }

    void Attack()
    {
        Collider2D[] HitEnemies = Physics2D.OverlapCircleAll(HitPoint.position, HitRange, HateLayers);

        foreach(Collider2D enemy in HitEnemies)
        {
            Debug.Log("lmao");
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(HitPoint.position, HitRange);
    }
}
