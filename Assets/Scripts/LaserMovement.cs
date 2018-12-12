using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    public float LSpeed = 0.2f;
    public float ESpeed = 0.2f;

    void Update()
    {
        transform.Translate(LSpeed, ESpeed, 0);
    }
}
