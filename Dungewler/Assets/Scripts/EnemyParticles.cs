using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParticles : MonoBehaviour
{
    [SerializeField] ParticleSystem attackParticle = null;
    public bool flip;
    public bool activator;
    public float flipper;
    public Transform left;
    public Transform right;
    public Transform self;
    public GameObject parentEnemy;
    Enemy enemyScript;
    ParticleSystem particleSystemHere;
    ParticleSystemRenderer particleSystemRenderer;


    private void Awake()
    {
        enemyScript = parentEnemy.GetComponent<Enemy>();
        particleSystemHere = self.GetComponent<ParticleSystem>();
        particleSystemRenderer = particleSystemHere.GetComponent<ParticleSystemRenderer>();
        flipper = particleSystemRenderer.flip.x;
    }
    void Start()
    {
       
    }

 
    void FixedUpdate()
    {
        if (activator == true)
        {
            attackParticle.Play();
            activator = false;
        }

        if (flip == true)
        {
            Debug.Log("i Flipped le bitchlmao");
            flipper = 1;
        }
        else
        {
            Debug.Log("i did not flip le bitchlmao");
            flipper = 0;
        }
    }
}
