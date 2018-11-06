using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemyAI : MonoBehaviour
{

    private float HP =3f;

    private float EnemySpeed = -0.05f;

    private ScoreCounter count;

    // Use this for initialization
    void Start()
    {
        count = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ScoreCounter>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, EnemySpeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Player")
        {
            collision.collider.GetComponent<Movement>().Damage(3F);
            Destroy(gameObject);
        }

        else if (collision.collider.tag == "Shot")
        {
            Debug.Log("shot");
            HP = HP - 1f;
            Destroy(collision.collider.gameObject);
            if (HP < 1)
            {
                count.Score += 50;
                Destroy(this.gameObject);
            }
        }
    }
}
