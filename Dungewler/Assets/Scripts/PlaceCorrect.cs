using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCorrect : MonoBehaviour
{
    ModeratorScript moderatorScript;
    public float x;
    public float y;
    public Vector3[] offset;
    bool depressed;
    int rand;
    public GameObject self;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Room"))
        {
            Destroy(self);
        }
        
    }
    void Start()
    {
        //moderatorScript = GameObject.FindGameObjectWithTag("Moderator").GetComponent<ModeratorScript>();
        rand = Random.Range(0, offset.Length);
        transform.position = transform.position + offset[rand];
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
}
