using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorWheel : MonoBehaviour
{
    public GameObject fox;
    private float rotateSpeed = 2.0f;
    private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        //fox = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = fox.transform.position;
        transform.Rotate(rotation * rotateSpeed * Time.deltaTime, Space.Self);
    }
}
