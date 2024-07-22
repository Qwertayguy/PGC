using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int direction;
    //1 = top
    //2 = right
    //3 = bottom
    //4 = left

    public GameObject self;
    ModeratorScript moderatorScript;
    RoomTemplates templates;
    int rand;
    public bool spawned;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Room") == false)
        {
            //spawned = false;
            //Debug.Log("sssfalse");
        }
        else
        {
            //spawned = true;
            //Debug.Log("ssstrue");
        }
    }
    void Start()
    {
        //moderatorScript = GameObject.FindGameObjectWithTag("Moderator").GetComponent<ModeratorScript>();
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);
        StartCoroutine(KYS());
    }

    private void Update()
    {
        
    }

    void Spawn()
    {
        if(spawned == false)
        {
            if (direction == 1)
            {
                rand = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
                //moderatorScript.roomsPresent = moderatorScript.roomsPresent + 1;
            }
            else if (direction == 2)
            {
                rand = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                //moderatorScript.roomsPresent = moderatorScript.roomsPresent + 1;
            }
            else if (direction == 3)
            {
                rand = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                //moderatorScript.roomsPresent = moderatorScript.roomsPresent + 1;
            }
            else if (direction == 4)
            {
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
                //moderatorScript.roomsPresent = moderatorScript.roomsPresent + 1;
            }
            spawned = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Room")) 
        {
            //Debug.Log("spawntrue");
            //make it spawn a door block
            spawned = false;
            //Invoke("Spawn", 0.1f);
        }
        else
        {
            //spawned = false;
            //Invoke("Spawn", 0.1f);
        }
    }

    IEnumerator KYS()
    {
        yield return new WaitForSeconds(5);
        Destroy(self); //*thunder sfx*
        //deactivate script instead of suicide
    }
}
