using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float HorizonSpeed = 0.01f;
    public float VertiSpeed = 0.1f;
    public GameObject projectile;
    public Transform ship;
    public float PHP = 10f;
    



    void Update()
    {
        transform.Translate(0, Input.GetAxisRaw("Vertical") * VertiSpeed, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, ship.position, ship.rotation);
        }


    }

    public void Damage(float dam)
    {
        PHP = PHP - dam;
        if (PHP <= 0f)
        {
            Death();
        }
    }

    public void Death()
    {
        Destroy(gameObject);

    }
}
