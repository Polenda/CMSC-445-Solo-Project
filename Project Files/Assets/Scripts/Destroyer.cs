using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {}
        else if (other.CompareTag("Camera")) {}
        
        else {
            Destroy(other.gameObject);
        }
    }
}
