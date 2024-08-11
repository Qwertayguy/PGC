using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCorrect : MonoBehaviour
{
    ModeratorScript moderatorScript;
    public Vector3[] offset;
    Vector3 originalPos;
    bool depressed;
    int rand;
    public GameObject self;
    public GameObject hitBox;
    LowTierGod LowTierGod;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Room"))
        {
            //moderatorScript.roomsPresent = moderatorScript.roomsPresent - 1;
            Destroy(self);
        }
        
    }
    private void Awake()
    {
        LowTierGod = hitBox.GetComponent<LowTierGod>();
        //moderatorScript = GameObject.FindGameObjectWithTag("Moderator").GetComponent<ModeratorScript>();
    }
    void Start()
    {
        //moderatorScript.roomsPresent = moderatorScript.roomsPresent + 1;
        originalPos = transform.position;
        LowTierGod.enabled = false;
        //Debug.Log(hitBoxBox.enabled);
        rand = Random.Range(0, offset.Length);
        transform.position = transform.position + offset[rand];
        LowTierGod.enabled = true;
        //Debug.Log(hitBoxBox.enabled);
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
