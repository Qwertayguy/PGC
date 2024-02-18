using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Cooldown cooldown;
    public float speed;
    public Transform Player;
    public Transform HitPoint;
    public float HitRange = 1f;
    public LayerMask HateLayers;
    SpriteRenderer spriteRenderer;

    private bool check;
    private bool checkers;

    public int damage;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            check = true;
        }
    }




    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        check = false;
    }

    void FixedUpdate()
    {
        if (check == false)
        {
            Walk();
        }
        else if (checkers == false && check == true)
        {
            StartCoroutine(Attack());
            checkers = true;
        }
        
    }
    private void Update()
    {
        
    }

    private void LateUpdate()
    {
        
    }

    void Walk()
    {

        Vector3 direction = Player.position - transform.position;

        Vector3 moveAmount = direction.normalized * speed * Time.deltaTime;

        transform.Translate(moveAmount);
    }

    IEnumerator Attack()
    {
        check = false;
        yield return new WaitForSeconds(1);
        Collider2D[] HitEnemies = Physics2D.OverlapCircleAll(HitPoint.position, HitRange, HateLayers);

        foreach (Collider2D enemy in HitEnemies)
        {
            
                enemy.GetComponent<Health>().TakeDamage(damage);
                Debug.Log("hit" + enemy.name);

                break;

            
        }
        yield return new WaitForSeconds(1);
        checkers = false;

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(HitPoint.position, HitRange);
    }
}
