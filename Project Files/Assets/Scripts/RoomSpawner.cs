using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour {
    public int openingDirection;
    // 1 --> Right door
    // 2 --> Top  door
    // 3 --> Bottom door
    // 4 --> Left door

    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;
    public float waitTime = 6f;

    void Start() {
        Destroy(gameObject, waitTime);
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.2f);
    }

    void Spawn() {
        if (spawned == false) {

            if (openingDirection == 1) {
                // spawn BOTTOM door
                rand = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                // spawned = true;
            }
            else if (openingDirection == 2) {
                // spawn TOP door
                rand = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
                // spawned = true;
            }
            else if (openingDirection == 3) {
                // spawn LEFT door
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
                // spawned = true;
            }
            else if (openingDirection == 4) {
                // spawn RIGHT door
                rand = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                // spawned = true;
            }
            spawned = true;
        }
    }

    void OnTriggerEnter2D (Collider2D other) {

        if (other.CompareTag("MapSpawner")) {
            if (other.GetComponent<RoomSpawner>().spawned == false && spawned == false) {
                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            spawned = true;
        }
    }


}
