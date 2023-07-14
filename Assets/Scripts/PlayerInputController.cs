using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    Player player;
    Rigidbody2D rb;
    public float jumpForce = 0.1f;

    void Awake()
    {
        player = GetComponent<Player>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode2D.Impulse);
        }

        if(Input.GetKey(KeyCode.D)) {
            player.Move(new Vector3(1,0,0));
        } else if(Input.GetKey(KeyCode.A)) {
            player.Move(new Vector3(-1,0,0));
        }
    }
}
