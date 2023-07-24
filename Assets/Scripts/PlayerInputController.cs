using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private float horizontalMove;

    Player player;
    Rigidbody2D rb;
    public float jumpForce = 2f;
    public bool onGround;

    void Awake()
    {
        player = GetComponent<Player>();
        rb = GetComponent<Rigidbody2D>();
        onGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround) {
            Debug.Log("Jump");
            rb.velocity = Vector2.up * jumpForce;
            onGround = false;
            Debug.Log("in the air");
        }

        horizontalMove = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate() {
        rb.velocity = new Vector3(horizontalMove * player.speed, rb.velocity.y, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor") {
            onGround = true;
            Debug.Log("on the ground");
        }
        
    }
}
