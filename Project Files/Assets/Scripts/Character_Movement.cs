using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character_Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    private Vector2 move;

    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    { 
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Finish")) {
            Timer.instance.EndTimer();
            Menu.finalTime = Timer.finalTime;
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
