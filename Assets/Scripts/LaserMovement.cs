using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    
    private float LSpeed = 0.2f;
    
   
    
    
    void Update()
    {
        transform.Translate(LSpeed, 0, 0);
     
    }
}
