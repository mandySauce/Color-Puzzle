using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform doorPosiiton;

    public Transform GetDoorPosition() {
        return doorPosiiton;
    }
}
