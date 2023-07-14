using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Quaternion q;
    // Start is called before the first frame update
    void Start()
    {
        q = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = q;
    }
}
