using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCorrect : MonoBehaviour
{
    ModeratorScript moderatorScript;
    public float x;
    public float y;
    bool depressed;
    void Start()
    {
        //moderatorScript = GameObject.FindGameObjectWithTag("Moderator").GetComponent<ModeratorScript>();
        transform.position = transform.position + new Vector3(x, y, 0);
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
