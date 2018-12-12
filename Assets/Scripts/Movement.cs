using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float HorizonSpeed = 0.01f;
    public float VertiSpeed = 0.1f;
    public float PHP = 10f;
    
    void Update()
    {
        transform.Translate(0, Input.GetAxisRaw("Vertical") * VertiSpeed, 0);

    }

    public void Damage(float dam)
    {
        PHP = PHP - dam;
        if (PHP <= 0f)
        {
            Death();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "EnemyShot")
        {
            Damage(1f);
            Destroy(collision.collider.gameObject);
        }
    }

    public void Death()
    {
        Destroy(gameObject);
    }


}
