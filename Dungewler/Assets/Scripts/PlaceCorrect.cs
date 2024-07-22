using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCorrect : MonoBehaviour
{
    ModeratorScript moderatorScript;
    public Vector3[] offset;
    bool depressed;
    int rand;
    public GameObject self;
    public GameObject hitBox;
    LowTierGod LowTierGod;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Room"))
        {
            Destroy(self);
        }
        
    }
    private void Awake()
    {
        LowTierGod = hitBox.GetComponent<LowTierGod>();
    }
    void Start()
    {
        //moderatorScript = GameObject.FindGameObjectWithTag("Moderator").GetComponent<ModeratorScript>();
        LowTierGod.enabled = false;
        //Debug.Log(hitBoxBox.enabled);
        rand = Random.Range(0, offset.Length);
        transform.position = transform.position + offset[rand];
        LowTierGod.enabled = true;
        //Debug.Log(hitBoxBox.enabled);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (depressed == true && (other.CompareTag("Room")))
        {
            //Destroy(other);
            moderatorScript.roomsPresent = moderatorScript.roomsPresent - 1;
        }
    }

    IEnumerator HurtOthers()
    {
        yield return new WaitForSeconds(1);
        depressed = true;
    }

    private void Update()
    {
        Debug.Log(LowTierGod.enabled);
    }
}
