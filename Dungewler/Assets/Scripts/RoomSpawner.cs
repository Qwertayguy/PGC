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
    public bool touchedRoom;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Room") || other.gameObject.CompareTag("SpawnPoint"))
        {
            //touchedRoom = true;
            Destroy(self);
        }
    }

    private void Awake()
    {
        //moderatorScript = GameObject.FindGameObjectWithTag("Moderator").GetComponent<ModeratorScript>();
        //adding the moderatorScript here seems to break the script
    }
    void Start()
    {
        //moderatorScript = GameObject.FindGameObjectWithTag("Moderator").GetComponent<ModeratorScript>();
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        if (touchedRoom == true)
        {
            spawned = true;
            //spawn doorwayblock
        }
        Invoke("Spawn", 0.1f);
        //StartCoroutine(KYS());
    }

    private void Update()
    {
        Debug.Log("spawned " + spawned);
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

    IEnumerator KYS()
    {
        yield return new WaitForSeconds(5);
        Destroy(self); //*thunder sfx*
        //deactivate script instead of suicide
    }
}
