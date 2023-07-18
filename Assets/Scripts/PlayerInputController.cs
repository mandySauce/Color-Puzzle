using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    Player player;
    Rigidbody2D rb;
    public float jumpForce = 2f;

    void Awake()
    {
        player = GetComponent<Player>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Jump");
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode2D.Impulse);
        }

        if(Input.GetKey(KeyCode.D)) {
            player.Move(new Vector3(1,0,0));
        } else if(Input.GetKey(KeyCode.A)) {
            player.Move(new Vector3(-1,0,0));
        }
    }
}
