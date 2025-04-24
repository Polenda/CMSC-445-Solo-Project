using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closedRoom;

    public List<GameObject> rooms;

    public float waitTime;
    private bool spawnedcharacters;
    private bool timerStart;

    public GameObject boss;
    public GameObject player;
    public GameObject playerSpawner;

    void Update() {
        if (waitTime <= 0 && spawnedcharacters == false) {
            for (int i = 0; i < rooms.Count; i++) {
                if (i == rooms.Count-1) {
                    Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
                    Instantiate(player, playerSpawner.transform.position, Quaternion.identity);
                    spawnedcharacters = true;
                }
            }
            if (timerStart == false) {
                Timer.instance.StartTimer();
                timerStart = true;
            }
            
        }
        else if (waitTime >= 0) {
            waitTime -= Time.deltaTime;
        }

        
    }

}
