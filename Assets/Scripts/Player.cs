using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    public float walkSpeed = 10.0f;
    public float sprintSpeed = 5.0f;
    
    public int healthPoints = 1;

    private GameObject interactedDoor;
    private GameObject interactedExitDoor;
    private ExitDoor exitDoor;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

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
                exitDoor.AttemptToOpenExitDoor();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Door")) {
            interactedDoor = other.gameObject;
        } 
        if (other.CompareTag("ExitDoor")) {
            interactedExitDoor = other.gameObject;
            exitDoor = interactedExitDoor.GetComponent<ExitDoor>();
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Door")) {
            if (other.gameObject == interactedDoor) {
                interactedDoor = null;
            }
        }
        if (other.CompareTag("ExitDoor")) {
            if (other.gameObject == interactedExitDoor) {
                interactedExitDoor = null;
            }
        }
    }
    
}
