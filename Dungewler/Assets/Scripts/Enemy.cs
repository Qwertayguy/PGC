using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Cooldown cooldown;
    [SerializeField] ParticleSystem attackParticle = null;
    public float speed;
    public float lastX;
    public float HitRange = 1f;
    public LayerMask HateLayers;
    public Transform HitPoint;
    public Transform left;
    public Transform right;
    public GameObject particleChild;
    public GameObject Player;
    public GameObject Self;
    EnemyParticles enemyParticles;
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
        Player = GameObject.FindGameObjectWithTag("Player");
        spriteRenderer = GetComponent<SpriteRenderer>();
        enemyParticles = particleChild.GetComponent<EnemyParticles>();
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

        particleChild.transform.position = Player.transform.position;
        if (Player.transform.position.x < transform.position.x)
        {
            //flip
            enemyParticles.flip = true;
        }
        if (Player.transform.position.x > transform.position.x)
        {
            //dont flip
            enemyParticles.flip = false;
        }
        lastX = transform.position.x;
    }

    void Walk()
    {

        Vector3 direction = Player.transform.position - transform.position;

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

            //attackParticle.Play();
            enemyParticles.activator = true;
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
