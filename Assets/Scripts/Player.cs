using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    public float walkSpeed = 5.0f;
    public float sprintSpeed = 3.0f;
    
    public int healthPoints = 1;

    private GameObject interactedDoor;
    private GameObject interactedExitDoor;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //screenBoundary = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) {
            speed = walkSpeed + sprintSpeed;
        } else {
            speed = walkSpeed;
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            if (interactedDoor != null) {
                transform.position = interactedDoor.GetComponent<Teleporter>().GetDoorPosition().position;
            }
            if (interactedExitDoor != null) {
                Debug.Log("Exit door E");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Door")) {
            interactedDoor = other.gameObject;
        } 
        if (other.CompareTag("ExitDoor")) {
            interactedExitDoor = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Door")) {
            if (other.gameObject == interactedDoor) {
                interactedDoor = null;
            }
        }
    }

    /*public void Move(Vector3 direction) {
        rb.MovePosition(transform.position + (direction * speed * Time.fixedDeltaTime));
        
    }*/

    
}
